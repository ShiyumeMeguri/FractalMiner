// HGRP VfxCharacterGrowing — character "growing / dissolve" VFX overlay (single ForwardOnly pass, transparent/additive).
// Merged from: vfxcharactergrowing.shader (HGRP/Effect/VFXCharacterGrowing) — vertex base blob b2 (#else catch-all),
//   fragment base blob b3 (#else catch-all). MV variant blobs b4/b5 add NOTHING material — they only swap the plain
//   _unity_ObjectToWorld / CB3UBO(particle param) access for the instanced _SRP_UnityPerDraw array + motion-vector RT,
//   so the base pair is the full 1:1 ground truth.
// Keywords: (none kept as shader_feature) — source only had HG_ENABLE_MV / SRP_INSTANCING_ON, both pure pipeline infra.
// Kept (1:1 from blobs):
//   - World-direction CUT-OFF discard + smoothstep grow window driven by _CutOffDirection/_CutOffPosY/_CutOffWidth/
//     _CutOffTransition (frag b3:120-152), reused as the vertex-animation amplitude window (vert b2:132-135).
//   - Value-noise (4-corner frac(sin(dot))*43758 hash, smoothstep+derivative blend, 1/1024 grid, freq 30) producing a
//     2-component view-plane vertex offset, scaled by _VertexAnimationScaleX/Y and faded by (1 - _ExpIntensity)
//     (vert b2:90-137, 344-365). Offset placed in camera right/up (UNITY_MATRIX_I_V) plane.
//   - Rim-glow tint: rim = max(dot(normalize(normalWS), -objectXAxisWS), 0.1); emissive =
//     clamp( max(tint*rim - _ExpThreshold,0)*_ExpIntensity + tint*rim , 0, 1000), tint = _TintColorIntensity*_TintColor/exposure
//     (frag b3:138-143, 219-221).
//   - Cut-off window alpha * _TintColorAlpha * _TintColor.a (frag b3:149-152).
//   - _IgnorePostExposure post-exposure divide (frag b3:138).
// Removed (HGRP pipeline infra substituted by URP / pixel-neutral, NOT material): GPU skinning (ByteAddressBuffer T0 +
//   BLENDWEIGHTS/BLENDINDICES, vert b2:152-350), motion-vector second render target SV_Target_1 (frag b3:222-227),
//   TAA jitter (_TaaJitterStrength, vert b2:384-385), GPU instancing / _SRP_UnityPerDraw array (b4/b5),
//   camera-relative world-space offset (folded into standard world space; TransformWorldToHClip),
//   _NonJitteredViewNoTransProjMatrix clip transform, the Texture3D froxel VOLUMETRIC fog + HG exponential/atmosphere
//   SCENE fog (_AtmosphereFogParams/_ExponentialFogParams/_VolumetricFogParams, frag b3:153-221) -> dropped (this is an
//   additive VFX overlay; the sibling HGRP_CharacterNPR_VFX_Fix likewise drops HG scene fog). World pos for the cut-off
//   is taken from the interpolated positionWS instead of depth-reconstruction (frag b3:120-125) — same world point.
//
// NOTE: _ExpIntensity is shared by BOTH the glow ramp (frag) AND the inverse vertex-animation fade (1 - _ExpIntensity,
//   vert b2:141) — high ExpIntensity brightens the glow while killing the vertex wobble. Kept exactly.
// NOTE: CB3_m0[] (CB3UBO, register b3) in the vertex blob is HG's per-draw particle param buffer; its slots map 1:1 to the
//   material props — CB3_m0[1].w=_VertexAnimationSpeed, [2].x/.y=_VertexAnimationUVScaleX/Y, [1].y/.z=_VertexAnimationScaleX/Y,
//   [2].z=_CutOffPosY, [2].w=_CutOffWidth, [3].x=_CutOffTransition, [4].xyz=_CutOffDirection (verified against the frag blob,
//   which uses the named uniforms in the identical cut-off math).

Shader "HGRP/VfxCharacterGrowing_Fix"
{
    Properties
    {
        [Header(Base)]
        [Enum(Opaque, 0, Transparent, 1)] _SurfaceType ("Surface Type", Float) = 1
        [Enum(Alpha, 0, Additive, 1)] _BlendMode ("Blend Type", Float) = 1
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2
        [ToggleUI] _IgnorePostExposure ("Ignore Post Exposure", Float) = 1

        _TintColor ("TintColor", Color) = (1, 1, 1, 1)
        _TintColorIntensity ("Tint Color Intensity (Default 1)", Range(1, 100)) = 1
        _ExpThreshold ("Exp Threshold", Range(0, 1)) = 1
        _ExpIntensity ("Exp Intensity", Range(0, 100)) = 0
        _TintColorAlpha ("Tint Color Alpha (Default 1)", Range(0, 10)) = 1

        [Header(Vertex Animation)]
        _VertexAnimationScaleX ("VertexAnimationScaleX", Float) = 0
        _VertexAnimationScaleY ("VertexAnimationScaleY", Float) = 0
        _VertexAnimationSpeed ("VertexAnimationSpeed", Float) = 0
        _VertexAnimationUVScaleX ("VertexAnimationUVScaleX", Float) = 0
        _VertexAnimationUVScaleY ("VertexAnimationUVScaleY", Float) = 0

        [Header(Grow Cut Off)]
        _CutOffPosY ("Cut Off Pos Y", Float) = 1
        _CutOffWidth ("Cut Off Width", Range(0, 5)) = 1
        _CutOffTransition ("Cut Off Transition", Range(0, 5)) = 1
        _CutOffDirection ("Cut Off Direction", Vector) = (0, 1, 0, 0)

        [Header(Exposure)]
        // HGRP global _ExposureParams re-exposed as a material Vector (URP has no such global). .x = exposure multiplier.
        _ExposureParams ("ExposureParams (.x=exposure)", Vector) = (1, 0, 0, 0)

        // Render-state plumbing (driven by a material editor / OnValidate from _SurfaceType + _BlendMode, not by the shader).
        [HideInInspector] _ZTest ("__zt", Float) = 4
        [HideInInspector] _ZWrite ("__zw", Float) = 0
        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 1
        [HideInInspector] _AlphaSrcBlend ("__alphaSrc", Float) = 1
        [HideInInspector] _AlphaDstBlend ("__alphaDst", Float) = 1
    }

    SubShader
    {
        Tags
        {
            "RenderPipeline"="UniversalPipeline"
            "RenderType"="Transparent"
            "Queue"="Transparent"
        }
        LOD 300

        HLSLINCLUDE
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            CBUFFER_START(UnityPerMaterial)
                // Base
                float _SurfaceType;
                float _BlendMode;
                float _IgnorePostExposure;
                float _TintColorIntensity;
                float _TintColorAlpha;
                float _ExpThreshold;
                float _ExpIntensity;
                float4 _TintColor;
                // Vertex animation
                float _VertexAnimationScaleX;
                float _VertexAnimationScaleY;
                float _VertexAnimationSpeed;
                float _VertexAnimationUVScaleX;
                float _VertexAnimationUVScaleY;
                // Grow cut-off
                float _CutOffPosY;
                float _CutOffWidth;
                float _CutOffTransition;
                float4 _CutOffDirection;
                // Exposure (HGRP global re-exposed)
                float4 _ExposureParams;
            CBUFFER_END

            // ---- Magic-constant decodes (STYLE_BIBLE §4) ----
            // 0.0009765625 = 1/1024 (value-noise grid cell, vert b2:97-98).
            // 30.0        = value-noise frequency (vert b2:91-92).
            // hash consts 12.9898 / 78.233 / 43758.5453 = frac(sin(dot(p,(12.9898,78.233)))*43758.5453) (vert b2:119-122).
            // 1.1754943508e-38 = FLT_MIN (normalize guard, vert b2:391).
            // 9.99999994e-09  = 1e-8 (rsqrt / divide epsilon, frag b3:133/145/146).
            // 0.10000000149   = 0.1 (rim-dot floor, frag b3:143).
            static const float NOISE_CELL  = 0.0009765625; // 1/1024
            static const float NOISE_FREQ  = 30.0;
            static const float RIM_FLOOR   = 0.100000001490116119384765625; // 0.1
            static const float FLT_MIN_F   = 1.1754943508222875079687365372222e-38;

            // 2D value hash, sign-preserving, exactly as the blob spells it (vert b2:97-122).
            // The blob computes cellCoord*1/1024, takes frac(abs())*sign*1024 to fold the lattice index, then the
            // classic frac(sin(dot))*43758 hash. Reproduced 1:1 so the noise pattern matches.
            float HashLattice(float a)
            {
                // a*1/1024 already applied by caller; here we fold: frac(abs(a))*sign(a)*1024  (b2:99-102)
                float f = frac(abs(a));
                return ((a >= -a) ? f : -f) * 1024.0;
            }
            float ValHash2(float x, float y)
            {
                return frac(sin(dot(float2(x, y), float2(12.98980045318603515625, 78.233001708984375))) * 43758.546875);
            }

            // Smoothstep window helper t -> t*t*(3-2t) on a saturated t  (frag b3:150-152 / vert b2:135).
            float SmoothWin(float t)
            {
                return mad(mad(t, -2.0, 3.0), t * t, 0.0);
            }

            // Grow cut-off window: signed distance along _CutOffDirection, two saturated edges, smoothstep difference.
            // frag b3:149-152 ; vert b2:132-135 (same math, vert uses CB3 params == these named uniforms).
            float GrowWindow(float signedDist)
            {
                float invT = 1.0 / _CutOffTransition;
                float eHi = saturate(invT * (-signedDist + ((_CutOffWidth + _CutOffPosY) + _CutOffTransition)));
                float eLo = saturate(invT * (-signedDist + ((-_CutOffWidth) + _CutOffPosY)));
                return saturate(SmoothWin(eHi) - SmoothWin(eLo));
            }

            // 2-component value-noise vertex-animation offset in the view (camera right/up) plane.
            // vert b2:90-137 (noise) + 136-137 (amplitude * _VertexAnimationScaleX/Y) + 344-346 windowed by GrowWindow.
            // Returns the (x,y) view-plane displacement BEFORE the (1 - _ExpIntensity) fade and basis placement.
            float2 ComputeVertexNoise(float2 uv, float growWin)
            {
                // Time-scrolled lattice sample point (b2:90-92).
                float t   = frac(_Time.x * _VertexAnimationSpeed);
                float sx  = mad(uv.x, _VertexAnimationUVScaleX, t) * NOISE_FREQ;
                float sy  = mad(uv.y, _VertexAnimationUVScaleY, t) * NOISE_FREQ;
                float cy  = floor(sy);
                float cx  = floor(sx);
                float fx  = frac(sx);
                float fy  = frac(sy);

                // Lattice corner indices, folded by HashLattice (b2:97-114, 126-131, 247-262).
                // NOTE on blob-temp identity (value-equality, names are by axis not by blob id):
                //   blob _102 = fold(cy*cell)  (b2:101, _85=floor(sy)*cell),  blob _104 = fold(cx*cell) (b2:102).
                //   So this h00x (=fold(cx*cell)) == blob _104, and h00y (=fold(cy*cell)) == blob _102.
                float h00x = HashLattice(cx * NOISE_CELL);             // == blob _104 (fold(cx*cell), b2:102)
                float h00y = HashLattice(cy * NOISE_CELL);             // == blob _102 (fold(cy*cell), b2:101)
                float hX1  = HashLattice((cx + 1.0) * NOISE_CELL);     // == blob _147 (b2:111, from _119=(cx+1)*cell)
                float hY0  = HashLattice((cy + 0.0) * NOISE_CELL);     // == blob _148 (b2:112, from _120=(cy+0)*cell)
                float hX1b = HashLattice((cy + 1.0) * NOISE_CELL);     // == blob _149 (b2:113, from _121=(cy+1)*cell)
                float hY0b = HashLattice((cx + 0.0) * NOISE_CELL);     // == blob _150 (b2:114, from _122=(cx+0)*cell)
                float hYY1 = HashLattice((cy + 1.0) * NOISE_CELL);     // == blob _261/_149 (b2:130, from _247=(cy+1)*cell)
                float hXX1 = HashLattice((cx + 1.0) * NOISE_CELL);     // == blob _262/_147 (b2:131, from _248=(cx+1)*cell)

                // Smoothstep weights + derivative terms (b2:115-118, 123-124).
                float fx2 = fx * fx;                                   // _156
                float fy2 = fy * fy;                                   // _157
                float sX  = mad(-fx, 2.0, 3.0);                        // _160
                float sY  = mad(-fy, 2.0, 3.0);                        // _163
                float wX  = sX * fx2;                                  // _178
                float wY  = sY * fy2;                                  // _179

                // 4-corner hashes (b2:119-122). By VALUE: r0==blob _176, r1==blob _175, r2==blob _174, r3==blob _177
                //   (r0/r2 carry the swapped-arg pair: blob _174=VH(_102,_104)=VH(fold cy,fold cx)==r2 here;
                //    blob _176=VH(_104,_102)=VH(fold cx,fold cy)==r0 here). The mad-trees below consume these by the
                //   SAME value identities, so the assembled bilerp matches b2:136-137 exactly (verified term-by-term).
                float r0  = ValHash2(h00x, h00y);                      // == blob _176  VH(fold cx, fold cy)
                float r1  = ValHash2(hX1b, hY0b);                      // == blob _175  VH(fold(cy+1), fold(cx+0))
                float r2  = ValHash2(h00y, h00x);                      // == blob _174  VH(fold cy, fold cx)
                float r3  = ValHash2(hX1,  hY0);                       // == blob _177  VH(fold(cx+1), fold(cy+0))

                // Two independent value-noise components -> X / Y displacement (b2:136-137).
                // _345 (X): windowed * (bilerp(...)*2-1) * _VertexAnimationScaleX
                float bilX = mad(
                                mad(wX * (-r3 + ValHash2(hXX1, hYY1)), wY,
                                    mad(wY * (-r2 + ValHash2(hY0b, hX1b)), mad(-fx2, sX, 1.0),
                                        mad(wX, -r2 + r3, r2))),
                                2.0, -1.0);
                float dispX = growWin * (bilX * _VertexAnimationScaleX);

                // _346 (Y): windowed * (bilerp(...)*2-1) * _VertexAnimationScaleY
                float bilY = mad(
                                mad(wY * (-r1 + ValHash2(hYY1, hXX1)), wX,
                                    mad(wX * (-r0 + ValHash2(hY0, hX1)), mad(-fy2, sY, 1.0),
                                        mad(wY, -r0 + r1, r0))),
                                2.0, -1.0);
                float dispY = growWin * (bilY * _VertexAnimationScaleY);

                return float2(dispX, dispY);
            }
        ENDHLSL

        Pass
        {
            Name "ForwardOnly"
            Tags { "LightMode"="UniversalForwardOnly" }

            Blend [_SrcBlend] [_DstBlend], [_AlphaSrcBlend] [_AlphaDstBlend]
            ZTest [_ZTest]
            ZWrite [_ZWrite]
            Cull [_CullMode]

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex vert
            #pragma fragment frag

            struct Attributes
            {
                float3 positionOS : POSITION;
                float3 normalOS   : NORMAL;
                float4 color      : COLOR;
                float2 uv         : TEXCOORD0;
            };

            struct Varyings
            {
                float4 positionCS : SV_POSITION;
                float3 normalWS   : TEXCOORD0; // b2: TEXCOORD_1 (world normal)
                float4 color      : TEXCOORD1; // b2: TEXCOORD_2 (vertex color, pass-through)
                float3 positionWS : TEXCOORD2; // for cut-off signed distance
            };

            Varyings vert(Attributes v)
            {
                Varyings o;

                // World-space normal (b2:375-394: normal * 1/dot(axis,axis) per ObjectToWorld column, then mul,
                // then rsqrt-normalize with FLT_MIN guard). TransformObjectToWorldNormal is the URP inverse-transpose
                // equivalent of that hand-rolled basis; normalize keeps the b2:391 guard intent.
                float3 nWS = TransformObjectToWorldNormal(v.normalOS);
                nWS = nWS * rsqrt(max(dot(nWS, nWS), FLT_MIN_F));
                o.normalWS = nWS;

                // World position (b2:225 / 363-365 minus the camera-relative offset, folded into absolute world space).
                float3 posWS = TransformObjectToWorld(v.positionOS);

                // Grow window at this vertex (b2:132-135) — signed distance along _CutOffDirection of the WORLD position.
                // b2:225 builds it from the object-to-world position dotted with CB3_m0[4].xyz (=_CutOffDirection).
                float signedDist = dot(posWS, _CutOffDirection.xyz);
                float growWin = GrowWindow(signedDist);

                // Value-noise view-plane displacement, faded by (1 - _ExpIntensity)  (b2:90-137, 141, 360-365).
                float2 disp = ComputeVertexNoise(v.uv, growWin);
                float expFade = 1.0 + (-_ExpIntensity); // _367 (b2:141)

                // Place displacement in camera right (_InvViewMatrix[0]) / up (_InvViewMatrix[1]) plane (b2:138-140),
                // scaled by expFade, and add to world position (b2:363-365).
                float3 camRight = UNITY_MATRIX_I_V._m00_m10_m20; // _InvViewMatrix[0].xyz
                float3 camUp    = UNITY_MATRIX_I_V._m01_m11_m21; // _InvViewMatrix[1].xyz
                float3 viewOffset = camRight * disp.x + camUp * disp.y; // _360/_361/_362
                posWS += viewOffset * expFade;

                o.positionWS = posWS;
                o.positionCS = TransformWorldToHClip(posWS);
                o.color = v.color;
                return o;
            }

            float4 frag(Varyings input) : SV_Target
            {
                // ---- Grow cut-off: discard above the cut plane, window the alpha (frag b3:120-127, 149-152) ----
                float signedDist = dot(input.positionWS, _CutOffDirection.xyz); // _120
                // discard_cond (b3:127): keeps the fragment when (_CutOffPosY >= _120); the decompiled predicate is
                //   discard_state = ( (_CutOffPosY >= _120) ? 0xFFFFFFFF : 0 ) == 0 , i.e. DISCARD iff _CutOffPosY < _120.
                // Boundary equality is on the KEEP side (>=). Showing the region below the cut, hiding above (grow-up).
                if (_CutOffPosY < signedDist) { discard; }

                float window = GrowWindow(signedDist); // (b3:149-152)
                float alpha  = saturate(window * (_TintColorAlpha * _TintColor.w)); // SV_Target.w (b3:152)

                // ---- Post-exposure divide (b3:138) ----
                float exposure = (_IgnorePostExposure != 0.0) ? _ExposureParams.x : 1.0; // _213
                float3 tint = (_TintColorIntensity * _TintColor.rgb) / exposure;          // _214/_215/_216

                // ---- Rim term: world normal vs object local-X axis in world (b3:142-143) ----
                // TEXCOORD (b3) = interpolated world normal; -_unity_ObjectToWorld[0].xyz = -objectXAxisWS.
                // _232 = rsqrt(dot(n,n)) — unguarded in the blob (b3:142).
                float3 nWS = input.normalWS * rsqrt(dot(input.normalWS, input.normalWS)); // _232
                float3 objX = float3(unity_ObjectToWorld._m00, unity_ObjectToWorld._m10, unity_ObjectToWorld._m20); // _unity_ObjectToWorld[0].xyz
                float rim = max(dot(nWS, -objX), RIM_FLOOR); // _253

                // ---- Glow ramp (b3:219-221, fog factors _908*_404 + inscatter dropped) ----
                // SV_Target.rgb = clamp( max(tint*rim - _ExpThreshold,0)*_ExpIntensity + tint*rim , 0, 1000 )
                float expThresholdNeg = -_ExpThreshold; // _261
                float3 glow = clamp(
                    mad(max(mad(tint, rim, expThresholdNeg.xxx), 0.0), _ExpIntensity.xxx, tint * rim),
                    0.0, 1000.0);

                // ---- Output (b3:219-221 RGB + b3:152 .w) ----
                // Blob writes SV_Target = float4(glow, alpha): the RGB (glow*fogTransmittance + inscatter, fog dropped
                // -> raw glow) is NOT premultiplied by the window alpha (b3:219-221 never multiply .xyz by .w / the
                // window term). Output the glow and alpha SEPARATELY and let the bound blend state apply alpha:
                //   Additive (_BlendMode=1, [One One]) adds full glow (window affects only .w, ignored by add) — 1:1;
                //   Alpha (_BlendMode=0, SrcAlpha blend) lets the hardware multiply by alpha. Premultiplying here would
                //   wrongly attenuate the additive glow at the cut edge and double-apply alpha on the SrcAlpha path.
                return float4(glow, alpha);
            }
            ENDHLSL
        }
    }
}

#ifndef GF2_CHARACTER_UBER_FUNCTIONS_INCLUDED
#define GF2_CHARACTER_UBER_FUNCTIONS_INCLUDED

#include "GF2CharacterUberInput.hlsl"
#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareDepthTexture.hlsl"

half2 EnvBRDFApproxLazarov(half Roughness, half NoV)
{
	// [ Lazarov 2013, "Getting More Physical in Call of Duty: Black Ops II" ]
	// Adaptation to fit our G term.
	const half4 c0 = { -1, -0.0275, -0.572, 0.022 };
	const half4 c1 = { 1, 0.0425, 1.04, -0.04 };
	half4 r = Roughness * c0 + c1;
	half a004 = min(r.x * r.x, exp2(-9.28 * NoV)) * r.x + r.y;
	half2 AB = half2(-1.04, 1.04) * a004 + r.zw;
	return AB;
}

half3 GetAmbient(half3 sh_value, bool useGIFlatten)
{
    half3 ambientLightColor = half3(unity_SHAr.w, unity_SHAg.w, unity_SHAb.w) + half3(unity_SHBr.z, unity_SHBg.z, unity_SHBb.z) / 3.0;

    half3 luminance = half3(0.2126729, 0.7151522, 0.072175);
    half ambientLuminance = dot(ambientLightColor, luminance);
    half shLuminance = dot(sh_value, luminance);
    return useGIFlatten ? ambientLuminance * (sh_value / shLuminance) : max(sh_value, 0.0);
}

// reference https://www.shadertoy.com/view/NtlyWX
half GetGGXAnisotropic(half alpha_t, half alpha_b, half TdotH, half BdotH, half NDotH)
{
    half a2 = alpha_t * alpha_b;
    half3 v = half3(TdotH * alpha_b, BdotH * alpha_t, NDotH * a2);
    half v2 = dot(v, v);
    half w2 = a2 / v2;
    return a2 * w2 * w2 * INV_PI;
}

half GetStockingSpecular(half3 normalDir, half3 binormalWS, half3 H, half NDotH, half roughnessFactor, bool useAnisotropicGGX, half specular)
{
    half3 stockingTangent = cross(normalDir, binormalWS.yzx);
    half3 stockingBinormal = cross(normalDir, binormalWS);
    half TdotH = dot(stockingTangent, H);
    half BdotH = dot(stockingBinormal, H);
    // 最適化のため挂け算回数を減らした
    half alpha_x = max(roughnessFactor * (1.0 + _AnisotropicGGX), 0.001);
    half alpha_y = max(roughnessFactor * (1.0 - _AnisotropicGGX), 0.001);
    half specularGGX = GetGGXAnisotropic(alpha_x, alpha_y, TdotH, BdotH, NDotH);
    // GGXスペキュラーを使う？
    return useAnisotropicGGX ? specularGGX : specular;
}

half3 GetRimRamp(half3 normalDir, half rimIntensity, bool useRampMap)
{
	half3 rimFactor;
	if (useRampMap)
	{
		// 光源方向によりRim反転する
		half lightDirVS = mul(unity_MatrixV, _MainLightPosition.xyz).x;
		half faceingLeft = lightDirVS > 0.0 ? -1 : 0;
		half faceingRight = lightDirVS < 0.0 ? -1 : 0;
		half rimReverse = faceingLeft - faceingRight;
		
		half3 rimViewDirWS = normalize(rimReverse * unity_MatrixInvV._m00_m10_m20);
		half NdotRimV = saturate(dot(normalDir, rimViewDirWS));
		// Rim計算
		half2 rampUV1 = half2(rimIntensity * NdotRimV, 0.625);
		rimFactor = SAMPLE_TEXTURE2D_LOD(_RampMap, sampler_RampMap, rampUV1, 0.0);
	}
	else
	{
		rimFactor = -0.0024;
	}
	return rimFactor;
}

half GetBaseSpecular(half NDotH, half roughness)
{
    half reflectionBase = NDotH * roughness;
    // 鏡面反射の基本部分を計算します
    reflectionBase = roughness / ((reflectionBase * reflectionBase) + (1.0 - NDotH * NDotH));
    // 基本部分の結果を二乗して、鏡面反射の効果を強化
    half specularReflection = reflectionBase * reflectionBase;
    // 結果が最大値を超えないように制限
    return min(specularReflection, 2048.0);
}

half GetSpecularRim(half VDotH, half roughness, half diffuse, half occlusion)
{
    return min(1.0 / max((diffuse * occlusion) + (VDotH * roughness), 0.0001) * 0.5, 1.0);
}

half GetSpecularIntensity(half VDotH, half metallic)
{
    half specRimIntensity = pow(max(1.0 - VDotH, 0.001), 5.0);
    half specularMetallic = saturate(metallic * 50.0);
    return (specularMetallic * specRimIntensity - specRimIntensity) + 1.0;
}

half3 GetSpecularRamp(half3 lightDir, half3 H, half VDotH, half roughnessRimIntensity, half roughnessIntensity, half specular, half specularIntensity, bool useRampMap)
{
    half3 rampSpecular;
    if (useRampMap)
    {
        half LDotH = max(dot(lightDir, H), 0.0);

        half VDotHMasked = VDotH * roughnessRimIntensity + roughnessIntensity;
        half LDotHMasked = LDotH * roughnessRimIntensity + roughnessIntensity;

        half rampRoughness = 1.0 / roughnessIntensity;
        rampRoughness = min(rampRoughness * rampRoughness, 2048.0);

        half rampSpecIntensity = GetSpecularRim(VDotH, LDotHMasked, LDotH, VDotHMasked);

        half2 rampUV1 = half2(saturate((specular * specularIntensity * 1.0 / rampRoughness) * (1.0 / rampSpecIntensity)), 0.375);
        half3 specularRampColor = SAMPLE_TEXTURE2D_LOD(_RampMap, sampler_RampMap, rampUV1, 0.0);

        rampSpecular = rampSpecIntensity * rampRoughness * specularRampColor;
    }
    else
    {
        rampSpecular = specular * specularIntensity;
    }
    return rampSpecular;
}

half3 GetDiffuse(half diffuse, bool useRampMap, half colorY)
{
    half3 diffuseColor;
    if (useRampMap) // 皮膚透射
    {
        half2 rampUV1 = half2(diffuse, colorY);
        half3 diffuseRamp = SAMPLE_TEXTURE2D_LOD(_RampMap, sampler_RampMap, rampUV1, 0.0);
        half sssIntensity = min(1.0 / rampUV1.x * diffuse, 1.0);
        diffuseColor = diffuseRamp * sssIntensity;
    }
    else
    {
        diffuseColor = diffuse;
    }
    return diffuseColor;
}

// 立　体　防　御
half3 GetFaceDiffuse(half4 uv, inout half2 faceLightDir, inout half sdfFaceDiffuse, inout half4 sdfMask, bool useSpecularUV2, bool useRampMap)
{
    half3 lightPosOS = mul(unity_WorldToObject, _MainLightPosition.xyz).xyz;

    faceLightDir = normalize(lightPosOS).xz;
    half sdfIntensity = (1.0 - abs(faceLightDir.y)) * 0.5 + 0.5;

    half2 blendUV1 = useSpecularUV2 ? uv.zw : uv.xy;
    half2 blendUV2 = half2(1.0 - blendUV1.x, blendUV1.y);
    half4 sdfTexMask = SAMPLE_TEXTURE2D(_BlendTex, sampler_BlendTex, blendUV1);

    faceLightDir = normalize(faceLightDir);
    sdfMask.xy = faceLightDir.y * half2(0.5, 0.5) + half2(0.5, 1.5);
    sdfMask.z = SAMPLE_TEXTURE2D(_BlendTex, sampler_BlendTex, blendUV2).x;
    sdfMask.w = sdfTexMask.x;

    // 下颚附近皮肤使用不同阴影
    bool isSubmandibular = 0.5 < 1.0 - sdfTexMask.w;
    half3 faceMask = isSubmandibular ? sdfMask.xwz : sdfMask.yzw;

    // 反转左边遮罩 得到360度的遮罩 
    bool isLeft = faceLightDir.x < 0.0;
    // sdf环形遮罩
    half faceRingIntensityMask = isLeft ? 2.0 - faceMask.x : faceMask.x;

    // 强度负偏移
    half faceRingIntensityMaskMin = (faceRingIntensityMask - _BlendSmoothness * 0.5) + 4.0;
    half temp_val = faceRingIntensityMaskMin + faceRingIntensityMaskMin;
    isLeft = temp_val >= -temp_val;
    half2 sdfIntensityMaskMin = isLeft ? half2(2.0, 0.5) : half2(-2.0, -0.5);

    // 强度正偏移
    half faceRingIntensityMaskMax = (faceRingIntensityMask + _BlendSmoothness * 0.5) + 4.0;
    temp_val = faceRingIntensityMaskMax + faceRingIntensityMaskMax;
    isLeft = temp_val >= -temp_val;
    half2 sdfIntensityMaskMax = isLeft ? half2(2.0, 0.5) : half2(-2.0, -0.5);

    half sdfMinDiffuse = frac(faceRingIntensityMaskMin * sdfIntensityMaskMin.y);
    half sdfMaxDiffuse = frac(faceRingIntensityMaskMax * sdfIntensityMaskMax.y);

    // 基础sdf漫反射
    half sdfFrontDiffuseIntensityMask = sdfIntensityMaskMin.x * sdfMinDiffuse;
    half sdfBackDiffuseIntensityMask = sdfIntensityMaskMax.x * sdfMaxDiffuse;

    // 计算方向
    half diffuseRight = faceMask.z - sdfFrontDiffuseIntensityMask;
    diffuseRight /= _BlendSmoothness;
    diffuseRight = saturate(diffuseRight);

    half diffuseLeft = 2.0 - sdfFrontDiffuseIntensityMask;
    diffuseLeft -= faceMask.y;
    diffuseLeft /= _BlendSmoothness;
    diffuseLeft = saturate(diffuseLeft);
    diffuseLeft = 1.0 - diffuseLeft;

    half diffuseFront = sdfBackDiffuseIntensityMask - faceMask.z;
    diffuseFront /= _BlendSmoothness;
    diffuseFront = saturate(diffuseFront);
    diffuseFront = 1.0 - diffuseFront;

    half diffuseDouble = sdfFrontDiffuseIntensityMask < 1.0 ? diffuseRight : diffuseLeft;
    half sdfDiffuseFront = min(diffuseFront, diffuseDouble);
    half sdfDiffuseBack = max(diffuseLeft, diffuseDouble);

    bool isFrontLight = sdfBackDiffuseIntensityMask < 1.0;
    sdfFaceDiffuse = isFrontLight ? sdfDiffuseFront : sdfDiffuseBack;

    half diffusSDF = sdfIntensity * sdfFaceDiffuse;

    return GetDiffuse(diffusSDF, useRampMap, 0.125);
}

half GetFaceSpecular(half2 faceLightDir, half2 blendUV1, half NdotV, half4 sdfMask, half sdfFaceDiffuse)
{
    // (矩阵)マトリックス第三列は回転
    half3 rotationWS = mul(unity_CameraToWorld, unity_WorldToObject._m02_m12_m22);
    // 視線方向
    half2 viewLightDir = normalize(rotationWS).xz - faceLightDir;
    viewLightDir = viewLightDir * 0.85 + faceLightDir;

    half viewLightProjection = rsqrt(dot(viewLightDir, viewLightDir));
    // ついでに正規化
    viewLightDir.x = viewLightDir.x * viewLightProjection;

    bool isSpecVisible = viewLightDir.x < 0.0;
    half2 blendUV3;
    blendUV3.x = isSpecVisible ? 1.0 - blendUV1.x : blendUV1.x;
    blendUV3.y = blendUV1.y;

    half3 sdfSpecMask = SAMPLE_TEXTURE2D(_BlendTex, sampler_BlendTex, blendUV3);;

    half sdfSpecIntensity1 = -viewLightDir.y * viewLightProjection - 0.707106769; //根据角色对象空间z轴方向转换到相机空间决定的
    sdfSpecIntensity1 = saturate(sdfSpecIntensity1) * 3.41421342;
    sdfSpecIntensity1 = clamp(sdfSpecIntensity1, 0.01, 0.99);

    // 高光范围的交集和强度计算
    isSpecVisible = sdfSpecMask.z >= sdfSpecIntensity1;
    half sdfSpecIntensityRange1 = isSpecVisible ? 1.0 : 0.0;

    isSpecVisible = sdfSpecMask.y >= 1.0 - sdfSpecIntensity1;
    half sdfSpecIntensityRange2 = isSpecVisible ? 1.0 : 0.0;

    half sdfSpecIntensityRange = sdfSpecIntensityRange2 * sdfSpecIntensityRange1;
    sdfSpecIntensityRange *= NdotV;
    sdfSpecIntensityRange *= _Anisotropy;
    sdfSpecIntensityRange *= INV_PI;

    half sdfSpecIntensity = saturate(sdfMask.x * 4.0 + -3.0);

    return sdfFaceDiffuse * (sdfSpecIntensityRange * sdfSpecIntensity);
}

v2f GF2Vertex(appdata_ex v)
{
    v2f o;
    half4 positionWS = mul(unity_ObjectToWorld, v.vertex);
    half4 positionCS = mul(unity_MatrixVP, positionWS);
    half3 normalWS = normalize(mul(half4(v.normal, 0.0), unity_WorldToObject).xyz);
    half3 tangentWS = normalize(mul(unity_ObjectToWorld, half4(v.tangent.xyz, 0.0)));
    half3 binormalWS = normalize(cross(normalWS, tangentWS) * v.tangent.w * unity_WorldTransformParams.w);

    o.position = positionCS;
    o.uv = half4(v.texcoord.xy, v.texcoord1.xy); //UV1 UV2
    o.normalWS.xyz = normalWS; // 法線
    o.tangentWS.xyz = tangentWS; // 接線
    o.binormalWS.xyz = binormalWS; // 従法線
    o.positionWS = positionWS; // 世界座標
    o.viewDirWS = _WorldSpaceCameraPos - positionWS; // カメラ方向
    return o;
}

half4 GF2Fragment(v2f input) : SV_Target
{
    half3 positionWS = input.positionWS; // 世界空間座標

    half3 viewDirWS = normalize(input.viewDirWS); //世界視線方向
    half3 normalWS = normalize(input.normalWS); // 世界法線方向
    half3 tangentWS = normalize(input.tangentWS); // 世界接線方向
    half3 binormalWS = normalize(input.binormalWS); // 世界従法線方向

    bool useRampMap = 0.0 < _UseRampMap;
    bool useGIFlatten = 0.0 < _UseGIFlatten;
    bool useSpecularUV2 = 0.0 < _UseSpecularUV2;
    bool useAnisotropicGGX = 0.001 < abs(_AnisotropicGGX);

    half2 uv1 = input.uv.xy * _BaseMap_ST.xy + _BaseMap_ST.zw; //TRANSFORM_TEX(input.uv.xy, _BaseMap);

    half4 mainTex = SAMPLE_TEXTURE2D(_BaseMap, sampler_BaseMap, uv1);
    half4 blendTex = SAMPLE_TEXTURE2D(_BlendTex, sampler_BlendTex, uv1);
    half4 rmoTex = SAMPLE_TEXTURE2D(_RMOTex, sampler_RMOTex, uv1);
    // R 代表 Roughness（粗糙度）M 代表 Metallic（金属度）O 代表 Occlusion（遮挡）
    half4 normalTex = SAMPLE_TEXTURE2D(_BumpMap, sampler_BumpMap, uv1);
    normalTex.y = 1.0 - normalTex.y;

    half3 unpackednormal = UnpackNormal(normalTex);
    half3 normalDir = normalize(tangentWS * unpackednormal.x + binormalWS * unpackednormal.y + normalWS * unpackednormal.z);;

    half4 baseColor = mainTex * _BaseColor;
    half3 emissiveColor = baseColor * _EmissiveIntensity;
    half diffuse = max(dot(normalDir, _MainLightPosition.xyz), 0.0);
    half NdotV = saturate(dot(normalDir, viewDirWS));

    // 反射光
    half reflectIntensity = NdotV + NdotV;
    half3 reflectDir = normalDir * reflectIntensity - viewDirWS;
    // 球面調和関数
    half3 sh = SampleSH(normalDir);
    // 環境光
    half3 finalAmbientColor = GetAmbient(sh, useGIFlatten);
    // 拡散反射
    half3 diffuseColor;
    half2 faceLightDir;
    half sdfFaceDiffuse;
    half4 sdfMask;
    #if (_USE_BLEND_TEX)
    {
        diffuseColor = GetFaceDiffuse(input.uv, faceLightDir, sdfFaceDiffuse, sdfMask, useSpecularUV2, useRampMap);
    }
    #else
    {
    	half customDiffuse = diffuse;
    	#if (_ANISOTROPIC_SPECULAR) // 髪用
			customDiffuse *= blendTex.a;
    	#endif
        diffuseColor = GetDiffuse(customDiffuse, useRampMap, 0.125);
    }
    #endif

    half mipmapLevel;
    half3 mainDiffuseColor;
    half3 rimFactor;
    half3 finalRimColor;
    half3 finalSpecularIntensity;
    half3 finalSpecularColor;
    half roughnessFactor;
    half roughnessRimFactor;
    half NdotVSafe;
    half NdotVSafeFactor;
    half3 nonMetallicColor;
    half3 metallicColor;
    half3 stockingFalloff;
    #if (_ANISOTROPIC_SPECULAR)
    {
        mipmapLevel = 6.0;
        half rimIntensity1 = -0.0024;

        rimFactor = GetRimRamp(normalDir, rimIntensity1, useRampMap);
        finalRimColor = rimFactor + 0.0181;

        half2 blendUV1 = useSpecularUV2 ? input.uv.zw : input.uv.xy;
        blendUV1.y = blendUV1.y - viewDirWS.y * _AnisotropyShift;
        #if (_USE_BLEND_TEX)
        {
            finalSpecularIntensity = GetFaceSpecular(
                faceLightDir,
                blendUV1,
                NdotV,
                sdfMask,
                sdfFaceDiffuse
            );

            finalSpecularColor = (finalSpecularIntensity * 0.1) + (diffuse * finalSpecularIntensity * 0.9);
        }
        #else
        {
            half3 specMask = SAMPLE_TEXTURE2D(_BlendTex, sampler_BlendTex, blendUV1);
            finalSpecularIntensity = NdotV * specMask * _Anisotropy;
            finalSpecularColor = diffuse * finalSpecularIntensity;
            finalSpecularColor = (finalSpecularIntensity * (INV_PI * 0.1)) + (finalSpecularColor * 0.286478877);
        }
        #endif

        mainDiffuseColor = diffuseColor * baseColor + finalSpecularColor;
        mainDiffuseColor = mainDiffuseColor * _MainLightColor.rgb;
        mainDiffuseColor = baseColor * finalAmbientColor + mainDiffuseColor;
    }
    #else
    {
        half3 H = normalize(viewDirWS + _MainLightPosition); // 視線方向 half vector
        half NDotH = max(dot(normalDir, H), 0.0); // 拡散反射
        half VDotH = max(dot(viewDirWS, H), 0.0); // 半角視線方向
        NdotVSafe = clamp(NdotV, 0.00001, 1.0);

        mipmapLevel = rmoTex.x * 6.0; // cubemap lod

        // 非金属色
        nonMetallicColor = (mainTex * _BaseColor) - (baseColor * rmoTex.y);
        half metallicFactor;
        #if (_USE_STOCKING)
        {
            // GGXの場合発光いらない
            emissiveColor = useAnisotropicGGX ? 0.0 : emissiveColor;
            // ストッキングの金属度
            half stockingMetallic = useAnisotropicGGX ? rmoTex.w : 0.5;
            metallicFactor = stockingMetallic * 0.08;
            metallicFactor = metallicFactor - metallicFactor * rmoTex.y;
            // ストッキングのフレネル色
            half3 stockingCenterColor = _StockingCenterColor - _StockingFalloffColor;
            stockingFalloff = pow(NdotVSafe, _StockingFalloffPower) * stockingCenterColor + _StockingFalloffColor;
            // 非金属の色調整
            nonMetallicColor *= stockingFalloff;
        }
        #else
        {
            // 金属度
            metallicFactor = 0.04 - rmoTex.y * 0.04;
        }
        #endif
        // 基礎金属色
        metallicColor = baseColor * rmoTex.y + metallicFactor;
        // 非金属部分は環境色受けない
        finalAmbientColor *= nonMetallicColor;
		
		half2 AB = EnvBRDFApproxLazarov(rmoTex.x, reflectIntensity);
		// Custom EnvBRDFApprox
        finalRimColor = metallicColor * AB.x + GetRimRamp(normalDir, AB.y, useRampMap);

        // スペキュラー
        roughnessFactor = rmoTex.x * rmoTex.x;
        roughnessRimFactor = 1.0 - roughnessFactor;
        half specular = GetBaseSpecular(NDotH, roughnessFactor);
        //Stockingスペキュラー
        #if (_USE_STOCKING)
        {
            specular = GetStockingSpecular(normalDir, binormalWS, H, NDotH, roughnessFactor, useAnisotropicGGX, specular);
        }
        #endif
        //スペキュラーの強さ制御
        NdotVSafeFactor = NdotVSafe * roughnessRimFactor + roughnessFactor;
        half diffuseSpecMasked = diffuse * roughnessRimFactor + roughnessFactor;

        half specularRimIntensity = GetSpecularRim(diffuseSpecMasked, NdotVSafe, diffuse, NdotVSafeFactor);
        half specularIntensity = GetSpecularIntensity(VDotH, metallicColor.y);
        half3 specularBaseColor = GetSpecularRamp(_MainLightPosition, H, VDotH, roughnessRimFactor, roughnessFactor, specular, specularRimIntensity, useRampMap);

        half3 finalSpecularIntensity = specularIntensity * specularBaseColor;
        finalSpecularIntensity = clamp(finalSpecularIntensity, 0.0, 10.0);

        // メインライト最終色
        mainDiffuseColor = metallicColor * finalSpecularIntensity * diffuseColor;
        mainDiffuseColor = nonMetallicColor * diffuseColor + mainDiffuseColor;
        mainDiffuseColor = mainDiffuseColor * _MainLightColor.xyz;
        mainDiffuseColor = finalAmbientColor * rmoTex.z + mainDiffuseColor;
    }
    #endif

    half colorY = 0.875;
    half3 addPositionWS = normalWS * 0.02 + positionWS;
    half3 finalAddDiffuseColor = mainDiffuseColor;
    for (uint i = 0; i < min(_AdditionalLightsCount.x, unity_LightData.y); i++)
    {
        int arrayIndex = int(dot(unity_LightIndices[i >> 2u], k_identity4x4[i & 3u])); //0 1 2 3循環取得
        half3 addLightPositionWS = _AdditionalLightsPosition[arrayIndex].xyz - addPositionWS * _AdditionalLightsPosition[arrayIndex].w;
        half3 addLightDir = normalize(addLightPositionWS);
        half addLightLength = dot(addLightPositionWS, addLightPositionWS);

        //光減衰を計算する
        half addLightAttenuation = addLightLength * _AdditionalLightsAttenuation[arrayIndex].x;
        addLightAttenuation = 1.0 - addLightAttenuation * addLightAttenuation;
        addLightAttenuation = max(addLightAttenuation, 0.0);
        addLightAttenuation = addLightAttenuation * addLightAttenuation;
        addLightAttenuation = addLightAttenuation * (1.0 / addLightLength);
        //照射範囲を計算する
        half addLightArea = dot(_AdditionalLightsSpotDir[arrayIndex].xyz, addLightDir);
        addLightArea = addLightArea * _AdditionalLightsAttenuation[arrayIndex].z + _AdditionalLightsAttenuation[arrayIndex].w;
        addLightArea = saturate(addLightArea);
        addLightArea = addLightArea * addLightArea;
        half currentLightAttenuation = addLightArea * addLightAttenuation;

        half currentDiffuse = max(dot(normalDir, addLightDir), 0.0);
        half3 addDiffuseColor;
        half3 currentAddDiffuseColor;
        #if (_ANISOTROPIC_SPECULAR)
        {
            addDiffuseColor = GetDiffuse(currentDiffuse, useRampMap, colorY);
            currentAddDiffuseColor = baseColor * addDiffuseColor;
        }
        #else
        {
            half3 addLightH = normalize(viewDirWS + addLightDir);
            half addLightNDotH = max(dot(normalDir, addLightH), 0.0);
            half addLightVDotH = max(dot(viewDirWS, addLightH), 0.0);
            // 拡散反射
            addDiffuseColor = GetDiffuse(currentDiffuse, useRampMap, colorY);
            //スペキュラー
            half addLightSpecular = GetBaseSpecular(addLightNDotH, roughnessFactor);
            //ストッキングスペキュラー
            #if (_USE_STOCKING)
                {
                addLightSpecular = GetStockingSpecular(normalDir, binormalWS, addLightH, addLightNDotH, roughnessFactor, useAnisotropicGGX, addLightSpecular);
                }
            #endif
            half currentRoughness = currentDiffuse * roughnessRimFactor + roughnessFactor;
            half addLightRimSpecularIntensity = GetSpecularRim(NdotVSafe, currentRoughness, currentDiffuse, NdotVSafeFactor);
            half addLightSpecularIntensity = GetSpecularIntensity(addLightVDotH, metallicColor.y);
            half3 addLightBaseSpecularColor = GetSpecularRamp(addLightDir, addLightH, addLightVDotH, roughnessRimFactor, roughnessFactor, addLightSpecular, addLightRimSpecularIntensity, useRampMap);

            half addLightSpecArea = addLightSpecularIntensity * addLightBaseSpecularColor;
            addLightSpecArea = clamp(addLightSpecArea, 0.0, 10.0);

            currentAddDiffuseColor = metallicColor * addLightSpecArea * addDiffuseColor;
            currentAddDiffuseColor = addDiffuseColor * nonMetallicColor + currentAddDiffuseColor;
        }
        #endif
        // 拡散反射の色を変える
        currentAddDiffuseColor *= _AdditionalLightsColor[arrayIndex].xyz;
        // 光源結果を加算
        finalAddDiffuseColor = currentAddDiffuseColor * currentLightAttenuation + finalAddDiffuseColor;
    }
    //環境色計算
    half4 encodedIrrandiance = SAMPLE_TEXTURECUBE_LOD(unity_SpecCube0, samplerunity_SpecCube0, reflectDir, mipmapLevel);
    half3 specCubeColor = DecodeHDREnvironment(encodedIrrandiance, unity_SpecCube0_HDR);

    half3 finalColor = specCubeColor * finalRimColor + finalAddDiffuseColor;
    #if (!_ANISOTROPIC_SPECULAR)
        finalColor = emissiveColor * rmoTex.w + finalColor;
    #endif
    half3 finalTintColor = finalColor * _FinalTint.xyz;
    half4 output = half4(finalTintColor, 1.0);
    return output;
}
#endif

#ifndef GF2_CHARACTER_UBEROUTLINE_FUNCTIONS_INCLUDED
#define GF2_CHARACTER_UBEROUTLINE_FUNCTIONS_INCLUDED

#include "GF2CharacterUberInput.hlsl"
#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareDepthTexture.hlsl"

v2fOutline GF2VertexOutline(appdata_ex v)
{
    v2fOutline o;
    half3 binormalWS = normalize(cross(v.normal,v.tangent) * v.tangent.w * unity_WorldTransformParams.w);
    half3 smoothNormal = v.color.xyz * 2.0 + -1.0;
    half3 normalOutline = normalize(smoothNormal.x * v.tangent.xyz + binormalWS.xyz * smoothNormal.y + smoothNormal.z * v.normal.xyz);
    half3 normalWS = normalize(mul(normalOutline, unity_WorldToObject).xyz);
    half4 positionWS = mul(unity_ObjectToWorld, half4(v.vertex.xyz, 1.0));
    
    half4 positionVS = half4(mul(unity_MatrixV, half4(positionWS.xyz,1.0)).xyz, 1.0);
    positionVS.z = positionVS.z - _OutlineZBias * 0.001;
    
    half4 normalVS = half4((mul(unity_MatrixV, normalWS) * 0.00052083336 + positionVS.xyz), 1.0);
    
    // _ScreenParams: x 是摄像机目标纹理的宽度（以像素为单位），y 是摄像机目标纹理的高度（以像素为单位）
    // _ScreenParams: z 是 1.0 + 1.0/宽度，w 为 1.0 + 1.0/高度。 也就是偏移1个像素
    half3 normalCS = normalize(mul(unity_MatrixVP, half4(normalWS, 0.0)).xyz);
    half2 outlineWeight = normalCS.xy * (_ScreenParams.zw - 1.0) * 2;
    
    half depthPS = dot(UNITY_MATRIX_P._m32_m33, positionVS.zw);
    half2 outlineWeight1 = depthPS * outlineWeight * 1.2;
    half2 outlineWeight2 = depthPS * (outlineWeight * _ScreenParams.x) * 0.00130208337;
    
    // 根据距离调整宽度
    half outlineWidth = _OutlineWidth * 1.3;
    half2 normalPS = half2(dot(UNITY_MATRIX_P._m00_m02_m03, normalVS.xzw), dot(UNITY_MATRIX_P._m11_m12_m13, normalVS.yzw));
    half2 positionPS = half2(dot(UNITY_MATRIX_P._m00_m02_m03, positionVS.xzw), dot(UNITY_MATRIX_P._m11_m12_m13, positionVS.yzw));
    half2 outlineDepthScale = outlineWidth * (normalPS - positionPS);
    outlineDepthScale = max(abs(outlineDepthScale), abs(outlineWeight1));
    outlineDepthScale = min(abs(outlineWeight2), outlineDepthScale);
    
    // 判断正反法线方向并反转结果 并优化一些计算 (normalCS.xy < 0.0) * -1 - (normalCS.xy > 0.0) * -1
    half2 outlineDir = int2((normalCS.xy > 0.0) - (normalCS.xy < 0.0));
    half2 outlineValue = outlineDir * outlineDepthScale;
    
    half2 vertexDirPlane = normalize(v.vertex.xz);
    half2 lightDirPlane = normalize(mul(unity_WorldToObject, _MainLightPosition.xyz).xyz).xz;   // 这里没有多余 有xyz和没有是两回事
    
    half outlineLightIntensity = (dot(vertexDirPlane, lightDirPlane) + 1.0) * 0.5;
    
    half4 outlineBaseColor = _OutlineColor - _OutlineShadowColor;
    
    o.uv.xy = v.texcoord;
    o.position = half4(outlineValue * v.color.w + positionPS.xy, dot(UNITY_MATRIX_P._m20_m21_m22_m23, positionVS), depthPS);
    o.outlineColor = (outlineLightIntensity * outlineBaseColor + _OutlineShadowColor) * _OutlineIntensity;
    return o;
}

half4 GF2FragmentOutline(v2fOutline input, half facing: VFACE) : SV_Target
{
    float3 baseColor =  input.outlineColor.xyz * _FinalTint.xyz * _MainLightColor.xyz;
    float3 baseTex = SAMPLE_TEXTURE2D(_BaseMap, sampler_BaseMap, input.uv.xy * _BaseMap_ST.xy + _BaseMap_ST.zw);
    return half4(baseColor * baseTex, 1.0);
}
#endif

/*************************************************************************
  EndField_Uber.glsl
  —— Substance Painter GLSL 全功能移植版：Endfield 角色 Uber
  
  ============== 通道 / 贴图映射（统一槽位思路，按部位换语义） ==============
  引擎通道（所有部位共用）：
    basecolor → _BaseMap.rgb     opacity → _BaseMap.a
    metallic  → RMOS Metal(.r)   specularlevel → RMOS Spec(.g)
    roughness → 1-Smooth(.a)     AO → RMOS Shadow(.b) [H1]
    normal    → _BumpMap         emissive → _EmissionMap
  user 通道：
    user1 = Standard: ClearCoat Mask (.r, 可绘制)
    (SP 通道无 Alpha — SDF Mask/Split Normal/Fur Direction 等 RGBA 资产走 sampler 参数)
  自定义贴图参数（共享资产 / RGBA 完整 / 需任意 UV 变换，不可绘制）：
    _RampMap _SpecRampMap _ShadowLutTex _SDFMask _SDFLightmap _EmotionMap _HighlightMap
    _MatcapTex _SplitNormalMap _StrokeMap _LineMap _ParallaxTex _FurMap _FurDirMap _FurDyeMap
    _VFXSpecialMainTex _VFXSpecialBlendTex (Fur烬火)
    _VFXMainTex _VFXMaskTex _VFXBlendTex _VFXDisturbTex _VFXNormalMap (VFX part)

  ============== 硬编码 / 无等价物清单 ==============
  [H1] RMOS.b 阴影遮罩(shadowMask) → SP AO 通道等价；无 AO 数据时返回 1.0（=Unity 无遮罩）。
  [H2] 主光源屏幕空间阴影：SP 无 → shadowAttenuation=1.0（全亮）。
  [H3] 主光源颜色：UI 参数 v_MainLightColor；方向 = SP 视口主灯 light_main 经 i_LightRotX/Y/Z 旋转。
  [H4] unity_ObjectToWorld：SP 模型即世界（无变换）→ 取单位矩阵；枢轴 originX/Z=0。
       Face/Hair/Eye 的对象轴 = 世界轴 (1,0,0)/(0,1,0)/(0,0,1)；SP 烘焙网格无需 FBX -90 旋转修正
       (已删该开关: 它把发丝各向异性轴转错 90°, 致刘海高光环消失)。
       Face SDF 基轴 (源=O2W 列0/列2) 直接由 _FaceRight/_FaceForward 以 SP 世界空间输入
       (±1, rip FBX 实测面朝 -Z ⇒ Unity .mat 轴 Z 取反)，faceUp=cross(right,fwd) 重建列1。
  [H5] ApplyCustomAO（Fix 沙盒自定义 AO）：跳过。
  [H6] 反射立方图：_CharMaxCubemap(Standard) 与 unity_SpecCube0(Fur) 都 → SP 环境 envSampleLOD()。
       mip 公式不变；环境内容随 SP 环境贴图而变（建议挂 CharCubemap.exr）。
  [H7] 引擎通道按 1:1 UV 绘制，不支持 _BaseMap_ST 平铺；_BaseMap_ST 参数只作用于
       自定义贴图参数的 UV 公式（与 Unity 一致）。默认 (1,1,0,0) 时两边完全一致。
  [H8] getTSNormal(sparse_coord)：取 SP 法线通道切线空间法线（替代 Unity DXT5nm 解码）。
  [H9] HG 后处理 tonemap (ACES_modified, 源 lutbuilder2d b4) 已内置: u_UseEndfieldTonemap
       默认开 + f_TonemapExposure。SP 显示设置的 Tone mapping 务必选 Linear 防二次映射;
       Bloom/调色 LUT 等其余后处理仍不在本 shader 内。另: sRGBTexture=1 的贴图参数
       (_ShadowLutTex/_EmotionMap/_MatcapTex/_ParallaxTex/Fur·VFX 系) 已补硬件 sRGB 解码。
  [H10] Fur 壳层挤出是顶点/多 pass：SP 不可能 → f_FurShellIdx 滑条预览任意单壳层的片元着色
       （0=底面，1=最外层）。clip(shellAlpha-0.003) 保留。
  [H11] Hair 皮肤高光的深度边缘检测(_CameraDepthTexture)：SP 无场景深度 →
       f_HairDepthEdgeMask 参数替代 depthSmooth（默认 1=始终生效）。
  [H12] VFX part：SP 无顶点色/UV2/粒子CustomData → vertColor=白、uv1=uv0、custom=0；
       _Time.y → f_VFXTime 手动滑条。混合状态固定 over（无法逐部位换 additive 状态）。
  [H13] OverlayShadow 眼白阴影是 `Blend Zero SrcColor` 乘法叠帧 pass。SP 无乘帧 → 用 over
       混合等价逼近：输出阴影染色 _BaseColor.rgb + alpha=变暗权重(texR·a²)，强制半透明
       (forceAlphaBlend, 否则该材质 _SurfaceType 非透明会被渲成挡眼的白色不透明面片)。
       眼白 fb≈1 时 over 与真乘法逐像素相等。顶点视空间偏移 _ShadowAngleRange 跳过。
  ====================================================================
*************************************************************************/

//----------------------------------------------------------------------region 面板 UI 参数
//- {
  //- region 部位
    //: param custom {
    //:   "default": 0,
    //:   "label": "角色部位 CharaPart",
    //:   "widget": "combobox",
    //:   "values": {
    //:     "0 Standard 衣物/身体": 0,
    //:     "1 Face 脸/皮肤": 1,
    //:     "2 Eyes 眼睛": 2,
    //:     "3 Hair 头发": 3,
    //:     "4 Fur 毛皮": 4,
    //:     "5 Eyebrow 眉毛": 5,
    //:     "6 VFX 特效": 6,
    //:     "7 OverlayShadow 眼白阴影": 7
    //:   },
    //:   "group": "0 部位"
    //: }
    uniform_specialization int u_CharaPart;
  //- endregion

  //- region 基础设置
    //: param custom { "default": [1.0, 1.0, 1.0, 1.0], "label": "基础色 BaseColor", "widget":"color", "group": "1 基础设置" }
    uniform vec4 _BaseColor;
    //: param custom { "default": [1.0, 1.0, 0.0, 0.0], "label": "BaseMap_ST (xy=Tiling zw=Offset, 仅作用于自定义贴图UV)", "group": "1 基础设置" }
    uniform vec4 _BaseMap_ST;
    //: param custom { "default": true, "label": "使用法线贴图 _NORMALMAP", "group": "1 基础设置" }
    uniform bool u_UseBumpMap;
    //: param custom { "default": 1.0, "label": "法线强度 BumpScale", "min": 0.0, "max": 4.0, "group": "1 基础设置" }
    uniform float _BumpScale;
    //: param custom { "default": true, "label": "使用 RMOS 通道 _METALLICSPECGLOSSMAP", "group": "1 基础设置" }
    uniform bool u_UseMetallicGlossMap;
    //: param custom { "default": 0.839, "label": "金属度(无贴图时) Metallic", "min": 0.0, "max": 1.0, "group": "1 基础设置" }
    uniform float _Metallic;
    //: param custom { "default": 1.0, "label": "高光强度(无贴图时) Specular", "min": 0.0, "max": 1.0, "group": "1 基础设置" }
    uniform float _Specular;
    //: param custom { "default": 0.406, "label": "光滑度(无贴图时) Smoothness", "min": 0.0, "max": 1.0, "group": "1 基础设置" }
    uniform float _Smoothness;
    //: param custom { "default": true, "label": "使用漫反射 Ramp _DIFF_RAMP_ON", "group": "1 基础设置" }
    uniform bool u_UseDiffRamp;
    //: param custom { "default": "", "default_color": [1.0,1.0,1.0,1.0], "label": "漫反射 Ramp (RGB:色调 A:明暗)", "usage": "texture", "group": "1 基础设置" }
    uniform sampler2D _RampMap;
    //: param custom { "default": [1.0, 1.0, 1.0], "label": "主光源颜色", "widget":"color", "group": "1 基础设置" }
    uniform vec3 v_MainLightColor;
    //: param custom { "default": 0, "label": "灯光旋转 X", "min": 0, "max": 360, "group": "1 基础设置" }
    uniform int i_LightRotX;
    //: param custom { "default": 0, "label": "灯光旋转 Y", "min": 0, "max": 360, "group": "1 基础设置" }
    uniform int i_LightRotY;
    //: param custom { "default": 0, "label": "灯光旋转 Z", "min": 0, "max": 360, "group": "1 基础设置" }
    uniform int i_LightRotZ;
    //: param custom { "default": 0.0, "label": "背面法线翻转 BackFaceNormalFlip (0=反向 1=保持)", "min": 0.0, "max": 1.0, "group": "1 基础设置" }
    uniform float _BackFaceNormalFlip;
  //- endregion

  //- region 阴影色
    //: param custom { "default": false, "label": "使用 Shadow LUT _SHADOW_LUT_TEX", "group": "2 阴影色" }
    uniform bool u_UseShadowLut;
    //: param custom { "default": "", "default_color": [1.0,1.0,1.0,1.0], "label": "Shadow LUT (32切片 1024x32)", "usage": "texture", "group": "2 阴影色" }
    uniform sampler2D _ShadowLutTex;
    //: param custom { "default": 0.5, "label": "阴影色亮度 ShadowColorBrightness", "min": 0.0, "max": 1.0, "group": "2 阴影色" }
    uniform float _ShadowColorBrightness;
    //: param custom { "default": 1.0, "label": "阴影色饱和度 ShadowColorSaturation", "min": 0.0, "max": 2.0, "group": "2 阴影色" }
    uniform float _ShadowColorSaturation;
  //- endregion

  //- region 高光 Ramp / 反射
    //: param custom { "default": false, "label": "使用高光 Ramp _SPEC_RAMP_ON", "group": "3 高光Ramp与反射" }
    uniform bool u_UseSpecRamp;
    //: param custom { "default": "", "default_color": [1.0,1.0,1.0,1.0], "label": "高光 Ramp 贴图", "usage": "texture", "group": "3 高光Ramp与反射" }
    uniform sampler2D _SpecRampMap;
    //: param custom { "default": 0.0, "label": "Iridescent 模式", "min": 0.0, "max": 1.0, "group": "3 高光Ramp与反射" }
    uniform float _SpecRampIridescentMode;
    //: param custom { "default": 1.0, "label": "Cubemap/环境反射强度 (仅 Standard)", "min": 0.0, "max": 4.0, "group": "3 高光Ramp与反射" }
    uniform float _CubemapIntensity;
  //- endregion

  //- region 自发光
    //: param custom { "default": true, "label": "使用自发光 _EMISSION", "group": "4 自发光" }
    uniform bool u_UseEmission;
    //: param custom { "default": [0.0, 0.0, 0.0, 1.0], "label": "自发光颜色 EmissionColor", "widget":"color", "group": "4 自发光" }
    uniform vec4 _EmissionColor;
    //: param custom { "default": 1.0, "label": "自发光亮度 EmissionBrightness", "min": 0.0, "max": 16.0, "group": "4 自发光" }
    uniform float _EmissionBrightness;
  //- endregion

  //- region 渲染设置
    //: param custom { "default": false, "label": "半透明混合 AlphaBlend", "group": "5 渲染设置" }
    uniform_specialization bool u_AlphaBlend;
    //: param custom { "default": 0.0, "label": "透明裁切阈值 AlphaClip", "min": 0.0, "max": 1.0, "group": "5 渲染设置" }
    uniform float f_AlphaClip;
    //: param custom { "default": 0.0, "label": "AlphaPremultiply", "min": 0.0, "max": 1.0, "group": "5 渲染设置" }
    uniform float _AlphaPremultiply;
    //: param custom { "default": true, "label": "EndField Tonemap ACES_modified (SP显示设置Tone mapping请选Linear)", "group": "5 渲染设置" }
    uniform bool u_UseEndfieldTonemap;
    //: param custom { "default": 1.0, "label": "Tonemap 前曝光", "min": 0.0, "max": 4.0, "group": "5 渲染设置" }
    uniform float f_TonemapExposure;
  //- endregion

  //- region ClearCoat (Standard)
    //: param custom { "default": false, "label": "启用清漆 _CLEARCOAT (mask=user1.r)", "group": "6 ClearCoat" }
    uniform bool u_ClearCoat;
    //: param custom { "default": [1.0, 1.0, 1.0, 1.0], "label": "清漆颜色 ClearCoatColor", "widget":"color", "group": "6 ClearCoat" }
    uniform vec4 _ClearCoatColor;
    //: param custom { "default": 0.95, "label": "清漆光滑度 ClearCoatSmoothness", "min": 0.0, "max": 1.0, "group": "6 ClearCoat" }
    uniform float _ClearCoatSmoothness;
    //: param custom { "default": 0.0, "label": "清漆金属度 ClearCoatMetallic", "min": 0.0, "max": 1.0, "group": "6 ClearCoat" }
    uniform float _ClearCoatMetallic;
    //: param custom { "default": 0.0, "label": "清漆法线 (0=顶点 1=贴图)", "min": 0.0, "max": 1.0, "group": "6 ClearCoat" }
    uniform float _ClearCoatNormalMode;
  //- endregion

  //- region Pantyhose (Standard)
    //: param custom { "default": false, "label": "启用连裤袜 _PANTYHOSE", "group": "7 Pantyhose" }
    uniform bool u_Pantyhose;
    //: param custom { "default": [0.36, 0.17, 0.16, 0.5], "label": "Pantyhose 颜色", "widget":"color", "group": "7 Pantyhose" }
    uniform vec4 _PantyhoseColor;
    //: param custom { "default": 0.0, "label": "Pantyhose 高光强度", "min": 0.0, "max": 0.5, "group": "7 Pantyhose" }
    uniform float _PantyhoseSpecularInt;
    //: param custom { "default": 0.0, "label": "Pantyhose 高光偏移", "min": -2.0, "max": 2.0, "group": "7 Pantyhose" }
    uniform float _PantyhoseSpecularValue;
    //: param custom { "default": 0.0, "label": "Pantyhose 各向异性", "min": -1.0, "max": 1.0, "group": "7 Pantyhose" }
    uniform float _PantyhoseAnisotropyDirection;
  //- endregion

  //- region Parallax (Standard)
    //: param custom { "default": false, "label": "启用视差 _PARALLAX_MAP", "group": "8 Parallax" }
    uniform bool u_UseParallax;
    //: param custom { "default": "", "default_color": [0.0,0.0,0.0,1.0], "label": "视差高度图 ParallaxTex (R)", "usage": "texture", "group": "8 Parallax" }
    uniform sampler2D _ParallaxTex;
    //: param custom { "default": [1.0, 1.0, 0.0, 0.0], "label": "ParallaxTex_ST", "group": "8 Parallax" }
    uniform vec4 _ParallaxTex_ST;
    //: param custom { "default": 2.0, "label": "步进次数 ParallaxMarchNum", "min": 1.0, "max": 5.0, "group": "8 Parallax" }
    uniform float _ParallaxMarchNum;
    //: param custom { "default": 0.3, "label": "视差强度 ParallaxScale (Eyes 也用)", "min": 0.0, "max": 1.0, "group": "8 Parallax" }
    uniform float _ParallaxScale;
    //: param custom { "default": [1.0, 1.0, 1.0, 1.0], "label": "视差颜色 ParallaxColor", "widget":"color", "group": "8 Parallax" }
    uniform vec4 _ParallaxColor;
  //- endregion

  //- region Face (Part 1)
    //: param custom { "default": false, "label": "使用 SDF Lightmap _SDFLIGHTMAP (mask=user0)", "group": "A Face" }
    uniform bool u_UseSDFLightmap;
    //: param custom { "default": "", "default_color": [0.0,0.0,0.0,1.0], "label": "SDF Lightmap", "usage": "texture", "group": "A Face" }
    uniform sampler2D _SDFLightmap;
    //: param custom { "default": "", "default_color": [1.0,1.0,0.0,0.0], "label": "SDF Mask (rgba: rim/blend/body/ctrl)", "usage": "texture", "group": "A Face" }
    uniform sampler2D _SDFMask;
    //: param custom { "default": [1.0, 1.0, 1.0, 1.0], "label": "皮肤边缘光色 SDFRimColor", "widget":"color", "group": "A Face" }
    uniform vec4 _SDFRimColor;
    //: param custom { "default": 0.5, "label": "皮肤边缘光强 SkinRimOffScale", "min": 0.0, "max": 1.5, "group": "A Face" }
    uniform float _SkinRimOffScale;
    //: param custom { "default": 1.0, "label": "脸部边缘光强 FaceRimOffScale (SDF区)", "min": 0.0, "max": 1.5, "group": "A Face" }
    uniform float _FaceRimOffScale;
    //- 源 shader 的脸基轴 = unity_ObjectToWorld 列0(右)/列2(前), 从不读 .mat 的 FaceForward/FaceRight。
    //- SP 模型烘死在世界空间无矩阵可读 → 这两个参数直接填"SP 世界空间"的脸轴, 支持负值
    //- (必须显式声明 min/max, 否则 SP UI 钳 0..1 输不进负数)。
    //- rip FBX 进 SP 实测面朝 -Z: Unity 轴 → SP 轴 = Z 取反 (X/Y 不变), 故默认 (0,0,-1)/(1,0,0)。
    //- 调试: 明暗随光前后扫掠反相 → FaceForward 整体取反; 阴影左右镜像取错边 → FaceRight 整体取反。
    //- 不需要第三个 FaceBack/FaceUp 参数: Up = cross 重建 (源列1, 仅 ~1e-4 权重), Back = -Forward。
    //- 默认 (0,0,0): 实测该 SP 网格的"上轴"不是世界 Y (疑似 Z-up FBX 导入), 任何真实前向轴
    //- 都会让 SDF 把光投到错误的水平面 → 正反都糊; (0,0,0) 令 objLightZ≡0 关掉前后扫描,
    //- SDF 静态居中(不随光平滑扫掠)但不再出错。要恢复平滑需先定准网格真实上/前轴。
    //: param custom { "default": [0.0, 0.0, 0.0], "label": "脸正面朝向 FaceForward (SP世界轴; 0=关前后SDF扫描)", "min": -1.0, "max": 1.0, "group": "A Face" }
    uniform vec3 _FaceForward;
    //: param custom { "default": [1.0, 0.0, 0.0], "label": "脸右侧朝向 FaceRight (SP世界轴)", "min": -1.0, "max": 1.0, "group": "A Face" }
    uniform vec3 _FaceRight;
    //: param custom { "default": false, "label": "使用表情贴图 _EMOTION_MAP", "group": "A Face" }
    uniform bool u_UseEmotionMap;
    //: param custom { "default": "", "default_color": [0.0,0.0,0.0,0.0], "label": "表情贴图 EmotionMap (2x2 grid)", "usage": "texture", "group": "A Face" }
    uniform sampler2D _EmotionMap;
    //: param custom { "default": 0, "label": "表情序号 EmotionIndex", "min": 0, "max": 3, "group": "A Face" }
    uniform int _EmotionIndex;
    //: param custom { "default": 1.0, "label": "表情混合 EmotionBlend", "min": 0.0, "max": 1.0, "group": "A Face" }
    uniform float _EmotionBlend;
    //: param custom { "default": false, "label": "使用高光贴图 _HIGHLIGHT_MAP", "group": "A Face" }
    uniform bool u_FaceHighlightMap;
    //: param custom { "default": "", "default_color": [0.0,0.0,0.0,0.0], "label": "脸部高光贴图 HighlightMap", "usage": "texture", "group": "A Face" }
    uniform sampler2D _HighlightMap;
    //: param custom { "default": [0.04, -0.01, 0.0, 0.0], "label": "高光贴图偏移 HighlightMapVector", "group": "A Face" }
    uniform vec4 _HighlightMapVector;
  //- endregion

  //- region Eyes (Part 2 / 5)
    //: param custom { "default": false, "label": "使用 Matcap _MATCAP_ON", "group": "B Eyes" }
    uniform bool u_UseMatcap;
    //: param custom { "default": "", "default_color": [1.0,1.0,1.0,1.0], "label": "Matcap 贴图", "usage": "texture", "group": "B Eyes" }
    uniform sampler2D _MatcapTex;
    //: param custom { "default": 1.0, "label": "Matcap 法线强度 MatcapNormalScale", "min": 0.0, "max": 1.5, "group": "B Eyes" }
    uniform float _MatcapNormalScale;
    //: param custom { "default": [1.0, 1.0, 1.0, 1.0], "label": "Matcap 颜色 (HDR)", "widget":"color", "group": "B Eyes" }
    uniform vec4 _MatcapColor;
    //: param custom { "default": false, "label": "眼睛高光 _EYE_HIGHLIGHT", "group": "B Eyes" }
    uniform bool u_EyeHighLight;
    //: param custom { "default": [2.0, 2.0, 2.0, 1.0], "label": "眼高光颜色 (HDR)", "widget":"color", "group": "B Eyes" }
    uniform vec4 _EyeHighLightColor;
    //: param custom { "default": [1.0, 1.0, 1.0, 1.0], "label": "眼散射颜色 (HDR)", "widget":"color", "group": "B Eyes" }
    uniform vec4 _EyeScatteringColor;
    //: param custom { "default": 0.03, "label": "虹膜视差 EyeParallaxScale", "min": 0.0, "max": 0.15, "group": "B Eyes" }
    uniform float _EyeParallaxScale;
  //- endregion

  //- region Hair (Part 3)
    //: param custom { "default": "", "default_color": [0.5,0.5,0.5,0.5], "label": "Split Normal Map (RG=diffuse BA=spec 裸[0,1])", "usage": "texture", "group": "C Hair" }
    uniform sampler2D _SplitNormalMap;
    //: param custom { "default": true, "label": "拆分高光法线 _SPECULAR_NORMALMAP (.ba)", "group": "C Hair" }
    uniform bool u_UseSpecBumpMap;
    //: param custom { "default": 1.0, "label": "高光法线强度 SpecBumpScale", "min": 0.0, "max": 4.0, "group": "C Hair" }
    uniform float _SpecBumpScale;
    //: param custom { "default": 0.7, "label": "各向异性1 AnisotropyValue", "min": 0.0, "max": 1.0, "group": "C Hair" }
    uniform float _AnisotropyValue;
    //: param custom { "default": 0.712, "label": "各向异性2 AnisotropyValue2", "min": 0.0, "max": 1.0, "group": "C Hair" }
    uniform float _AnisotropyValue2;
    //: param custom { "default": 0.0, "label": "各向异性方向X AnisotropyDirX", "min": -1.0, "max": 1.0, "group": "C Hair" }
    uniform float _AnisotropyDirX;
    //: param custom { "default": 2.0, "label": "各向异性强度 AnisotropyIntensity", "min": 0.0, "max": 3.0, "group": "C Hair" }
    uniform float _AnisotropyIntensity;
    //: param custom { "default": 3.0, "label": "边缘衰减 AnisotropyEdgeFade", "min": 0.01, "max": 10.0, "group": "C Hair" }
    uniform float _AnisotropyEdgeFade;
    //: param custom { "default": 0.5, "label": "高光2范围 AnisotropyRange2", "min": -1.0, "max": 1.0, "group": "C Hair" }
    uniform float _AnisotropyRange2;
    //: param custom { "default": [0.563, 0.283, 0.048, 1.0], "label": "高光2颜色 AnisotropyColor2", "widget":"color", "group": "C Hair" }
    uniform vec4 _AnisotropyColor2;
    //: param custom { "default": false, "label": "使用 Stroke Map _STROKE_ON", "group": "C Hair" }
    uniform bool u_StrokeOn;
    //: param custom { "default": "", "default_color": [0.5,0.5,0.5,1.0], "label": "Stroke Map (R)", "usage": "texture", "group": "C Hair" }
    uniform sampler2D _StrokeMap;
    //: param custom { "default": [1.0, 1.0, 0.0, 0.0], "label": "StrokeMap_ST", "group": "C Hair" }
    uniform vec4 _StrokeMap_ST;
    //: param custom { "default": 1.0, "label": "Stroke 强度 StrokeScale", "min": -4.0, "max": 4.0, "group": "C Hair" }
    uniform float _StrokeScale;
    //: param custom { "default": true, "label": "高光线 _SPECULAR_LINE", "group": "C Hair" }
    uniform bool u_SpecularLine;
    //: param custom { "default": 1.0, "label": "使用 Line Map (0=程序线)", "min": 0.0, "max": 1.0, "group": "C Hair" }
    uniform float _UseLineMap;
    //: param custom { "default": "", "default_color": [0.0,0.0,0.0,1.0], "label": "Line Map (R)", "usage": "texture", "group": "C Hair" }
    uniform sampler2D _LineMap;
    //: param custom { "default": [1.0, 1.0, 0.0, 0.0], "label": "LineMap_ST", "group": "C Hair" }
    uniform vec4 _LineMap_ST;
    //: param custom { "default": 300.0, "label": "线数量 LineAmount", "min": 1.0, "max": 1000.0, "group": "C Hair" }
    uniform float _LineAmount;
    //: param custom { "default": 0.58, "label": "线位置 LineValue", "min": 0.0, "max": 1.0, "group": "C Hair" }
    uniform float _LineValue;
    //: param custom { "default": 0.93, "label": "线范围 LineRange", "min": -1.0, "max": 1.0, "group": "C Hair" }
    uniform float _LineRange;
    //: param custom { "default": 0.3, "label": "线强度 LineIntensity", "min": 0.0, "max": 1.0, "group": "C Hair" }
    uniform float _LineIntensity;
    //: param custom { "default": 1.7, "label": "线饱和度 LineSaturation", "min": 0.0, "max": 10.0, "group": "C Hair" }
    uniform float _LineSaturation;
    //: param custom { "default": [0.0, 0.0, 0.0, 0.0], "label": "高度压暗 HairDarkenParams (x=offX y=darken z=offZ w=min)", "group": "C Hair" }
    uniform vec4 _HairDarkenParams;
    //: param custom { "default": 1.0, "label": "[H11] 皮肤高光深度边缘替代 HairDepthEdgeMask", "min": 0.0, "max": 1.0, "group": "C Hair" }
    uniform float f_HairDepthEdgeMask;
  //- endregion

  //- region Fur (Part 4)
    //: param custom { "default": 0.5, "label": "[H10] 壳层预览 FurShellIdx (0=底 1=外)", "min": 0.0, "max": 1.0, "group": "D Fur" }
    uniform float f_FurShellIdx;
    //: param custom { "default": "", "default_color": [1.0,1.0,1.0,1.0], "label": "毛噪声 FurMap", "usage": "texture", "group": "D Fur" }
    uniform sampler2D _FurMap;
    //: param custom { "default": [1.0, 1.0, 0.0, 0.0], "label": "FurMap_ST (各向同性: 仅 .x 用于双轴)", "group": "D Fur" }
    uniform vec4 _FurMap_ST;
    //: param custom { "default": 0.7, "label": "毛长 FurLengthIntensity (仅参与壳层公式)", "min": 0.001, "max": 6.0, "group": "D Fur" }
    uniform float _FurLengthIntensity;
    //: param custom { "default": 0.0, "label": "根部裁切 FurCutoffStart", "min": 0.0, "max": 1.0, "group": "D Fur" }
    uniform float _FurCutoffStart;
    //: param custom { "default": 1.0, "label": "尖部裁切 FurCutoffEnd", "min": 0.0, "max": 1.0, "group": "D Fur" }
    uniform float _FurCutoffEnd;
    //: param custom { "default": 1.0, "label": "根部AO FurAO", "min": 0.0, "max": 1.0, "group": "D Fur" }
    uniform float _FurAO;
    //: param custom { "default": 0.4, "label": "边缘衰减 FurEdgeFade", "min": 0.0, "max": 1.0, "group": "D Fur" }
    uniform float _FurEdgeFade;
    //: param custom { "default": 0.0, "label": "透光强度 FurTTIntensity", "min": 0.0, "max": 1.0, "group": "D Fur" }
    uniform float _FurTTIntensity;
    //: param custom { "default": "", "default_color": [0.5,0.5,1.0,1.0], "label": "Fur Direction Map (RG=dir B=density A=length)", "usage": "texture", "group": "D Fur" }
    uniform sampler2D _FurDirMap;
    //: param custom { "default": 0.0, "label": "使用方向图 FurDirMapEnable", "min": 0.0, "max": 1.0, "group": "D Fur" }
    uniform float _FurDirMapEnable;
    //: param custom { "default": 0.0, "label": "毛尖锐化 FurSharpen", "min": 0.0, "max": 1.0, "group": "D Fur" }
    uniform float _FurSharpen;
    //: param custom { "default": 0.0, "label": "壳层噪声 FurNoise", "min": 0.0, "max": 1.0, "group": "D Fur" }
    uniform float _FurNoise;
    //: param custom { "default": false, "label": "毛染色 _CHARACTER_FUR_DYE", "group": "D Fur" }
    uniform bool u_FurDyeEnable;
    //: param custom { "default": "", "default_color": [0.0,0.0,0.0,1.0], "label": "染色贴图 FurDyeMap", "usage": "texture", "group": "D Fur" }
    uniform sampler2D _FurDyeMap;
    //: param custom { "default": [1.0, 1.0, 0.0, 0.0], "label": "FurDyeMap_ST", "group": "D Fur" }
    uniform vec4 _FurDyeMap_ST;
    //: param custom { "default": 1.0, "label": "染色强度 FurDyeIntensity", "min": 0.0, "max": 1.0, "group": "D Fur" }
    uniform float _FurDyeIntensity;
  //- endregion

  //- region Fur 烬火 VFX (_CHARACTER_VFX_SPECIAL)
    //: param custom { "default": false, "label": "启用 Fur VFX _CHARACTER_VFX_SPECIAL", "group": "E Fur VFX" }
    uniform bool u_EnableCharacterVFX;
    //: param custom { "default": [1.0, 1.0, 1.0, 1.0], "label": "VFX 颜色 (HDR)", "widget":"color", "group": "E Fur VFX" }
    uniform vec4 _VFXColor;
    //: param custom { "default": 1.0, "label": "VFX 颜色强度", "min": 1.0, "max": 100.0, "group": "E Fur VFX" }
    uniform float _VFXColorIntensity;
    //: param custom { "default": 1.0, "label": "VFX 颜色Alpha", "min": 0.0, "max": 10.0, "group": "E Fur VFX" }
    uniform float _VFXColorAlpha;
    //: param custom { "default": "", "default_color": [1.0,1.0,1.0,1.0], "label": "VFX 主纹理 SpecialMainTex", "usage": "texture", "group": "E Fur VFX" }
    uniform sampler2D _VFXSpecialMainTex;
    //: param custom { "default": [1.0, 1.0, 0.0, 0.0], "label": "VFXSpecialMainTex_ST", "group": "E Fur VFX" }
    uniform vec4 _VFXSpecialMainTex_ST;
    //: param custom { "default": 0.0, "label": "主纹理R作Alpha UseVFXMainTexAsAlpha", "min": 0.0, "max": 1.0, "group": "E Fur VFX" }
    uniform float _UseVFXMainTexAsAlpha;
    //: param custom { "default": "", "default_color": [0.0,0.0,0.0,0.0], "label": "VFX 混合纹理 SpecialBlendTex", "usage": "texture", "group": "E Fur VFX" }
    uniform sampler2D _VFXSpecialBlendTex;
    //: param custom { "default": [1.0, 1.0, 0.0, 0.0], "label": "VFXSpecialBlendTex_ST", "group": "E Fur VFX" }
    uniform vec4 _VFXSpecialBlendTex_ST;
    //: param custom { "default": 1.0, "label": "混合纹理R扰动 BlendTexRForDisturb", "min": 0.0, "max": 1.0, "group": "E Fur VFX" }
    uniform float _VFXSpecialBlendTexRForDisturb;
    //: param custom { "default": [1.0, 1.0, 1.0, 1.0], "label": "VFX 混合染色 BlendTint (HDR)", "widget":"color", "group": "E Fur VFX" }
    uniform vec4 _VFXBlendTint;
    //: param custom { "default": [0.0, 0.0, 0.0, 0.0], "label": "VFX 滚动 SpecialParam (XY:Main ZW:Blend)", "group": "E Fur VFX" }
    uniform vec4 _VFXSpecialParam;
    //: param custom { "default": [1.0, 1.0, 1.0, 1.0], "label": "VFX 菲涅尔色 (HDR)", "widget":"color", "group": "E Fur VFX" }
    uniform vec4 _VFXFresnelColor;
    //: param custom { "default": 0.0, "label": "菲涅尔偏置 FresnelBias", "min": -1.0, "max": 2.0, "group": "E Fur VFX" }
    uniform float _VFXFresnelBias;
    //: param custom { "default": 1.0, "label": "菲涅尔影响不透明度", "min": 0.0, "max": 1.0, "group": "E Fur VFX" }
    uniform float _VFXFresnelAffectOpacity;
    //: param custom { "default": 1.0, "label": "菲涅尔指数 FresnelPower", "min": 1.0, "max": 100.0, "group": "E Fur VFX" }
    uniform float _VFXFresnelPower;
    //: param custom { "default": 0.0, "label": "菲涅尔翻转 FresnelFlip", "min": 0.0, "max": 1.0, "group": "E Fur VFX" }
    uniform float _VFXFresnelFlip;
    //: param custom { "default": 0.0, "label": "溶解进度 DissolveScheduleOffset (1=隐藏)", "min": 0.0, "max": 1.0, "group": "E Fur VFX" }
    uniform float _SpecialDissolveScheduleOffset;
    //: param custom { "default": 0.0, "label": "[H12] VFX 时间 (替代 _Time.y)", "min": 0.0, "max": 100.0, "group": "E Fur VFX" }
    uniform float f_VFXTime;
  //- endregion

  //- region VFX Part (Part 6, HGRP_CharacterNPR_VFX_Fix)
    //: param custom { "default": 0.0, "label": "混合模式 BlendMode (0=Alpha 1=Additive)", "min": 0.0, "max": 1.0, "group": "F VFX部位" }
    uniform float _BlendMode;
    //: param custom { "default": [1.0, 1.0, 1.0, 1.0], "label": "TintColor (HDR)", "widget":"color", "group": "F VFX部位" }
    uniform vec4 _TintColor;
    //: param custom { "default": 1.0, "label": "Tint 强度", "min": 1.0, "max": 100.0, "group": "F VFX部位" }
    uniform float _TintColorIntensity;
    //: param custom { "default": 1.0, "label": "Tint Alpha", "min": 0.0, "max": 10.0, "group": "F VFX部位" }
    uniform float _TintColorAlpha;
    //: param custom { "default": 1.0, "label": "忽略后处理曝光 IgnorePostExposure", "min": 0.0, "max": 1.0, "group": "F VFX部位" }
    uniform float _IgnorePostExposure;
    //: param custom { "default": "", "default_color": [1.0,1.0,1.0,1.0], "label": "Main Tex", "usage": "texture", "group": "F VFX部位" }
    uniform sampler2D _VFXMainTex;
    //: param custom { "default": [1.0, 1.0, 0.0, 0.0], "label": "MainTex_ST", "group": "F VFX部位" }
    uniform vec4 _VFXMainTex_ST;
    //: param custom { "default": 1.0, "label": "MainTex R作Alpha", "min": 0.0, "max": 1.0, "group": "F VFX部位" }
    uniform float _UseMainTexAsAlpha;
    //: param custom { "default": 1.0, "label": "MainTex 受扰动", "min": 0.0, "max": 1.0, "group": "F VFX部位" }
    uniform float _MainTexUseDisturb;
    //: param custom { "default": [0.0, 0.0, 0.0, 0.0], "label": "MainTexUVSpeed (XY:Time)", "group": "F VFX部位" }
    uniform vec4 _MainTexUVSpeed;
    //: param custom { "default": 0.0, "label": "MainTexUVRotate (度)", "min": -180.0, "max": 180.0, "group": "F VFX部位" }
    uniform float _MainTexUVRotate;
    //: param custom { "default": false, "label": "使用 Mask _USE_MASK", "group": "F VFX部位" }
    uniform bool u_VFXUseMask;
    //: param custom { "default": "", "default_color": [1.0,1.0,1.0,1.0], "label": "Mask Tex", "usage": "texture", "group": "F VFX部位" }
    uniform sampler2D _VFXMaskTex;
    //: param custom { "default": [1.0, 1.0, 0.0, 0.0], "label": "MaskTex_ST", "group": "F VFX部位" }
    uniform vec4 _VFXMaskTex_ST;
    //: param custom { "default": 1.0, "label": "MaskTex R作Alpha", "min": 0.0, "max": 1.0, "group": "F VFX部位" }
    uniform float _UseMaskTexAsAlpha;
    //: param custom { "default": 0.0, "label": "MaskTex 受扰动", "min": 0.0, "max": 1.0, "group": "F VFX部位" }
    uniform float _MaskTexUseDisturb;
    //: param custom { "default": [0.0, 0.0, 0.0, 0.0], "label": "MaskTexUVSpeed", "group": "F VFX部位" }
    uniform vec4 _MaskTexUVSpeed;
    //: param custom { "default": 0.0, "label": "MaskTexUVRotate (度)", "min": -180.0, "max": 180.0, "group": "F VFX部位" }
    uniform float _MaskTexUVRotate;
    //: param custom { "default": false, "label": "使用 Blend _USE_BLEND", "group": "F VFX部位" }
    uniform bool u_VFXUseBlend;
    //: param custom { "default": "", "default_color": [0.0,0.0,0.0,0.0], "label": "Blend Tex", "usage": "texture", "group": "F VFX部位" }
    uniform sampler2D _VFXBlendTex;
    //: param custom { "default": [1.0, 1.0, 0.0, 0.0], "label": "BlendTex_ST", "group": "F VFX部位" }
    uniform vec4 _VFXBlendTex_ST;
    //: param custom { "default": [1.0, 1.0, 1.0, 1.0], "label": "BlendTint (HDR)", "widget":"color", "group": "F VFX部位" }
    uniform vec4 _BlendTint;
    //: param custom { "default": 0.0, "label": "BlendTex 受扰动", "min": 0.0, "max": 1.0, "group": "F VFX部位" }
    uniform float _BlendTexUseDisturb;
    //: param custom { "default": [0.0, 0.0, 0.0, 0.0], "label": "BlendTexUVSpeed", "group": "F VFX部位" }
    uniform vec4 _BlendTexUVSpeed;
    //: param custom { "default": 0.0, "label": "BlendTexUVRotate (度)", "min": -180.0, "max": 180.0, "group": "F VFX部位" }
    uniform float _BlendTexUVRotate;
    //: param custom { "default": false, "label": "使用扰动 _USE_DISTURB", "group": "F VFX部位" }
    uniform bool u_VFXUseDisturb;
    //: param custom { "default": "", "default_color": [1.0,1.0,1.0,1.0], "label": "Disturb Tex 1", "usage": "texture", "group": "F VFX部位" }
    uniform sampler2D _VFXDisturbTex;
    //: param custom { "default": [1.0, 1.0, 0.0, 0.0], "label": "DisturbTex_ST", "group": "F VFX部位" }
    uniform vec4 _VFXDisturbTex_ST;
    //: param custom { "default": [0.0, 0.0, 0.0, 0.0], "label": "DisturbUVSpeed1", "group": "F VFX部位" }
    uniform vec4 _DisturbUVSpeed1;
    //: param custom { "default": 0.0, "label": "DisturbUVRotate1 (度)", "min": -180.0, "max": 180.0, "group": "F VFX部位" }
    uniform float _DisturbUVRotate1;
    //: param custom { "default": 0.0, "label": "双向扰动 Bi_Disturb", "min": 0.0, "max": 1.0, "group": "F VFX部位" }
    uniform float _Bi_Disturb;
    //: param custom { "default": 0.0, "label": "扰动图为法线 DisturbTex1Normal", "min": 0.0, "max": 1.0, "group": "F VFX部位" }
    uniform float _DisturbTex1Normal;
    //: param custom { "default": 0.0, "label": "扰动U强度 DisturbUIntensity1", "min": -2.0, "max": 2.0, "group": "F VFX部位" }
    uniform float _DisturbUIntensity1;
    //: param custom { "default": 0.0, "label": "扰动V强度 DisturbVIntensity1", "min": -2.0, "max": 2.0, "group": "F VFX部位" }
    uniform float _DisturbVIntensity1;
    //: param custom { "default": false, "label": "使用法线 _NORMAL_MAP", "group": "F VFX部位" }
    uniform bool u_VFXEnableNormalMap;
    //: param custom { "default": "", "default_color": [0.5,0.5,1.0,1.0], "label": "VFX Normal Map (DXT5nm布局)", "usage": "texture", "group": "F VFX部位" }
    uniform sampler2D _VFXNormalMap;
    //: param custom { "default": [1.0, 1.0, 0.0, 0.0], "label": "NormalMap_ST", "group": "F VFX部位" }
    uniform vec4 _VFXNormalMap_ST;
    //: param custom { "default": [0.0, 0.0, 0.0, 0.0], "label": "NormalMapUVSpeed", "group": "F VFX部位" }
    uniform vec4 _NormalMapUVSpeed;
    //: param custom { "default": 0.0, "label": "NormalMapUVRotate (度)", "min": -180.0, "max": 180.0, "group": "F VFX部位" }
    uniform float _NormalMapUVRotate;
    //: param custom { "default": 1.0, "label": "法线强度 NormalScale", "min": 0.0, "max": 3.0, "group": "F VFX部位" }
    uniform float _NormalScale;
    //: param custom { "default": 1.0, "label": "法线受扰动 NormalMapUseDisturb", "min": 0.0, "max": 1.0, "group": "F VFX部位" }
    uniform float _NormalMapUseDisturb;
    //: param custom { "default": false, "label": "使用菲涅尔 _USE_FRESNEL", "group": "F VFX部位" }
    uniform bool u_VFXUseFresnel;
    //: param custom { "default": [1.0, 1.0, 1.0, 1.0], "label": "FresnelColor (HDR)", "widget":"color", "group": "F VFX部位" }
    uniform vec4 _FresnelColor;
    //: param custom { "default": 0.0, "label": "FresnelBias", "min": -1.0, "max": 2.0, "group": "F VFX部位" }
    uniform float _FresnelBias;
    //: param custom { "default": 1.0, "label": "Fresnel影响不透明度", "min": 0.0, "max": 1.0, "group": "F VFX部位" }
    uniform float _FresnelAffectOpacity;
    //: param custom { "default": 1.0, "label": "FresnelPower", "min": 1.0, "max": 10.0, "group": "F VFX部位" }
    uniform float _FresnelPower;
    //: param custom { "default": 0.001, "label": "FresnelFlip", "min": 0.0, "max": 1.0, "group": "F VFX部位" }
    uniform float _FresnelFlip;
    //: param custom { "default": 0.0, "label": "近相机淡出 UseNearCameraFade", "min": 0.0, "max": 1.0, "group": "F VFX部位" }
    uniform float _UseNearCameraFade;
    //: param custom { "default": 0.001, "label": "Fade Start 1", "min": 0.001, "max": 3000.0, "group": "F VFX部位" }
    uniform float _NearCameraFadeDistanceStart;
    //: param custom { "default": 10.0, "label": "Fade End 1", "min": 0.001, "max": 3000.0, "group": "F VFX部位" }
    uniform float _NearCameraFadeDistanceEnd;
    //: param custom { "default": 100.0, "label": "Fade End 2", "min": 0.002, "max": 3000.0, "group": "F VFX部位" }
    uniform float _NearCameraFadeDistanceEnd2;
    //: param custom { "default": 120.0, "label": "Fade Start 2", "min": 0.001, "max": 3000.0, "group": "F VFX部位" }
    uniform float _NearCameraFadeDistanceStart2;
  //- endregion

  //- region OverlayShadow (Part 7)
    //: param custom { "default": 1.0, "label": "灰度作Alpha UseGrayAsAlpha", "min": 0.0, "max": 1.0, "group": "G OverlayShadow" }
    uniform float _UseGrayAsAlpha;
  //- endregion

  //- region 角色参数 CharacterParams
    //: param custom { "default": [0.0, 1.0, 0.7, 1.0],     "label": "CP0 (.y=diffuse .z=shadow .w=brightness)", "group": "H 角色参数" }
    uniform vec4 _CharacterParams0;
    //: param custom { "default": [0.0, 0.0, 0.0, 0.0],     "label": "CP1 (.x=brightMix .y=shadowStr .z=shadowLerp .w=lightDirOverride)", "group": "H 角色参数" }
    uniform vec4 _CharacterParams1;
    //: param custom { "default": [1.0, 1.0, 1.0, 0.0],     "label": "CP2 (ambient color, Standard/Hair/Fur/Eye)", "group": "H 角色参数" }
    uniform vec4 _CharacterParams2;
    //: param custom { "default": [1.0, 1.0, 1.0, 0.0],     "label": "CP3 (ambient color, Face)", "group": "H 角色参数" }
    uniform vec4 _CharacterParams3;
    //: param custom { "default": [1.0, 1.0, 1.0, 1.0],     "label": "CP4 (light color override, Face)", "group": "H 角色参数" }
    uniform vec4 _CharacterParams4;
    //: param custom { "default": [1.0, 1.0, 1.0, 1.0],     "label": "CP5 (light color override, Standard/Hair/Fur/Eye)", "group": "H 角色参数" }
    uniform vec4 _CharacterParams5;
    //: param custom { "default": [0.0, 1.0, 0.0, 0.0],     "label": "CP6 (ambient direction)", "group": "H 角色参数" }
    uniform vec4 _CharacterParams6;
    //: param custom { "default": [0.15, 0.6, 1.0, 0.0],    "label": "CP7 (.x=offset .y=scale .z=bias)", "group": "H 角色参数" }
    uniform vec4 _CharacterParams7;
    //: param custom { "default": [0.0, 0.0, 0.0, 1.0],     "label": "CP8 (skin spec rgb + .w=intensity)", "group": "H 角色参数" }
    uniform vec4 _CharacterParams8;
    //: param custom { "default": [0.0, 1.0, 0.0, 0.4],     "label": "CP9 (skin spec .xy=dir .z=tint .w=width)", "group": "H 角色参数" }
    uniform vec4 _CharacterParams9;
    //: param custom { "default": [0.0, 0.0, 0.0, 0.0],     "label": "CP10 (hair height darken)", "group": "H 角色参数" }
    uniform vec4 _CharacterParams10;
    //: param custom { "default": [-0.433, 0.5, 0.75, 0.0], "label": "CP11 (light dir override xyz + .w=rampBias)", "group": "H 角色参数" }
    uniform vec4 _CharacterParams11;
    //: param custom { "default": [0.0, 0.0, 0.0, 0.0],     "label": "CP12 (.x=rampOffset .y=lightColOverride .z=shadowGate .w=exposureBlend)", "group": "H 角色参数" }
    uniform vec4 _CharacterParams12;
    //: param custom { "default": [0.0, 0.0, 0.0, 1.0],     "label": "CP13 (.xyz=eye direct .w=GGX toggle)", "group": "H 角色参数" }
    uniform vec4 _CharacterParams13;
    //: param custom { "default": [0.0, 0.0, 0.0, 0.0],     "label": "CP14 (face 二级高光 rgb + .w=intensity)", "group": "H 角色参数" }
    uniform vec4 _CharacterParams14;
    //: param custom { "default": [0.0, 0.0, 0.0, 0.0],     "label": "CP15 (.z=SDF 二级阈值)", "group": "H 角色参数" }
    uniform vec4 _CharacterParams15;
    //: param custom { "default": [1.67, 1.5, 1.0, 0.0],    "label": "EnvGlobalParams0", "group": "H 角色参数" }
    uniform vec4 _EnvironmentGlobalParams0;
    //: param custom { "default": [1.0, 0.0, 0.0, 0.0],     "label": "ExposureParams (.x=曝光)", "group": "H 角色参数" }
    uniform vec4 _ExposureParams;
  //- endregion

  //- region VFX 颜色调整
    //: param custom { "default": 0.0, "label": "启用 VFX 颜色调整", "min": 0.0, "max": 1.0, "group": "I VFX颜色调整" }
    uniform float _EnableVFXColorAdjustment;
    //: param custom { "default": 1.0, "label": "亮度 Brightness", "min": 0.5, "max": 1.5, "group": "I VFX颜色调整" }
    uniform float _ColorAdjustmentBrightness;
    //: param custom { "default": 1.0, "label": "饱和度 Saturation", "min": 0.0, "max": 2.0, "group": "I VFX颜色调整" }
    uniform float _ColorAdjustmentSaturation;
    //: param custom { "default": 1.0, "label": "对比度 Contrast", "min": 0.0, "max": 2.0, "group": "I VFX颜色调整" }
    uniform float _ColorAdjustmentContrast;
    //: param custom { "default": [1.0, 1.0, 1.0, 0.0], "label": "颜色混合 ColorBlend", "widget":"color", "group": "I VFX颜色调整" }
    uniform vec4 _ColorAdjustmentColorBlend;
    //: param custom { "default": 0.35, "label": "边缘光宽度 RimWidth", "min": 0.0, "max": 1.0, "group": "I VFX颜色调整" }
    uniform float _ColorAdjustmentRimWidth;
    //: param custom { "default": 4.0, "label": "边缘光强度 RimIntensity", "min": 0.0, "max": 10.0, "group": "I VFX颜色调整" }
    uniform float _ColorAdjustmentRimIntensity;
    //: param custom { "default": [1.0, 1.0, 1.0, 1.0], "label": "边缘光颜色 RimColor", "widget":"color", "group": "I VFX颜色调整" }
    uniform vec4 _ColorAdjustmentRimColor;
  //- endregion
//- }

//----------------------------------------------------------------------region SP 函数库导入
//- {
  import lib-pbr.glsl
  import lib-bent-normal.glsl
  import lib-emissive.glsl
  import lib-pom.glsl
  import lib-sss.glsl
  import lib-utils.glsl
  import lib-sparse.glsl
//- }

//----------------------------------------------------------------------region 渲染状态
//- {
  //: state cull_face off
  //: state blend over
//- }

//----------------------------------------------------------------------region 引擎通道纹理
//- {
  //: param auto channel_basecolor
  uniform SamplerSparse basecolor_tex;
  //: param auto channel_roughness
  uniform SamplerSparse roughness_tex;
  //: param auto channel_metallic
  uniform SamplerSparse metallic_tex;
  //: param auto channel_specularlevel
  uniform SamplerSparse specularlevel_tex;
  //: param auto channel_opacity
  uniform SamplerSparse opacity_tex;
  // emissive_tex 由 lib-emissive.glsl 提供

  //- user1 = Standard: ClearCoat Mask (.r, 可绘制)。
  //- 注: SP 通道无 Alpha — Face SDF Mask(.w)/Hair SplitNormal(.ba)/Fur Direction 改走
  //-     sampler2D 参数 (_SDFMask/_SplitNormalMap/_FurDirMap), 保证 RGBA 完整 (BuildSPInputs 原样导出)。
  //: param auto channel_user1
  uniform SamplerSparse slot_user1_tex;
//- }

//----------------------------------------------------------------------region 引擎 auto 属性
//- {
  //: param auto main_light
  uniform vec4 light_main;
  //: param auto facing
  uniform int uniform_facing;
  //: param auto camera_view_matrix
  uniform mat4 uniform_camera_view_matrix;
  //: param auto environment_max_lod
  uniform float environment_max_lod;
//- }

//----------------------------------------------------------------------region 类型宏 + HLSL→GLSL 兼容层
//- {
  #define float2 vec2
  #define float3 vec3
  #define float4 vec4
  #define half  float
  #define half2 vec2
  #define half3 vec3
  #define half4 vec4

  // HLSL 内置函数补齐
  float rsqrt(float x) { return 1.0 / sqrt(x); }
  #define frac fract
  #define ddx dFdx
  #define ddy dFdy

  half  saturate(half v)  { return max(0.0, min(1.0, v)); }
  half2 saturate(half2 v) { return max(half2(0.0), min(half2(1.0), v)); }
  half3 saturate(half3 v) { return max(half3(0.0), min(half3(1.0), v)); }
  half4 saturate(half4 v) { return max(half4(0.0), min(half4(1.0), v)); }

  half  lerp(half a, half b, half t)    { return (1.0 - t) * a + t * b; }
  half2 lerp(half2 a, half2 b, half t)  { return (1.0 - t) * a + t * b; }
  half3 lerp(half3 a, half3 b, half t)  { return (1.0 - t) * a + t * b; }
  half4 lerp(half4 a, half4 b, half t)  { return (1.0 - t) * a + t * b; }
  half3 lerp(half3 a, half3 b, half3 t) {
      return half3((1.0 - t.x) * a.x + t.x * b.x,
                   (1.0 - t.y) * a.y + t.y * b.y,
                   (1.0 - t.z) * a.z + t.z * b.z);
  }

  float  mad(float a, float b, float c)   { return a * b + c; }
  float2 mad(float2 a, float2 b, float2 c){ return a * b + c; }
  float3 mad(float3 a, float3 b, float3 c){ return a * b + c; }

  // Unity 纹理采样宏 → GLSL (sampler_* 参数被吞掉; cube → SP 环境)
  #define _DiffRampMap _RampMap
  #define SAMPLE_TEXTURE2D(tex, samp, uv)              texture(tex, uv)
  #define SAMPLE_TEXTURE2D_LOD(tex, samp, uv, lod)     textureLod(tex, uv, float(lod))
  #define SAMPLE_TEXTURECUBE_LOD(tex, samp, dir, lod)  envSampleLOD(dir, float(lod))
//- }

//----------------------------------------------------------------------region 共享常量 + 共享函数
//- {
  const float3 LUM = float3(0.2126729, 0.7152, 0.07217500);
  const float NEAR_ZERO_Y = 6.103515625e-05; // asfloat(947912704u)

  float LinearToSRGB_Custom(float c) {
      return (c <= 0.0031308) ? (c * 12.92)
          : (1.055 * pow(abs(c), 0.41666666) - 0.055);
  }

  // ---- Unity 硬件 sRGB 采样解码补偿 ----
  // 这些贴图资产在 Unity 端 .meta sRGBTexture=1 (实测全角色普查):
  //   _ShadowLutTex _EmotionMap _MatcapTex _ParallaxTex _FurDirMap _FurDyeMap
  //   _VFXMainTex _VFXMaskTex _VFXBlendTex _VFXDisturbTex _VFXSpecialMainTex _VFXSpecialBlendTex
  // Unity 采样器自动 sRGB→Linear; SP 自定义贴图参数为裸采样, 必须手动补同款解码
  // (alpha 通道不解码, 与硬件行为一致)。注: 解码在双线性过滤之后, 与硬件
  // "先解码后过滤"在 texel 间插值处有极小偏差, LUT 取 texel 中心时无差。
  float SRGBToLinear_Custom(float c) {
      return (c <= 0.04045) ? (c / 12.92)
          : pow(abs((c + 0.055) / 1.055), 2.4);
  }
  float3 SRGBToLinear3(float3 c) {
      return float3(SRGBToLinear_Custom(c.r), SRGBToLinear_Custom(c.g), SRGBToLinear_Custom(c.b));
  }
  float4 SampleSRGBTex(sampler2D tex, float2 uv) {
      float4 s = texture(tex, uv);
      return float4(SRGBToLinear3(s.rgb), s.a);
  }

  // ---- 主光方向旋转 (NPR_Uber.glsl 同款 YXZ 欧拉) ----
  mat3 efRotateX(float r) { float c = cos(r), s = sin(r); return mat3(1,0,0, 0,c,s, 0,-s,c); }
  mat3 efRotateY(float r) { float c = cos(r), s = sin(r); return mat3(c,0,-s, 0,1,0, s,0,c); }
  mat3 efRotateZ(float r) { float c = cos(r), s = sin(r); return mat3(c,s,0, -s,c,0, 0,0,1); }
  float3 GetMainLightDir() {
      mat3 rot = efRotateY(radians(float(i_LightRotY))) * efRotateX(radians(float(i_LightRotX))) * efRotateZ(radians(float(i_LightRotZ)));
      return normalize(rot * light_main.xyz);
  }

  // ---- 共享视角/相机量 ----
  //  V       : Unity 的 ortho-aware viewDir; SP 视口透视 → unity_OrthoParams.w=0 路径
  //  camFwd  : UNITY_MATRIX_I_V 第三列 (相机背向, Endfield 约定, 与 Unity 端同号)
  float3 GetCamFwd() {
      return normalize((inverse(uniform_camera_view_matrix) * float4(0.0, 0.0, 1.0, 0.0)).xyz);
  }

  // ---- Unity uv (含 _BaseMap_ST) ----
  float2 GetBaseUV(V2F inputs) {
      return inputs.sparse_coord.tex_coord * _BaseMap_ST.xy + _BaseMap_ST.zw;
  }

  // ---- Shadow LUT 采样 (Skin/Cloth/Hair/Eye 共享公式, 逐行同源) ----
  float3 SampleShadowLutColor(float3 albedo) {
      float sR = saturate(LinearToSRGB_Custom(albedo.r));
      float sG = saturate(LinearToSRGB_Custom(albedo.g));
      float sB = saturate(LinearToSRGB_Custom(albedo.b));
      float bSlice = floor(sB * 31.0);
      float lutU = bSlice * 0.03125 + sR * 0.0302734375 + 0.00048828125;
      float lutV = sG * 0.96875 + 0.015625;
      // LUT 资产 sRGBTexture=1 → 补硬件解码 (这是"开 Shadow LUT 全身泛白"的根因)
      float3 lut0 = SRGBToLinear3(textureLod(_ShadowLutTex, float2(lutU, lutV), 0.0).rgb);
      float3 lut1 = SRGBToLinear3(textureLod(_ShadowLutTex, float2(lutU + 0.03125, lutV), 0.0).rgb);
      float bFrac = sB * 31.0 - bSlice;
      return lerp(lut0, lut1, bFrac);
  }

  // 亮度/饱和度阴影色 (LUT 关闭分支, Cloth/Hair/Fur/Eye 用; Face 的 #else 是纯白, 不走这里)
  float3 ComputeShadowColorBrightSat(float3 albedo) {
      float3 shadBright = albedo * _ShadowColorBrightness;
      float shadLum = dot(shadBright, LUM);
      return _ShadowColorSaturation * (shadBright - shadLum) + shadLum;
  }

  // Environment BRDF rational approximation (HGRP Cloth/Fur 同一份, decompiled 2320-2328)
  void ComputeEnvBRDF(float NdotV, float roughSq, out float dfgX, out float dfgY) {
      float NdotV2 = NdotV * NdotV;
      float NdotV3 = NdotV * NdotV2;
      float roughSq6 = roughSq * roughSq * roughSq;

      float2 numX = float2(
          dot(float2(3.32707, 1.0), float2(NdotV, 0.0365463)),
          dot(float2(-9.04756, 1.0), float2(NdotV, 9.0632))
      );
      float3 denX = float3(
          dot(float3(3.59685, -1.36772, 1.0), float3(NdotV2, NdotV3, 1.0)),
          dot(float3(-16.3174, 1.0, 9.22949), float3(NdotV2, 9.04401, NdotV3)),
          dot(float3(1.0, 19.7886, -20.2123), float3(5.56589, NdotV2, NdotV3))
      );
      dfgX = dot(numX, float2(1.0, roughSq)) / dot(denX, float3(1.0, roughSq, roughSq6));

      float2 numY = float2(
          dot(float2(-1.28514, 1.0), float2(NdotV, 0.99044)),
          dot(float2(1.0, -0.755907), float2(1.29678, NdotV))
      );
      float3 denY = float3(
          dot(float3(2.92338, 59.4188, 1.0), float3(NdotV, NdotV3, 1.0)),
          dot(float3(1.0, -27.0302, 222.592), float3(20.3225, NdotV, NdotV3)),
          dot(float3(626.13, 316.627, 1.0), float3(NdotV, NdotV3, 121.563))
      );
      dfgY = dot(numY, float2(1.0, roughSq)) / dot(denY, float3(1.0, roughSq, roughSq6));
  }

  // ---- RMOS 读取 ([H1]: Unity _MetallicGlossMap RGBA=Metal/Spec/Shadow/Smooth → SP 通道) ----
  void SampleRMOS(V2F inputs, out float metallic, out float specScale, out float shadowMask, out float smoothness) {
      if (u_UseMetallicGlossMap) {
          metallic   = getMetallic(metallic_tex, inputs.sparse_coord);            // .r
          specScale  = getSpecularLevel(specularlevel_tex, inputs.sparse_coord);  // .g
          shadowMask = getAO(inputs.sparse_coord, true, use_bent_normal);         // .b → AO 通道 [H1]
          smoothness = 1.0 - getRoughness(roughness_tex, inputs.sparse_coord);    // .a = 1 - roughness
      } else {
          metallic   = _Metallic;
          specScale  = _Specular;
          shadowMask = 1.0;
          smoothness = _Smoothness;
      }
  }

  // ---- 法线 ([H8]: SP 法线通道 TS 法线 + Unity 的 TBN 组装公式, 逐行同源) ----
  float3 SampleBumpNormal(V2F inputs, float3 normalWS_raw, float4 tangentWS, float faceSign, float bumpScale) {
      if (u_UseBumpMap) {
          float3 tsN = getTSNormal(inputs.sparse_coord); // [-1,1]
          float nrmX = tsN.x * bumpScale;
          float nrmY = tsN.y * bumpScale;
          float nrmZ = max(sqrt(1.0 - saturate(nrmX*nrmX + nrmY*nrmY)), 1e-16);
          float3 nrmWS = normalize(normalWS_raw);
          float3 tanWS = normalize(tangentWS.xyz);
          float3 bitWS = cross(nrmWS, tanWS) * tangentWS.w;
          return faceSign * normalize(nrmX * tanWS + nrmY * bitWS + nrmZ * nrmWS);
      }
      return faceSign * normalize(normalWS_raw);
  }
//- }

//----------------------------------------------------------------------region Part 0 Standard — HGRP_CharacterNPR_Fix.shader computeNPRLighting 逐行移植
//- {
  // 与旧版 EndField_Uber 相同的逐行移植, 差异: ShadowLUT/SpecRamp/ClearCoat/Pantyhose/Parallax
  // 由 #ifdef 改为运行时 bool (数学逐位一致); 变量按 GLSL 作用域规则做了无副作用的提升声明。
  float3 shadeStandard(V2F inputs, float3 positionWS, float3 normalWS_raw, float4 tangentWS, float faceSign, float3 albedo, float baseAlpha, out float3 shadowColorOut) {
      float2 uv = GetBaseUV(inputs);
      // ---- Object-to-World origin ([H4]) ----
      float originX = 0.0;
      float originZ = 0.0;

      // ---- View direction ----
      float3 toCam = camera_pos - positionWS;
      float3 V = normalize(toCam);

      // ---- MetallicGlossMap ([H1]) ----
      float metallic, specScale, shadowMask, smoothness;
      SampleRMOS(inputs, metallic, specScale, shadowMask, smoothness);
      float roughnessRaw = 1.0 - smoothness;

      // ---- Shadow color ----
      float3 shadowColor;
      if (u_UseShadowLut) {
          shadowColor = SampleShadowLutColor(albedo);
      } else {
          shadowColor = ComputeShadowColorBrightSat(albedo);
      }

      // ---- Normal map ----
      float3 N = SampleBumpNormal(inputs, normalWS_raw, tangentWS, faceSign, _BumpScale);

      // ---- ClearCoat setup (mask = user1.r; 通道未填充时回退 HGRP 默认 "white"=1) ----
      float ccMask = 0.0;
      float3 ccN = N;
      float ccPercRough = 1.0;
      float ccAlpha = 0.0078125;
      float3 ccF0 = float3(0.0);
      bool ccActive = false;
      if (u_ClearCoat) {
          ccMask = slot_user1_tex.is_set ? textureSparse(slot_user1_tex, inputs.sparse_coord).r : 1.0;
          ccN = lerp(faceSign * normalize(normalWS_raw), N, _ClearCoatNormalMode);
          ccPercRough = 1.0 - _ClearCoatSmoothness;
          ccAlpha = max(ccPercRough * ccPercRough, 0.0078125);
          float ccF0scalar = mad(_ClearCoatMetallic, 0.96, 0.04);
          ccF0 = ccF0scalar * _ClearCoatColor.rgb;
          ccActive = ccMask > 0.001;
      }

      // ---- Pantyhose Fresnel color blend ----
      float ph_alphaProduct = 0.0;
      float ph_mask = 0.0;
      if (u_Pantyhose) {
          ph_alphaProduct = baseAlpha * _BaseColor.a;
          ph_mask = (ph_alphaProduct < 0.99) ? 1.0 : 0.0;
          float ph_NdotV = saturate(dot(V, N));
          float ph_exp = ph_alphaProduct + 1.0 - _PantyhoseColor.a;
          float ph_blend = ph_mask * min(exp2(log2(1.05 - ph_NdotV) * (ph_exp * 2.0)), 0.9);
          albedo = lerp(albedo, _PantyhoseColor.rgb, ph_blend);
          shadowColor = lerp(shadowColor, _PantyhoseColor.rgb, ph_blend);
      }
      shadowColorOut = shadowColor;

      // ---- Emission map ----
      float3 emissionTex = float3(0.0);
      if (u_UseEmission) {
          emissionTex = pbrComputeEmissive(emissive_tex, inputs.sparse_coord);
      }

      // ---- Steep Parallax Mapping (SampleGrad → textureGrad, 数学不变) ----
      float parallaxSample = 0.0;
      if (u_UseParallax) {
          float3 pxNrm = normalize(normalWS_raw);
          float3 pxTan = normalize(tangentWS.xyz);
          float3 pxBit = cross(pxNrm, pxTan) * tangentWS.w;
          float3 tbnV = float3(dot(pxTan, V), dot(pxBit, V), dot(pxNrm, V));
          float tbnInvLen = rsqrt(max(dot(tbnV, tbnV), 1.175e-38));
          float2 pxUV = uv * _ParallaxTex_ST.xy + _ParallaxTex_ST.zw;
          float2 pxDxUV = ddx(pxUV);
          float2 pxDyUV = ddy(pxUV);
          float pxSteps = min(20.0, _ParallaxMarchNum);
          float pxStepSz = 1.0 / pxSteps;
          float pxViewZ = max(tbnInvLen * tbnV.z, 0.001);
          float2 pxUVStep = (tbnInvLen * tbnV.xy / pxViewZ) * (-_ParallaxScale);
          float2 pxUVDelta = pxStepSz * pxUVStep;
          float2 pxAccum = pxUVDelta;
          float2 pxPrevOff = float2(0.0);
          float pxPrevH = 0.0;
          float pxLayerH = 1.0 - pxStepSz;
          float pxPrevLayerH = 1.0;
          float pxHitH = 0.0;
          bool pxHit = false;
          for (float pxi = 0.0; pxi < pxSteps + 1.0; pxi += 1.0) {
              float pxTexH = SRGBToLinear_Custom(textureGrad(_ParallaxTex, pxUV + pxAccum, pxDxUV, pxDyUV).r); // sRGBTexture=1
              if (pxLayerH < pxTexH) { pxHitH = pxTexH; pxHit = true; break; }
              pxPrevOff = pxAccum;
              pxAccum += pxUVDelta;
              pxPrevH = pxTexH;
              pxPrevLayerH = pxLayerH;
              pxLayerH -= pxStepSz;
          }
          if (!pxHit) pxHitH = pxPrevH;
          float pxT = (pxPrevH - pxPrevLayerH)
                    / (-pxPrevLayerH + pxLayerH + pxPrevH - pxHitH);
          float2 pxFinalUV = pxUV + pxUVDelta * pxT + pxPrevOff;
          parallaxSample = SRGBToLinear_Custom(texture(_ParallaxTex, pxFinalUV).r); // sRGBTexture=1
      }

      // ---- Flat direction ----
      float fX = positionWS.x - originX;
      float fZ = positionWS.z - originZ;
      float fLen = rsqrt(fX*fX + NEAR_ZERO_Y*NEAR_ZERO_Y + fZ*fZ);
      float3 flatDir = float3(fX*fLen, NEAR_ZERO_Y*fLen, fZ*fLen);

      // ---- Exposure ----
      float exposure = (_CharacterParams12.w * (1.0 - _EnvironmentGlobalParams0.x) + _EnvironmentGlobalParams0.x) * _ExposureParams.x;

      // ---- Ambient ----
      float ambInt = exposure;
      float3 ambCol = _CharacterParams2.xyz;

      // ---- Camera forward ----
      float3 camFwd = GetCamFwd();

      // ---- Metallic workflow ----
      float dielSpec = specScale * 0.04;
      float oneMinusRefl = (1.0 - metallic) * 0.96;
      float3 diffColor = oneMinusRefl * albedo;
      float3 specColor = metallic * (albedo - dielSpec) + dielSpec;
      float3 shadowDiff = oneMinusRefl * shadowColor;

      float roughness = max(roughnessRaw * roughnessRaw, 0.0078125);

      // ---- Main light ([H2][H3]) ----
      float mainLightShadowAtten = 1.0;
      float3 mainLightDir = GetMainLightDir();
      float3 lightCol = v_MainLightColor.rgb;
      float lightInt = 1.0;

      // ---- Adjusted light direction ----
      float3 adjustedLightDir = lerp(mainLightDir, _CharacterParams11.xyz, _CharacterParams1.w);
      float adjXZLen = rsqrt(adjustedLightDir.x*adjustedLightDir.x + adjustedLightDir.z*adjustedLightDir.z + NEAR_ZERO_Y*NEAR_ZERO_Y);
      float adjXZ_x = adjXZLen * adjustedLightDir.x;
      float adjXZ_z = adjXZLen * adjustedLightDir.z;

      // ---- Light color blend (CP5) ----
      float3 blendedLightCol = lerp(lightCol, _CharacterParams5.xyz, _CharacterParams12.y);
      float blendedLightInt = lerp(lightInt, 1.0, _CharacterParams12.w);

      // ---- Camera-light facing ----
      float cfXZLen = rsqrt(camFwd.x * camFwd.x + camFwd.z * camFwd.z);
      float camLightDot = saturate(-(adjXZ_x * (cfXZLen * camFwd.x) + adjXZ_z * (cfXZLen * camFwd.z)));
      float camYFade = saturate(2.0 * (0.75 - abs(camFwd.y)));
      float camYSmooth = camYFade * camYFade * (3.0 - 2.0 * camYFade);

      // ==== DIFFUSE RAMP ====
      float geomNdotL = dot(N, adjustedLightDir);
      float wrapAdd = 0.5 - 0.5 * geomNdotL * geomNdotL;
      float camFadeFactor = (1.0 - _CharacterParams12.x) * (camLightDot * camYSmooth);
      float modNdotL = camFadeFactor * wrapAdd + geomNdotL;
      float3 rampCol; float rampA; float rampChroma; float rampChromaInv; float viewRampA;
      if (u_UseDiffRamp) {
          float rampInput = clamp(_CharacterParams11.w * _CharacterParams12.x + modNdotL, -1.0, 1.0) * 0.5 + 0.5;
          float4 rampSmp = textureLod(_RampMap, float2(rampInput, 0.5), 0.0);
          rampCol = rampSmp.rgb;
          rampA = rampSmp.a;
          rampChroma = max(rampCol.r, max(rampCol.g, rampCol.b)) - min(rampCol.r, min(rampCol.g, rampCol.b));
          rampChromaInv = 1.0 - rampChroma;
          float viewRampU = dot(N, camFwd) * 0.5 + 0.5;
          float4 viewRampSmp = textureLod(_RampMap, float2(viewRampU, 0.5), 0.0);
          viewRampA = viewRampSmp.a;
      } else {
          rampCol = float3(1.0);
          rampA = saturate(modNdotL * 0.5 + 0.5);
          rampChroma = 0.0;
          rampChromaInv = 1.0;
          viewRampA = 0.0;
      }

      // ---- Shadow terms ----
      float castShadow = lerp(smoothstep(0.0, 1.0, mainLightShadowAtten), 1.0, _CharacterParams1.z);
      float minShadow = min(rampA, shadowMask) * castShadow;
      float viewShadowProduct = viewRampA * shadowMask;

      // ==== NPR DIFFUSE COMPOSITION ====
      float3 albScaled = shadowDiff * _CharacterParams0.z;
      float diffColorLum = dot(diffColor, LUM);

      float nprNdotL = saturate(dot(N, _CharacterParams6.xyz) + _CharacterParams7.x) * _CharacterParams7.y + _CharacterParams7.z;
      float shadowStr = minShadow * _CharacterParams1.y;

      float3 shadAmb = nprNdotL * (shadowStr * (1.0 - ambCol) + ambCol);

      float bright065 = min(ambInt * 0.35 + 0.65, 1.5);
      float brightFull = clamp(ambInt, 0.0, 1.5);
      float brightMix = lerp(bright065, clamp(ambInt, 1.25, 1.75), _CharacterParams1.x);
      float3 brightAmb = brightMix * shadAmb * _CharacterParams0.w;

      float lightLum = dot(blendedLightCol * blendedLightInt, LUM);

      float oneMinus12y = 1.0 - _CharacterParams12.y;
      float3 lightBlend = blendedLightCol * _CharacterParams12.y + oneMinus12y;
      float3 fullDiff;
      fullDiff.r = (shadAmb.r * brightFull * lightBlend.r + minShadow * (blendedLightCol.r * blendedLightInt - lightLum) + lightLum) * _CharacterParams0.y;
      fullDiff.g = (shadAmb.g * brightFull * lightBlend.g + minShadow * (blendedLightCol.g * blendedLightInt - lightLum) + lightLum) * _CharacterParams0.y;
      fullDiff.b = (shadAmb.b * brightFull * lightBlend.b + minShadow * (blendedLightCol.b * blendedLightInt - lightLum) + lightLum) * _CharacterParams0.y;

      float albScaledLum = dot(albScaled * 0.65, LUM);
      float3 desatShad = (albScaled * 0.65 - albScaledLum) * 1.2 + albScaledLum;

      float combWeight = saturate(viewShadowProduct + rampA);
      float3 weightedAmb = lerp(desatShad, albScaled, combWeight);
      float3 shadowBlended = lerp(weightedAmb, diffColor, minShadow);

      float3 viewDepShad = viewShadowProduct * ((diffColor - diffColorLum) * 1.2 + diffColorLum - albScaled) + albScaled;

      float3 rampTinted = shadowBlended * (rampCol * rampChroma + rampChromaInv);

      float shadowLumVal = dot(shadowBlended, LUM);
      float rampLum = dot(rampTinted, LUM);
      float lumRatio = clamp(shadowLumVal / max(rampLum, 0.001), 0.0, 1.5);

      float3 nprDiff = rampTinted * lumRatio;

      float ambDiffInt = minShadow * (1.0 - _CharacterParams0.z) + _CharacterParams0.z;
      float specAmbInt = ambDiffInt * (minShadow * 0.5 + 0.5);

      // ==== ALPHA PREMULTIPLY ====
      float alphaPremul = baseAlpha * _AlphaPremultiply + (1.0 - _AlphaPremultiply);

      // ==== GGX SPECULAR ====
      float NdotV_spec = saturate(dot(N, V));
      float mainLightY = adjustedLightDir.y;
      float3 camFwdMod = normalize(float3(camFwd.x, mainLightY, camFwd.z));
      float3 H = normalize(V * 3.0 + adjustedLightDir + camFwdMod * 2.0);
      float NdotH = dot(N, H);
      float roughSq = roughness * roughness;
      float denom = (NdotH * roughSq - NdotH) * NdotH + 1.0;
      float denomSq = denom * denom;
      float D_raw = (denomSq != roughSq) ? roughSq / denomSq : 1.0;

      float D_combined = D_raw;
      if (u_Pantyhose) {
          float3 ph_rawTan = tangentWS.xyz;
          float3 ph_T = normalize(ph_rawTan - N * dot(ph_rawTan, N));
          float3 ph_B = cross(N, ph_T) * tangentWS.w;
          float3 ph_H = normalize(H + V * _PantyhoseSpecularValue);
          float ph_aniso = saturate(ph_alphaProduct * 0.5) * (0.5 - _PantyhoseAnisotropyDirection) + _PantyhoseAnisotropyDirection;
          float ph_rT = roughness * (ph_aniso + 1.0);
          float ph_rB = (1.0 - ph_aniso) * roughness;
          float ph_rTB = ph_rT * ph_rB;
          float ph_tH = ph_rB * dot(ph_T, ph_H);
          float ph_bH = dot(ph_B, ph_H) * ph_rT;
          float ph_nH = dot(N, ph_H) * ph_rTB;
          float ph_d = ph_tH * ph_tH + ph_bH * ph_bH + ph_nH * ph_nH;
          float ph_rTB3 = ph_rTB * ph_rTB * ph_rTB;
          float ph_d2 = ph_d * ph_d;
          float ph_ndf = (ph_d2 != ph_rTB3) ? (ph_rTB3 / ph_d2) : 1.0;
          D_combined = D_raw + ph_ndf * _PantyhoseSpecularInt * ph_mask;
      }
      float ggxTerm = clamp(D_combined * 0.5 / (NdotV_spec * 2.0 + roughness + 1e-4) - NEAR_ZERO_Y, 0.0, 20.0);

      // ---- Spec Ramp ----
      float3 specRampColor = specColor;
      float3 specRampEnv = specColor;
      if (u_UseSpecRamp) {
          float specRampPartial = D_raw * (roughSq + 1e-4);
          float specRampU = lerp(specRampPartial, NdotV_spec * NdotV_spec, _SpecRampIridescentMode);
          float specRampV = (1.0 - metallic) * roughnessRaw;
          float3 specRampSmp = textureLod(_SpecRampMap, float2(specRampU, specRampV), 0.0).rgb;
          specRampColor = specColor * specRampSmp;
          specRampEnv = lerp(specColor, specRampColor, _SpecRampIridescentMode);
      }

      // ---- ClearCoat Specular (directional) ----
      float3 ccSpecDir = float3(0.0);
      float3 ccBaseScale = float3(1.0);
      float3 ccDiffScale = float3(1.0);
      if (u_ClearCoat && ccActive) {
          float ccNdotH = dot(ccN, H);
          float ccNdotV = saturate(dot(ccN, V));
          float VdotH = saturate(dot(V, H));
          float oneMinusVdotH = 1.0 - VdotH;
          float pow2 = oneMinusVdotH * oneMinusVdotH;
          float pow5 = pow2 * pow2 * oneMinusVdotH;
          float complement = 1.0 - pow5;
          float3 ccFresnel = ccF0 * complement + pow5;
          float3 ccMaskedF = ccMask * ccFresnel;
          ccBaseScale = 1.0 - ccMaskedF;
          ccDiffScale = 1.0 - ccMask * ccMaskedF;
          float ccAlphaSq = ccAlpha * ccAlpha;
          float ccDenom = (ccNdotH * ccAlphaSq - ccNdotH) * ccNdotH + 1.0;
          float ccDenomSq = ccDenom * ccDenom;
          float ccD = (ccDenomSq != ccAlphaSq) ? ccAlphaSq / ccDenomSq : 1.0;
          float ccV = 0.5 / (mad(ccNdotV, 2.0, ccAlpha) + 0.0001);
          ccSpecDir = clamp(ccV * ccD * ccMaskedF, 0.0, 20.0);
      }

      // Main lit composition
      float3 mainLit;
      if (u_ClearCoat) {
          mainLit = fullDiff * nprDiff * alphaPremul * ccDiffScale
                  + (specAmbInt * fullDiff) * (ggxTerm * specRampColor * ccBaseScale * ccBaseScale + ccSpecDir) * _CharacterParams13.w;
      } else {
          mainLit = fullDiff * nprDiff * alphaPremul + (specAmbInt * fullDiff) * (ggxTerm * specRampColor) * _CharacterParams13.w;
      }
      float mainLitLum = dot(mainLit, LUM);
      float desatAmt = clamp(mainLitLum - 0.5, 0.0, 0.5);

      // ==== SKIN SPECULAR CP8/CP9 ====
      float cp9x = _CharacterParams9.x;
      float cp9y = _CharacterParams9.y;
      float3 skinDir;
      skinDir.x = -cp9y * camFwd.z;
      skinDir.y = camFwd.z * cp9x;
      skinDir.z = camFwd.x * cp9y - cp9x * camFwd.y;
      skinDir = normalize(skinDir);

      float skinFresnel = 1.0 - abs(dot(V, N));
      float skinLow = _CharacterParams9.w * (-0.6) + 0.8;
      float skinHigh = _CharacterParams9.w * (-0.4) + 0.9;
      float skinT = saturate((skinFresnel - skinLow) / (skinHigh - skinLow));
      float skinSmooth = skinT * skinT * (3.0 - 2.0 * skinT);
      float skinNdotL = saturate(dot(flatDir, skinDir) + 1.0);
      float skinShadow = min(shadowMask, skinNdotL);
      float skinNdotBN = saturate(dot(skinDir, N));

      float3 skinSpec;
      skinSpec.r = skinShadow * skinSmooth * _CharacterParams8.x * _CharacterParams8.w * skinNdotBN * (_CharacterParams9.z * (diffColor.r - 0.25) + 0.25);
      skinSpec.g = skinShadow * skinSmooth * _CharacterParams8.y * _CharacterParams8.w * skinNdotBN * (_CharacterParams9.z * (diffColor.g - 0.25) + 0.25);
      skinSpec.b = skinShadow * skinSmooth * _CharacterParams8.z * _CharacterParams8.w * skinNdotBN * (_CharacterParams9.z * (diffColor.b - 0.25) + 0.25);

      // ==== SUBSURFACE SPECULAR ====
      float mainNdotL_xz = dot(float3(adjXZ_x, adjXZLen * NEAR_ZERO_Y, adjXZ_z), N);
      float wrapNdotL = saturate(0.5 + mainNdotL_xz - 0.5 * mainNdotL_xz * mainNdotL_xz);
      float camLightFacing = (1.0 - _CharacterParams12.x) * camLightDot;
      float edgeT = saturate((-abs(dot(V, N)) + 0.4) * 5.0);
      float edgeFresnel = edgeT * edgeT * (3.0 - 2.0 * edgeT);
      float brightT = saturate((0.1 - diffColorLum) * 16.666);
      float brightnessGate = (brightT * brightT) * (3.0 - 2.0 * brightT);
      float3 subsurfLight = blendedLightCol * blendedLightInt;
      float3 subsurfSpec = brightnessGate * shadowMask * edgeFresnel * camLightFacing * wrapNdotL * subsurfLight * max(diffColor, 0.15);

      // ==== CUBEMAP REFLECTION ([H6]) ====
      float3 reflDir = reflect(-V, N);
      float cubeMip = log2(max(roughnessRaw, 0.001)) * 1.2 + 5.0;
      float3 cubeSample = envSampleLOD(reflDir, cubeMip).rgb;

      float dfgX, dfgY;
      ComputeEnvBRDF(NdotV_spec, roughness, dfgX, dfgY);
      float3 envBRDF = specRampEnv * dfgX + dfgY;
      float totalRefl = dfgX + dfgY;
      float reflBoost = (1.0 - totalRefl) / max(totalRefl, 1e-6);

      float cubeAmbInt = ambDiffInt * (clamp(exposure, 0.5, 1.5) * _CharacterParams0.w);
      float3 cubeRefl = cubeSample * envBRDF * (1.0 + reflBoost * specRampEnv);
      float3 cubemapContrib = cubeAmbInt * cubeRefl * ambCol * _CubemapIntensity;

      // ---- ClearCoat IBL ----
      if (u_ClearCoat && ccActive) {
          float3 ccReflDir = reflect(-V, ccN);
          float ccCubeMip = log2(max(ccPercRough, 0.001)) * 1.2 + 5.0;
          float3 ccCubeSmp = envSampleLOD(ccReflDir, ccCubeMip).rgb;
          float ccNdotV_ibl = saturate(dot(ccN, V));
          float ccDfgX, ccDfgY;
          ComputeEnvBRDF(ccNdotV_ibl, ccAlpha, ccDfgX, ccDfgY);
          float3 ccEnvBRDF = ccF0 * ccDfgX + ccDfgY;
          float ccTotalRefl = ccDfgX + ccDfgY;
          float ccReflBoost = (1.0 - ccTotalRefl) / max(ccTotalRefl, 1e-6);
          float3 ccCubeRefl = ccCubeSmp * ccEnvBRDF * (1.0 + ccReflBoost * ccF0);
          cubemapContrib += ccMask * ccCubeRefl * _CubemapIntensity;
      }

      // ==== EMISSION ====
      float3 emissionContrib = float3(0.0);
      if (u_UseEmission) {
          emissionContrib = emissionTex * _EmissionColor.rgb * _EmissionBrightness * alphaPremul;
      }
      if (u_UseParallax) {
          emissionContrib += baseAlpha * parallaxSample * _ParallaxColor.rgb * alphaPremul;
      }

      // ==== FINAL ASSEMBLY ====
      float desatFactor = desatAmt * desatAmt + 1.0;
      float3 desatMainLit = desatFactor * (mainLit - mainLitLum) + mainLitLum;

      float3 litColor = desatMainLit + skinSpec + subsurfSpec + emissionContrib + cubemapContrib;

      // ==== VFX COLOR ADJUSTMENT ====
      if (_EnableVFXColorAdjustment > 0.5) {
          float litLum = dot(litColor, LUM);
          float3 adjusted;
          adjusted.r = _ColorAdjustmentContrast * (lerp(litLum, litColor.r, _ColorAdjustmentSaturation) - 0.5) + 0.5;
          adjusted.g = _ColorAdjustmentContrast * (lerp(litLum, litColor.g, _ColorAdjustmentSaturation) - 0.5) + 0.5;
          adjusted.b = _ColorAdjustmentContrast * (lerp(litLum, litColor.b, _ColorAdjustmentSaturation) - 0.5) + 0.5;
          float caRimT = saturate((_ColorAdjustmentRimWidth - NdotV_spec) / max(_ColorAdjustmentRimWidth, 1e-5));
          float caRimSmooth = caRimT * caRimT * (3.0 - 2.0 * caRimT);
          float3 caBrightened = adjusted * _ColorAdjustmentBrightness;
          litColor = lerp(caBrightened, _ColorAdjustmentColorBlend.rgb, _ColorAdjustmentColorBlend.w)
                   + caRimSmooth * _ColorAdjustmentRimColor.rgb * _ColorAdjustmentRimIntensity;
      }

      float3 finalColor = litColor / _ExposureParams.x;
      return finalColor;
  }
//- }

//----------------------------------------------------------------------region Part 1 Face — HGRP_CharacterNPR_Skin_Fix.shader computeNPRLighting 逐行移植
//- {
  // SDF Mask / SDF Lightmap = 贴图参数 (RGBA 完整 + 镜像 UV 采样需任意 UV)。
  // Face 的 LUT-off 阴影色是"纯白" (shadowLut = oneMinusRefl), 与其他部位不同 — 逐行保留。
  // castShadow: SDF on → 1.0 (HGRP 同); off → shadowAtten=1 [H2] 时 smoothstep(1)=1。
  float3 shadeFace(V2F inputs, float3 positionWS, float3 normalWS_raw, float4 tangentWS, float faceSign, float3 albedo, float baseAlpha) {
      float2 uv = GetBaseUV(inputs);

      // ---- Object-to-World ([H4]: 单位矩阵世界轴; SP 烘焙网格无需 FBX 旋转修正) ----
      float3 objectRight   = float3(1.0, 0.0, 0.0);
      float3 objectUp      = float3(0.0, 1.0, 0.0);
      float originX = 0.0;
      float originZ = 0.0;

      // ---- View direction ----
      float3 V = normalize(camera_pos - positionWS);

      // ---- Normal map ----
      float3 N = SampleBumpNormal(inputs, normalWS_raw, tangentWS, faceSign, _BumpScale);

      // ---- SDF Mask (sampler 参数, rgba 完整) ----
      float4 sdfMask = float4(1.0, 1.0, 0.0, 0.0);
      if (u_UseSDFLightmap) {
          sdfMask = texture(_SDFMask, uv);
      }

      // ---- Flat direction ----
      float fX = positionWS.x - originX;
      float fZ = positionWS.z - originZ;
      float fLen = rsqrt(fX*fX + NEAR_ZERO_Y*NEAR_ZERO_Y + fZ*fZ);
      float3 flatDir = float3(fX*fLen, NEAR_ZERO_Y*fLen, fZ*fLen);

      // ---- Camera forward ----
      float3 camFwd = GetCamFwd();

      // ---- 脸空间相机向量 (SDF rim gate + skin camGate; 无条件算, 关闭时不消费) ----
      // 源: faceRight = unity_ObjectToWorld 列0 (objLightX→lightSide 左右镜像),
      //     faceFwd   = unity_ObjectToWorld 列2 (objLightZ→sdfLightZ 前后/明暗扫描),
      //     faceUp    = 列1 — cross 重建, 无需第三参数。参数即 SP 世界轴原值 (±1),
      // 不再经过任何旋转/翻转重映射 (Unity↔SP 手性差是镜像, 纯旋转表达不了, 只能靠负分量)。
      // cross 取 right×fwd: 默认 ((1,0,0),(0,0,-1)) 给出 (0,1,0) 世界上方与源列1一致;
      // faceUp 仅以 NEAR_ZERO 权重进 SDF 法线重建, camFwdObj.y 无消费者, 符号无关紧要。
      float3 faceFwd = _FaceForward.xyz;
      float3 faceRight = _FaceRight.xyz;
      float3 faceUp = cross(faceRight, faceFwd);
      float3 camFwdObj = float3(
          dot(camFwd, faceRight),
          dot(camFwd, faceUp),
          dot(camFwd, faceFwd)
      );
      float camFwdObjLen = rsqrt(max(dot(camFwdObj, camFwdObj), 1.175494e-38));
      camFwdObj *= camFwdObjLen;
      // max(): faceFwd=(0,0,0) 退化时 camFwdObj.xz 可能全 0 → 防 rsqrt(0)=Inf→NaN
      float camFwdObj_xz_invLen = rsqrt(max(camFwdObj.x * camFwdObj.x + camFwdObj.z * camFwdObj.z, 1.175494e-38));

      // ---- Flat normal XZ ----
      float3 vertNFlatXZ = float3(N.x, NEAR_ZERO_Y, N.z);
      float vertNFlatLen = rsqrt(dot(vertNFlatXZ, vertNFlatXZ));
      vertNFlatXZ *= vertNFlatLen;

      float3 blendedDir;
      if (u_UseSDFLightmap) {
          blendedDir = normalize(lerp(flatDir, vertNFlatXZ, sdfMask.y));
      } else {
          blendedDir = vertNFlatXZ;
      }

      // ---- Exposure / Ambient (Face 用 CP3) ----
      float exposure = (_CharacterParams12.w * (1.0 - _EnvironmentGlobalParams0.x) + _EnvironmentGlobalParams0.x) * _ExposureParams.x;
      float ambInt = exposure;
      float3 ambCol = _CharacterParams3.xyz;

      // ---- Rim ----
      float rimModifier;
      if (u_UseSDFLightmap) {
          float camAngleBias = saturate(camFwdObj.z * camFwdObj_xz_invLen + 0.5);
          rimModifier = lerp(camAngleBias, 1.0, sdfMask.y) * sdfMask.x;
      } else {
          rimModifier = 1.0;
      }

      float rimOffScale;
      if (u_UseSDFLightmap) {
          rimOffScale = lerp(_FaceRimOffScale, _SkinRimOffScale, sdfMask.z);
      } else {
          rimOffScale = _SkinRimOffScale;
      }

      float NdotV = dot(N, V);
      float NdotV_sat = saturate(NdotV);
      float rimFresnel = 1.0 - (NdotV_sat * 0.85 + 0.15);
      float rimAmt = saturate(rimFresnel * rimModifier * rimOffScale);
      float rimInv = 1.0 - rimAmt;
      float3 rimFactor = _SDFRimColor.rgb * rimAmt + rimInv;
      float3 rimAlbedo = albedo * rimFactor;

      // ---- Metallic workflow (Face: 标量, 无 RMOS map — 与 Skin_Fix 一致) ----
      float specScale;
      if (u_UseSDFLightmap) {
          specScale = sdfMask.y * _Specular;
      } else {
          specScale = _Specular;
      }
      float roughnessRaw = 1.0 - _Smoothness;
      float oneMinusRefl = (1.0 - _Metallic) * 0.96;
      float3 diffColor = oneMinusRefl * rimAlbedo;
      float dielSpec = specScale * 0.04;
      float3 specColor = _Metallic * (rimAlbedo - dielSpec) + dielSpec;

      // ---- Shadow LUT (Face: LUT-off = 纯白 oneMinusRefl) ----
      float3 shadowLut;
      if (u_UseShadowLut) {
          shadowLut = oneMinusRefl * SampleShadowLutColor(albedo);
      } else {
          shadowLut = float3(oneMinusRefl);
      }

      float roughness = max(roughnessRaw * roughnessRaw, 0.0078125);

      // ---- Main light ([H2][H3]) ----
      float mainLightShadowAtten = 1.0;
      float3 mainLightDir = GetMainLightDir();
      float3 lightCol = v_MainLightColor.rgb;
      float lightInt = 1.0;

      // ---- Adjusted light direction ----
      float3 adjustedLightDir = lerp(mainLightDir, _CharacterParams11.xyz, _CharacterParams1.w);
      float adjXZLen = rsqrt(adjustedLightDir.x*adjustedLightDir.x + adjustedLightDir.z*adjustedLightDir.z + NEAR_ZERO_Y*NEAR_ZERO_Y);
      float adjXZ_x = adjXZLen * adjustedLightDir.x;
      float adjXZ_z = adjXZLen * adjustedLightDir.z;

      // ---- Camera-light dot ----
      float cfXZLen = rsqrt(camFwd.x * camFwd.x + camFwd.z * camFwd.z);
      float camLightDot = -(adjXZ_x * (cfXZLen * camFwd.x) + adjXZ_z * (cfXZLen * camFwd.z));

      // ---- Light color blend (Face 用 CP4) ----
      float3 blendedLightCol;
      blendedLightCol.r = lightCol.r + _CharacterParams12.y * (_CharacterParams4.x - lightCol.r);
      blendedLightCol.g = lightCol.g + _CharacterParams12.y * (_CharacterParams4.y - lightCol.g);
      blendedLightCol.b = lightCol.b + _CharacterParams12.y * (_CharacterParams4.z - lightCol.b);
      float blendedLightInt = _CharacterParams12.w * (1.0 - lightInt) + lightInt;

      // ==== SDF LIGHTMAP ====
      float3 sdfBlendedN = N;
      float sdfValue = 0.0;
      float sdfNdotL = 0.0;
      if (u_UseSDFLightmap) {
          float objLightX = dot(adjustedLightDir, faceRight);
          float objLightZ = dot(adjustedLightDir, faceFwd);
          float objLight_invLen = rsqrt(objLightX * objLightX + NEAR_ZERO_Y * NEAR_ZERO_Y + objLightZ * objLightZ);
          float sdfLightZ = objLight_invLen * objLightZ;
          float lightSide = (objLight_invLen * objLightX > 0.0) ? 1.0 : 0.0;

          float mirrorU = 1.0 - uv.x;
          float2 sdfUV = float2(
              mad(lightSide, uv.x - mirrorU, mirrorU),
              uv.y
          );
          float4 sdfSample = textureLod(_SDFLightmap, sdfUV, 0.0);
          sdfValue = sdfSample.x + sdfSample.y;

          float sdfNx_base = 1.0 - 2.0 * sdfSample.z;
          float sdfNx = mad(lightSide, (2.0 * sdfSample.z - 1.0) - sdfNx_base, sdfNx_base);
          float sdfNz = 1.0 - abs(sdfNx);
          float3 sdfFlatN = normalize(float3(sdfNx, NEAR_ZERO_Y, sdfNz));

          float3 sdfNormalWS = normalize(sdfFlatN.x * faceRight + sdfFlatN.y * faceUp + sdfFlatN.z * faceFwd);
          sdfBlendedN = normalize(lerp(sdfNormalWS, N, sdfMask.y));

          float backlitFactor = saturate(camLightDot) * saturate(-sdfLightZ) * (1.0 - _CharacterParams12.x);
          float wrapTerm = 0.5 * (1.0 - sdfLightZ * sdfLightZ);
          float sdfWrapNdotL = sdfLightZ + backlitFactor * wrapTerm;

          float halfWrap = sdfWrapNdotL * 0.5;
          float sdfT = clamp(0.5 - halfWrap, 0.001, 0.999);
          float sdfLo = max(2.0 * sdfT - 1.0, 0.0);
          float sdfHi = min(2.0 * sdfT, 1.0);
          float sdfS = saturate((sdfValue * 0.5 - sdfLo) / (sdfHi - sdfLo));
          float sdfSS = sdfS * sdfS * (3.0 - 2.0 * sdfS);
          float halfCeil = ceil(halfWrap) * halfWrap;
          sdfNdotL = (sdfSS + halfCeil) * 2.0 - 1.0;
      }

      // ==== DIFFUSE RAMP ====
      float geomNdotL = dot(N, adjustedLightDir);
      float clampedNdotL = clamp(_CharacterParams11.w * _CharacterParams12.x + geomNdotL, -1.0, 1.0);

      float rampInput;
      if (u_UseSDFLightmap) {
          rampInput = lerp(sdfNdotL, clampedNdotL, sdfMask.y) * 0.5 + 0.5;
      } else {
          rampInput = clampedNdotL * 0.5 + 0.5;
      }

      float3 rampCol; float rampA; float rampChroma; float rampChromaInv;
      if (u_UseDiffRamp) {
          float4 rampSmp = textureLod(_RampMap, float2(rampInput, 0.5), 0.0);
          rampCol = rampSmp.rgb;
          rampA = rampSmp.a;
          rampChroma = max(rampCol.r, max(rampCol.g, rampCol.b)) - min(rampCol.r, min(rampCol.g, rampCol.b));
          rampChromaInv = 1.0 - rampChroma;
      } else {
          rampCol = float3(1.0);
          rampA = 1.0;
          rampChroma = 0.0;
          rampChromaInv = 1.0;
      }

      // ==== NPR DIFFUSE COMPOSITION ====
      float3 albScaled = shadowLut * _CharacterParams0.z;
      float diffColorLum = dot(diffColor, LUM);
      float castShadow;
      if (u_UseSDFLightmap) {
          castShadow = 1.0;
      } else {
          castShadow = lerp(smoothstep(0.0, 1.0, mainLightShadowAtten), 1.0, _CharacterParams1.z);
      }
      float minShadow = min(rampA, baseAlpha) * castShadow;

      float nprNdotL = saturate(dot(blendedDir, _CharacterParams6.xyz) + _CharacterParams7.x) * _CharacterParams7.y + _CharacterParams7.z;
      float shadowStr = minShadow * _CharacterParams1.y;

      float3 shadAmb;
      shadAmb.r = nprNdotL * (shadowStr * (1.0 - ambCol.r) + ambCol.r);
      shadAmb.g = nprNdotL * (shadowStr * (1.0 - ambCol.g) + ambCol.g);
      shadAmb.b = nprNdotL * (shadowStr * (1.0 - ambCol.b) + ambCol.b);

      float bright065 = min(ambInt * 0.35 + 0.65, 1.5);
      float brightFull = clamp(ambInt, 0.0, 1.5);
      float brightMix = lerp(bright065, clamp(ambInt, 1.25, 1.75), _CharacterParams1.x);

      float lightLum = dot(blendedLightCol * blendedLightInt, LUM);

      float oneMinus12y = 1.0 - _CharacterParams12.y;
      float3 lightBlend = blendedLightCol * _CharacterParams12.y + oneMinus12y;
      float3 fullDiff;
      fullDiff.r = (shadAmb.r * brightFull * lightBlend.r + minShadow * (blendedLightCol.r * blendedLightInt - lightLum) + lightLum) * _CharacterParams0.y;
      fullDiff.g = (shadAmb.g * brightFull * lightBlend.g + minShadow * (blendedLightCol.g * blendedLightInt - lightLum) + lightLum) * _CharacterParams0.y;
      fullDiff.b = (shadAmb.b * brightFull * lightBlend.b + minShadow * (blendedLightCol.b * blendedLightInt - lightLum) + lightLum) * _CharacterParams0.y;

      float albScaledLum = dot(albScaled * 0.65, LUM);
      float3 desatShad;
      desatShad.r = (albScaled.r * 0.65 - albScaledLum) * 1.2 + albScaledLum;
      desatShad.g = (albScaled.g * 0.65 - albScaledLum) * 1.2 + albScaledLum;
      desatShad.b = (albScaled.b * 0.65 - albScaledLum) * 1.2 + albScaledLum;

      float combWeight = saturate(baseAlpha + rampA);
      float3 weightedAmb = lerp(desatShad, albScaled, combWeight);
      float3 shadowBlended = lerp(weightedAmb, diffColor, minShadow);

      float3 rampTinted;
      rampTinted.r = shadowBlended.r * (rampCol.r * rampChroma + rampChromaInv);
      rampTinted.g = shadowBlended.g * (rampCol.g * rampChroma + rampChromaInv);
      rampTinted.b = shadowBlended.b * (rampCol.b * rampChroma + rampChromaInv);

      float shadowLumVal = dot(shadowBlended, LUM);
      float rampLum = dot(rampTinted, LUM);
      float lumRatio = clamp(shadowLumVal / max(rampLum, 0.001), 0.0, 1.5);

      float3 nprDiff = rampTinted * lumRatio;

      float attenFac = minShadow;
      float ambDiffInt = (attenFac * (1.0 - _CharacterParams0.z) + _CharacterParams0.z) * (attenFac * 0.5 + 0.5);

      float3 ambDiff = ambDiffInt * fullDiff;

      // ==== GGX SPECULAR ====
      float NdotV_spec = saturate(dot(N, V));
      float3 camFwdMod = normalize(float3(camFwd.x, adjustedLightDir.y, camFwd.z));
      float3 H = normalize(V * 3.0 + adjustedLightDir + camFwdMod * 2.0);
      float NdotH = dot(N, H);
      float roughSq = roughness * roughness;
      float denom = (NdotH * roughSq - NdotH) * NdotH + 1.0;
      float denomSq = denom * denom;
      float D_raw = (denomSq != roughSq) ? roughSq / denomSq : 1.0;
      float ggxTerm = clamp(D_raw * 0.5 / (NdotV_spec * 2.0 + roughness + 1e-4) - NEAR_ZERO_Y, 0.0, 20.0);

      // ==== HIGHLIGHT MAP ====
      float3 hlSample = float3(0.0);
      if (u_FaceHighlightMap) {
          float hlOffsetX = dot(V, objectRight) * _HighlightMapVector.x;
          float hlOffsetY = dot(V, objectUp) * _HighlightMapVector.y;
          hlSample = texture(_HighlightMap, float2(uv.x + hlOffsetX, uv.y + hlOffsetY)).rgb;
      }

      // Main lit composition
      float3 mainLit;
      mainLit.r = fullDiff.r * nprDiff.r + ambDiff.r * (specColor.r * ggxTerm * _CharacterParams13.w + hlSample.r);
      mainLit.g = fullDiff.g * nprDiff.g + ambDiff.g * (specColor.g * ggxTerm * _CharacterParams13.w + hlSample.g);
      mainLit.b = fullDiff.b * nprDiff.b + ambDiff.b * (specColor.b * ggxTerm * _CharacterParams13.w + hlSample.b);
      float mainLitLum = dot(mainLit, LUM);
      float desatAmt = clamp(mainLitLum - 0.5, 0.0, 0.5);

      // ==== SKIN SPECULAR (CP8/CP9) ====
      float3 skinDir;
      skinDir.x = -_CharacterParams9.y * camFwd.z;
      skinDir.y =  camFwd.z * _CharacterParams9.x;
      skinDir.z =  camFwd.x * _CharacterParams9.y - _CharacterParams9.x * camFwd.y;
      skinDir = normalize(skinDir);

      float skinNdotV = dot(V, sdfBlendedN);
      float skinFresnel = 1.0 - abs(skinNdotV);
      float skinLow = _CharacterParams9.w * (-0.6) + 0.8;
      float skinHigh = _CharacterParams9.w * (-0.4) + 0.9;
      float skinT = saturate((skinFresnel - skinLow) / (skinHigh - skinLow));
      float skinSmooth = skinT * skinT * (3.0 - 2.0 * skinT);

      float skinAmt;
      if (u_UseSDFLightmap) {
          float camAngleAbs = abs(camFwdObj.z * camFwdObj_xz_invLen);
          float camGateT = saturate((camAngleAbs - 0.9) * 10.0);
          float camGate = camGateT * camGateT * (3.0 - 2.0 * camGateT);
          float cp9wGate = saturate(_CharacterParams9.w * 10.0 - 3.0);
          float camFacingSkin = (dot(camFwd, skinDir) < -0.01) ? 1.0 : 0.0;
          skinAmt = lerp(camGate * skinSmooth, max(camGate, camFacingSkin) * sdfMask.w, cp9wGate);
      } else {
          skinAmt = skinSmooth;
      }

      float skinNdotL = saturate(dot(flatDir, skinDir) + 1.0);
      float skinShadow = min(baseAlpha, skinNdotL);
      float skinNdotBN = saturate(dot(skinDir, sdfBlendedN));

      // ==== SUBSURFACE SPECULAR ====
      float mainNdotL_xz = dot(float3(adjXZ_x, adjXZLen * NEAR_ZERO_Y, adjXZ_z), N);
      float wrapNdotL = saturate(0.5 + mainNdotL_xz - 0.5 * mainNdotL_xz * mainNdotL_xz);
      float camLightFacing = (1.0 - _CharacterParams12.x) * saturate(camLightDot);
      float edgeT = saturate((-abs(NdotV) + 0.4) * 5.0);
      float edgeFresnel = edgeT * edgeT * (3.0 - 2.0 * edgeT);
      float brightT = saturate((0.1 - diffColorLum) * 16.666);
      float brightnessGate = (brightT * brightT) * (3.0 - 2.0 * brightT);
      float3 subsurfLight = blendedLightCol * blendedLightInt;
      float3 subsurfSpec;
      subsurfSpec.r = brightnessGate * baseAlpha * edgeFresnel * camLightFacing * wrapNdotL * subsurfLight.r * max(diffColor.r, 0.15);
      subsurfSpec.g = brightnessGate * baseAlpha * edgeFresnel * camLightFacing * wrapNdotL * subsurfLight.g * max(diffColor.g, 0.15);
      subsurfSpec.b = brightnessGate * baseAlpha * edgeFresnel * camLightFacing * wrapNdotL * subsurfLight.b * max(diffColor.b, 0.15);

      // ==== CP14 SECONDARY SPECULAR ====
      float3 cp14Term = float3(0.0);
      if (u_UseSDFLightmap) {
          float halfCP15 = 0.5 * _CharacterParams15.z;
          float cp15T = clamp(0.5 - halfCP15, 0.001, 0.999);
          float cp15Lo = max(2.0 * cp15T - 1.0, 0.0);
          float cp15Hi = min(2.0 * cp15T, 1.0);
          float cp15S = saturate((sdfValue * 0.5 - cp15Lo) / (cp15Hi - cp15Lo));
          float cp15SS = cp15S * cp15S * (3.0 - 2.0 * cp15S);
          float cp15Ceil = ceil(halfCP15) * halfCP15;
          float cp15Raw = saturate((cp15SS + cp15Ceil) * 2.0 - 0.5);
          float cp15Smooth = cp15Raw * cp15Raw * (3.0 - 2.0 * cp15Raw);
          float cp14Spec = (1.0 - sdfMask.y) * cp15Smooth;
          cp14Term.r = diffColor.r * cp14Spec * _CharacterParams14.x * _CharacterParams14.w;
          cp14Term.g = diffColor.g * cp14Spec * _CharacterParams14.y * _CharacterParams14.w;
          cp14Term.b = diffColor.b * cp14Spec * _CharacterParams14.z * _CharacterParams14.w;
      }

      // ==== FINAL ASSEMBLY ====
      float desatFactor = desatAmt * desatAmt + 1.0;
      float3 term1;
      term1.r = desatFactor * (mainLit.r - mainLitLum) + mainLitLum;
      term1.g = desatFactor * (mainLit.g - mainLitLum) + mainLitLum;
      term1.b = desatFactor * (mainLit.b - mainLitLum) + mainLitLum;

      float3 skinTerm;
      skinTerm.r = skinShadow * skinAmt * _CharacterParams8.x * _CharacterParams8.w * skinNdotBN * (_CharacterParams9.z * (diffColor.r - 0.25) + 0.25);
      skinTerm.g = skinShadow * skinAmt * _CharacterParams8.y * _CharacterParams8.w * skinNdotBN * (_CharacterParams9.z * (diffColor.g - 0.25) + 0.25);
      skinTerm.b = skinShadow * skinAmt * _CharacterParams8.z * _CharacterParams8.w * skinNdotBN * (_CharacterParams9.z * (diffColor.b - 0.25) + 0.25);

      float3 litColor = term1 + skinTerm + subsurfSpec + cp14Term;

      // ==== VFX COLOR ADJUSTMENT (Face: caRimAmt 带 rimModifier) ====
      if (_EnableVFXColorAdjustment > 0.5) {
          float litLum = dot(litColor, LUM);
          float3 adjusted;
          adjusted.r = _ColorAdjustmentContrast * (lerp(litLum, litColor.r, _ColorAdjustmentSaturation) - 0.5) + 0.5;
          adjusted.g = _ColorAdjustmentContrast * (lerp(litLum, litColor.g, _ColorAdjustmentSaturation) - 0.5) + 0.5;
          adjusted.b = _ColorAdjustmentContrast * (lerp(litLum, litColor.b, _ColorAdjustmentSaturation) - 0.5) + 0.5;
          float caRimT = saturate((_ColorAdjustmentRimWidth - NdotV_sat) / max(_ColorAdjustmentRimWidth, 1e-5));
          float caRimSmooth = caRimT * caRimT * (3.0 - 2.0 * caRimT);
          float caRimAmt = rimModifier * caRimSmooth;
          float3 caBrightened = adjusted * _ColorAdjustmentBrightness;
          litColor = lerp(caBrightened, _ColorAdjustmentColorBlend.rgb, _ColorAdjustmentColorBlend.w)
                   + caRimAmt * _ColorAdjustmentRimColor.rgb * _ColorAdjustmentRimIntensity;
      }

      float3 finalColor = litColor / _ExposureParams.x;
      return finalColor;
  }
//- }

//----------------------------------------------------------------------region Part 2/5 Eyes — HGRP_CharacterNPR_Eye_Fix.shader EyeFrag 逐行移植
//- {
  // allowMatcap: Part2(Eyes)=u_UseMatcap, Part5(Eyebrow)=false (眉毛 = Eye shader 无 _MATCAP_ON 路径)。
  // 虹膜视差要在"任意偏移 UV"上重采基础色/不透明度 → 走通道裸 sampler (.tex) [见头部注释]。
  // 物体空间光投影: [H4] 单位矩阵 + FBX 修正。
  float3 shadeEyes(V2F inputs, float3 positionWS, float3 rawN_in, float4 tangentWS, bool isFrontFace, bool allowMatcap) {
      float2 uvBase = GetBaseUV(inputs);
      bool useMatcap = allowMatcap && u_UseMatcap;

      // ---- View direction ----
      float3 V = normalize(camera_pos - positionWS);

      // ---- Normal ----
      float3 rawN = rawN_in;
      float  nInvLen = rsqrt(dot(rawN, rawN));
      float  faceSign = isFrontFace ? 1.0 : (_BackFaceNormalFlip * 2.0 - 1.0);
      float3 N = faceSign * (nInvLen * rawN);

      // ---- Iris pipeline: TBN, parallax, iris mask, matcap normal ----
      float3 T = tangentWS.xyz;
      float  tSign = tangentWS.w;
      float3 B = cross(rawN, T) * tSign;

      float irisMask = 0.0;
      float scaledNx = 0.0;
      float scaledNy = 0.0;
      float matNz = 1.0;
      float2 sampleUV = uvBase;
      float3 lightN = N;
      float3 flatLightN = normalize(float3(N.x, NEAR_ZERO_Y, N.z));
      if (useMatcap) {
          float2 fracUV = frac(uvBase);
          float2 uvFromCenter = fracUV - 0.5;
          float distSq = dot(uvFromCenter, uvFromCenter);
          irisMask = (distSq >= 0.25) ? 1.0 : 0.0;

          float Tv = dot(nInvLen * T, V);
          float Bv = dot(nInvLen * (tSign * cross(rawN, T)), V);
          float Nv = dot(nInvLen * rawN, V);
          float tbvLen = rsqrt(max(Tv * Tv + Bv * Bv + Nv * Nv, 1.175494e-38));
          float parallaxRaw = saturate((distSq - 0.25) * (-5.0));
          float parallaxSmooth = parallaxRaw * parallaxRaw * (3.0 - 2.0 * parallaxRaw);
          sampleUV = float2(
              uvBase.x - (tbvLen * Tv * _EyeParallaxScale) * parallaxSmooth,
              uvBase.y - (tbvLen * Bv * _EyeParallaxScale * 0.25) * parallaxSmooth
          );

          float matNx = fracUV.x * 2.0 - 1.0;
          float matNy = fracUV.y * 2.0 - 1.0;
          matNz = max(sqrt(saturate(1.0 - dot(float2(matNx, matNy), float2(matNx, matNy)))), 1e-16);
          scaledNx = matNx * (-_MatcapNormalScale);
          scaledNy = matNy * (-_MatcapNormalScale);
          float maskFactor = 0.125 * (irisMask - 1.0); // -0.125 inside, 0 outside
          lightN = normalize(T * (scaledNx * maskFactor)
                           + B * (scaledNy * maskFactor)
                           + rawN * lerp(matNz, 1.0, irisMask));
          flatLightN = normalize(float3(lightN.x, NEAR_ZERO_Y, lightN.z));
      }

      // ---- Base color (视差偏移 UV → 通道裸采样) ----
      float4 baseSample;
      baseSample.rgb = basecolor_tex.is_set ? texture(basecolor_tex.tex, sampleUV).rgb : float3(1.0);
      baseSample.a   = opacity_tex.is_set   ? texture(opacity_tex.tex, sampleUV).r    : 1.0;
      float3 albedo = baseSample.rgb * _BaseColor.rgb;
      float  baseAlpha = baseSample.a * _BaseColor.a;

      // ---- Exposure ----
      float exposure = (_CharacterParams12.w * (1.0 - _EnvironmentGlobalParams0.x)
                       + _EnvironmentGlobalParams0.x) * _ExposureParams.x;

      // ---- Ambient (CP2) ----
      float3 ambCol = _CharacterParams2.xyz;

      // ---- Camera forward ----
      float3 camFwd = GetCamFwd();

      // ---- Metallic workflow ----
      float oneMinusRefl = (1.0 - _Metallic) * 0.96;
      float3 diffColor = oneMinusRefl * albedo;

      // ---- Shadow color ----
      float3 shadowColor;
      if (u_UseShadowLut) {
          shadowColor = oneMinusRefl * SampleShadowLutColor(albedo);
      } else {
          float3 albBright = albedo * _ShadowColorBrightness;
          float shadBright = dot(albBright, LUM);
          shadowColor = oneMinusRefl * (shadBright + _ShadowColorSaturation * (albBright - shadBright));
      }

      // ---- Main light ([H3], Eye 无阴影坐标) ----
      float3 mainLightDir = GetMainLightDir();

      // ---- Adjusted light direction ----
      float3 adjustedLightDir = lerp(mainLightDir, _CharacterParams11.xyz, _CharacterParams1.w);
      float adjXZLen = rsqrt(adjustedLightDir.x * adjustedLightDir.x
                           + adjustedLightDir.z * adjustedLightDir.z
                           + NEAR_ZERO_Y * NEAR_ZERO_Y);
      float adjXZ_x = adjXZLen * adjustedLightDir.x;
      float adjXZ_z = adjXZLen * adjustedLightDir.z;

      // ---- Light color blend (CP5) ----
      float3 blendedLightCol = lerp(v_MainLightColor.rgb, _CharacterParams5.xyz, _CharacterParams12.y);
      float lightLum = dot(blendedLightCol, LUM);

      // ---- Object-space light projection ([H4] 单位 o2w; SP 烘焙网格无需 FBX 旋转修正) ----
      float3 _otwC0 = float3(1.0, 0.0, 0.0);
      float3 _otwC1 = float3(0.0, 1.0, 0.0);
      float3 _otwC2 = float3(0.0, 0.0, 1.0);
      // HGRP 的 float3x3(C0.x,C1.x,C2.x / C0.y,... / C0.z,...) 行优先填充后, 矩阵的"列"恰为
      // otwC0/C1/C2 (基向量列) — GLSL mat3(v0,v1,v2) 按列构造, 直接传基向量即可得到同一矩阵。
      mat3 o2w3x3 = mat3(_otwC0, _otwC1, _otwC2);
      // HLSL mul(v, M) = M^T·v → transpose(M)*v; HLSL mul(M, v) = M·v → M*v
      float3 localLight = transpose(o2w3x3) * adjustedLightDir;
      float localLen = rsqrt(max(dot(localLight, localLight), 1.175494e-38));
      float3 normLocal = localLight * localLen;
      float3 projLight = o2w3x3 * float3(normLocal.x, 0.0, normLocal.z);
      float projLen = rsqrt(max(dot(projLight, projLight), 1.175494e-38));
      projLight *= projLen;

      // ---- Eye blend factor ----
      float3 eyeBlend = float3(1.0);
      if (useMatcap) {
          float insideMask = 1.0 - irisMask;
          float3 highlightTerm;
          if (u_EyeHighLight) {
              highlightTerm = _EyeHighLightColor.rgb * irisMask + insideMask;
          } else {
              highlightTerm = float3(insideMask);
          }
          float scatterBase = 1.0 - baseAlpha;
          eyeBlend = highlightTerm * (_EyeScatteringColor.rgb * baseAlpha + scatterBase);
      }

      // ==== DIFFUSE RAMP ====
      float3 rampCol; float rampA; float viewRampA;
      if (u_UseDiffRamp) {
          float rampNdotL = dot(lightN, projLight);
          float rampInput = clamp(_CharacterParams11.w * _CharacterParams12.x + rampNdotL, -1.0, 1.0) * 0.5 + 0.5;
          float4 rampSmp = textureLod(_RampMap, float2(rampInput, 0.5), 0.0);
          rampCol = rampSmp.rgb;
          rampA = rampSmp.a;

          float viewRampInput = dot(lightN, camFwd) * 0.5 + 0.5;
          float4 viewRampSmp = textureLod(_RampMap, float2(viewRampInput, 0.5), 0.0);
          viewRampA = viewRampSmp.a;
      } else {
          rampCol = float3(1.0);
          rampA = 1.0;
          viewRampA = 0.0;
      }

      float rampChroma = max(rampCol.r, max(rampCol.g, rampCol.b))
                       - min(rampCol.r, min(rampCol.g, rampCol.b));
      float rampChromaInv = 1.0 - rampChroma;
      float minRampA = min(rampA, 1.0);

      // ==== NPR DIFFUSE COMPOSITION ====
      float nprNdotL = saturate(dot(flatLightN, _CharacterParams6.xyz) + _CharacterParams7.x)
                     * _CharacterParams7.y + _CharacterParams7.z;
      float shadowStr = minRampA * _CharacterParams1.y;
      float3 shadAmb = nprNdotL * (shadowStr * (1.0 - ambCol) + ambCol);

      float brightFull = clamp(exposure, 0.0, 1.5);
      float brightAlt = clamp(exposure, 1.25, 1.75);
      float brightness = lerp(brightFull, brightAlt, _CharacterParams1.x);

      float3 lightBlend = blendedLightCol * _CharacterParams12.y + (1.0 - _CharacterParams12.y);

      float3 fullDiff = (shadAmb * brightness * lightBlend
                        + minRampA * (blendedLightCol - lightLum) + lightLum)
                        * _CharacterParams0.y;

      // Shadow desaturation
      float3 albScaled = shadowColor * _CharacterParams0.z;
      float3 albScaled65 = albScaled * 0.65;
      float albScaledLum = dot(albScaled65, LUM);
      float3 desatShad = (albScaled65 - albScaledLum) * 1.2 + albScaledLum;

      float combWeight = saturate(rampA + viewRampA);
      float3 weightedAmb = lerp(desatShad, albScaled, combWeight);
      float3 shadowBlended = lerp(weightedAmb, diffColor * eyeBlend, minRampA);

      float3 rampTinted = shadowBlended * (rampCol * rampChroma + rampChromaInv);

      float shadowLum = dot(shadowBlended, LUM);
      float rampLum = dot(rampTinted, LUM);
      float lumRatio = clamp(shadowLum / max(rampLum, 0.001), 0.0, 1.5);

      float3 nprDiff = rampTinted * lumRatio;

      // ==== MATCAP SAMPLING & BLENDING ====
      float alphaPremult = lerp(1.0, baseAlpha, _AlphaPremultiply);

      float3 matcapContrib = float3(0.0);
      if (useMatcap) {
          float rampBlendFactor = minRampA;
          float matcapIntensity = (rampBlendFactor * (1.0 - _CharacterParams0.z) + _CharacterParams0.z)
                                * (rampBlendFactor * 0.5 + 0.5);

          float3 matcapFullN = normalize(T * scaledNx + B * scaledNy + rawN * matNz);
          // UNITY_MATRIX_V 三行 · v = mat3(view) * v
          float3 viewN = mat3(uniform_camera_view_matrix) * matcapFullN;
          float viewNLen = rsqrt(dot(viewN, viewN));
          float2 matcapUV = float2(viewN.x * viewNLen * 0.5 + 0.5, viewN.y * viewNLen * 0.5 + 0.5);
          float4 matcapSmp = SampleSRGBTex(_MatcapTex, matcapUV); // sRGBTexture=1
          float matcapA = matcapSmp.a;

          matcapContrib = (matcapSmp.rgb * _MatcapColor.a + matcapA * _MatcapColor.rgb)
                        * (matcapIntensity * fullDiff);
      }

      float3 mainLit = nprDiff * fullDiff * alphaPremult + matcapContrib;
      float mainLitLum = dot(mainLit, LUM);

      // Desaturation
      float desatAmt = clamp(mainLitLum - 0.5, 0.0, 0.5);
      float desatFactor = desatAmt * desatAmt + 1.0;
      float3 term1 = desatFactor * (mainLit - mainLitLum) + mainLitLum;

      // ==== SUBSURFACE SPECULAR ====
      float mainNdotL_xz = dot(float3(adjXZ_x, adjXZLen * NEAR_ZERO_Y, adjXZ_z), lightN);
      float wrapNdotL = saturate(0.5 + mainNdotL_xz - 0.5 * mainNdotL_xz * mainNdotL_xz);

      float cfXZLen = rsqrt(camFwd.x * camFwd.x + camFwd.z * camFwd.z);
      float camLightDot = -(adjXZ_x * (cfXZLen * camFwd.x) + adjXZ_z * (cfXZLen * camFwd.z));
      float camLightFacing = (1.0 - _CharacterParams12.x) * saturate(camLightDot);

      float NdotV = dot(V, lightN);
      float edgeT = saturate((-abs(NdotV) + 0.4) * 5.0);
      float edgeFresnel = edgeT * edgeT * (3.0 - 2.0 * edgeT);

      float diffColorLum = dot(diffColor, LUM);
      float brightT = saturate((0.1 - diffColorLum) * 16.666);
      float brightnessGate = brightT * brightT * (3.0 - 2.0 * brightT);

      float3 subsurfSpec = brightnessGate * edgeFresnel * camLightFacing * wrapNdotL
                         * blendedLightCol * max(diffColor, 0.15);

      // ==== CP13 EYE DIRECT TERM ====
      float3 eyeDirect = float3(0.0);
      if (useMatcap) {
          float3 highlightEmission;
          if (u_EyeHighLight) {
              highlightEmission = irisMask * _EyeHighLightColor.rgb;
          } else {
              highlightEmission = float3(0.0);
          }
          eyeDirect = (albedo * _CharacterParams13.x
                     + highlightEmission * _CharacterParams13.y
                     + (baseAlpha * _EyeScatteringColor.rgb) * _CharacterParams13.z)
                     * alphaPremult;
      }

      // ==== FINAL ASSEMBLY ====
      float3 finalColor = (eyeDirect + subsurfSpec + term1) / _ExposureParams.x;
      return finalColor;
  }
//- }

//----------------------------------------------------------------------region Part 3 Hair — HGRP_CharacterNPR_Hair_Fix.shader computeNPRLighting 逐行移植
//- {
  // Split Normal = _SplitNormalMap 贴图参数 (RG=diffuse BA=spec, 裸 [0,1], 不走 DXT5nm); Stroke/Line = 贴图参数。
  // [H11] 皮肤高光的深度边缘检测 → f_HairDepthEdgeMask 直接替代 depthSmooth。
  // 注: HGRP Hair 的 minShadow 不乘 castShadow (charShadow=1 路径), 逐行保留。
  float3 shadeHair(V2F inputs, float3 positionWS, float3 normalWS_raw, float4 tangentWS, float faceSign, float3 albedo, float baseAlpha) {
      float2 uv = GetBaseUV(inputs);
      // ---- Object-to-World origin ([H4]) ----
      float originX = 0.0;
      float originZ = 0.0;

      // ---- View direction ----
      float3 V = normalize(camera_pos - positionWS);

      // ---- MetallicGlossMap ([H1]) ----
      float metallic, specScale, shadowMask, smoothness;
      SampleRMOS(inputs, metallic, specScale, shadowMask, smoothness);

      // ---- Shadow color ----
      float3 shadowColor;
      if (u_UseShadowLut) {
          shadowColor = SampleShadowLutColor(albedo);
      } else {
          shadowColor = ComputeShadowColorBrightSat(albedo);
      }

      // ---- Split Normal Map (user1: RG=diffuse BA=spec, 裸 [0,1]) ----
      float3 nrmWS = normalize(normalWS_raw);
      float3 tanWS = normalize(tangentWS.xyz);
      float3 bitWS = cross(nrmWS, tanWS) * tangentWS.w;

      float3 N;
      float3 specN;
      if (u_UseSpecBumpMap && u_UseBumpMap) {
          float4 nrmSmp = texture(_SplitNormalMap, uv);
          float dnRawX = nrmSmp.x * 2.0 - 1.0;
          float dnRawY = nrmSmp.y * 2.0 - 1.0;
          float dnZ = max(sqrt(1.0 - saturate(dnRawX*dnRawX + dnRawY*dnRawY)), 1e-16);
          float dnX = dnRawX * _BumpScale;
          float dnY = dnRawY * _BumpScale;
          N = faceSign * normalize(dnX * tanWS + dnY * bitWS + dnZ * nrmWS);
          float snRawX = nrmSmp.z * 2.0 - 1.0;
          float snRawY = nrmSmp.w * 2.0 - 1.0;
          float snZ = max(sqrt(1.0 - saturate(snRawX*snRawX + snRawY*snRawY)), 1e-16);
          float snX = snRawX * _SpecBumpScale;
          float snY = snRawY * _SpecBumpScale;
          specN = normalize(snX * tanWS + snY * bitWS + snZ * nrmWS);
      } else if (u_UseBumpMap) {
          float4 nrmSmp = texture(_SplitNormalMap, uv);
          float dnRawX = nrmSmp.x * 2.0 - 1.0;
          float dnRawY = nrmSmp.y * 2.0 - 1.0;
          float dnZ = max(sqrt(1.0 - saturate(dnRawX*dnRawX + dnRawY*dnRawY)), 1e-16);
          float dnX = dnRawX * _BumpScale;
          float dnY = dnRawY * _BumpScale;
          N = faceSign * normalize(dnX * tanWS + dnY * bitWS + dnZ * nrmWS);
          specN = N;
      } else {
          N = faceSign * nrmWS;
          specN = N;
      }

      float3 geomN = faceSign * nrmWS;

      // ---- Flat direction ----
      float fX = positionWS.x - originX;
      float fZ = positionWS.z - originZ;
      float fLen = rsqrt(fX*fX + NEAR_ZERO_Y*NEAR_ZERO_Y + fZ*fZ);
      float3 flatDir = float3(fX*fLen, NEAR_ZERO_Y*fLen, fZ*fLen);

      // ---- Anisotropy tangent ([H4] 单位 o2w; SP 烘焙网格无需 FBX 旋转修正) ----
      // 注: FBX -90 修正会把 otwCol1(发丝方向=世界上方 0,1,0) 换成水平 → anisoDir 错 90°
      //     → 刘海各向异性高光环消失。SP 不需要, 已彻底删除该开关。
      float3 otwCol0 = float3(1.0, 0.0, 0.0);
      float3 otwCol1 = float3(0.0, 1.0, 0.0);
      float3 otwCol2 = float3(0.0, 0.0, 1.0);
      float3 anisoDir = normalize(otwCol0 * _AnisotropyDirX + otwCol1);
      float3 anisoBitan = cross(specN, anisoDir);
      float3 blendedBitan = lerp(anisoBitan, tangentWS.xyz, metallic);
      float tanSignScale = lerp(1.0, tangentWS.w, metallic);
      float3 modBitan = tanSignScale * cross(specN, blendedBitan);

      // ---- Edge fade ----
      float vDotC0 = dot(V, otwCol0);
      float vDotC2 = dot(V, otwCol2);
      float nDotC0 = dot(specN, otwCol0);
      float nDotC2 = dot(specN, otwCol2);
      float nXZLen = rsqrt(nDotC0*nDotC0 + nDotC2*nDotC2);
      float vXZLen = rsqrt(vDotC0*vDotC0 + vDotC2*vDotC2);
      float edgeDot = saturate(dot(float2(nXZLen*nDotC0, nXZLen*nDotC2), float2(vXZLen*vDotC0, vXZLen*vDotC2)));
      float edgeFade = exp2(log2(edgeDot) * _AnisotropyEdgeFade);

      // ---- Exposure / Ambient (CP2) ----
      float exposure = (_CharacterParams12.w * (1.0 - _EnvironmentGlobalParams0.x) + _EnvironmentGlobalParams0.x) * _ExposureParams.x;
      float ambInt = exposure;
      float3 ambCol = _CharacterParams2.xyz;

      // ---- CP10 Height Darken ----
      float darkenOffsetX = lerp(_HairDarkenParams.x, _CharacterParams10.y, _CharacterParams10.x);
      float darkenOffsetZ = lerp(_HairDarkenParams.z, _CharacterParams10.w, _CharacterParams10.x);
      float darkenY = lerp(_HairDarkenParams.y, 0.0, _CharacterParams10.x);
      float darkenMinW = _HairDarkenParams.w;

      float heightT = saturate(((darkenOffsetZ - positionWS.y) + 0.2) * 2.857143);
      float heightSmooth = heightT * heightT * (3.0 - 2.0 * heightT);
      float darkenFactor = max(heightSmooth * darkenY, darkenMinW);

      float darkenSum = darkenFactor + darkenOffsetX;
      float3 darkenedAlbedo;
      float3 darkenedShadowColor;
      float darkenedScale;
      if (0.01 < darkenSum) {
          float dMax = max(darkenFactor, darkenOffsetX);
          float dInv = 1.0 - dMax;
          float dMul = dMax * 0.8 + dInv;
          darkenedAlbedo = albedo * dMul;
          darkenedShadowColor = shadowColor * dMul;
          darkenedScale = dMax * 2.0 + dInv;
      } else {
          darkenedAlbedo = albedo;
          darkenedShadowColor = shadowColor;
          darkenedScale = 1.0;
      }

      // ---- Metallic workflow (Hair: metallic=0 简化) ----
      float3 diffColor = darkenedAlbedo * 0.96;
      float dielSpec = specScale * 0.04;
      float3 shadowDiff = darkenedShadowColor * 0.96;
      float diffColorLum = dot(diffColor, LUM);

      // ---- Main light ([H2][H3]) ----
      float mainLightShadowAtten = 1.0;
      float3 mainLightDir = GetMainLightDir();
      float3 lightCol = v_MainLightColor.rgb;

      // ---- Adjusted light direction ----
      float3 adjustedLightDir = lerp(mainLightDir, _CharacterParams11.xyz, _CharacterParams1.w);
      float adjXZLen = rsqrt(adjustedLightDir.x*adjustedLightDir.x + adjustedLightDir.z*adjustedLightDir.z + NEAR_ZERO_Y*NEAR_ZERO_Y);
      float adjXZ_x = adjXZLen * adjustedLightDir.x;
      float adjXZ_z = adjXZLen * adjustedLightDir.z;

      // ---- Light color blend (CP5) ----
      float3 blendedLightCol = lerp(lightCol, _CharacterParams5.xyz, _CharacterParams12.y);
      float blendedLightInt = lerp(1.0, 1.0, _CharacterParams12.w);

      // ---- Camera forward ----
      float3 camFwd = GetCamFwd();

      // ---- Camera-light facing ----
      float cfXZLen = rsqrt(camFwd.x * camFwd.x + camFwd.z * camFwd.z);
      float camLightDot = saturate(-(adjXZ_x * (cfXZLen * camFwd.x) + adjXZ_z * (cfXZLen * camFwd.z)));
      float camYFade = saturate(2.0 * (0.75 - abs(camFwd.y)));
      float camYSmooth = camYFade * camYFade * (3.0 - 2.0 * camYFade);

      // ==== DIFFUSE RAMP ====
      float geomNdotL = dot(N, adjustedLightDir);
      float wrapAdd = 0.5 - 0.5 * geomNdotL * geomNdotL;
      float camFadeFactor = (1.0 - _CharacterParams12.x) * (camLightDot * camYSmooth);
      float modNdotL = camFadeFactor * wrapAdd + geomNdotL;
      float3 rampCol; float rampA; float rampChroma; float rampChromaInv; float viewRampA;
      if (u_UseDiffRamp) {
          float rampInput = clamp(_CharacterParams11.w * _CharacterParams12.x + modNdotL, -1.0, 1.0) * 0.5 + 0.5;
          float4 rampSmp = textureLod(_RampMap, float2(rampInput, 0.5), 0.0);
          rampCol = rampSmp.rgb;
          rampA = rampSmp.a;
          rampChroma = max(rampCol.r, max(rampCol.g, rampCol.b)) - min(rampCol.r, min(rampCol.g, rampCol.b));
          rampChromaInv = 1.0 - rampChroma;

          float viewRampU = dot(N, camFwd) * 0.5 + 0.5;
          float4 viewRampSmp = textureLod(_RampMap, float2(viewRampU, 0.5), 0.0);
          viewRampA = viewRampSmp.a;
      } else {
          rampCol = float3(1.0);
          rampA = saturate(modNdotL * 0.5 + 0.5);
          rampChroma = 0.0;
          rampChromaInv = 1.0;
          viewRampA = 0.0;
      }

      // ---- Shadow terms (charShadow=1: minShadow 不乘 castShadow) ----
      float castShadow = lerp(smoothstep(0.0, 1.0, mainLightShadowAtten), 1.0, _CharacterParams1.z);
      float charShadowMask = shadowMask;
      float minShadow = min(rampA, shadowMask) * 1.0;
      float viewShadowProduct = viewRampA * charShadowMask;

      // ==== NPR DIFFUSE COMPOSITION ====
      float3 albScaled = shadowDiff * _CharacterParams0.z;
      float nprNdotL = saturate(dot(N, _CharacterParams6.xyz) + _CharacterParams7.x) * _CharacterParams7.y + _CharacterParams7.z;
      float shadowStr = minShadow * _CharacterParams1.y;
      float3 shadAmb = nprNdotL * (shadowStr * (1.0 - ambCol) + ambCol);

      float bright065 = min(ambInt * 0.35 + 0.65, 1.5);
      float brightFull = clamp(ambInt, 0.0, 1.5);
      float brightMix = lerp(bright065, clamp(ambInt, 1.25, 1.75), _CharacterParams1.x);
      float3 brightAmb = brightMix * shadAmb * _CharacterParams0.w;
      float lightLum = dot(blendedLightCol * blendedLightInt, LUM);

      float oneMinus12y = 1.0 - _CharacterParams12.y;
      float3 lightBlend = blendedLightCol * _CharacterParams12.y + oneMinus12y;
      float3 fullDiff;
      fullDiff.r = (shadAmb.r * brightFull * lightBlend.r + minShadow * (blendedLightCol.r * blendedLightInt - lightLum) + lightLum) * _CharacterParams0.y;
      fullDiff.g = (shadAmb.g * brightFull * lightBlend.g + minShadow * (blendedLightCol.g * blendedLightInt - lightLum) + lightLum) * _CharacterParams0.y;
      fullDiff.b = (shadAmb.b * brightFull * lightBlend.b + minShadow * (blendedLightCol.b * blendedLightInt - lightLum) + lightLum) * _CharacterParams0.y;

      float albScaledLum = dot(albScaled * 0.65, LUM);
      float3 desatShad = (albScaled * 0.65 - albScaledLum) * 1.2 + albScaledLum;

      float combWeight = saturate(viewShadowProduct + rampA);
      float3 weightedAmb = lerp(desatShad, albScaled, combWeight);
      float3 shadowBlended = lerp(weightedAmb, diffColor, minShadow);

      float3 rampTinted = shadowBlended * (rampCol * rampChroma + rampChromaInv);

      float3 viewDepShad = viewShadowProduct * ((diffColor - diffColorLum) * 1.2 + diffColorLum - albScaled) + albScaled;

      float shadowLumVal = dot(shadowBlended, LUM);
      float rampLumVal = dot(rampTinted, LUM);
      float lumRatio = clamp(shadowLumVal / max(rampLumVal, 0.001), 0.0, 1.5);

      float3 nprDiff = rampTinted * lumRatio;

      float ambDiffInt = minShadow * (1.0 - _CharacterParams0.z) + _CharacterParams0.z;
      float specAmbInt = ambDiffInt * (minShadow * 0.5 + 0.5);

      // ==== KAJIYA-KAY ANISOTROPIC SPECULAR ====
      float anisoShift1;
      float anisoShift2;
      if (u_StrokeOn) {
          float2 strokeUV = uv * _StrokeMap_ST.xy + _StrokeMap_ST.zw;
          float strokeVal = texture(_StrokeMap, strokeUV).r * 2.0 - 1.0;
          anisoShift1 = strokeVal * _StrokeScale + _AnisotropyValue * 2.0 - 1.0;
          anisoShift2 = strokeVal * _StrokeScale + _AnisotropyValue2 * 2.0 - 1.0;
      } else {
          anisoShift1 = _AnisotropyValue * 2.0 - 1.0;
          anisoShift2 = _AnisotropyValue2 * 2.0 - 1.0;
      }

      float3 shiftedT1 = normalize(specN * anisoShift1 + modBitan);

      float3 worldContrib = otwCol0 * vDotC0 + otwCol1 * adjustedLightDir.y + otwCol2 * vDotC2;
      float3 modL = adjustedLightDir + worldContrib * 2.0;
      float3 H = normalize(normalize(modL) + V);

      float TdotH1 = dot(shiftedT1, H);
      float sinTH1 = max(sqrt(1.0 - TdotH1 * TdotH1), 0.0001);
      float strand1 = saturate(specScale * exp2(log2(sinTH1) * 200.0));

      float edgeFade2 = edgeFade * edgeFade;
      float3 strand1Spec;
      if (u_UseSpecRamp) {
          float specRampV = edgeFade2 * ((TdotH1 > 0.0) ? 1.0 : 0.0);
          float3 specRampSmp = textureLod(_SpecRampMap, float2(strand1, specRampV), 0.0).rgb;
          strand1Spec = edgeFade * (strand1 * specRampSmp);
      } else {
          strand1Spec = float3(1.0) * (edgeFade * strand1);
      }
      float strand1Max = max(strand1Spec.r, max(strand1Spec.g, strand1Spec.b));

      float3 shiftedT2 = normalize(specN * anisoShift2 + modBitan);
      float TdotH2 = dot(shiftedT2, H);
      float sinTH2 = max(sqrt(1.0 - TdotH2 * TdotH2), 0.0001);
      float strand2Exp = trunc(max(1.0 - _AnisotropyRange2, 0.0) * 200.0);
      float strand2Raw = edgeFade * exp2(log2(sinTH2) * strand2Exp);
      float3 strand2Spec = darkenedScale * (strand2Raw * (smoothness * _AnisotropyColor2.rgb));

      // ==== SPECULAR LINE ====
      float lineMod = 1.0;
      if (u_SpecularLine) {
          float2 lineUV = uv * _LineMap_ST.xy + _LineMap_ST.zw;
          float lineMapVal = texture(_LineMap, lineUV).x;

          float lineShift = _LineValue * 2.0 - 1.0;
          float3 shiftedTL = normalize(specN * lineShift + modBitan);
          float TdotHL = dot(shiftedTL, H);
          float sinTHL = max(sqrt(1.0 - TdotHL * TdotHL), 0.0001);

          float procLine = ceil(max(frac(uv.x * _LineAmount) - 0.5, 0.0));
          float lineBlend = (_UseLineMap * (-procLine + (1.0 - lineMapVal)) + procLine) * _LineIntensity + (1.0 - _LineIntensity);

          float lineExp = trunc(max(1.0 - _LineRange, 0.0) * 200.0);
          lineMod = specScale * ((lineBlend + (1.0 - lineBlend) * strand1Max - 1.0) * exp2(log2(sinTHL) * lineExp)) + 1.0;
      }

      // ==== MAIN LIT COMPOSITION ====
      float alphaPremul = mad(baseAlpha, _AlphaPremultiply, 1.0 - _AlphaPremultiply);
      float3 mainLit = fullDiff * nprDiff * alphaPremul;
      float3 lineSatLit = lineMod * mainLit;
      float lineSatLitLum = dot(lineSatLit, LUM);
      float lineSatFactor = lineMod * (1.0 - _LineSaturation) + _LineSaturation;
      float3 diffContrib = (lineSatFactor * (lineSatLit - lineSatLitLum) + lineSatLitLum);

      float3 anisoSpec;
      anisoSpec.r = darkenedScale * ((dielSpec * strand1Spec.r) * _AnisotropyIntensity) * 5.0 + lerp(strand2Spec.r, 0.0, strand1Max);
      anisoSpec.g = darkenedScale * ((dielSpec * strand1Spec.g) * _AnisotropyIntensity) * 5.0 + lerp(strand2Spec.g, 0.0, strand1Max);
      anisoSpec.b = darkenedScale * ((dielSpec * strand1Spec.b) * _AnisotropyIntensity) * 5.0 + lerp(strand2Spec.b, 0.0, strand1Max);
      float3 specContrib = (specAmbInt * fullDiff) * anisoSpec * _CharacterParams13.w;

      float3 combined = diffContrib + specContrib;
      float combinedLum = dot(combined, LUM);
      float desatAmt = clamp(combinedLum - 0.5, 0.0, 0.5);

      // ==== SKIN SPECULAR CP8/CP9 ([H11] 深度边缘 → f_HairDepthEdgeMask) ====
      float cp9x = _CharacterParams9.x;
      float cp9y = _CharacterParams9.y;
      float3 skinDir;
      skinDir.x = -cp9y * camFwd.z;
      skinDir.y = camFwd.z * cp9x;
      skinDir.z = camFwd.x * cp9y - cp9x * camFwd.y;
      skinDir = normalize(skinDir);

      float depthSmooth = f_HairDepthEdgeMask; // [H11] SP 无场景深度

      float skinNdotL = min(charShadowMask, min(shadowMask, saturate(dot(flatDir, skinDir) + 1.0)));
      float skinNdotBN = saturate(dot(skinDir, N));

      float3 skinSpec;
      skinSpec.r = skinNdotL * ((depthSmooth * _CharacterParams8.x) * _CharacterParams8.w) * skinNdotBN * (_CharacterParams9.z * (diffColor.r - 0.25) + 0.25);
      skinSpec.g = skinNdotL * ((depthSmooth * _CharacterParams8.y) * _CharacterParams8.w) * skinNdotBN * (_CharacterParams9.z * (diffColor.g - 0.25) + 0.25);
      skinSpec.b = skinNdotL * ((depthSmooth * _CharacterParams8.z) * _CharacterParams8.w) * skinNdotBN * (_CharacterParams9.z * (diffColor.b - 0.25) + 0.25);

      // ==== SUBSURFACE SPECULAR ====
      float mainNdotL_xz = dot(float3(adjXZ_x, adjXZLen * NEAR_ZERO_Y, adjXZ_z), N);
      float wrapNdotL = saturate(0.5 + mainNdotL_xz - 0.5 * mainNdotL_xz * mainNdotL_xz);
      float camLightFacing = (1.0 - _CharacterParams12.x) * camLightDot;
      float VdotN = dot(V, N);
      float edgeT2 = saturate((-abs(VdotN) + 0.4) * 5.0);
      float edgeFresnel = edgeT2 * edgeT2 * (3.0 - 2.0 * edgeT2);
      float brightT = saturate((diffColorLum - 0.1) * (-16.6667));
      float brightnessGate = brightT * brightT * (3.0 - 2.0 * brightT);
      float3 subsurfLight = blendedLightCol * blendedLightInt;
      float3 subsurfSpec = brightnessGate * (shadowMask * (edgeFresnel * (camLightFacing * (wrapNdotL * subsurfLight)))) * max(diffColor, 0.15);

      // ==== FINAL ASSEMBLY ====
      float desatFactor = desatAmt * desatAmt + 1.0;
      float3 desatCombined = desatFactor * (combined - combinedLum) + combinedLum;
      float3 litColor = desatCombined + skinSpec + subsurfSpec;

      // ==== VFX COLOR ADJUSTMENT ====
      if (_EnableVFXColorAdjustment > 0.5) {
          float NdotV_spec = saturate(dot(N, V));
          float litLum = dot(litColor, LUM);
          float3 adjusted;
          adjusted.r = _ColorAdjustmentContrast * (lerp(litLum, litColor.r, _ColorAdjustmentSaturation) - 0.5) + 0.5;
          adjusted.g = _ColorAdjustmentContrast * (lerp(litLum, litColor.g, _ColorAdjustmentSaturation) - 0.5) + 0.5;
          adjusted.b = _ColorAdjustmentContrast * (lerp(litLum, litColor.b, _ColorAdjustmentSaturation) - 0.5) + 0.5;
          float caRimT = saturate((_ColorAdjustmentRimWidth - NdotV_spec) / max(_ColorAdjustmentRimWidth, 1e-5));
          float caRimSmooth = caRimT * caRimT * (3.0 - 2.0 * caRimT);
          float3 caBrightened = adjusted * _ColorAdjustmentBrightness;
          litColor = lerp(caBrightened, _ColorAdjustmentColorBlend.rgb, _ColorAdjustmentColorBlend.w)
                   + caRimSmooth * _ColorAdjustmentRimColor.rgb * _ColorAdjustmentRimIntensity;
      }

      float3 finalColor = litColor / _ExposureParams.x;
      return finalColor;
  }
//- }

//----------------------------------------------------------------------region Part 4 Fur — HGRP_CharacterNPR_Fur_Fix.shader frag 逐行移植
//- {
  // [H10] 壳层挤出为顶点级多层网格 (UV1.x=层号), SP 不可能 → f_FurShellIdx 预览单壳层。
  // FurDirMap/FurMap/FurDyeMap = 贴图参数 (RGBA 完整 / 需 ST 偏移采样)。
  // Fur 源没有 Shadow LUT 选项 — 阴影色固定走 亮度/饱和度。
  // 反射: HGRP Fur 用 URP 探针 unity_SpecCube0 → SP 环境 envSampleLOD ([H6])。
  float3 shadeFur(V2F inputs, float3 positionWS, float3 normalWS_raw, float4 tangentWS, float faceSign, float3 albedoIn, out float shellAlphaOut) {
      float shellIdx = f_FurShellIdx;
      float2 uv = GetBaseUV(inputs);

      // ---- Object-to-World origin ([H4]) ----
      float originX = 0.0;
      float originZ = 0.0;

      // ---- View direction ----
      float3 V = normalize(camera_pos - positionWS);

      // ---- Base color ----
      float3 albedo = albedoIn;

      // ---- Fur Dye (screen blend) ----
      if (u_FurDyeEnable) {
          float2 dyeUV = float2(
              mad((uv.x - _BaseMap_ST.z) / max(0.001, abs(_BaseMap_ST.x)), _FurDyeMap_ST.x, _FurDyeMap_ST.z),
              mad((uv.y - _BaseMap_ST.w) / max(0.001, abs(_BaseMap_ST.y)), _FurDyeMap_ST.y, _FurDyeMap_ST.w)
          );
          float3 dyeSmp = SRGBToLinear3(texture(_FurDyeMap, dyeUV).rgb); // sRGBTexture=1
          float3 screenBlend = 1.0 - (1.0 - albedo) * (1.0 - dyeSmp);
          albedo = lerp(albedo, screenBlend, _FurDyeIntensity);
      }

      // ---- MetallicGlossMap ([H1]) ----
      float metallic, specScale, shadowMask, smoothness;
      SampleRMOS(inputs, metallic, specScale, shadowMask, smoothness);
      float roughnessRaw = 1.0 - smoothness;

      // ---- Shadow color (Fur: 仅亮度/饱和度) ----
      float3 shadBright = albedo * _ShadowColorBrightness;
      float shadLum = dot(shadBright, LUM);
      float3 shadowColor = _ShadowColorSaturation * (shadBright - shadLum) + shadLum;

      // ---- Normal map (保留 nrmZ_raw 给毛皮 AO) ----
      float nrmZ_raw = 1.0;
      float3 N;
      if (u_UseBumpMap) {
          float3 tsN = getTSNormal(inputs.sparse_coord); // [H8]
          float nrmX_raw = tsN.x;
          float nrmY_raw = tsN.y;
          nrmZ_raw = max(sqrt(1.0 - saturate(nrmX_raw * nrmX_raw + nrmY_raw * nrmY_raw)), 1e-16);
          float nrmX = nrmX_raw * _BumpScale;
          float nrmY = nrmY_raw * _BumpScale;
          float3 nrmWS = normalize(normalWS_raw);
          float3 tanWS = normalize(tangentWS.xyz);
          float3 bitWS = cross(nrmWS, tanWS) * tangentWS.w;
          N = faceSign * normalize(nrmX * tanWS + nrmY * bitWS + nrmZ_raw * nrmWS);
      } else {
          N = faceSign * normalize(normalWS_raw);
      }

      // ---- FurDirMap (sampler 参数, rgba 完整; HGRP 在 ST 后 uv 采样) ----
      float4 furDirSmp = SampleSRGBTex(_FurDirMap, uv); // sRGBTexture=1

      // ---- FurMap sampling ----
      float furShellNoise = (frac(sin(dot(float2(shellIdx, shellIdx), float2(12.9898, 78.233))) * 43758.5469) * 2.0 - 1.0) * _FurNoise * 0.05;
      float2 furDirOffset = float2(
          (furDirSmp.x * 2.0 - 1.0) * _FurDirMapEnable * 0.005 + furShellNoise,
          (furDirSmp.y * 2.0 - 1.0) * _FurDirMapEnable * 0.005 + furShellNoise
      );
      // FurMap UV: 各向同性平铺 (_FurMap_ST.x 用于双轴)
      float2 furSampleUV = float2(
          (uv.x - shellIdx * furDirOffset.x) * _FurMap_ST.x + _FurMap_ST.z,
          (uv.y - shellIdx * furDirOffset.y) * _FurMap_ST.x + _FurMap_ST.w
      );
      float furSample = texture(_FurMap, furSampleUV).x;
      float furDirZ = furDirSmp.z;

      // ---- Fur cutoff + alpha ----
      float cutoff = shellIdx * (_FurCutoffEnd - _FurCutoffStart) + _FurCutoffStart;
      float cutoffSharp = lerp(cutoff, sqrt(cutoff), _FurSharpen);
      float cutLo = max(cutoffSharp - 0.25, 0.0);
      float cutHi = min(cutoffSharp + 0.25, 1.0);
      float furRaw = saturate((furDirZ * furSample - cutLo) / (cutHi - cutLo));
      float furSmooth = furRaw * furRaw * (3.0 - 2.0 * furRaw);

      float isBase = (shellIdx <= 0.01) ? 1.0 : 0.0;
      float furAlphaRaw = isBase * (1.0 - furSmooth) + furSmooth;
      float3 geomN = normalize(normalWS_raw);
      float edgeFactor = (1.0 - shellIdx * shellIdx * shellIdx) + dot(geomN, V) - _FurEdgeFade;
      float shellAlpha = ceil(shellIdx) * (saturate(furAlphaRaw * edgeFactor) - 1.0) + 1.0;
      shellAlphaOut = shellAlpha; // clip(shellAlpha - 0.003) 由 shade() 执行

      // ---- Fur AO ----
      float nrmZ2 = min(nrmZ_raw * 2.0, 1.0);
      float nrmZ2sq = nrmZ2 * nrmZ2;
      float furAO = shellIdx * (1.0 - nrmZ2sq * _FurAO) + nrmZ2sq * _FurAO;
      float furShadowMask = furAO * shadowMask;

      // ---- Character VFX Special: 采样 + Fresnel ([H12] _Time.y → f_VFXTime) ----
      float4 vfxBlendSmp = float4(0.0);
      float vfxTexAlpha = 0.0;
      float3 vfxMainRGB = float3(0.0);
      float vfxFresnelFlipped = 0.0;
      float vfxAlphaBase = 0.0;
      float vfxDissolveDelta = 0.0;
      float vfxDissolveEdge = 0.0;
      if (u_EnableCharacterVFX) {
          float vfxTime = f_VFXTime;

          float2 vfxBlendUV = float2(
              mad(mad(_VFXSpecialParam.z, vfxTime, uv.x), _VFXSpecialBlendTex_ST.x, _VFXSpecialBlendTex_ST.z),
              mad(mad(_VFXSpecialParam.w, vfxTime, uv.y), _VFXSpecialBlendTex_ST.y, _VFXSpecialBlendTex_ST.w)
          );
          vfxBlendSmp = SampleSRGBTex(_VFXSpecialBlendTex, vfxBlendUV); // sRGBTexture=1

          float2 vfxDistortUV = uv + vfxBlendSmp.r * _VFXSpecialBlendTexRForDisturb;
          float2 vfxMainUV = float2(
              mad(mad(_VFXSpecialParam.x, vfxTime, vfxDistortUV.x), _VFXSpecialMainTex_ST.x, _VFXSpecialMainTex_ST.z),
              mad(mad(_VFXSpecialParam.y, vfxTime, vfxDistortUV.y), _VFXSpecialMainTex_ST.y, _VFXSpecialMainTex_ST.w)
          );
          float4 vfxMainSmp = SampleSRGBTex(_VFXSpecialMainTex, vfxMainUV); // sRGBTexture=1

          vfxTexAlpha = lerp(vfxMainSmp.a, vfxMainSmp.r, _UseVFXMainTexAsAlpha);
          vfxMainRGB = lerp(vfxMainSmp.rgb, float3(1.0), _UseVFXMainTexAsAlpha);

          float3 vfxGeomN = normalize(normalWS_raw);
          float vfxFresnel = exp2(log2(saturate(dot(V, vfxGeomN) + _VFXFresnelBias)) * _VFXFresnelPower);
          vfxFresnelFlipped = lerp(1.0 - vfxFresnel, vfxFresnel, _VFXFresnelFlip);

          vfxAlphaBase = _VFXColorAlpha * _VFXColor.a;

          vfxDissolveDelta = vfxBlendSmp.r - (_SpecialDissolveScheduleOffset * 2.02 - 1.01);
          vfxDissolveEdge = saturate(-vfxDissolveDelta);
      }

      // ---- Flat direction ----
      float fX = positionWS.x - originX;
      float fZ = positionWS.z - originZ;
      float fLen = rsqrt(fX * fX + NEAR_ZERO_Y * NEAR_ZERO_Y + fZ * fZ);
      float3 flatDir = float3(fX * fLen, NEAR_ZERO_Y * fLen, fZ * fLen);

      // ---- Exposure / Ambient (CP2) ----
      float exposure = (_CharacterParams12.w * (1.0 - _EnvironmentGlobalParams0.x) + _EnvironmentGlobalParams0.x) * _ExposureParams.x;
      float ambInt = exposure;
      float3 ambCol = _CharacterParams2.xyz;

      // ---- Camera forward ----
      float3 camFwd = GetCamFwd();

      // ---- Metallic workflow ----
      float dielSpec = specScale * 0.04;
      float oneMinusRefl = (1.0 - metallic) * 0.96;
      float3 diffColor = oneMinusRefl * albedo;
      float3 specColor = metallic * (albedo - dielSpec) + dielSpec;
      float3 shadowDiff = oneMinusRefl * shadowColor;

      float roughness = max(roughnessRaw * roughnessRaw, 0.0078125);
      float roughSq4 = roughness * roughness;

      // ---- Main light ([H2][H3]) ----
      float mainLightShadowAtten = 1.0;
      float3 mainLightDir = GetMainLightDir();
      float3 lightCol = v_MainLightColor.rgb;
      float lightInt = 1.0;

      // ---- Adjusted light direction ----
      float3 adjustedLightDir = lerp(mainLightDir, _CharacterParams11.xyz, _CharacterParams1.w);
      float adjXZLen = rsqrt(adjustedLightDir.x * adjustedLightDir.x + adjustedLightDir.z * adjustedLightDir.z + NEAR_ZERO_Y * NEAR_ZERO_Y);
      float adjXZ_x = adjXZLen * adjustedLightDir.x;
      float adjXZ_z = adjXZLen * adjustedLightDir.z;

      // ---- Light color blend (CP5) ----
      float3 blendedLightCol = lerp(lightCol, _CharacterParams5.xyz, _CharacterParams12.y);
      float blendedLightInt = lerp(lightInt, 1.0, _CharacterParams12.w);

      // ---- Camera-light facing ----
      float cfXZLen = rsqrt(camFwd.x * camFwd.x + camFwd.z * camFwd.z);
      float camLightDot = saturate(-(adjXZ_x * (cfXZLen * camFwd.x) + adjXZ_z * (cfXZLen * camFwd.z)));
      float camYFade = saturate(2.0 * (0.75 - abs(camFwd.y)));
      float camYSmooth = camYFade * camYFade * (3.0 - 2.0 * camYFade);

      // ==== FUR NdotL MODIFICATION ====
      float geomNdotL = dot(N, adjustedLightDir);
      float furInv = saturate((1.0 - furSample) * 1.4286);
      float furInvSmooth = furInv * furInv * (3.0 - 2.0 * furInv);
      float furTT = furInvSmooth * camLightDot * _FurNoise * (1.15 - _FurTTIntensity) + _FurTTIntensity;
      float furModNdotL = clamp(furTT * shellIdx + geomNdotL, -1.0, 1.0);

      // ==== DIFFUSE RAMP (fur-modified NdotL) ====
      float wrapAdd = 0.5 - 0.5 * furModNdotL * furModNdotL;
      float camFadeFactor = (1.0 - _CharacterParams12.x) * (camLightDot * camYSmooth);
      float modNdotL = camFadeFactor * wrapAdd + furModNdotL;
      float3 rampCol; float rampA; float rampChroma; float rampChromaInv; float viewRampA;
      if (u_UseDiffRamp) {
          float rampInput = clamp(_CharacterParams11.w * _CharacterParams12.x + modNdotL, -1.0, 1.0) * 0.5 + 0.5;
          float4 rampSmp = textureLod(_RampMap, float2(rampInput, 0.5), 0.0);
          rampCol = rampSmp.rgb;
          rampA = rampSmp.a;
          rampChroma = max(rampCol.r, max(rampCol.g, rampCol.b)) - min(rampCol.r, min(rampCol.g, rampCol.b));
          rampChromaInv = 1.0 - rampChroma;

          float viewRampU = dot(N, camFwd) * 0.5 + 0.5;
          float4 viewRampSmp = textureLod(_RampMap, float2(viewRampU, 0.5), 0.0);
          viewRampA = viewRampSmp.a;
      } else {
          rampCol = float3(1.0);
          rampA = saturate(modNdotL * 0.5 + 0.5);
          rampChroma = 0.0;
          rampChromaInv = 1.0;
          viewRampA = 0.0;
      }

      // ---- Shadow terms (charShadow=1, furShadowMask) ----
      float castShadow = lerp(smoothstep(0.0, 1.0, mainLightShadowAtten), 1.0, _CharacterParams1.z);
      float minShadow = min(rampA, furShadowMask) * castShadow;
      float viewShadowProduct = viewRampA * furShadowMask;

      // ==== NPR DIFFUSE COMPOSITION ====
      float3 albScaled = shadowDiff * _CharacterParams0.z;
      float diffColorLum = dot(diffColor, LUM);

      float nprNdotL = saturate(dot(N, _CharacterParams6.xyz) + _CharacterParams7.x) * _CharacterParams7.y + _CharacterParams7.z;
      float shadowStr = minShadow * _CharacterParams1.y;

      float3 shadAmb = nprNdotL * (shadowStr * (1.0 - ambCol) + ambCol);

      float bright065 = min(ambInt * 0.35 + 0.65, 1.5);
      float brightFull = clamp(ambInt, 0.0, 1.5);
      float brightMix = lerp(bright065, clamp(ambInt, 1.25, 1.75), _CharacterParams1.x);
      float3 brightAmb = brightMix * shadAmb * _CharacterParams0.w;

      float lightLum = dot(blendedLightCol * blendedLightInt, LUM);
      float oneMinus12y = 1.0 - _CharacterParams12.y;
      float3 lightBlend = blendedLightCol * _CharacterParams12.y + oneMinus12y;
      float3 fullDiff;
      fullDiff.r = (shadAmb.r * brightFull * lightBlend.r + minShadow * (blendedLightCol.r * blendedLightInt - lightLum) + lightLum) * _CharacterParams0.y;
      fullDiff.g = (shadAmb.g * brightFull * lightBlend.g + minShadow * (blendedLightCol.g * blendedLightInt - lightLum) + lightLum) * _CharacterParams0.y;
      fullDiff.b = (shadAmb.b * brightFull * lightBlend.b + minShadow * (blendedLightCol.b * blendedLightInt - lightLum) + lightLum) * _CharacterParams0.y;

      float albScaledLum = dot(albScaled * 0.65, LUM);
      float3 desatShad = (albScaled * 0.65 - albScaledLum) * 1.2 + albScaledLum;

      float combWeight = saturate(viewShadowProduct + rampA);
      float3 weightedAmb = lerp(desatShad, albScaled, combWeight);
      float3 shadowBlended = lerp(weightedAmb, diffColor, minShadow);

      float3 viewDepShad = viewShadowProduct * ((diffColor - diffColorLum) * 1.2 + diffColorLum - albScaled) + albScaled;

      float3 rampTinted = shadowBlended * (rampCol * rampChroma + rampChromaInv);

      float shadowLum = dot(shadowBlended, LUM);
      float rampLum = dot(rampTinted, LUM);
      float lumRatio = clamp(shadowLum / max(rampLum, 0.001), 0.0, 1.5);

      float3 nprDiff = rampTinted * lumRatio;

      float ambDiffInt = minShadow * (1.0 - _CharacterParams0.z) + _CharacterParams0.z;
      float specAmbInt = ambDiffInt * (minShadow * 0.5 + 0.5);

      // ==== GGX SPECULAR ====
      float NdotV_spec = saturate(dot(N, V));
      float mainLightY = adjustedLightDir.y;
      float3 camFwdMod = normalize(float3(camFwd.x, mainLightY, camFwd.z));
      float3 H = normalize(V * 3.0 + adjustedLightDir + camFwdMod * 2.0);
      float NdotH = dot(N, H);
      float roughSq = roughness * roughness;
      float denom = (NdotH * roughSq - NdotH) * NdotH + 1.0;
      float denomSq = denom * denom;
      float D_raw = (denomSq != roughSq) ? roughSq / denomSq : 1.0;
      float ggxTerm = clamp(D_raw * 0.5 / (NdotV_spec * 2.0 + roughness + 1e-4) - NEAR_ZERO_Y, 0.0, 20.0);

      // ---- Spec Ramp ----
      float3 specRampColor = specColor;
      float3 specRampEnv = specColor;
      if (u_UseSpecRamp) {
          float specRampPartial = D_raw * (roughSq4 + 1e-4);
          float specRampU = lerp(specRampPartial, NdotV_spec * NdotV_spec, _SpecRampIridescentMode);
          float specRampV = (1.0 - metallic) * roughnessRaw;
          float3 specRampSmp = textureLod(_SpecRampMap, float2(specRampU, specRampV), 0.0).rgb;
          specRampColor = specColor * specRampSmp;
          specRampEnv = lerp(specColor, specRampColor, _SpecRampIridescentMode);
      }

      // AlphaPremultiply
      float alphaPremul = shellAlpha * _AlphaPremultiply + (1.0 - _AlphaPremultiply);

      // Main lit composition
      float3 mainLit = fullDiff * nprDiff * alphaPremul + (specAmbInt * fullDiff) * (ggxTerm * specRampColor) * _CharacterParams13.w;
      float mainLitLum = dot(mainLit, LUM);
      float desatAmt = clamp(mainLitLum - 0.5, 0.0, 0.5);

      // ==== SKIN SPECULAR CP8/CP9 ====
      float cp9x = _CharacterParams9.x;
      float cp9y = _CharacterParams9.y;
      float3 skinDir;
      skinDir.x = -cp9y * camFwd.z;
      skinDir.y = camFwd.z * cp9x;
      skinDir.z = camFwd.x * cp9y - cp9x * camFwd.y;
      skinDir = normalize(skinDir);

      float skinFresnel = 1.0 - abs(dot(V, N));
      float skinLow = _CharacterParams9.w * (-0.6) + 0.8;
      float skinHigh = _CharacterParams9.w * (-0.4) + 0.9;
      float skinT = saturate((skinFresnel - skinLow) / (skinHigh - skinLow));
      float skinSmooth = skinT * skinT * (3.0 - 2.0 * skinT);
      float skinNdotL = saturate(dot(flatDir, skinDir) + 1.0);
      float skinShadow = min(furShadowMask, skinNdotL);
      float skinNdotBN = saturate(dot(skinDir, N));

      float3 skinSpec;
      skinSpec.r = skinShadow * skinSmooth * _CharacterParams8.x * _CharacterParams8.w * skinNdotBN * (_CharacterParams9.z * (diffColor.r - 0.25) + 0.25);
      skinSpec.g = skinShadow * skinSmooth * _CharacterParams8.y * _CharacterParams8.w * skinNdotBN * (_CharacterParams9.z * (diffColor.g - 0.25) + 0.25);
      skinSpec.b = skinShadow * skinSmooth * _CharacterParams8.z * _CharacterParams8.w * skinNdotBN * (_CharacterParams9.z * (diffColor.b - 0.25) + 0.25);

      // ==== SUBSURFACE SPECULAR ====
      float mainNdotL_xz = dot(float3(adjXZ_x, adjXZLen * NEAR_ZERO_Y, adjXZ_z), N);
      float wrapNdotL = saturate(0.5 + mainNdotL_xz - 0.5 * mainNdotL_xz * mainNdotL_xz);
      float camLightFacing = (1.0 - _CharacterParams12.x) * camLightDot;
      float edgeT = saturate((-abs(dot(V, N)) + 0.4) * 5.0);
      float edgeFresnel = edgeT * edgeT * (3.0 - 2.0 * edgeT);
      float brightT = saturate((0.1 - diffColorLum) * 16.666);
      float brightnessGate = (brightT * brightT) * (3.0 - 2.0 * brightT);
      float3 subsurfLight = blendedLightCol * blendedLightInt;
      float3 subsurfSpec = brightnessGate * furShadowMask * edgeFresnel * camLightFacing * wrapNdotL * subsurfLight * max(diffColor, 0.15);

      // ==== CUBEMAP REFLECTION (URP 探针 → SP 环境 [H6]) ====
      float3 reflDir = reflect(-V, N);
      float cubeMip = log2(max(roughnessRaw, 0.001)) * 1.2 + 5.0;
      float3 cubeSample = envSampleLOD(reflDir, cubeMip).rgb;

      float dfgX, dfgY;
      ComputeEnvBRDF(NdotV_spec, roughness, dfgX, dfgY);
      float3 envBRDF = specRampEnv * dfgX + dfgY;
      float totalRefl = dfgX + dfgY;
      float reflBoost = (1.0 - totalRefl) / max(totalRefl, 1e-6);

      float cubeAmbInt = ambDiffInt * (clamp(exposure, 0.5, 1.5) * _CharacterParams0.w);
      float3 cubeRefl = cubeSample * envBRDF * (1.0 + reflBoost * specRampEnv);
      float3 cubemapContrib = cubeAmbInt * cubeRefl * ambCol;

      // ==== FINAL ASSEMBLY ====
      float desatFactor = desatAmt * desatAmt + 1.0;
      float3 desatMainLit = desatFactor * (mainLit - mainLitLum) + mainLitLum;

      float3 finalColor = desatMainLit + skinSpec + subsurfSpec + cubemapContrib;

      // ---- Character VFX Special: additive color ----
      if (u_EnableCharacterVFX) {
          float vfxBlendFactor = saturate((vfxAlphaBase * vfxTexAlpha + vfxBlendSmp.a) * _VFXBlendTint.a);
          float3 vfxColorTerm = _VFXColorIntensity * _VFXColor.rgb * vfxMainRGB;
          float3 vfxTintTerm = _VFXBlendTint.rgb * _VFXColorIntensity;
          float vfxTintWeight = saturate(vfxBlendFactor * dot(vfxBlendSmp.rgb, float3(0.333)));
          float3 vfxMainColor = lerp(vfxColorTerm, vfxTintTerm, vfxTintWeight);
          float3 vfxDissolvedColor = lerp(vfxMainColor, vfxDissolveEdge * _VFXFresnelColor.rgb * _VFXColorIntensity, vfxDissolveEdge);
          float vfxFresnelAlpha = vfxFresnelFlipped * _VFXFresnelColor.a;
          float vfxDissolveVis = saturate(vfxDissolveDelta);
          float vfxOpacity = saturate(vfxDissolveVis * vfxAlphaBase * vfxTexAlpha)
                           * lerp(1.0, vfxFresnelFlipped, _VFXFresnelAffectOpacity);
          float3 vfxContrib = vfxOpacity * lerp(vfxDissolvedColor, _VFXFresnelColor.rgb, vfxFresnelAlpha);
          finalColor += vfxContrib * alphaPremul;
      }

      finalColor /= _ExposureParams.x;
      return finalColor;
  }
//- }

//----------------------------------------------------------------------region Part 6 VFX — HGRP_CharacterNPR_VFX_Fix.shader frag 逐行移植
//- {
  // [H12] SP 限制: 顶点色=白 / uv1=uv0 / 粒子 CustomData=0 / _Time.y=f_VFXTime /
  //       顶点相机偏移 _VertCameraOffset 为顶点级跳过 / 混合状态固定 over (Additive 无法逐实例切)。
  // UV 流水线 (computeVFXUV) 逐行复制; RotateMat 由角度参数现算 (数学同 Unity 端预计算矩阵)。
  float2 ComputeVFXUV(float2 uv0, float2 uv1, float4 speed,
                      float time, float customData, float rotDeg, float4 st,
                      float2 disturb, float useDisturb)
  {
      float2 uv = uv0 * 1.0 + uv1 * 0.0; // [H12] weights=(1,0): SP 无 UV1
      uv += speed.xy * time + speed.zw * customData;
      float rad = radians(rotDeg);
      float c = cos(rad);
      float s = sin(rad);
      float2 cc = uv - 0.5;
      uv.x = cc.x * c + cc.y * (-s) + 0.5;
      uv.y = cc.x * s + cc.y * c + 0.5;
      uv = uv * st.xy + st.zw;
      uv += disturb * useDisturb;
      return uv;
  }

  float3 shadeVFX(V2F inputs, float3 positionWS, float3 normalWS_raw, float4 tangentWS, bool isFrontFace, out float outAlpha) {
      float time = f_VFXTime;

      float custom1X = 0.0; // [H12]
      float custom1Y = 0.0; // [H12]
      float2 uv0 = inputs.sparse_coord.tex_coord; // VFX 用 raw texcoord0 (HGRP 不乘 _BaseMap_ST)
      float2 uv1 = uv0;     // [H12]
      float4 vertColor = float4(1.0); // [H12]

      // ==== DISTURB ====
      float2 disturb = float2(0.0);
      if (u_VFXUseDisturb) {
          float2 disturbUV = ComputeVFXUV(uv0, uv1, _DisturbUVSpeed1,
                                          time, custom1Y, _DisturbUVRotate1,
                                          _VFXDisturbTex_ST, float2(0.0), 0.0);
          float4 disturbSample = SampleSRGBTex(_VFXDisturbTex, disturbUV); // sRGBTexture=1
          float biDisturb = mad(disturbSample.x, 1.0 + _Bi_Disturb, -_Bi_Disturb);
          bool isNormalMode = (0.0 != _DisturbTex1Normal);
          disturb.x = isNormalMode
              ? mad(biDisturb * disturbSample.w, 2.0, -1.0) * _DisturbUIntensity1
              : biDisturb * _DisturbUIntensity1;
          disturb.y = isNormalMode
              ? mad(disturbSample.y, 2.0, -1.0) * _DisturbUIntensity1
              : biDisturb * _DisturbVIntensity1;
      }

      // ==== MAIN TEX ====
      float2 mainUV = ComputeVFXUV(uv0, uv1, _MainTexUVSpeed,
                                   time, custom1X, _MainTexUVRotate,
                                   _VFXMainTex_ST, disturb, _MainTexUseDisturb);
      float4 mainSample = SampleSRGBTex(_VFXMainTex, mainUV); // sRGBTexture=1

      float mainAlpha = lerp(mainSample.a, mainSample.r, _UseMainTexAsAlpha);
      float baseAlpha = vertColor.a * _TintColor.a * _TintColorAlpha * mainAlpha; // _DisableVertColor 语义=白 [H12]

      // ==== MASK ====
      float maskAlpha = 1.0;
      float3 maskColorFactor = float3(1.0);
      if (u_VFXUseMask) {
          float2 maskUV = ComputeVFXUV(uv0, uv1, _MaskTexUVSpeed,
                                       time, custom1Y, _MaskTexUVRotate,
                                       _VFXMaskTex_ST, disturb, _MaskTexUseDisturb);
          float4 maskSample = SampleSRGBTex(_VFXMaskTex, maskUV); // sRGBTexture=1
          maskAlpha = lerp(maskSample.a, maskSample.r, _UseMaskTexAsAlpha);
          maskColorFactor = lerp(maskSample.rgb, float3(1.0), _UseMaskTexAsAlpha);
      }

      // ==== BASE COLOR ====
      float3 vcAdj = vertColor.rgb; // [H12]
      float3 mainColorFactor = lerp(mainSample.rgb, float3(1.0), _UseMainTexAsAlpha);
      float3 color = vcAdj * _TintColor.rgb * _TintColorIntensity * mainColorFactor * maskColorFactor;

      // ==== BLEND ====
      float combinedAlpha = baseAlpha * maskAlpha;
      if (u_VFXUseBlend) {
          float2 blendUV = ComputeVFXUV(uv0, uv1, _BlendTexUVSpeed,
                                        time, custom1Y, _BlendTexUVRotate,
                                        _VFXBlendTex_ST, disturb, _BlendTexUseDisturb);
          float4 blendSample = SampleSRGBTex(_VFXBlendTex, blendUV); // sRGBTexture=1
          float blendFactor = saturate((combinedAlpha + blendSample.a) * vertColor.a * _BlendTint.a);
          color += blendFactor * blendSample.rgb * vertColor.rgb * _BlendTint.rgb;
      }

      // ==== NORMAL MAP (DXT5nm 解码, 与源一致 — 贴图请用同布局) ====
      float3 faceNormal = normalize(normalWS_raw);
      if (u_VFXEnableNormalMap) {
          float2 normalUV = ComputeVFXUV(uv0, uv1, _NormalMapUVSpeed,
                                         time, custom1Y, _NormalMapUVRotate,
                                         _VFXNormalMap_ST, disturb, _NormalMapUseDisturb);
          float4 nSample = texture(_VFXNormalMap, normalUV);
          float3 normalTS;
          normalTS.x = nSample.r * nSample.a * 2.0 - 1.0;
          normalTS.y = nSample.g * 2.0 - 1.0;
          normalTS.z = max(sqrt(1.0 - min(dot(normalTS.xy, normalTS.xy), 1.0)), 1e-16);
          normalTS.xy *= _NormalScale;
          normalTS = normalize(normalTS);
          float3 T = normalize(tangentWS.xyz);
          float3 Nv = faceNormal;
          float bSign = (tangentWS.w > 0.0) ? 1.0 : -1.0;
          float3 B = bSign * cross(Nv, T);
          faceNormal = normalize(normalTS.x * T + normalTS.y * B + normalTS.z * Nv);
      }
      faceNormal = isFrontFace ? faceNormal : -faceNormal;

      // ==== FRESNEL ====
      float fresnelTerm = 1.0;
      if (u_VFXUseFresnel) {
          float3 viewDir = normalize(camera_pos - positionWS);
          float NdotV = dot(viewDir, faceNormal) + _FresnelBias;
          float fresnel = pow(saturate(NdotV), _FresnelPower);
          float invFresnel = 1.0 - fresnel;
          fresnelTerm = mad(_FresnelFlip, fresnel - invFresnel, invFresnel);
          float fresnelBlend = fresnelTerm * _FresnelColor.a;
          color = lerp(color, _FresnelColor.rgb, fresnelBlend);
      }

      // ==== EXPOSURE ====
      float exposureScale = mad(_ExposureParams.x, _IgnorePostExposure, 1.0 - _IgnorePostExposure);
      color = clamp(color / exposureScale, 0.0, 1000.0);

      // ==== NEAR CAMERA FADE (视图矩阵第三行) ====
      float nearFade = 1.0;
      if (_UseNearCameraFade != 0.0) {
          float4 viewRow2 = float4(
              uniform_camera_view_matrix[0][2],
              uniform_camera_view_matrix[1][2],
              uniform_camera_view_matrix[2][2],
              uniform_camera_view_matrix[3][2]);
          float dist = abs(dot(viewRow2.xyz, positionWS) + viewRow2.w);
          nearFade = saturate((dist - _NearCameraFadeDistanceStart2)
                              / (_NearCameraFadeDistanceEnd2 - _NearCameraFadeDistanceStart2))
                   * saturate((dist - _NearCameraFadeDistanceStart)
                              / (_NearCameraFadeDistanceEnd - _NearCameraFadeDistanceStart));
      }

      // ==== FINAL ALPHA ====
      float fresnelOpacity = lerp(1.0, fresnelTerm, _FresnelAffectOpacity);
      float finalAlpha = saturate(saturate(combinedAlpha) * fresnelOpacity * nearFade);

      // [H12] 原版输出 premultiplied (finalAlpha*color, (1-_BlendMode)*finalAlpha) 配合可切换混合;
      //       SP 固定 over 混合 → 输出 straight color + finalAlpha 预览 (数学到此处为止逐位一致)。
      outAlpha = finalAlpha;
      return color;
  }
//- }

//----------------------------------------------------------------------region Part 7 OverlayShadow — HGRP_CharacterNPR_OverlayShadow_Fix.shader 逐行移植
//- {
  // [H13] 原版是 `Blend Zero SrcColor` 的乘法叠帧 pass (+顶点视空间光向偏移, 跳过):
  //       fb.rgb *= finalColor, 其中 finalColor = lerp(1, blended, finalIntensity)。
  //   SP 只有 over 混合, 无法直接乘帧。等价改写: over 的 lerp(fb, src, a) 要逼近 fb*乘子。
  //   令 src = blended(阴影染色), a = finalIntensity(变暗权重):
  //     over:  fb*(1-a) + blended*a
  //     真乘:  fb*(1 - a*(1-blended)) = fb*(1-a) + fb*blended*a
  //   眼白 fb≈1 → 两式相等 (正是本 pass 的目标区域)。无阴影处 texR=0 → a=0 全透,
  //   不再是挡住眼睛的白片。输出"染色+权重alpha"而非旧版直接吐乘子色。
  float3 shadeOverlayShadow(float3 baseColRGB, float baseAlphaTex, out float outAlpha) {
      float4 tex = float4(baseColRGB, baseAlphaTex);

      // _UseGrayAsAlpha: RGB → 1, Alpha → R
      float3 rgb;
      rgb.r = lerp(tex.r, 1.0, _UseGrayAsAlpha);
      rgb.g = lerp(tex.g, 1.0, _UseGrayAsAlpha);
      rgb.b = lerp(tex.b, 1.0, _UseGrayAsAlpha);
      float alpha = lerp(tex.a, tex.r, _UseGrayAsAlpha);

      float shadowAlpha = alpha * _BaseColor.a;
      float finalIntensity = shadowAlpha * _BaseColor.a; // 变暗权重 = texR·_BaseColor.a²
      float3 blended = rgb * _BaseColor.rgb;             // 阴影染色 (UseGrayAsAlpha=1 → _BaseColor.rgb)

      outAlpha = finalIntensity;
      return blended;
  }
//- }

//----------------------------------------------------------------------region EndField 后处理 Tonemap (HGRP ACES_modified 1:1)
//- {
  // 源: HG lutbuilder2d Sub0_Pass0_Fragment_b4.hlsl L141-166, 经 AzureNihil
  // Ruri_PostProcess_LutBuilder.shader 的 EndFieldAcesModifiedTonemap 移植, 常量逐字。
  // 入参 = ACEScg/AP1 线性。输出 = sRGB 基线性 [0,1]。
  float3 EndfieldAcesModifiedTonemap(float3 acescg) {
      const float3 ap1LumaWeights = float3(0.2722289860248565673828125, 0.674081981182098388671875, 0.0536894984543323516845703125);

      // 高光去饱和系数 (源 L151: saturate((luma-0.5)*2/3))
      float highlightDesaturation = saturate((dot(acescg, ap1LumaWeights) - 0.5) * 0.666666686534881591796875);

      // 有理拟合曲线 (源 L152-154)
      float3 x = acescg;
      float3 numerator = x * (x * 2.7850849628448486328125 + 0.107772000133991241455078125);
      float3 denominator = x * (x * 2.9360449314117431640625 + 0.887121975421905517578125) + 0.806888997554779052734375;
      float3 fitted = min(max(1.0 / denominator, 9.9999997473787516355514526367188e-05) * numerator, 1.0);

      // ODT 去饱和 0.93 (源 L155-159)
      float fittedLuma = dot(fitted, ap1LumaWeights);
      float3 desaturated = (fitted - fittedLuma) * 0.930000007152557373046875 + fittedLuma;

      // AP1 → sRGB (源 L160-162, 矩阵常量逐字)
      float3 srgb;
      srgb.r = dot(float3(1.70505154132843017578125, -0.621790707111358642578125, -0.083258680999279022216796875), desaturated);
      srgb.g = dot(float3(-0.13025714457035064697265625, 1.140802860260009765625, -0.010548190213739871978759765625), desaturated);
      srgb.b = dot(float3(-0.02400326915085315704345703125, -0.128968775272369384765625, 1.15297162532806396484375), desaturated);

      // 高光向归一化色相收敛 (源 L163-166)
      float maxChannel = max(max(srgb.r, max(srgb.g, srgb.b)), 9.9999997473787516355514526367188e-06);
      return clamp(lerp(srgb, clamp(srgb / maxChannel, 0.0, 1.0), highlightDesaturation), 0.0, 1.0);
  }

  // 调色中性时 HG LutBuilder 链 = sRGB线性 → unity_to_ACES→ACEScg (合并即 sRGB_2_AP1)
  // → ACES_modified 尾段。此矩阵为上面 AP1→sRGB 的精确数值逆 (往返误差 ~1e-16)。
  float3 ApplyEndfieldTonemap(float3 srgbLinear) {
      if (!u_UseEndfieldTonemap) return srgbLinear;
      float3 c = srgbLinear * f_TonemapExposure;
      float3 acescg;
      acescg.r = dot(float3(0.6130973255536435, 0.3395228813214228, 0.0473793330068586), c);
      acescg.g = dot(float3(0.0701942176296659, 0.9163555605787149, 0.0134523438298940), c);
      acescg.b = dot(float3(0.0206156004863253, 0.1095698373575739, 0.8698151534347436), c);
      return EndfieldAcesModifiedTonemap(acescg);
  }
//- }

//----------------------------------------------------------------------region Shader 入口 — 按 u_CharaPart 分发
//- {
  void shade(V2F inputs)
  {
      // ---- 基础色 / Alpha (引擎通道, sparse 1:1 [H7]) ----
      float3 baseCol = getBaseColor(basecolor_tex, inputs.sparse_coord);
      float baseAlphaTex = getOpacity(opacity_tex, inputs.sparse_coord);

      // ---- 朝向 / TBN 手性 ----
      bool isFrontFace = (uniform_facing >= 0);
      float faceSign = isFrontFace ? 1.0 : (_BackFaceNormalFlip * 2.0 - 1.0);
      float tSign = (dot(cross(normalize(inputs.normal), normalize(inputs.tangent)), normalize(inputs.bitangent)) < 0.0) ? -1.0 : 1.0;
      float4 tangentWS = float4(inputs.tangent, tSign);

      float3 color = float3(0.0);
      float outAlpha = 1.0;
      bool skipDefaultClip = false;
      bool forceAlphaBlend = false; // 部位本身就是半透明(如 OverlayShadow 乘法叠帧), 无视 u_AlphaBlend

      if (u_CharaPart == 1) {
          // ---- Face: Emotion 混合在进光照前完成 (HGRP Skin frag L687-702) ----
          float3 albedo;
          if (u_UseEmotionMap) {
              float halfIdx = 0.5 * float(_EmotionIndex);
              float fracIdx = frac(halfIdx);
              float2 uvE = GetBaseUV(inputs);
              float2 emotionUV = float2(
                  uvE.x * 0.5 + fracIdx,
                  uvE.y * 0.5 + floor(halfIdx) * 0.5
              );
              float4 emotionSmp = SampleSRGBTex(_EmotionMap, emotionUV); // sRGBTexture=1
              float emotionT = emotionSmp.a * _EmotionBlend;
              albedo.r = mad(emotionT, emotionSmp.r - baseCol.r * _BaseColor.r, baseCol.r * _BaseColor.r);
              albedo.g = mad(emotionT, emotionSmp.g - baseCol.g * _BaseColor.g, baseCol.g * _BaseColor.g);
              albedo.b = mad(emotionT, emotionSmp.b - baseCol.b * _BaseColor.b, baseCol.b * _BaseColor.b);
          } else {
              albedo = baseCol * _BaseColor.rgb;
          }
          color = shadeFace(inputs, inputs.position, inputs.normal, tangentWS, faceSign, albedo, baseAlphaTex);
          outAlpha = 1.0; // HGRP Skin ForwardLit 输出 alpha=1
      }
      else if (u_CharaPart == 2 || u_CharaPart == 5) {
          // ---- Eyes / Eyebrow (Eyebrow = 无 Matcap 路径) ----
          color = shadeEyes(inputs, inputs.position, inputs.normal, tangentWS, isFrontFace, u_CharaPart == 2);
          outAlpha = 1.0; // HGRP Eye 输出 alpha=1
      }
      else if (u_CharaPart == 3) {
          // ---- Hair ----
          float3 albedo = baseCol * _BaseColor.rgb;
          float baseAlpha = baseAlphaTex * _BaseColor.a;
          color = shadeHair(inputs, inputs.position, inputs.normal, tangentWS, faceSign, albedo, baseAlpha);
          outAlpha = u_AlphaBlend ? baseAlphaTex : 1.0; // 原: (_SurfaceType==1) ? baseSample.a : 1
      }
      else if (u_CharaPart == 4) {
          // ---- Fur ([H10] 单壳层预览) ----
          float3 albedo = baseCol * _BaseColor.rgb;
          float shellAlpha;
          color = shadeFur(inputs, inputs.position, inputs.normal, tangentWS, faceSign, albedo, shellAlpha);
          if (shellAlpha - 0.003 < 0.0) discard; // 原 clip(shellAlpha - 0.003)
          outAlpha = shellAlpha;
          skipDefaultClip = true;
      }
      else if (u_CharaPart == 6) {
          // ---- VFX ([H12]) ----
          color = shadeVFX(inputs, inputs.position, inputs.normal, tangentWS, isFrontFace, outAlpha);
          skipDefaultClip = true;
      }
      else if (u_CharaPart == 7) {
          // ---- OverlayShadow ([H13] 乘法叠帧 → over 近似; 强制半透明, 否则白片挡眼) ----
          color = shadeOverlayShadow(baseCol, baseAlphaTex, outAlpha);
          forceAlphaBlend = true;
          skipDefaultClip = true;
      }
      else {
          // ---- Standard (默认 / Part 0) ----
          float3 albedo = baseCol * _BaseColor.rgb;
          float3 shadowColorUnused;
          color = shadeStandard(inputs, inputs.position, inputs.normal, tangentWS, faceSign, albedo, baseAlphaTex, shadowColorUnused);
          outAlpha = u_AlphaBlend ? baseAlphaTex : 1.0; // 原: (_SurfaceType==1) ? baseSample.a : 1
          // [H5] ApplyCustomAO: 跳过
      }

      // ---- Alpha 输出 / 裁切 (与旧版工作流一致) ----
      if (u_AlphaBlend || forceAlphaBlend) {
          alphaOutput(outAlpha);
      } else if (!skipDefaultClip) {
          float clipA = baseAlphaTex * _BaseColor.a;
          if (clipA < f_AlphaClip) discard;
      }

      // ---- EndField 后处理 tonemap (HGRP ACES_modified; 屏幕链对所有 part 一致) ----
      color = ApplyEndfieldTonemap(color);

      diffuseShadingOutput(color);
  }
//- }

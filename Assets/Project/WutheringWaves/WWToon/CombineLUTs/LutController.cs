using UnityEngine;
using UnityEngine.Rendering;

[ExecuteInEditMode]
public class LutController : MonoBehaviour
{
    [Header("Shader Resources")]
    public ComputeShader lutGeneratorCompute;
    public Material applyLutMaterial; // 用于最终屏幕效果的材质

    [Header("Tonemapper Film Curve")]
    public float TonemapperSlope = 0.88f;
    public float TonemapperToe = 0.55f;
    public float TonemapperShoulder = 0.26f;
    public float TonemapperBlackClip = 0.0f;
    public float TonemapperWhiteClip = 0.04f;

    [Header("White Balance")]
    [Range(1500, 15000)] public float WhiteBalanceTemp = 6500.0f;
    [Range(-1.0f, 1.0f)] public float WhiteBalanceTint = 0.0f;

    [Header("Color Grading - Global")]
    // 默认值根据CB dump还原
    public Color ColorSaturation = new Color(0.97f, 0.97f, 0.97f, 1.0f);
    public Color ColorContrast = new Color(1.06f, 1.06f, 1.06f, 1.0f);
    public Color ColorGamma = new Color(1.0f, 1.01f, 1.05f, 1.0f);
    public Color ColorGain = new Color(1, 1, 1, 1);
    public Color ColorOffset = new Color(0, 0, 0, 0);

    [Header("Color Grading - Shadows")]
    [Range(0.0f, 2.0f)] public float ColorCorrectionShadowsMax = 0.09f;
    public Color ColorSaturationShadows = new Color(1, 1, 1, 1);
    public Color ColorContrastShadows = new Color(1, 1, 1, 1);
    public Color ColorGammaShadows = new Color(1, 1, 1, 1);
    public Color ColorGainShadows = new Color(1, 1, 1, 1);
    public Color ColorOffsetShadows = new Color(0, 0, 0, 0);

    [Header("Color Grading - Midtones")]
    public Color ColorSaturationMidtones = new Color(1, 1, 1, 1);
    public Color ColorContrastMidtones = new Color(1, 1, 1, 1);
    public Color ColorGammaMidtones = new Color(1, 1, 1, 1);
    public Color ColorGainMidtones = new Color(1, 1, 1, 1);
    public Color ColorOffsetMidtones = new Color(0, 0, 0, 0);

    [Header("Color Grading - Highlights")]
    [Range(0.0f, 2.0f)] public float ColorCorrectionHighlightsMin = 0.5f;
    public Color ColorSaturationHighlights = new Color(1, 1, 1, 1);
    public Color ColorContrastHighlights = new Color(1, 1, 1, 1);
    public Color ColorGammaHighlights = new Color(1, 1, 1, 1);
    public Color ColorGainHighlights = new Color(1, 1, 1, 1);
    public Color ColorOffsetHighlights = new Color(0, 0, 0, 0);

    [Header("Misc Corrections")]
    [Range(0, 1)] public float BlueCorrection = 0.6f;
    [Range(1, 2)] public float ExpandGamut = 1.0f;

    private RenderTexture _lut3D;
    private const int LutSize = 32;

    void OnEnable() { GenerateLut(); }
    void OnValidate() { if (isActiveAndEnabled) GenerateLut(); }
    void OnDisable()
    {
        if (_lut3D != null)
        {
            _lut3D.Release();
            _lut3D = null;
        }
    }

    public void GenerateLut()
    {
        if (lutGeneratorCompute == null) return;

        if (_lut3D == null || !_lut3D.IsCreated())
        {
            _lut3D = new RenderTexture(LutSize, LutSize, 0, RenderTextureFormat.ARGBHalf)
            {
                dimension = TextureDimension.Tex3D,
                volumeDepth = LutSize,
                enableRandomWrite = true
            };
            _lut3D.Create();
        }

        int kernel = lutGeneratorCompute.FindKernel("cs_main");

        // Set all parameters...
        lutGeneratorCompute.SetVector("ColorSaturation", ColorSaturation);
        lutGeneratorCompute.SetVector("ColorContrast", ColorContrast);
        lutGeneratorCompute.SetVector("ColorGamma", ColorGamma);
        lutGeneratorCompute.SetVector("ColorGain", ColorGain);
        lutGeneratorCompute.SetVector("ColorOffset", ColorOffset);
        lutGeneratorCompute.SetVector("ColorSaturationShadows", ColorSaturationShadows);
        lutGeneratorCompute.SetVector("ColorContrastShadows", ColorContrastShadows);
        lutGeneratorCompute.SetVector("ColorGammaShadows", ColorGammaShadows);
        lutGeneratorCompute.SetVector("ColorGainShadows", ColorGainShadows);
        lutGeneratorCompute.SetVector("ColorOffsetShadows", ColorOffsetShadows);
        lutGeneratorCompute.SetVector("ColorSaturationMidtones", ColorSaturationMidtones);
        lutGeneratorCompute.SetVector("ColorContrastMidtones", ColorContrastMidtones);
        lutGeneratorCompute.SetVector("ColorGammaMidtones", ColorGammaMidtones);
        lutGeneratorCompute.SetVector("ColorGainMidtones", ColorGainMidtones);
        lutGeneratorCompute.SetVector("ColorOffsetMidtones", ColorOffsetMidtones);
        lutGeneratorCompute.SetVector("ColorSaturationHighlights", ColorSaturationHighlights);
        lutGeneratorCompute.SetVector("ColorContrastHighlights", ColorContrastHighlights);
        lutGeneratorCompute.SetVector("ColorGammaHighlights", ColorGammaHighlights);
        lutGeneratorCompute.SetVector("ColorGainHighlights", ColorGainHighlights);
        lutGeneratorCompute.SetVector("ColorOffsetHighlights", ColorOffsetHighlights);
        lutGeneratorCompute.SetFloat("ColorCorrectionShadowsMax", ColorCorrectionShadowsMax);
        lutGeneratorCompute.SetFloat("ColorCorrectionHighlightsMin", ColorCorrectionHighlightsMin);
        lutGeneratorCompute.SetFloat("BlueCorrection", BlueCorrection);
        lutGeneratorCompute.SetFloat("ExpandGamut", ExpandGamut);
        lutGeneratorCompute.SetFloat("FilmSlope", TonemapperSlope);
        lutGeneratorCompute.SetFloat("FilmToe", TonemapperToe);
        lutGeneratorCompute.SetFloat("FilmShoulder", TonemapperShoulder);
        lutGeneratorCompute.SetFloat("FilmBlackClip", TonemapperBlackClip);
        lutGeneratorCompute.SetFloat("FilmWhiteClip", TonemapperWhiteClip);
        lutGeneratorCompute.SetFloat("WhiteTemp", WhiteBalanceTemp);
        lutGeneratorCompute.SetFloat("WhiteTint", WhiteBalanceTint);

        // Set parameters from article that are hardcoded or derived
        Vector3 colorTransform = new Vector3(0.0f, 0.5f, 1.0f);
        float c = colorTransform.x, b = 4 * colorTransform.y - 3 * colorTransform.x - colorTransform.z, a = colorTransform.z - colorTransform.x - b;
        lutGeneratorCompute.SetVector("MappingPolynomial", new Vector4(a, b, c, 1));
        lutGeneratorCompute.SetVector("ColorScale", Vector3.one);
        lutGeneratorCompute.SetVector("OverlayColor", Color.clear);
        float displayGamma = 2.2f;
        float engineGamma = (QualitySettings.activeColorSpace == ColorSpace.Linear) ? 2.2f : 1.0f;
        lutGeneratorCompute.SetVector("InverseGamma", new Vector3(1.0f / displayGamma, engineGamma / displayGamma, 1.0f));
        lutGeneratorCompute.SetInt("OutputDevice", 0);
        lutGeneratorCompute.SetInt("OutputGamut", 0);
        lutGeneratorCompute.SetVector("ColorShadow_Tint2", new Color(0, 0, 0, 1));
        lutGeneratorCompute.SetFloat("ToneCurveAmount", 1.0f);
        lutGeneratorCompute.SetInt("bUseMobileTonemapper", 0);


        lutGeneratorCompute.SetTexture(kernel, "RWOutComputeTex", _lut3D);
        int threadGroups = LutSize / 8;
        lutGeneratorCompute.Dispatch(kernel, threadGroups, threadGroups, threadGroups);

        if (applyLutMaterial != null)
        {
            applyLutMaterial.SetTexture("_Lut3D", _lut3D);
        }
    }

    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        if (applyLutMaterial != null && _lut3D != null)
        {
            Graphics.Blit(source, destination, applyLutMaterial);
        }
        else
        {
            Graphics.Blit(source, destination);
        }
    }
}
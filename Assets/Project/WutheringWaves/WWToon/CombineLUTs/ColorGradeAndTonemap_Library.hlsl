#ifndef COLORGRADE_AND_TONEMAP_LIBRARY_HLSL
#define COLORGRADE_AND_TONEMAP_LIBRARY_HLSL

// re-ordered and cleaned to resolve dependencies for a single-file include in Unity:
// 1. ACES.ush.hlsl
// 2. GammaCorrectionCommon.ush.hlsl
// 3. TonemapCommon.ush.hlsl
// 4. PostProcessCombineLUTs.usf.hlsl (Core logic only)
//
// The code logic has NOT been changed to ensure byte-level identical results.
//====================================================================================================


//====================================================================================================
// PART 1: FROM ACES.ush.hlsl
// (Provides color space matrices, ACES standards, and spline functions)
//====================================================================================================

static const float3x3 AP0_2_XYZ_MAT =
{
    0.9525523959, 0.0000000000, 0.0000936786,
	0.3439664498, 0.7281660966, -0.0721325464,
	0.0000000000, 0.0000000000, 1.0088251844,
};

static const float3x3 XYZ_2_AP0_MAT =
{
    1.0498110175, 0.0000000000, -0.0000974845,
	-0.4959030231, 1.3733130458, 0.0982400361,
	 0.0000000000, 0.0000000000, 0.9912520182,
};

static const float3x3 AP1_2_XYZ_MAT =
{
    0.6624541811, 0.1340042065, 0.1561876870,
	 0.2722287168, 0.6740817658, 0.0536895174,
	-0.0055746495, 0.0040607335, 1.0103391003,
};

static const float3x3 XYZ_2_AP1_MAT =
{
    1.6410233797, -0.3248032942, -0.2364246952,
	-0.6636628587, 1.6153315917, 0.0167563477,
	 0.0117218943, -0.0082844420, 0.9883948585,
};

static const float3x3 AP0_2_AP1_MAT = //mul( AP0_2_XYZ_MAT, XYZ_2_AP1_MAT );
{
    1.4514393161, -0.2365107469, -0.2149285693,
	-0.0765537734, 1.1762296998, -0.0996759264,
	 0.0083161484, -0.0060324498, 0.9977163014,
};

static const float3x3 AP1_2_AP0_MAT = //mul( AP1_2_XYZ_MAT, XYZ_2_AP0_MAT );
{
    0.6954522414, 0.1406786965, 0.1638690622,
	 0.0447945634, 0.8596711185, 0.0955343182,
	-0.0055258826, 0.0040252103, 1.0015006723,
};

static const float3 AP1_RGB2Y =
{
    0.2722287168, //AP1_2_XYZ_MAT[0][1],
	0.6740817658, //AP1_2_XYZ_MAT[1][1],
	0.0536895174, //AP1_2_XYZ_MAT[2][1]
};

// REC 709 primaries
static const float3x3 XYZ_2_sRGB_MAT =
{
    3.2409699419, -1.5373831776, -0.4986107603,
	-0.9692436363, 1.8759675015, 0.0415550574,
	 0.0556300797, -0.2039769589, 1.0569715142,
};

static const float3x3 sRGB_2_XYZ_MAT =
{
    0.4124564, 0.3575761, 0.1804375,
	0.2126729, 0.7151522, 0.0721750,
	0.0193339, 0.1191920, 0.9503041,
};

// REC 2020 primaries
static const float3x3 XYZ_2_Rec2020_MAT =
{
    1.7166084, -0.3556621, -0.2533601,
	-0.6666829, 1.6164776, 0.0157685,
	 0.0176422, -0.0427763, 0.94222867
};

static const float3x3 Rec2020_2_XYZ_MAT =
{
    0.6369736, 0.1446172, 0.1688585,
	0.2627066, 0.6779996, 0.0592938,
	0.0000000, 0.0280728, 1.0608437
};

// P3, D65 primaries
static const float3x3 XYZ_2_P3D65_MAT =
{
    2.4933963, -0.9313459, -0.4026945,
	-0.8294868, 1.7626597, 0.0236246,
	 0.0358507, -0.0761827, 0.9570140
};

static const float3x3 P3D65_2_XYZ_MAT =
{
    0.4865906, 0.2656683, 0.1981905,
	0.2289838, 0.6917402, 0.0792762,
	0.0000000, 0.0451135, 1.0438031
};

// Bradford chromatic adaptation transforms between ACES white point (D60) and sRGB white point (D65)
static const float3x3 D65_2_D60_CAT =
{
    1.01303, 0.00610531, -0.014971,
	 0.00769823, 0.998165, -0.00503203,
	-0.00284131, 0.00468516, 0.924507,
};

static const float3x3 D60_2_D65_CAT =
{
    0.987224, -0.00611327, 0.0159533,
	-0.00759836, 1.00186, 0.00533002,
	 0.00307257, -0.00509595, 1.08168,
};

static const float HALF_MAX = 65504.0;

float rgb_2_saturation(float3 rgb)
{
    float minrgb = min(min(rgb.r, rgb.g), rgb.b);
    float maxrgb = max(max(rgb.r, rgb.g), rgb.b);
    return (max(maxrgb, 1e-10) - max(minrgb, 1e-10)) / max(maxrgb, 1e-2);
}

float glow_fwd(float ycIn, float glowGainIn, float glowMid)
{
    float glowGainOut;

    if (ycIn <= 2. / 3. * glowMid)
    {
        glowGainOut = glowGainIn;
    }
    else if (ycIn >= 2 * glowMid)
    {
        glowGainOut = 0;
    }
    else
    {
        glowGainOut = glowGainIn * (glowMid / ycIn - 0.5);
    }

    return glowGainOut;
}

float glow_inv(float ycOut, float glowGainIn, float glowMid)
{
    float glowGainOut;

    if (ycOut <= ((1 + glowGainIn) * 2. / 3. * glowMid))
    {
        glowGainOut = -glowGainIn / (1 + glowGainIn);
    }
    else if (ycOut >= (2. * glowMid))
    {
        glowGainOut = 0.;
    }
    else
    {
        glowGainOut = glowGainIn * (glowMid / ycOut - 1. / 2.) / (glowGainIn / 2. - 1.);
    }

    return glowGainOut;
}


float sigmoid_shaper(float x)
{
	// Sigmoid function in the range 0 to 1 spanning -2 to +2.

    float t = max(1 - abs(0.5 * x), 0);
    float y = 1 + sign(x) * (1 - t * t);
    return 0.5 * y;
}


// ------- Red modifier functions
float cubic_basis_shaper
(
  float x,
  float w // full base width of the shaper function (in degrees)
)
{
	//return Square( smoothstep( 0, 1, 1 - abs( 2 * x/w ) ) );

    float M[4][4] =
    {
        { -1. / 6, 3. / 6, -3. / 6, 1. / 6 },
        { 3. / 6, -6. / 6, 3. / 6, 0. / 6 },
        { -3. / 6, 0. / 6, 3. / 6, 0. / 6 },
        { 1. / 6, 4. / 6, 1. / 6, 0. / 6 }
    };
  
    float knots[5] = { -0.5 * w, -0.25 * w, 0, 0.25 * w, 0.5 * w };
  
    float y = 0;
    if ((x > knots[0]) && (x < knots[4]))
    {
        float knot_coord = (x - knots[0]) * 4.0 / w;
        int j = knot_coord;
        float t = knot_coord - j;
	  
        float monomials[4] = { t * t * t, t * t, t, 1.0 };

		// (if/else structure required for compatibility with CTL < v1.5.)
        if (j == 3)
        {
            y = monomials[0] * M[0][0] + monomials[1] * M[1][0] +
				monomials[2] * M[2][0] + monomials[3] * M[3][0];
        }
        else if (j == 2)
        {
            y = monomials[0] * M[0][1] + monomials[1] * M[1][1] +
				monomials[2] * M[2][1] + monomials[3] * M[3][1];
        }
        else if (j == 1)
        {
            y = monomials[0] * M[0][2] + monomials[1] * M[1][2] +
				monomials[2] * M[2][2] + monomials[3] * M[3][2];
        }
        else if (j == 0)
        {
            y = monomials[0] * M[0][3] + monomials[1] * M[1][3] +
				monomials[2] * M[2][3] + monomials[3] * M[3][3];
        }
        else
        {
            y = 0.0;
        }
    }
  
    return y * 1.5;
}

float center_hue(float hue, float centerH)
{
    float hueCentered = hue - centerH;
    if (hueCentered < -180.)
        hueCentered += 360;
    else if (hueCentered > 180.)
        hueCentered -= 360;
    return hueCentered;
}


// Textbook monomial to basis-function conversion matrix.
static const float3x3 M =
{
    { 0.5, -1.0, 0.5 },
    { -1.0, 1.0, 0.5 },
    { 0.5, 0.0, 0.0 }
};

struct SegmentedSplineParams_c5
{
    float coefsLow[6]; // coefs for B-spline between minPoint and midPoint (units of log luminance)
    float coefsHigh[6]; // coefs for B-spline between midPoint and maxPoint (units of log luminance)
    float2 minPoint; // {luminance, luminance} linear extension below this
    float2 midPoint; // {luminance, luminance} 
    float2 maxPoint; // {luminance, luminance} linear extension above this
    float slopeLow; // log-log slope of low linear extension
    float slopeHigh; // log-log slope of high linear extension
};

struct SegmentedSplineParams_c9
{
    float coefsLow[10]; // coefs for B-spline between minPoint and midPoint (units of log luminance)
    float coefsHigh[10]; // coefs for B-spline between midPoint and maxPoint (units of log luminance)
    float2 minPoint; // {luminance, luminance} linear extension below this
    float2 midPoint; // {luminance, luminance} 
    float2 maxPoint; // {luminance, luminance} linear extension above this
    float slopeLow; // log-log slope of low linear extension
    float slopeHigh; // log-log slope of high linear extension
};

float segmented_spline_c5_fwd(float x)
{
	// RRT_PARAMS
    const SegmentedSplineParams_c5 C =
    {
		// coefsLow[6]
        { -4.0000000000, -4.0000000000, -3.1573765773, -0.4852499958, 1.8477324706, 1.8477324706 },
		// coefsHigh[6]
        { -0.7185482425, 2.0810307172, 3.6681241237, 4.0000000000, 4.0000000000, 4.0000000000 },
        { 0.18 * exp2(-15.0), 0.0001 }, // minPoint
        { 0.18, 4.8 }, // midPoint
        { 0.18 * exp2(18.0), 10000. }, // maxPoint
		0.0, // slopeLow
		0.0 // slopeHigh
    };

    const int N_KNOTS_LOW = 4;
    const int N_KNOTS_HIGH = 4;

	// Check for negatives or zero before taking the log. If negative or zero,
	// set to ACESMIN.1
    float xCheck = x <= 0 ? exp2(-14.0) : x;

    float logx = log10(xCheck);
    float logy;

    if (logx <= log10(C.minPoint.x))
    {
        logy = logx * C.slopeLow + (log10(C.minPoint.y) - C.slopeLow * log10(C.minPoint.x));
    }
    else if ((logx > log10(C.minPoint.x)) && (logx < log10(C.midPoint.x)))
    {
        float knot_coord = (N_KNOTS_LOW - 1) * (logx - log10(C.minPoint.x)) / (log10(C.midPoint.x) - log10(C.minPoint.x));
        int j = knot_coord;
        float t = knot_coord - j;

        float3 cf = { C.coefsLow[j], C.coefsLow[j + 1], C.coefsLow[j + 2] };
	
        float3 monomials = { t * t, t, 1.0 };
        logy = dot(monomials, mul(cf, M));
    }
    else if ((logx >= log10(C.midPoint.x)) && (logx < log10(C.maxPoint.x)))
    {
        float knot_coord = (N_KNOTS_HIGH - 1) * (logx - log10(C.midPoint.x)) / (log10(C.maxPoint.x) - log10(C.midPoint.x));
        int j = knot_coord;
        float t = knot_coord - j;

        float3 cf = { C.coefsHigh[j], C.coefsHigh[j + 1], C.coefsHigh[j + 2] };

        float3 monomials = { t * t, t, 1.0 };
        logy = dot(monomials, mul(cf, M));
    }
    else
    { //if ( logIn >= log10(C.maxPoint.x) ) { 
        logy = logx * C.slopeHigh + (log10(C.maxPoint.y) - C.slopeHigh * log10(C.maxPoint.x));
    }

    return pow(10, logy);
}

float segmented_spline_c5_rev(float y)
{
	// RRT_PARAMS
    const SegmentedSplineParams_c5 C =
    {
		// coefsLow[6]
        { -4.0000000000, -4.0000000000, -3.1573765773, -0.4852499958, 1.8477324706, 1.8477324706 },
		// coefsHigh[6]
        { -0.7185482425, 2.0810307172, 3.6681241237, 4.0000000000, 4.0000000000, 4.0000000000 },
        { 0.18 * exp2(-15.0), 0.0001 }, // minPoint
        { 0.18, 4.8 }, // midPoint
        { 0.18 * exp2(18.0), 10000. }, // maxPoint
		0.0, // slopeLow
		0.0 // slopeHigh
    };

    const int N_KNOTS_LOW = 4;
    const int N_KNOTS_HIGH = 4;

    const float KNOT_INC_LOW = (log10(C.midPoint.x) - log10(C.minPoint.x)) / (N_KNOTS_LOW - 1.);
    const float KNOT_INC_HIGH = (log10(C.maxPoint.x) - log10(C.midPoint.x)) / (N_KNOTS_HIGH - 1.);

    int i;
  
	// KNOT_Y is luminance of the spline at each knot
    float KNOT_Y_LOW[N_KNOTS_LOW];
    for (i = 0; i < N_KNOTS_LOW; i = i + 1)
    {
        KNOT_Y_LOW[i] = (C.coefsLow[i] + C.coefsLow[i + 1]) / 2.;
    };

    float KNOT_Y_HIGH[N_KNOTS_HIGH];
    for (i = 0; i < N_KNOTS_HIGH; i = i + 1)
    {
        KNOT_Y_HIGH[i] = (C.coefsHigh[i] + C.coefsHigh[i + 1]) / 2.;
    };

    float logy = log10(max(y, 1e-10));

    float logx;
    if (logy <= log10(C.minPoint.y))
    {
        logx = log10(C.minPoint.x);
    }
    else if ((logy > log10(C.minPoint.y)) && (logy <= log10(C.midPoint.y)))
    {
        uint j;
        float3 cf;
        if (logy > KNOT_Y_LOW[0] && logy <= KNOT_Y_LOW[1])
        {
            cf[0] = C.coefsLow[0];
            cf[1] = C.coefsLow[1];
            cf[2] = C.coefsLow[2];
            j = 0;
        }
        else if (logy > KNOT_Y_LOW[1] && logy <= KNOT_Y_LOW[2])
        {
            cf[0] = C.coefsLow[1];
            cf[1] = C.coefsLow[2];
            cf[2] = C.coefsLow[3];
            j = 1;
        }
        else if (logy > KNOT_Y_LOW[2] && logy <= KNOT_Y_LOW[3])
        {
            cf[0] = C.coefsLow[2];
            cf[1] = C.coefsLow[3];
            cf[2] = C.coefsLow[4];
            j = 2;
        }
	
        const float3 tmp = mul(cf, M);

        float a = tmp[0];
        float b = tmp[1];
        float c = tmp[2];
        c = c - logy;

        const float d = sqrt(b * b - 4. * a * c);

        const float t = (2. * c) / (-d - b);

        logx = log10(C.minPoint.x) + (t + j) * KNOT_INC_LOW;
    }
    else if ((logy > log10(C.midPoint.y)) && (logy < log10(C.maxPoint.y)))
    {
        uint j;
        float3 cf;
        if (logy > KNOT_Y_HIGH[0] && logy <= KNOT_Y_HIGH[1])
        {
            cf[0] = C.coefsHigh[0];
            cf[1] = C.coefsHigh[1];
            cf[2] = C.coefsHigh[2];
            j = 0;
        }
        else if (logy > KNOT_Y_HIGH[1] && logy <= KNOT_Y_HIGH[2])
        {
            cf[0] = C.coefsHigh[1];
            cf[1] = C.coefsHigh[2];
            cf[2] = C.coefsHigh[3];
            j = 1;
        }
        else if (logy > KNOT_Y_HIGH[2] && logy <= KNOT_Y_HIGH[3])
        {
            cf[0] = C.coefsHigh[2];
            cf[1] = C.coefsHigh[3];
            cf[2] = C.coefsHigh[4];
            j = 2;
        }
	
        const float3 tmp = mul(cf, M);

        float a = tmp[0];
        float b = tmp[1];
        float c = tmp[2];
        c = c - logy;

        const float d = sqrt(b * b - 4. * a * c);

        const float t = (2. * c) / (-d - b);

        logx = log10(C.midPoint.x) + (t + j) * KNOT_INC_HIGH;
    }
    else
    { //if ( logy >= log10(C.maxPoint.y) ) {
        logx = log10(C.maxPoint.x);
    }
  
    return pow(10, logx);
}

float segmented_spline_c9_fwd(float x, const SegmentedSplineParams_c9 C)
{
    const int N_KNOTS_LOW = 8;
    const int N_KNOTS_HIGH = 8;

	// Check for negatives or zero before taking the log. If negative or zero,
	// set to OCESMIN.
    float xCheck = x <= 0 ? 1e-4 : x;

    float logx = log10(xCheck);
    float logy;

    if (logx <= log10(C.minPoint.x))
    {
        logy = logx * C.slopeLow + (log10(C.minPoint.y) - C.slopeLow * log10(C.minPoint.x));
    }
    else if ((logx > log10(C.minPoint.x)) && (logx < log10(C.midPoint.x)))
    {
        float knot_coord = (N_KNOTS_LOW - 1) * (logx - log10(C.minPoint.x)) / (log10(C.midPoint.x) - log10(C.minPoint.x));
        int j = knot_coord;
        float t = knot_coord - j;

        float3 cf = { C.coefsLow[j], C.coefsLow[j + 1], C.coefsLow[j + 2] };

        float3 monomials = { t * t, t, 1.0 };
        logy = dot(monomials, mul(cf, M));
    }
    else if ((logx >= log10(C.midPoint.x)) && (logx < log10(C.maxPoint.x)))
    {
        float knot_coord = (N_KNOTS_HIGH - 1) * (logx - log10(C.midPoint.x)) / (log10(C.maxPoint.x) - log10(C.midPoint.x));
        int j = knot_coord;
        float t = knot_coord - j;

        float3 cf = { C.coefsHigh[j], C.coefsHigh[j + 1], C.coefsHigh[j + 2] };

        float3 monomials = { t * t, t, 1.0 };
        logy = dot(monomials, mul(cf, M));
    }
    else //if ( logIn >= log10(C.maxPoint.x) )
    {
        logy = logx * C.slopeHigh + (log10(C.maxPoint.y) - C.slopeHigh * log10(C.maxPoint.x));
    }

    return pow(10, logy);
}

float segmented_spline_c9_rev(float y, const SegmentedSplineParams_c9 C)
{
    const int N_KNOTS_LOW = 8;
    const int N_KNOTS_HIGH = 8;

    const float KNOT_INC_LOW = (log10(C.midPoint.x) - log10(C.minPoint.x)) / (N_KNOTS_LOW - 1.);
    const float KNOT_INC_HIGH = (log10(C.maxPoint.x) - log10(C.midPoint.x)) / (N_KNOTS_HIGH - 1.);
  
    int i;

	// KNOT_Y is luminance of the spline at each knot
    float KNOT_Y_LOW[N_KNOTS_LOW];
    for (i = 0; i < N_KNOTS_LOW; i = i + 1)
    {
        KNOT_Y_LOW[i] = (C.coefsLow[i] + C.coefsLow[i + 1]) / 2.;
    };

    float KNOT_Y_HIGH[N_KNOTS_HIGH];
    for (i = 0; i < N_KNOTS_HIGH; i = i + 1)
    {
        KNOT_Y_HIGH[i] = (C.coefsHigh[i] + C.coefsHigh[i + 1]) / 2.;
    };

    float logy = log10(max(y, 1e-10));

    float logx;
    if (logy <= log10(C.minPoint.y))
    {
        logx = log10(C.minPoint.x);
    }
    else if ((logy > log10(C.minPoint.y)) && (logy <= log10(C.midPoint.y)))
    {
        uint j;
        float3 cf;
        if (logy > KNOT_Y_LOW[0] && logy <= KNOT_Y_LOW[1])
        {
            cf[0] = C.coefsLow[0];
            cf[1] = C.coefsLow[1];
            cf[2] = C.coefsLow[2];
            j = 0;
        }
        else if (logy > KNOT_Y_LOW[1] && logy <= KNOT_Y_LOW[2])
        {
            cf[0] = C.coefsLow[1];
            cf[1] = C.coefsLow[2];
            cf[2] = C.coefsLow[3];
            j = 1;
        }
        else if (logy > KNOT_Y_LOW[2] && logy <= KNOT_Y_LOW[3])
        {
            cf[0] = C.coefsLow[2];
            cf[1] = C.coefsLow[3];
            cf[2] = C.coefsLow[4];
            j = 2;
        }
        else if (logy > KNOT_Y_LOW[3] && logy <= KNOT_Y_LOW[4])
        {
            cf[0] = C.coefsLow[3];
            cf[1] = C.coefsLow[4];
            cf[2] = C.coefsLow[5];
            j = 3;
        }
        else if (logy > KNOT_Y_LOW[4] && logy <= KNOT_Y_LOW[5])
        {
            cf[0] = C.coefsLow[4];
            cf[1] = C.coefsLow[5];
            cf[2] = C.coefsLow[6];
            j = 4;
        }
        else if (logy > KNOT_Y_LOW[5] && logy <= KNOT_Y_LOW[6])
        {
            cf[0] = C.coefsLow[5];
            cf[1] = C.coefsLow[6];
            cf[2] = C.coefsLow[7];
            j = 5;
        }
        else if (logy > KNOT_Y_LOW[6] && logy <= KNOT_Y_LOW[7])
        {
            cf[0] = C.coefsLow[6];
            cf[1] = C.coefsLow[7];
            cf[2] = C.coefsLow[8];
            j = 6;
        }
	
        const float3 tmp = mul(cf, M);

        float a = tmp[0];
        float b = tmp[1];
        float c = tmp[2];
        c = c - logy;

        const float d = sqrt(b * b - 4. * a * c);

        const float t = (2. * c) / (-d - b);

        logx = log10(C.minPoint.x) + (t + j) * KNOT_INC_LOW;
    }
    else if ((logy > log10(C.midPoint.y)) && (logy < log10(C.maxPoint.y)))
    {
        uint j;
        float3 cf;
        if (logy > KNOT_Y_HIGH[0] && logy <= KNOT_Y_HIGH[1])
        {
            cf[0] = C.coefsHigh[0];
            cf[1] = C.coefsHigh[1];
            cf[2] = C.coefsHigh[2];
            j = 0;
        }
        else if (logy > KNOT_Y_HIGH[1] && logy <= KNOT_Y_HIGH[2])
        {
            cf[0] = C.coefsHigh[1];
            cf[1] = C.coefsHigh[2];
            cf[2] = C.coefsHigh[3];
            j = 1;
        }
        else if (logy > KNOT_Y_HIGH[2] && logy <= KNOT_Y_HIGH[3])
        {
            cf[0] = C.coefsHigh[2];
            cf[1] = C.coefsHigh[3];
            cf[2] = C.coefsHigh[4];
            j = 2;
        }
        else if (logy > KNOT_Y_HIGH[3] && logy <= KNOT_Y_HIGH[4])
        {
            cf[0] = C.coefsHigh[3];
            cf[1] = C.coefsHigh[4];
            cf[2] = C.coefsHigh[5];
            j = 3;
        }
        else if (logy > KNOT_Y_HIGH[4] && logy <= KNOT_Y_HIGH[5])
        {
            cf[0] = C.coefsHigh[4];
            cf[1] = C.coefsHigh[5];
            cf[2] = C.coefsHigh[6];
            j = 4;
        }
        else if (logy > KNOT_Y_HIGH[5] && logy <= KNOT_Y_HIGH[6])
        {
            cf[0] = C.coefsHigh[5];
            cf[1] = C.coefsHigh[6];
            cf[2] = C.coefsHigh[7];
            j = 5;
        }
        else if (logy > KNOT_Y_HIGH[6] && logy <= KNOT_Y_HIGH[7])
        {
            cf[0] = C.coefsHigh[6];
            cf[1] = C.coefsHigh[7];
            cf[2] = C.coefsHigh[8];
            j = 6;
        }
	
        const float3 tmp = mul(cf, M);

        float a = tmp[0];
        float b = tmp[1];
        float c = tmp[2];
        c = c - logy;

        const float d = sqrt(b * b - 4. * a * c);

        const float t = (2. * c) / (-d - b);

        logx = log10(C.midPoint.x) + (t + j) * KNOT_INC_HIGH;
    }
    else
    { //if ( logy >= log10(C.maxPoint.y) ) {
        logx = log10(C.maxPoint.y);
    }
  
    return pow(10, logx);
}

// Transformations from RGB to other color representations
float rgb_2_hue(float3 rgb)
{
	// Returns a geometric hue angle in degrees (0-360) based on RGB values.
	// For neutral colors, hue is undefined and the function will return a quiet NaN value.
    float hue;
    if (rgb[0] == rgb[1] && rgb[1] == rgb[2])
    {
		//hue = FLT_NAN; // RGB triplets where RGB are equal have an undefined hue
        hue = 0;
    }
    else
    {
        hue = (180. / 3.14159265359) * atan2(sqrt(3.0) * (rgb[1] - rgb[2]), 2 * rgb[0] - rgb[1] - rgb[2]);
    }

    if (hue < 0.)
        hue = hue + 360;

    return clamp(hue, 0, 360);
}

float rgb_2_yc(float3 rgb, float ycRadiusWeight = 1.75)
{
	// Converts RGB to a luminance proxy, here called YC
	// YC is ~ Y + K * Chroma
	// Constant YC is a cone-shaped surface in RGB space, with the tip on the 
	// neutral axis, towards white.
	// YC is normalized: RGB 1 1 1 maps to YC = 1
	//
	// ycRadiusWeight defaults to 1.75, although can be overridden in function 
	// call to rgb_2_yc
	// ycRadiusWeight = 1 -> YC for pure cyan, magenta, yellow == YC for neutral 
	// of same value
	// ycRadiusWeight = 2 -> YC for pure red, green, blue  == YC for  neutral of 
	// same value.

    float r = rgb[0];
    float g = rgb[1];
    float b = rgb[2];
  
    float chroma = sqrt(b * (b - g) + g * (g - r) + r * (r - b));

    return (b + g + r + ycRadiusWeight * chroma) / 3.;
}

// 
// Reference Rendering Transform (RRT)
//
//   Input is ACES
//   Output is OCES
//
float3 RRT(float3 aces)
{
	// "Glow" module constants
    const float RRT_GLOW_GAIN = 0.05;
    const float RRT_GLOW_MID = 0.08;

    float saturation = rgb_2_saturation(aces);
    float ycIn = rgb_2_yc(aces);
    float s = sigmoid_shaper((saturation - 0.4) / 0.2);
    float addedGlow = 1 + glow_fwd(ycIn, RRT_GLOW_GAIN * s, RRT_GLOW_MID);
    aces *= addedGlow;
  
	// --- Red modifier --- //
    const float RRT_RED_SCALE = 0.82;
    const float RRT_RED_PIVOT = 0.03;
    const float RRT_RED_HUE = 0;
    const float RRT_RED_WIDTH = 135;
    float hue = rgb_2_hue(aces);
    float centeredHue = center_hue(hue, RRT_RED_HUE);
    float hueWeight = cubic_basis_shaper(centeredHue, RRT_RED_WIDTH);
		
    aces.r += hueWeight * saturation * (RRT_RED_PIVOT - aces.r) * (1. - RRT_RED_SCALE);

	// --- ACES to RGB rendering space --- //
    aces = clamp(aces, 0, 65535); // avoids saturated negative colors from becoming positive in the matrix

    float3 rgbPre = mul(AP0_2_AP1_MAT, aces);

    rgbPre = clamp(rgbPre, 0, 65535);

	// --- Global desaturation --- //
    const float RRT_SAT_FACTOR = 0.96;
    rgbPre = lerp(dot(rgbPre, AP1_RGB2Y), rgbPre, RRT_SAT_FACTOR);

	// --- Apply the tonescale independently in rendering-space RGB --- //
    float3 rgbPost;
    rgbPost[0] = segmented_spline_c5_fwd(rgbPre[0]);
    rgbPost[1] = segmented_spline_c5_fwd(rgbPre[1]);
    rgbPost[2] = segmented_spline_c5_fwd(rgbPre[2]);

	// --- RGB rendering space to OCES --- //
    float3 rgbOces = mul(AP1_2_AP0_MAT, rgbPost);
    return rgbOces;
}

// 
// Inverse Reference Rendering Transform (RRT)
//
//   Input is OCES
//   Output is ACES
//

float3 Inverse_RRT(float3 oces)
{
	// "Glow" module constants
    const float RRT_GLOW_GAIN = 0.05;
    const float RRT_GLOW_MID = 0.08;

	// --- OCES to RGB rendering space --- //
    float3 rgbPre = mul(AP0_2_AP1_MAT, oces);

	// --- Apply the tonescale independently in rendering-space RGB --- //
    float3 rgbPost;
    rgbPost[0] = segmented_spline_c5_rev(rgbPre[0]);
    rgbPost[1] = segmented_spline_c5_rev(rgbPre[1]);
    rgbPost[2] = segmented_spline_c5_rev(rgbPre[2]);

	// --- Global desaturation --- //
    const float RRT_SAT_FACTOR = 0.96;
    rgbPost = lerp(dot(rgbPost, AP1_RGB2Y), rgbPost, 1.0 / RRT_SAT_FACTOR);

    rgbPost = clamp(rgbPost, 0., HALF_MAX);

	// --- RGB rendering space to ACES --- //
    float3 aces = mul(AP1_2_AP0_MAT, rgbPost);

    aces = clamp(aces, 0., HALF_MAX);

	// --- Red modifier --- //
    const float RRT_RED_SCALE = 0.82;
    const float RRT_RED_PIVOT = 0.03;
    const float RRT_RED_HUE = 0;
    const float RRT_RED_WIDTH = 135;
    float hue = rgb_2_hue(aces);
    float centeredHue = center_hue(hue, RRT_RED_HUE);
    float hueWeight = cubic_basis_shaper(centeredHue, RRT_RED_WIDTH);

    float minChan;
    if (centeredHue < 0)
    {
		// min_f3(aces) = aces[1] (i.e. magenta-red)
        minChan = aces[1];
    }
    else
    { // min_f3(aces) = aces[2] (i.e. yellow-red)
        minChan = aces[2];
    }

    float a = hueWeight * (1. - RRT_RED_SCALE) - 1.;
    float b = aces[0] - hueWeight * (RRT_RED_PIVOT + minChan) * (1. - RRT_RED_SCALE);
    float c = hueWeight * RRT_RED_PIVOT * minChan * (1. - RRT_RED_SCALE);

    aces[0] = (-b - sqrt(b * b - 4. * a * c)) / (2. * a);

	// --- Glow module --- //
    float saturation = rgb_2_saturation(aces);
    float ycOut = rgb_2_yc(aces);
    float s = sigmoid_shaper((saturation - 0.4) / 0.2);
    float reducedGlow = 1. + glow_inv(ycOut, RRT_GLOW_GAIN * s, RRT_GLOW_MID);

    aces = reducedGlow * aces;

	// Assign ACES RGB to output variables (ACES)
    return aces;
}



// Transformations between CIE XYZ tristimulus values and CIE x,y 
// chromaticity coordinates
float3 XYZ_2_xyY(float3 XYZ)
{
    float3 xyY;
    float divisor = (XYZ[0] + XYZ[1] + XYZ[2]);
    if (divisor == 0.)
        divisor = 1e-10;
    xyY[0] = XYZ[0] / divisor;
    xyY[1] = XYZ[1] / divisor;
    xyY[2] = XYZ[1];
  
    return xyY;
}

float3 xyY_2_XYZ(float3 xyY)
{
    float3 XYZ;
    XYZ[0] = xyY[0] * xyY[2] / max(xyY[1], 1e-10);
    XYZ[1] = xyY[2];
    XYZ[2] = (1.0 - xyY[0] - xyY[1]) * xyY[2] / max(xyY[1], 1e-10);

    return XYZ;
}


float3x3 ChromaticAdaptation(float2 src_xy, float2 dst_xy)
{
	// Von Kries chromatic adaptation 

	// Bradford
    const float3x3 ConeResponse =
    {
        0.8951, 0.2664, -0.1614,
		-0.7502, 1.7135, 0.0367,
		 0.0389, -0.0685, 1.0296,
    };
    const float3x3 InvConeResponse =
    {
        0.9869929, -0.1470543, 0.1599627,
		 0.4323053, 0.5183603, 0.0492912,
		-0.0085287, 0.0400428, 0.9684867,
    };

    float3 src_XYZ = xyY_2_XYZ(float3(src_xy, 1));
    float3 dst_XYZ = xyY_2_XYZ(float3(dst_xy, 1));

    float3 src_coneResp = mul(ConeResponse, src_XYZ);
    float3 dst_coneResp = mul(ConeResponse, dst_XYZ);

    float3x3 VonKriesMat =
    {
        { dst_coneResp[0] / src_coneResp[0], 0.0, 0.0 },
        { 0.0, dst_coneResp[1] / src_coneResp[1], 0.0 },
        { 0.0, 0.0, dst_coneResp[2] / src_coneResp[2] }
    };

    return mul(InvConeResponse, mul(VonKriesMat, ConeResponse));
}

float Y_2_linCV(float Y, float Ymax, float Ymin)
{
    return (Y - Ymin) / (Ymax - Ymin);
}

float linCV_2_Y(float linCV, float Ymax, float Ymin)
{
    return linCV * (Ymax - Ymin) + Ymin;
}

// Gamma compensation factor
static const float DIM_SURROUND_GAMMA = 0.9811;

float3 darkSurround_to_dimSurround(float3 linearCV)
{
    float3 XYZ = mul(AP1_2_XYZ_MAT, linearCV);

    float3 xyY = XYZ_2_xyY(XYZ);
    xyY[2] = clamp(xyY[2], 0, 65535);
    xyY[2] = pow(xyY[2], DIM_SURROUND_GAMMA);
    XYZ = xyY_2_XYZ(xyY);

    return mul(XYZ_2_AP1_MAT, XYZ);
}

float3 dimSurround_to_darkSurround(float3 linearCV)
{
    float3 XYZ = mul(linearCV, AP1_2_XYZ_MAT);

    float3 xyY = XYZ_2_xyY(XYZ);
    xyY[2] = clamp(xyY[2], 0., 65535);
    xyY[2] = pow(xyY[2], 1. / DIM_SURROUND_GAMMA);
    XYZ = xyY_2_XYZ(xyY);

    return mul(XYZ, XYZ_2_AP1_MAT);
}

float3 ODT_sRGB_D65(float3 oces)
{
	// OCES to RGB rendering space
    float3 rgbPre = mul(AP0_2_AP1_MAT, oces);

    const SegmentedSplineParams_c9 ODT_48nits =
    {
		// coefsLow[10]
        { -1.6989700043, -1.6989700043, -1.4779000000, -1.2291000000, -0.8648000000, -0.4480000000, 0.0051800000, 0.4511080334, 0.9113744414, 0.9113744414 },
		// coefsHigh[10]
        { 0.5154386965, 0.8470437783, 1.1358000000, 1.3802000000, 1.5197000000, 1.5985000000, 1.6467000000, 1.6746091357, 1.6878733390, 1.6878733390 },
        { segmented_spline_c5_fwd(0.18 * exp2(-6.5)), 0.02 }, // minPoint
        { segmented_spline_c5_fwd(0.18), 4.8 }, // midPoint  
        { segmented_spline_c5_fwd(0.18 * exp2(6.5)), 48.0 }, // maxPoint
		0.0, // slopeLow
		0.04 // slopeHigh
    };

	// Apply the tonescale independently in rendering-space RGB
    float3 rgbPost;
    rgbPost[0] = segmented_spline_c9_fwd(rgbPre[0], ODT_48nits);
    rgbPost[1] = segmented_spline_c9_fwd(rgbPre[1], ODT_48nits);
    rgbPost[2] = segmented_spline_c9_fwd(rgbPre[2], ODT_48nits);

	// Target white and black points for cinema system tonescale
    const float CINEMA_WHITE = 48.0;
    const float CINEMA_BLACK = 0.02; // CINEMA_WHITE / 2400.

	// Scale luminance to linear code value
    float3 linearCV;
    linearCV[0] = Y_2_linCV(rgbPost[0], CINEMA_WHITE, CINEMA_BLACK);
    linearCV[1] = Y_2_linCV(rgbPost[1], CINEMA_WHITE, CINEMA_BLACK);
    linearCV[2] = Y_2_linCV(rgbPost[2], CINEMA_WHITE, CINEMA_BLACK);

	// Apply gamma adjustment to compensate for dim surround
    linearCV = darkSurround_to_dimSurround(linearCV);

	// Apply desaturation to compensate for luminance difference
    const float ODT_SAT_FACTOR = 0.93;
    linearCV = lerp(dot(linearCV, AP1_RGB2Y), linearCV, ODT_SAT_FACTOR);

	// Convert to display primary encoding
	// Rendering space RGB to XYZ
    float3 XYZ = mul(AP1_2_XYZ_MAT, linearCV);
	
	// Apply CAT from ACES white point to assumed observer adapted white point
    XYZ = mul(D60_2_D65_CAT, XYZ);

	// CIE XYZ to display primaries
    linearCV = mul(XYZ_2_sRGB_MAT, XYZ);

	// Handle out-of-gamut values
	// Clip values < 0 or > 1 (i.e. projecting outside the display primaries)
    linearCV = saturate(linearCV);

    return linearCV;
}

float3 Inverse_ODT_sRGB_D65(float3 linearCV)
{
	// Convert from display primary encoding
	// Display primaries to CIE XYZ
    float3 XYZ = mul(sRGB_2_XYZ_MAT, linearCV);

	// CIE XYZ to rendering space RGB
    linearCV = mul(XYZ_2_AP1_MAT, XYZ);

	// Apply CAT from ACES white point to assumed observer adapted white point
    XYZ = mul(D65_2_D60_CAT, XYZ);

	// Undo desaturation to compensate for luminance difference
    const float ODT_SAT_FACTOR = 0.93;
    linearCV = lerp(dot(linearCV, AP1_RGB2Y), linearCV, 1.0 / ODT_SAT_FACTOR);

	// Undo gamma adjustment to compensate for dim surround
    linearCV = dimSurround_to_darkSurround(linearCV);

	// Target white and black points for cinema system tonescale
    const float CINEMA_WHITE = 48.0;
    const float CINEMA_BLACK = 0.02; // CINEMA_WHITE / 2400.

	// Scale linear code value to luminance
    float3 rgbPre;
    rgbPre[0] = linCV_2_Y(linearCV[0], CINEMA_WHITE, CINEMA_BLACK);
    rgbPre[1] = linCV_2_Y(linearCV[1], CINEMA_WHITE, CINEMA_BLACK);
    rgbPre[2] = linCV_2_Y(linearCV[2], CINEMA_WHITE, CINEMA_BLACK);

    const SegmentedSplineParams_c9 ODT_48nits =
    {
		// coefsLow[10]
        { -1.6989700043, -1.6989700043, -1.4779000000, -1.2291000000, -0.8648000000, -0.4480000000, 0.0051800000, 0.4511080334, 0.9113744414, 0.9113744414 },
		// coefsHigh[10]
        { 0.5154386965, 0.8470437783, 1.1358000000, 1.3802000000, 1.5197000000, 1.5985000000, 1.6467000000, 1.6746091357, 1.6878733390, 1.6878733390 },
        { segmented_spline_c5_fwd(0.18 * pow(2., -6.5)), 0.02 }, // minPoint
        { segmented_spline_c5_fwd(0.18), 4.8 }, // midPoint  
        { segmented_spline_c5_fwd(0.18 * pow(2., 6.5)), 48.0 }, // maxPoint
		0.0, // slopeLow
		0.04 // slopeHigh
    };

	// Apply the tonescale independently in rendering-space RGB
    float3 rgbPost;
    rgbPost[0] = segmented_spline_c9_rev(rgbPre[0], ODT_48nits);
    rgbPost[1] = segmented_spline_c9_rev(rgbPre[1], ODT_48nits);
    rgbPost[2] = segmented_spline_c9_rev(rgbPre[2], ODT_48nits);

	// Rendering space RGB to OCES
    float3 oces = mul(AP1_2_AP0_MAT, rgbPost);

    return oces;
}

float3 ODT_1000nits(float3 oces)
{
	// OCES to RGB rendering space
    float3 rgbPre = mul(AP0_2_AP1_MAT, oces);

    const SegmentedSplineParams_c9 ODT_1000nits =
    {
		// coefsLow[10]
        { -4.9706219331, -3.0293780669, -2.1262, -1.5105, -1.0578, -0.4668, 0.11938, 0.7088134201, 1.2911865799, 1.2911865799 },
		// coefsHigh[10]
        { 0.8089132070, 1.1910867930, 1.5683, 1.9483, 2.3083, 2.6384, 2.8595, 2.9872608805, 3.0127391195, 3.0127391195 },
        { segmented_spline_c5_fwd(0.18 * pow(2., -12.)), 0.0001 }, // minPoint
        { segmented_spline_c5_fwd(0.18), 10.0 }, // midPoint  
        { segmented_spline_c5_fwd(0.18 * pow(2., 10.)), 1000.0 }, // maxPoint
		3.0, // slopeLow
		0.06 // slopeHigh
    };

	// Apply the tonescale independently in rendering-space RGB
    float3 rgbPost;
    rgbPost[0] = segmented_spline_c9_fwd(rgbPre[0], ODT_1000nits);
    rgbPost[1] = segmented_spline_c9_fwd(rgbPre[1], ODT_1000nits);
    rgbPost[2] = segmented_spline_c9_fwd(rgbPre[2], ODT_1000nits);

	// Subtract small offset to allow for a code value of 0
    rgbPost -= 0.00003507384284432574;

    return rgbPost;
}

float3 ODT_2000nits(float3 oces)
{
	// OCES to RGB rendering space
    float3 rgbPre = mul(AP0_2_AP1_MAT, oces);

    const SegmentedSplineParams_c9 ODT_2000nits =
    {
	  // coefsLow[10]
        { -2.3010299957, -2.3010299957, -1.9312000000, -1.5205000000, -1.0578000000, -0.4668000000, 0.1193800000, 0.7088134201, 1.2911865799, 1.2911865799 },
	  // coefsHigh[10]
        { 0.8019952042, 1.1980047958, 1.5943000000, 1.9973000000, 2.3783000000, 2.7684000000, 3.0515000000, 3.2746293562, 3.3274306351, 3.3274306351 },
        { segmented_spline_c5_fwd(0.18 * pow(2., -12.)), 0.005 }, // minPoint
        { segmented_spline_c5_fwd(0.18), 10.0 }, // midPoint  
        { segmented_spline_c5_fwd(0.18 * pow(2., 11.)), 2000.0 }, // maxPoint
	  0.0, // slopeLow
	  0.12 // slopeHigh
    };

	// Apply the tonescale independently in rendering-space RGB
    float3 rgbPost;
    rgbPost[0] = segmented_spline_c9_fwd(rgbPre[0], ODT_2000nits);
    rgbPost[1] = segmented_spline_c9_fwd(rgbPre[1], ODT_2000nits);
    rgbPost[2] = segmented_spline_c9_fwd(rgbPre[2], ODT_2000nits);

    return rgbPost;
}

//====================================================================================================
// PART 2: FROM GammaCorrectionCommon.ush.hlsl
// (Provides gamma correction, log/lin conversions, and ST2084/PQ functions)
//====================================================================================================

half3 LinearTo709Branchless(half3 lin)
{
    lin = max(6.10352e-5, lin); // minimum positive non-denormal (fixes black problem on DX11 AMD and NV)
    return min(lin * 4.5, pow(max(lin, 0.018), 0.45) * 1.099 - 0.099);
}

half3 LinearToSrgbBranchless(half3 lin)
{
    lin = max(6.10352e-5, lin); // minimum positive non-denormal (fixes black problem on DX11 AMD and NV)
    return min(lin * 12.92, pow(max(lin, 0.00313067), 1.0 / 2.4) * 1.055 - 0.055);
}

half LinearToSrgbBranchingChannel(half lin)
{
    if (lin < 0.00313067)
        return lin * 12.92;
    return pow(lin, (1.0 / 2.4)) * 1.055 - 0.055;
}

half3 LinearToSrgbBranching(half3 lin)
{
    return half3(
		LinearToSrgbBranchingChannel(lin.r),
		LinearToSrgbBranchingChannel(lin.g),
		LinearToSrgbBranchingChannel(lin.b));
}

half3 LinearToSrgb(half3 lin)
{
#if FEATURE_LEVEL > FEATURE_LEVEL_ES3_1
	// Branching is faster than branchless on AMD on PC.
	return LinearToSrgbBranching(lin);
#else
	// Adreno devices(Nexus5) with Android 4.4.2 do not handle branching version well, so always use branchless on Mobile
    return LinearToSrgbBranchless(lin);
#endif
}

half3 sRGBToLinear(half3 Color)
{
    Color = max(6.10352e-5, Color); // minimum positive non-denormal (fixes black problem on DX11 AMD and NV)
    return Color > 0.04045 ? pow(Color * (1.0 / 1.055) + 0.0521327, 2.4) : Color * (1.0 / 12.92);
}

/**
 * @param GammaCurveRatio The curve ratio compared to a 2.2 standard gamma, e.g. 2.2 / DisplayGamma.  So normally the value is 1.
 */
half3 ApplyGammaCorrection(half3 LinearColor, half GammaCurveRatio)
{
	// Apply "gamma" curve adjustment.
    half3 CorrectedColor = pow(LinearColor, GammaCurveRatio);

#if MAC
		// Note, MacOSX native output is raw gamma 2.2 not sRGB!
		CorrectedColor = pow(CorrectedColor, 1.0/2.2);
#else
#if USE_709
			// Didn't profile yet if the branching version would be faster (different linear segment).
			CorrectedColor = LinearTo709Branchless(CorrectedColor);
#else
    CorrectedColor = LinearToSrgb(CorrectedColor);
#endif
#endif

    return CorrectedColor;
}

//
// Generic log lin transforms
//
float3 LogToLin(float3 LogColor)
{
    const float LinearRange = 14;
    const float LinearGrey = 0.18;
    const float ExposureGrey = 444;

	// Using stripped down, 'pure log', formula. Parameterized by grey points and dynamic range covered.
    float3 LinearColor = exp2((LogColor - ExposureGrey / 1023.0) * LinearRange) * LinearGrey;
    return LinearColor;
}

float3 LinToLog(float3 LinearColor)
{
    const float LinearRange = 14;
    const float LinearGrey = 0.18;
    const float ExposureGrey = 444;

	// Using stripped down, 'pure log', formula. Parameterized by grey points and dynamic range covered.
    float3 LogColor = log2(LinearColor) / LinearRange - log2(LinearGrey) / LinearRange + ExposureGrey / 1023.0; // scalar: 3log2 3mad
    LogColor = saturate(LogColor);
    return LogColor;
}

//
// Dolby PQ transforms
//
float3
ST2084ToLinear(float3 pq)
{
    const float m1 = 0.1593017578125; // = 2610. / 4096. * .25;
    const float m2 = 78.84375; // = 2523. / 4096. *  128;
    const float c1 = 0.8359375; // = 2392. / 4096. * 32 - 2413./4096.*32 + 1;
    const float c2 = 18.8515625; // = 2413. / 4096. * 32;
    const float c3 = 18.6875; // = 2392. / 4096. * 32;
    const float C = 10000.;

    float3 Np = pow(pq, 1. / m2);
    float3 L = Np - c1;
    L = max(0., L);
    L = L / (c2 - c3 * Np);
    L = pow(L, 1. / m1);
    float3 P = L * C;

    return P;
}

float3
LinearToST2084(float3 lin)
{
    const float m1 = 0.1593017578125; // = 2610. / 4096. * .25;
    const float m2 = 78.84375; // = 2523. / 4096. *  128;
    const float c1 = 0.8359375; // = 2392. / 4096. * 32 - 2413./4096.*32 + 1;
    const float c2 = 18.8515625; // = 2413. / 4096. * 32;
    const float c3 = 18.6875; // = 2392. / 4096. * 32;
    const float C = 10000.;

    float3 L = lin / C;
    float3 Lm = pow(L, m1);
    float3 N1 = (c1 + c2 * Lm);
    float3 N2 = (1.0 + c3 * Lm);
    float3 N = N1 * rcp(N2);
    float3 P = pow(N, m2);
	
    return P;
}

//====================================================================================================
// PART 3: FROM TonemapCommon.ush.hlsl
// (Provides Film Tonemapping function and other ACES/Gamut helpers)
//====================================================================================================

// usually 1/2.2, the .y is used for inverse gamma when "gamma only" mode is not used
half3 InverseGamma;

// Scale factor for converting pixel values to nits. 
static const float LinearToNitsScale = 100.0;
static const float LinearToNitsScaleInverse = 1.0 / 100.0;

// Film tonal and color control.
half4 ColorMatrixR_ColorCurveCd1;
half4 ColorMatrixG_ColorCurveCd3Cm3;
half4 ColorMatrixB_ColorCurveCm2;
half4 ColorCurve_Cm0Cd0_Cd2_Ch0Cm1_Ch3;
half4 ColorCurve_Ch1_Ch2;
half4 ColorShadow_Luma;
half4 ColorShadow_Tint1;
half4 ColorShadow_Tint2;

half3 FilmPostProcess(half3 LinearColor)
{
	// Color and exposure control.
    half3 MatrixColor;
#if USE_COLOR_MATRIX == 1
		// Apply color matrix (channel mixer, exposure, saturation).
		MatrixColor.r = dot(LinearColor, ColorMatrixR_ColorCurveCd1.rgb);
		MatrixColor.g = dot(LinearColor, ColorMatrixG_ColorCurveCd3Cm3.rgb);
		MatrixColor.b = dot(LinearColor, ColorMatrixB_ColorCurveCm2.rgb);
#if USE_SHADOW_TINT == 1
			MatrixColor *= ColorShadow_Tint1.rgb + ColorShadow_Tint2.rgb * rcp(dot(LinearColor, ColorShadow_Luma.rgb) + 1.0);
#endif
		// Required to insure saturation doesn't create negative colors!
		MatrixColor = max(half3(0.0, 0.0, 0.0), MatrixColor);
#else
		// Less expensive route when not using saturation and channel mixer.
#if USE_SHADOW_TINT == 1
			MatrixColor = LinearColor * (ColorShadow_Tint1.rgb + ColorShadow_Tint2.rgb * rcp(dot(LinearColor, ColorShadow_Luma.rgb) + 1.0));
#else
    MatrixColor = LinearColor * ColorMatrixB_ColorCurveCm2.rgb;
#endif
#endif
	// Apply color curve (includes tonemapping).
#if USE_CONTRAST == 1
		// Full path.
		half3 MatrixColorD = max(0, ColorCurve_Cm0Cd0_Cd2_Ch0Cm1_Ch3.xxx - MatrixColor);
		half3 MatrixColorH = max(MatrixColor, ColorCurve_Cm0Cd0_Cd2_Ch0Cm1_Ch3.zzz);
		half3 MatrixColorM = clamp(MatrixColor, ColorCurve_Cm0Cd0_Cd2_Ch0Cm1_Ch3.xxx, ColorCurve_Cm0Cd0_Cd2_Ch0Cm1_Ch3.zzz);
		half3 CurveColor = 
			// Highlights
			(MatrixColorH*ColorCurve_Ch1_Ch2.xxx + ColorCurve_Ch1_Ch2.yyy) * rcp(MatrixColorH + ColorCurve_Cm0Cd0_Cd2_Ch0Cm1_Ch3.www) + 
				// Midtones
				((MatrixColorM*ColorMatrixB_ColorCurveCm2.aaa + 
					// Darks
					((MatrixColorD*ColorMatrixR_ColorCurveCd1.aaa) * rcp(MatrixColorD + ColorCurve_Cm0Cd0_Cd2_Ch0Cm1_Ch3.yyy) + ColorMatrixG_ColorCurveCd3Cm3.aaa)));
#else
		// This is for mobile, it assumes color is not negative.
		// Fast path when contrast=1, can remove the dark part of the curve.
    half3 MatrixColorH = max(MatrixColor, ColorCurve_Cm0Cd0_Cd2_Ch0Cm1_Ch3.zzz);
    half3 MatrixColorM = min(MatrixColor, ColorCurve_Cm0Cd0_Cd2_Ch0Cm1_Ch3.zzz);
    half3 CurveColor = (MatrixColorH * ColorCurve_Ch1_Ch2.xxx + ColorCurve_Ch1_Ch2.yyy) * rcp(MatrixColorH + ColorCurve_Cm0Cd0_Cd2_Ch0Cm1_Ch3.www) + MatrixColorM;
#endif

	// Must hit black by log10(-2.474)
    CurveColor -= 0.002;

    return CurveColor;
}

float FilmSlope;
float FilmToe;
float FilmShoulder;
float FilmBlackClip;
float FilmWhiteClip;

half3 FilmToneMap(half3 LinearColor)
{
    float3 ColorAP1 = LinearColor;
	
	// Use ACEScg primaries as working space
    float3 WorkingColor = ColorAP1;

    WorkingColor = max(0, WorkingColor);

	// Pre desaturate
    WorkingColor = lerp(dot(WorkingColor, AP1_RGB2Y), WorkingColor, 0.96);
	
    const half ToeScale = 1 + FilmBlackClip - FilmToe;
    const half ShoulderScale = 1 + FilmWhiteClip - FilmShoulder;
	
    const float InMatch = 0.18;
    const float OutMatch = 0.18;

    float ToeMatch;
    if (FilmToe > 0.8)
    {
		// 0.18 will be on straight segment
        ToeMatch = (1 - FilmToe - OutMatch) / FilmSlope + log10(InMatch);
    }
    else
    {
		// 0.18 will be on toe segment

		// Solve for ToeMatch such that input of InMatch gives output of OutMatch.
        const float bt = (OutMatch + FilmBlackClip) / ToeScale - 1;
        ToeMatch = log10(InMatch) - 0.5 * log((1 + bt) / (1 - bt)) * (ToeScale / FilmSlope);
    }

    float StraightMatch = (1 - FilmToe) / FilmSlope - ToeMatch;
    float ShoulderMatch = FilmShoulder / FilmSlope - StraightMatch;
	
    half3 LogColor = log10(WorkingColor);
    half3 StraightColor = FilmSlope * (LogColor + StraightMatch);
	
    half3 ToeColor = (-FilmBlackClip) + (2 * ToeScale) / (1 + exp((-2 * FilmSlope / ToeScale) * (LogColor - ToeMatch)));
    half3 ShoulderColor = (1 + FilmWhiteClip) - (2 * ShoulderScale) / (1 + exp((2 * FilmSlope / ShoulderScale) * (LogColor - ShoulderMatch)));

    ToeColor = LogColor < ToeMatch ? ToeColor : StraightColor;
    ShoulderColor = LogColor > ShoulderMatch ? ShoulderColor : StraightColor;

    half3 t = saturate((LogColor - ToeMatch) / (ShoulderMatch - ToeMatch));
    t = ShoulderMatch < ToeMatch ? 1 - t : t;
    t = (3 - 2 * t) * t * t;
    half3 ToneColor = lerp(ToeColor, ShoulderColor, t);

	// Post desaturate
    ToneColor = lerp(dot(float3(ToneColor), AP1_RGB2Y), ToneColor, 0.93);

	// Returning positive AP1 values
    return max(0, ToneColor);
}

//
// ACES D65 1000 nit Output Transform - Forward
//  Input is scene-referred linear values in the sRGB gamut
//  Output is output-referred linear values in the AP1 gamut
//
float3 ACESOutputTransforms1000(float3 SceneReferredLinearsRGBColor)
{
    const float3x3 sRGB_2_AP0 = mul(XYZ_2_AP0_MAT, mul(D65_2_D60_CAT, sRGB_2_XYZ_MAT));

    float3 aces = mul(sRGB_2_AP0, SceneReferredLinearsRGBColor * 1.5);
    float3 oces = RRT(aces);
    float3 OutputReferredLinearAP1Color = ODT_1000nits(oces);
    return OutputReferredLinearAP1Color;
}

//
// ACES D65 2000 nit Output Transform - Forward
//  Input is scene-referred linear values in the sRGB gamut
//  Output is output-referred linear values in the AP1 gamut
//
float3 ACESOutputTransforms2000(float3 SceneReferredLinearsRGBColor)
{
    const float3x3 sRGB_2_AP0 = mul(XYZ_2_AP0_MAT, mul(D65_2_D60_CAT, sRGB_2_XYZ_MAT));

    float3 aces = mul(sRGB_2_AP0, SceneReferredLinearsRGBColor * 1.5);
    float3 oces = RRT(aces);
    float3 OutputReferredLinearAP1Color = ODT_2000nits(oces);
    return OutputReferredLinearAP1Color;
}

static const float3x3 GamutMappingIdentityMatrix = { 1.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 1.0 };

//
// Gamut conversion matrices
//
float3x3 OuputGamutMappingMatrix(uint OutputGamut)
{
	// Gamut mapping matrices used later
    const float3x3 AP1_2_sRGB = mul(XYZ_2_sRGB_MAT, mul(D60_2_D65_CAT, AP1_2_XYZ_MAT));
    const float3x3 AP1_2_DCI_D65 = mul(XYZ_2_P3D65_MAT, mul(D60_2_D65_CAT, AP1_2_XYZ_MAT));
    const float3x3 AP1_2_Rec2020 = mul(XYZ_2_Rec2020_MAT, mul(D60_2_D65_CAT, AP1_2_XYZ_MAT));

	// Set gamut mapping matrix 
	// 0 = sRGB - D65
	// 1 = P3 - D65
	// 2 = Rec.2020 - D65
	// 3 = ACES AP0 - D60
	// 4 = ACES AP1 - D60

    if (OutputGamut == 1)
        return AP1_2_DCI_D65;
    else if (OutputGamut == 2)
        return AP1_2_Rec2020;
    else if (OutputGamut == 3)
        return AP1_2_AP0_MAT;
    else if (OutputGamut == 4)
        return GamutMappingIdentityMatrix;
    else
        return AP1_2_sRGB;
}

float3 ST2084ToScRGB(float3 Color, uint OutputDevice)
{
	// Nvidia HDR encoding - Remove PQ, convert to linear scRGB
    const float3x3 AP1_2_sRGB = mul(XYZ_2_sRGB_MAT, AP1_2_XYZ_MAT);
    const float WhitePoint = 80.f;

	// 1000.f nit display
    float MaxODTNits = 1000.0f;
    float MinODTNits = 0.0001f;

    if (OutputDevice == 4 || OutputDevice == 6)
    {
		// 2000 nit display
        MaxODTNits = 2000.0f;
        MinODTNits = 0.005f;
    }

    float3 OutColor = ST2084ToLinear(Color);
		
    OutColor = clamp(OutColor, MinODTNits, MaxODTNits);
    OutColor.x = Y_2_linCV(OutColor.x, MaxODTNits, MinODTNits);
    OutColor.y = Y_2_linCV(OutColor.y, MaxODTNits, MinODTNits);
    OutColor.z = Y_2_linCV(OutColor.z, MaxODTNits, MinODTNits);

    float scRGBScale = MaxODTNits / WhitePoint;
    OutColor = mul(AP1_2_sRGB, OutColor) * scRGBScale;

    return OutColor;
}

//====================================================================================================
// PART 4: FROM PostProcessCombineLUTs.usf.hlsl
// (The main LUT generation logic)
//====================================================================================================

// UNIFORMS (to be set from C#)
half3 ColorScale;
half4 OverlayColor;
uint bUseMobileTonemapper;
static const float LUTSize = 32;
float WhiteTemp;
float WhiteTint;
float4 ColorSaturation, ColorContrast, ColorGamma, ColorGain, ColorOffset;
float4 ColorSaturationShadows, ColorContrastShadows, ColorGammaShadows, ColorGainShadows, ColorOffsetShadows;
float4 ColorSaturationMidtones, ColorContrastMidtones, ColorGammaMidtones, ColorGainMidtones, ColorOffsetMidtones;
float4 ColorSaturationHighlights, ColorContrastHighlights, ColorGammaHighlights, ColorGainHighlights, ColorOffsetHighlights;
float ColorCorrectionShadowsMax, ColorCorrectionHighlightsMin;
uint OutputDevice;
uint OutputGamut;
float BlueCorrection;
float ExpandGamut;
float ToneCurveAmount;


// Helper functions from PostProcessCombineLUTs
float2 PlanckianLocusChromaticity(float Temp)
{
    float u = (0.860117757f + 1.54118254e-4f * Temp + 1.28641212e-7f * Temp * Temp) / (1.0f + 8.42420235e-4f * Temp + 7.08145163e-7f * Temp * Temp);
    float v = (0.317398726f + 4.22806245e-5f * Temp + 4.20481691e-8f * Temp * Temp) / (1.0f - 2.89741816e-5f * Temp + 1.61456053e-7f * Temp * Temp);

    float x = 3 * u / (2 * u - 8 * v + 4);
    float y = 2 * v / (2 * u - 8 * v + 4);

    return float2(x, y);
}

// Accurate for 4000K < Temp < 25000K
// in: correlated color temperature
// out: CIE 1931 chromaticity
float2 D_IlluminantChromaticity(float Temp)
{
	// Correct for revision of Plank's law
	// This makes 6500 == D65
    Temp *= 1.4388 / 1.438;

    float x = Temp <= 7000 ?
				0.244063 + (0.09911e3 + (2.9678e6 - 4.6070e9 / Temp) / Temp) / Temp :
				0.237040 + (0.24748e3 + (1.9018e6 - 2.0064e9 / Temp) / Temp) / Temp;
	
    float y = -3 * x * x + 2.87 * x - 0.275;

    return float2(x, y);
}

float2 PlanckianIsothermal(float Temp, float Tint)
{
    float u = (0.860117757f + 1.54118254e-4f * Temp + 1.28641212e-7f * Temp * Temp) / (1.0f + 8.42420235e-4f * Temp + 7.08145163e-7f * Temp * Temp);
    float v = (0.317398726f + 4.22806245e-5f * Temp + 4.20481691e-8f * Temp * Temp) / (1.0f - 2.89741816e-5f * Temp + 1.61456053e-7f * Temp * Temp);

    float2 uvd = normalize(float2(u, v));

	// Correlated color temperature is meaningful within +/- 0.05
    u += -uvd.y * Tint * 0.05;
    v += uvd.x * Tint * 0.05;
	
    float x = 3 * u / (2 * u - 8 * v + 4);
    float y = 2 * v / (2 * u - 8 * v + 4);

    return float2(x, y);
}

float3 WhiteBalance(float3 LinearColor)
{
    float2 SrcWhiteDaylight = D_IlluminantChromaticity(WhiteTemp);
    float2 SrcWhitePlankian = PlanckianLocusChromaticity(WhiteTemp);

    float2 SrcWhite = WhiteTemp < 4000 ? SrcWhitePlankian : SrcWhiteDaylight;
    float2 D65White = float2(0.31270, 0.32900);

	{
		// Offset along isotherm
        float2 Isothermal = PlanckianIsothermal(WhiteTemp, WhiteTint) - SrcWhitePlankian;
        SrcWhite += Isothermal;
    }

    float3x3 WhiteBalanceMat = ChromaticAdaptation(SrcWhite, D65White);
    WhiteBalanceMat = mul(XYZ_2_sRGB_MAT, mul(WhiteBalanceMat, sRGB_2_XYZ_MAT));

    return mul(WhiteBalanceMat, LinearColor);
}

float3 ColorCorrect(float3 WorkingColor,
	float4 ColorSaturation,
	float4 ColorContrast,
	float4 ColorGamma,
	float4 ColorGain,
	float4 ColorOffset)
{
	// TODO optimize
    float Luma = dot(WorkingColor, AP1_RGB2Y);
    WorkingColor = max(0, lerp(Luma.xxx, WorkingColor, ColorSaturation.xyz * ColorSaturation.w));
    WorkingColor = pow(WorkingColor * (1.0 / 0.18), ColorContrast.xyz * ColorContrast.w) * 0.18;
    WorkingColor = pow(WorkingColor, 1.0 / (ColorGamma.xyz * ColorGamma.w));
    WorkingColor = WorkingColor * (ColorGain.xyz * ColorGain.w) + (ColorOffset.xyz + ColorOffset.w);
    return WorkingColor;
}

// Nuke-style Color Correct
float3 ColorCorrectAll(float3 WorkingColor)
{
    float Luma = dot(WorkingColor, AP1_RGB2Y);

	// Shadow CC
    float3 CCColorShadows = ColorCorrect(WorkingColor,
		ColorSaturationShadows * ColorSaturation,
		ColorContrastShadows * ColorContrast,
		ColorGammaShadows * ColorGamma,
		ColorGainShadows * ColorGain,
		ColorOffsetShadows + ColorOffset);
    float CCWeightShadows = 1 - smoothstep(0, ColorCorrectionShadowsMax, Luma);
	
	// Highlight CC
    float3 CCColorHighlights = ColorCorrect(WorkingColor,
		ColorSaturationHighlights * ColorSaturation,
		ColorContrastHighlights * ColorContrast,
		ColorGammaHighlights * ColorGamma,
		ColorGainHighlights * ColorGain,
		ColorOffsetHighlights + ColorOffset);
    float CCWeightHighlights = smoothstep(ColorCorrectionHighlightsMin, 1, Luma);

	// Midtone CC
    float3 CCColorMidtones = ColorCorrect(WorkingColor,
		ColorSaturationMidtones * ColorSaturation,
		ColorContrastMidtones * ColorContrast,
		ColorGammaMidtones * ColorGamma,
		ColorGainMidtones * ColorGain,
		ColorOffsetMidtones + ColorOffset);
    float CCWeightMidtones = 1 - CCWeightShadows - CCWeightHighlights;

	// Blend Shadow, Midtone and Highlight CCs
    float3 WorkingColorSMH = CCColorShadows * CCWeightShadows + CCColorMidtones * CCWeightMidtones + CCColorHighlights * CCWeightHighlights;
	
    return WorkingColorSMH;
}

uint GetOutputDevice()
{
#if FEATURE_LEVEL > FEATURE_LEVEL_ES3_1
	return OutputDevice;
#else
	// Only sRGB output for Mobile
    return 0;
#endif 
}

float4 CombineLUTsCommon(float2 InUV, uint InLayerIndex)
{
#if USE_VOLUME_LUT == 1
	// construct the neutral color from a 3d position volume texture	
	float4 Neutral;
	{
		float2 UV = InUV - float2(0.5f / LUTSize, 0.5f / LUTSize);

		Neutral = float4(UV * LUTSize / (LUTSize - 1), InLayerIndex / (LUTSize - 1), 0);
	}
#else
	// construct the neutral color from a 2d position in 256x16
    float4 Neutral;
	{ 
        float2 UV = InUV;

		// 0.49999f instead of 0.5f to avoid getting into negative values
        UV -= float2(0.49999f / (LUTSize * LUTSize), 0.49999f / LUTSize);

        float Scale = LUTSize / (LUTSize - 1);

        float3 RGB;
		
        RGB.r = frac(UV.x * LUTSize);
        RGB.b = UV.x - RGB.r / LUTSize;
        RGB.g = UV.y;

        Neutral = float4(RGB * Scale, 0);
    }
#endif

    float4 OutColor = 0;
	
	// AP1 to Working space matrices
    const float3x3 sRGB_2_AP1 = mul(XYZ_2_AP1_MAT, mul(D65_2_D60_CAT, sRGB_2_XYZ_MAT));
    const float3x3 AP1_2_sRGB = mul(XYZ_2_sRGB_MAT, mul(D60_2_D65_CAT, AP1_2_XYZ_MAT));

    const float3x3 AP0_2_AP1 = mul(XYZ_2_AP1_MAT, AP0_2_XYZ_MAT);
    const float3x3 AP1_2_AP0 = mul(XYZ_2_AP0_MAT, AP1_2_XYZ_MAT);

    const float3x3 AP1_2_Output = OuputGamutMappingMatrix(OutputGamut);

    float3 LUTEncodedColor = Neutral.rgb;
    float3 LinearColor;
	// Decode texture values as ST-2084 (Dolby PQ)
    if (GetOutputDevice() >= 3)
    {
		// Since ST2084 returns linear values in nits, divide by a scale factor to convert
		// the reference nit result to be 1.0 in linear.
		// (for efficiency multiply by precomputed inverse)
        LinearColor = ST2084ToLinear(LUTEncodedColor) * LinearToNitsScaleInverse;
    }
	// Decode log values
    else
        LinearColor = LogToLin(LUTEncodedColor) - LogToLin(0);

    float3 BalancedColor = WhiteBalance(LinearColor);
    float3 ColorAP1 = mul(sRGB_2_AP1, BalancedColor);

	// Expand bright saturated colors outside the sRGB gamut to fake wide gamut rendering.
    if (!bUseMobileTonemapper)
    {
        float LumaAP1 = dot(ColorAP1, AP1_RGB2Y);
        float3 ChromaAP1 = ColorAP1 / LumaAP1;

        float ChromaDistSqr = dot(ChromaAP1 - 1, ChromaAP1 - 1);
        float ExpandAmount = (1 - exp2(-4 * ChromaDistSqr)) * (1 - exp2(-4 * ExpandGamut * LumaAP1 * LumaAP1));

		// Bizarre matrix but this expands sRGB to between P3 and AP1
		// CIE 1931 chromaticities:	x		y
		//				Red:		0.6965	0.3065
		//				Green:		0.245	0.718
		//				Blue:		0.1302	0.0456
		//				White:		0.3127	0.329
        const float3x3 Wide_2_XYZ_MAT =
        {
            0.5441691, 0.2395926, 0.1666943,
			0.2394656, 0.7021530, 0.0583814,
			-0.0023439, 0.0361834, 1.0552183,
        };

        const float3x3 Wide_2_AP1 = mul(XYZ_2_AP1_MAT, Wide_2_XYZ_MAT);
        const float3x3 ExpandMat = mul(Wide_2_AP1, AP1_2_sRGB);

        float3 ColorExpand = mul(ExpandMat, ColorAP1);
        ColorAP1 = lerp(ColorAP1, ColorExpand, ExpandAmount);
    }

    ColorAP1 = ColorCorrectAll(ColorAP1);

	// Store for Legacy tonemap later and for Linear HDR output without tone curve
    float3 GradedColor = mul(AP1_2_sRGB, ColorAP1);

    const float3x3 BlueCorrect =
    {
        0.9404372683, -0.0183068787, 0.0778696104,
		0.0083786969, 0.8286599939, 0.1629613092,
		0.0005471261, -0.0008833746, 1.0003362486
    };
    const float3x3 BlueCorrectInv =
    {
        1.06318, 0.0233956, -0.0865726,
		-0.0106337, 1.20632, -0.19569,
		-0.000590887, 0.00105248, 0.999538
    };
    const float3x3 BlueCorrectAP1 = mul(AP0_2_AP1, mul(BlueCorrect, AP1_2_AP0));
    const float3x3 BlueCorrectInvAP1 = mul(AP0_2_AP1, mul(BlueCorrectInv, AP1_2_AP0));

	// Blue correction
    ColorAP1 = lerp(ColorAP1, mul(BlueCorrectAP1, ColorAP1), BlueCorrection);

	// Tonemapped color in the AP1 gamut
    float3 ToneMappedColorAP1 = FilmToneMap(ColorAP1);
    ColorAP1 = lerp(ColorAP1, ToneMappedColorAP1, ToneCurveAmount);

	// Uncorrect blue to maintain white point
    ColorAP1 = lerp(ColorAP1, mul(BlueCorrectInvAP1, ColorAP1), BlueCorrection);

	// Convert from AP1 to sRGB and clip out-of-gamut values
    float3 FilmColor = max(0, mul(AP1_2_sRGB, ColorAP1));

#if FEATURE_LEVEL > FEATURE_LEVEL_ES3_1 // Mobile path uses separate shader for legacy tone mapper
	if (bUseMobileTonemapper)
	{
		// Legacy tone mapper
		FilmColor = FilmPostProcess(GradedColor);
	}
#endif // FEATURE_LEVEL > FEATURE_LEVEL_ES3_1

	// blend with custom LDR color, used for Fade track in Matinee
    float3 FilmColorNoGamma = lerp(FilmColor * ColorScale, OverlayColor.rgb, OverlayColor.a);
	// Apply Fade track to linear outputs also
    GradedColor = lerp(GradedColor * ColorScale, OverlayColor.rgb, OverlayColor.a);


	// Apply "gamma" curve adjustment.
    FilmColor = pow(max(0, FilmColorNoGamma), InverseGamma.y);
		
	// Note: Any changes to the following device encoding logic must also be made 
	// in PostProcessDeviceEncodingOnly.usf's corresponding pixel shader.
    half3 OutDeviceColor = 0;

	// sRGB, user specified gamut
    if (GetOutputDevice() == 0)
    {
		// FIXME: Workaround for UE-29935, pushing all colors with a 0 component to black output
		// Default parameters seem to cancel out (sRGB->XYZ->AP1->XYZ->sRGB), so should be okay for a temp fix
        float3 OutputGamutColor = FilmColor;

		// Apply conversion to sRGB (this must be an exact sRGB conversion else darks are bad).
        OutDeviceColor = LinearToSrgb(OutputGamutColor);
    }

	// Rec 709, user specified gamut
    else if (GetOutputDevice() == 1)
    {
		// Convert from sRGB to specified output gamut
        float3 OutputGamutColor = mul(AP1_2_Output, mul(sRGB_2_AP1, FilmColor));

		// Didn't profile yet if the branching version would be faster (different linear segment).
        OutDeviceColor = LinearTo709Branchless(OutputGamutColor);
    }

	// ACES 1000nit transform with PQ/2084 encoding, user specified gamut 
    else if (GetOutputDevice() == 3 || GetOutputDevice() == 5)
    {
		// 1000 nit ODT
        float3 ODTColor = ACESOutputTransforms1000(GradedColor);

		// Convert from AP1 to specified output gamut
        ODTColor = mul(AP1_2_Output, ODTColor);

		// Apply conversion to ST-2084 (Dolby PQ)
        OutDeviceColor = LinearToST2084(ODTColor);
    }

	// ACES 2000nit transform with PQ/2084 encoding, user specified gamut 
    else if (GetOutputDevice() == 4 || GetOutputDevice() == 6)
    {
		// 2000 nit ODT
        float3 ODTColor = ACESOutputTransforms2000(GradedColor);

		// Convert from AP1 to specified output gamut
        ODTColor = mul(AP1_2_Output, ODTColor);

		// Apply conversion to ST-2084 (Dolby PQ)
        OutDeviceColor = LinearToST2084(ODTColor);
    }
    else if (GetOutputDevice() == 7)
    {
        float3 OutputGamutColor = mul(AP1_2_Output, mul(sRGB_2_AP1, GradedColor));
        OutDeviceColor = LinearToST2084(OutputGamutColor);
    }
	// Linear HDR, including all color correction, but no tone curve
    else if (GetOutputDevice() == 8)
    {
        OutDeviceColor = GradedColor;
    }
	// "Linear" including all color correction and the tone curve, but no device gamma
    else if (GetOutputDevice() == 9)
    {
        float3 OutputGamutColor = mul(AP1_2_Output, mul(sRGB_2_AP1, FilmColorNoGamma));

        OutDeviceColor = OutputGamutColor;
    }

	// OutputDevice == 2
	// Gamma 2.2, user specified gamut
    else
    {
		// Convert from sRGB to specified output gamut
        float3 OutputGamutColor = mul(AP1_2_Output, mul(sRGB_2_AP1, FilmColor));

		// This is different than the prior "gamma" curve adjustment (but reusing the variable).
		// For displays set to a gamma colorspace.
		// Note, MacOSX native output is raw gamma 2.2 not sRGB!
        OutDeviceColor = pow(OutputGamutColor, InverseGamma.z);
    }

	// Better to saturate(lerp(a,b,t)) than lerp(saturate(a),saturate(b),t)
    OutColor.rgb = OutDeviceColor / 1.05;
    OutColor.a = 0;

    return OutColor;
}


#endif // COLORGRADE_AND_TONEMAP_LIBRARY_HLSL
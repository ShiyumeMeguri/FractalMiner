using System;

namespace HG.Rendering.Runtime
{
	public static class HGMaterialProperties
	{
		public const string kZWrite = "_ZWrite";

		public const string kTransparentZWrite = "_TransparentZWrite";

		public const string kTransparentCullMode = "_TransparentCullMode";

		public const string kOpaqueCullMode = "_OpaqueCullMode";

		public const string kZTestTransparent = "_ZTestTransparent";

		public const string kSurfaceType = "_SurfaceType";

		public const string kAlphaCutoffEnabled = "_AlphaCutoffEnable";

		public const string kBlendMode = "_BlendMode";

		public const string kTransparentSortPriority = "_TransparentSortPriority";

		public const string kReceivesSSR = "_ReceivesSSR";

		internal const string kEnableDecals = "_SupportDecals";

		internal const int kMaxLayerCount = 4;

		internal const string kLayerCount = "_LayerCount";

		internal const string kMaterialID = "_MaterialID";

		internal const string kZTestGBuffer = "_ZTestGBuffer";
	}
}

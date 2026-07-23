using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine.HyperGryphEngineCode;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal interface IPassConstructor // TypeDefIndex: 38513
	{
		// Methods
		void PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal);
		void OnPreRendering(ref PassEventInput input);
		void OnPostRendering(ref PassEventInput input);
		void Dispose(HGRenderGraph renderGraph);
	}
}

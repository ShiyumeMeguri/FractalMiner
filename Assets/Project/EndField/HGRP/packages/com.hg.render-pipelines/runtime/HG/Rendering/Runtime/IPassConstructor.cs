using System;
using HG.Rendering.RenderGraphModule;
using UnityEngine.HyperGryphEngineCode;

namespace HG.Rendering.Runtime
{
	internal interface IPassConstructor
	{
		void PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal);

		void OnPreRendering(ref PassEventInput input);

		void OnPostRendering(ref PassEventInput input);

		void Dispose(HGRenderGraph renderGraph);
	}
}

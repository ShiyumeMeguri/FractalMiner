using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public class WaterDefaultDeferredRenderingPass : IPassConstructor
	{
		// (get) Token: 0x06001217 RID: 4631 RVA: 0x000025D8 File Offset: 0x000007D8
		public bool isRendering
		{
			get
			{
				// // Boolean get_changed()
				// bool Rewired::Utils::Classes::Utility::ValueWatcher<float>::get_changed(
				//         ValueWatcher_1_System_Single_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.NiVDAueHECEJqGCNLxcjNXRtPmUC;
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x06001218 RID: 4632 RVA: 0x000025D2 File Offset: 0x000007D2
		public TextureHandle normalRoughnessWithWaterTexture
		{
			get
			{
				// // Vector4 <RegisterPorts>b__6_0()
				// Vector4 *FlowCanvas::Nodes::StaticCodeEvent<UnityEngine::Vector4>::_RegisterPorts_b__6_0(
				//         Vector4 *__return_ptr retstr,
				//         StaticCodeEvent_1_UnityEngine_Vector4_ *this,
				//         MethodInfo *method)
				// {
				//   Vector4 *result; // rax
				// 
				//   result = retstr;
				//   *retstr = this.fields.eventValue;
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06001219 RID: 4633 RVA: 0x000025D2 File Offset: 0x000007D2
		public TextureHandle depthWithWaterTexture
		{
			get
			{
				// // Vector4 <RegisterPorts>b__6_0()
				// Vector4 *FlowCanvas::Nodes::CodeEvent<UnityEngine::Vector4>::_RegisterPorts_b__6_0(
				//         Vector4 *__return_ptr retstr,
				//         CodeEvent_1_UnityEngine_Vector4_ *this,
				//         MethodInfo *method)
				// {
				//   Vector4 *result; // rax
				// 
				//   result = retstr;
				//   *retstr = this.fields.eventValue;
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x0600121A RID: 4634 RVA: 0x000025D2 File Offset: 0x000007D2
		public TextureHandle waterWetnessMaskTexture
		{
			get
			{
				// // Rect get_runtimeAtlasTextureRect()
				// Rect *UnityEngine::UI::Image::get_runtimeAtlasTextureRect(Rect *__return_ptr retstr, Image *this, MethodInfo *method)
				// {
				//   Rect *result; // rax
				// 
				//   result = retstr;
				//   *retstr = this.fields.m_RuntimeAtlasTextureRect;
				//   return result;
				// }
				// 
				return null;
			}
		}

		internal WaterDefaultDeferredRenderingPass(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources)
		{
		}

		internal void RenderPrepass(ref WaterDefaultDeferredRenderingPass.PassInput input, ref WaterDefaultDeferredRenderingPass.PassOutput output, HGRenderGraph renderGraph, HGCamera hgCamera, [MetadataOffset(Offset = "0x01F91937")] bool wetnessHighQualityEnabled = false)
		{
			// // Void RenderPrepass(WaterDefaultDeferredRenderingPass+PassInput ByRef, WaterDefaultDeferredRenderingPass+PassOutput ByRef, HGRenderGraph, HGCamera, Boolean)
			// // Hidden C++ exception states: #wind=5
			// void HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::RenderPrepass(
			//         WaterDefaultDeferredRenderingPass *this,
			//         WaterDefaultDeferredRenderingPass_PassInput *input,
			//         WaterDefaultDeferredRenderingPass_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *hgCamera,
			//         bool wetnessHighQualityEnabled,
			//         MethodInfo *method)
			// {
			//   WaterDefaultDeferredRenderingPass_PassInput *v9; // rbx
			//   WaterDefaultDeferredRenderingPass *v10; // r14
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   HGCamera *v13; // r12
			//   bool ShouldRenderWater; // al
			//   ProfilingSampler *v15; // rax
			//   HGManagerContext *currentManagerContext; // rax
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   HGWaterManager *waterManager_k__BackingField; // r13
			//   HGManagerContext *v20; // rax
			//   __int64 v21; // rdx
			//   __int64 v22; // rcx
			//   HGWaterManager *v23; // rcx
			//   ComputeBuffer *v24; // rax
			//   __int64 v25; // rdx
			//   __int64 v26; // rcx
			//   ComputeBuffer *v27; // rbx
			//   unsigned __int64 v28; // r8
			//   signed __int64 v29; // rtt
			//   CBHandle *v30; // rax
			//   __int64 v31; // rdx
			//   __int64 v32; // rcx
			//   __int128 v33; // xmm1
			//   void *ptr; // xmm0_8
			//   HGSettingParameters *settingParameters; // r15
			//   Object_1 *v36; // rbx
			//   __int64 v37; // rdx
			//   __int64 v38; // rcx
			//   Camera *camera; // rbx
			//   __int64 (__fastcall *v40)(Camera *); // rax
			//   __int64 v41; // rdx
			//   __int64 v42; // rcx
			//   __int64 v43; // rbx
			//   void (__fastcall *v44)(__int64, TextureHandle *); // rax
			//   __int64 v45; // rdx
			//   __int64 v46; // rcx
			//   Camera *v47; // rbx
			//   __int64 (__fastcall *v48)(Camera *); // rax
			//   Transform *v49; // rax
			//   __int64 v50; // rdx
			//   __int64 v51; // rcx
			//   __int64 v52; // rdx
			//   __int64 v53; // rcx
			//   float v54; // xmm15_4
			//   float v55; // xmm14_4
			//   HGWaterGlobalConfig *v56; // rax
			//   __int64 v57; // rdx
			//   __int64 v58; // rcx
			//   HGWaterGlobalConfig *v59; // rax
			//   __int64 v60; // rdx
			//   __int64 v61; // rcx
			//   int32_t v62; // r8d
			//   MethodInfo *v63; // r9
			//   uint32_t m_Value; // xmm0_4
			//   System::MathF *v65; // rcx
			//   uint32_t v66; // xmm10_4
			//   uint32_t v67; // xmm12_4
			//   uint32_t v68; // xmm0_4
			//   System::MathF *v69; // rcx
			//   __m128 type_k__BackingField; // xmm13
			//   HGWaterGlobalConfig *v71; // rax
			//   __int64 v72; // rdx
			//   __int64 v73; // rcx
			//   HGWaterGlobalConfig *v74; // rax
			//   __int64 v75; // rdx
			//   __int64 v76; // rcx
			//   int32_t heightMapY; // eax
			//   int v78; // edx
			//   int v79; // r8d
			//   int v80; // r9d
			//   Matrix4x4 *v81; // rax
			//   __int128 v82; // xmm6
			//   __int128 v83; // xmm7
			//   __int128 v84; // xmm8
			//   __int128 v85; // xmm9
			//   Matrix4x4 *GPUProjectionMatrix; // rax
			//   HGWaterGlobalConfig *v87; // rax
			//   __int64 v88; // rdx
			//   __int64 v89; // rcx
			//   int32_t RealMeshNumPerLOD; // ebx
			//   HGWaterGlobalConfig *v91; // rax
			//   __int64 v92; // rdx
			//   __int64 v93; // rcx
			//   int32_t RealMeshSize; // eax
			//   HGWaterGlobalConfig *v95; // rax
			//   __int64 v96; // rdx
			//   __int64 v97; // rcx
			//   HGWaterGlobalConfig *v98; // rax
			//   __int64 v99; // rdx
			//   __int64 v100; // rcx
			//   HGWaterGlobalConfig *v101; // rax
			//   __int64 v102; // rdx
			//   __int64 v103; // rcx
			//   ValueTuple_2_Int32_Int32_ SectorCoords; // rax
			//   int v105; // r12d
			//   int v106; // ebx
			//   HGWaterGlobalConfig *v107; // rax
			//   __int64 v108; // rdx
			//   __int64 v109; // rcx
			//   int v110; // r15d
			//   HGWaterGlobalConfig *v111; // rax
			//   __int64 v112; // rdx
			//   __int64 v113; // rcx
			//   int32_t sectorCoordsMin; // eax
			//   ILFixDynamicMethodWrapper_2 *v115; // rax
			//   __int64 v116; // rdx
			//   __int64 v117; // rcx
			//   WaterSettings__StaticFields *static_fields; // rax
			//   int32_t x; // ebx
			//   int32_t y; // r15d
			//   unsigned __int64 v121; // rdx
			//   signed __int64 v122; // rcx
			//   __int128 v123; // xmm2
			//   __int128 v124; // xmm3
			//   Color clearColor; // xmm4
			//   unsigned __int64 v126; // r8
			//   signed __int64 v127; // rtt
			//   TextureHandle v128; // xmm8
			//   TextureHandle v129; // xmm7
			//   TextureHandle v130; // xmm6
			//   ProfilingSampler *v131; // rax
			//   __int64 v132; // rcx
			//   Object *v133; // rdx
			//   int v134; // eax
			//   unsigned __int64 v135; // rdx
			//   unsigned __int64 v136; // r8
			//   char v137; // dl
			//   signed __int64 v138; // rtt
			//   Object *v139; // rdx
			//   Object__Class *m_waterProxyMaterial; // rcx
			//   unsigned __int64 v141; // rdx
			//   unsigned __int64 v142; // r8
			//   char v143; // dl
			//   signed __int64 v144; // rtt
			//   Object *v145; // rdx
			//   MonitorData *m_waterProxyMPB; // rcx
			//   unsigned __int64 v147; // rdx
			//   unsigned __int64 v148; // r8
			//   signed __int64 v149; // rtt
			//   Object *v150; // rbx
			//   Texture2D *flowMap; // rax
			//   __int64 v152; // rdx
			//   __int64 v153; // rcx
			//   unsigned __int64 v154; // r8
			//   signed __int64 v155; // rtt
			//   Object *v156; // rbx
			//   Texture2D *causticMap; // rax
			//   __int64 v158; // rdx
			//   __int64 v159; // rcx
			//   unsigned __int64 v160; // r8
			//   signed __int64 v161; // rtt
			//   __int64 v162; // rdx
			//   __int64 v163; // rcx
			//   CBHandle *v164; // rax
			//   __m128i v165; // xmm6
			//   __int64 v166; // rdx
			//   __int64 v167; // rcx
			//   MonitorData *monitor; // rcx
			//   __int64 v169; // rdx
			//   __int64 v170; // rcx
			//   MonitorData *v171; // rcx
			//   HGWaterGlobalConfig *handle; // r12
			//   ProfilingSampler *v173; // rax
			//   __int64 v174; // rdx
			//   __int64 v175; // rcx
			//   Object__Class *v176; // xmm1_8
			//   Object *v177; // rax
			//   Object *v178; // rbx
			//   __int64 v179; // rdx
			//   __int64 v180; // rcx
			//   TextureHandle v181; // xmm0
			//   Object *v182; // rbx
			//   __int64 v183; // rdx
			//   __int64 v184; // rcx
			//   TextureHandle v185; // xmm0
			//   Object *v186; // rbx
			//   __int64 v187; // rdx
			//   __int64 v188; // rcx
			//   TextureHandle v189; // xmm0
			//   Object *v190; // rbx
			//   __int64 v191; // rdx
			//   __int64 v192; // rcx
			//   TextureHandle v193; // xmm0
			//   Object *v194; // rbx
			//   Texture2D *v195; // rax
			//   __int64 v196; // rdx
			//   __int64 v197; // rcx
			//   unsigned __int64 v198; // r8
			//   signed __int64 v199; // rtt
			//   Object *v200; // rbx
			//   Texture2D *v201; // rax
			//   __int64 v202; // rdx
			//   __int64 v203; // rcx
			//   int v204; // eax
			//   unsigned __int64 v205; // r8
			//   signed __int64 v206; // rtt
			//   Object *v207; // rdx
			//   MonitorData *m_waterTextureProcessMaterial; // rcx
			//   unsigned __int64 v209; // rdx
			//   unsigned __int64 v210; // r8
			//   char v211; // dl
			//   signed __int64 v212; // rtt
			//   Object *v213; // rdx
			//   MonitorData *m_waterProxyDisplacementMPB; // rcx
			//   unsigned __int64 v215; // rdx
			//   unsigned __int64 v216; // r8
			//   char v217; // dl
			//   signed __int64 v218; // rtt
			//   WaterSettings__StaticFields *v219; // rax
			//   uint32_t v220; // r15d
			//   int32_t v221; // r12d
			//   Mesh *screenSpaceMesh; // rax
			//   __int64 v223; // rdx
			//   __int64 v224; // rcx
			//   signed int IndexCount; // ebx
			//   Mesh *v226; // rax
			//   __int64 v227; // rdx
			//   __int64 v228; // rcx
			//   signed int BaseVertex; // eax
			//   float v230; // xmm1_4
			//   float v231; // xmm1_4
			//   float v232; // xmm2_4
			//   float v233; // xmm0_4
			//   CBHandle *ConstantBuffer; // rax
			//   __int128 v235; // xmm7
			//   Void *v236; // xmm6_8
			//   ProfilingSampler *v237; // rax
			//   signed __int64 v238; // rcx
			//   Object *v239; // rdx
			//   unsigned int v240; // edx
			//   unsigned __int64 v241; // r8
			//   signed __int64 v242; // rtt
			//   Object *v243; // rcx
			//   Object__Class *v244; // xmm1_8
			//   Object *v245; // rax
			//   Object *v246; // rax
			//   Object *v247; // rbx
			//   __int64 v248; // rdx
			//   __int64 v249; // rcx
			//   TextureHandle v250; // xmm0
			//   Object *v251; // rbx
			//   __int64 v252; // rdx
			//   __int64 v253; // rcx
			//   TextureHandle v254; // xmm0
			//   ComputeBufferHandle *v255; // rbx
			//   ComputeBufferHandle v256; // rax
			//   ComputeBufferHandle v257; // rdx
			//   ComputeBufferHandle v258; // rcx
			//   ComputeBufferHandle *v259; // rbx
			//   ComputeBufferHandle v260; // rax
			//   ComputeBufferHandle v261; // rdx
			//   ComputeBufferHandle v262; // rcx
			//   Object *v263; // rcx
			//   Object *v264; // rdx
			//   unsigned int v265; // edx
			//   unsigned __int64 v266; // r8
			//   char v267; // dl
			//   signed __int64 v268; // rtt
			//   DepthBits__Enum v269; // r12d
			//   int v270; // r15d
			//   ProfilingSampler *v271; // rax
			//   __int64 v272; // rdx
			//   __int64 v273; // rcx
			//   Object__Class *v274; // xmm1_8
			//   Object *v275; // rax
			//   Object *v276; // rbx
			//   __int64 v277; // rdx
			//   __int64 v278; // rcx
			//   TextureHandle v279; // xmm0
			//   Object *v280; // rbx
			//   __int64 v281; // rdx
			//   __int64 v282; // rcx
			//   TextureHandle v283; // xmm0
			//   Object *v284; // rbx
			//   __int64 v285; // rdx
			//   __int64 v286; // rcx
			//   TextureHandle v287; // xmm0
			//   Object *v288; // rbx
			//   __int64 v289; // rdx
			//   __int64 v290; // rcx
			//   TextureHandle v291; // xmm0
			//   Object *v292; // rbx
			//   __int64 v293; // rdx
			//   __int64 v294; // rcx
			//   TextureHandle v295; // xmm0
			//   Object *v296; // rbx
			//   __int64 v297; // rdx
			//   __int64 v298; // rcx
			//   TextureHandle v299; // xmm0
			//   Object *v300; // rbx
			//   __int64 v301; // rdx
			//   __int64 v302; // rcx
			//   TextureHandle v303; // xmm0
			//   Object *v304; // rbx
			//   __int64 v305; // rdx
			//   __int64 v306; // rcx
			//   TextureHandle v307; // xmm0
			//   Object *v308; // rbx
			//   Texture2D *rainMap; // rax
			//   __int64 v310; // rdx
			//   __int64 v311; // rcx
			//   unsigned __int64 v312; // r9
			//   signed __int64 v313; // rtt
			//   Object *v314; // rbx
			//   Texture2DArray *normalMapArray; // rax
			//   unsigned __int64 v316; // rdx
			//   __int64 v317; // rcx
			//   unsigned __int64 v318; // r8
			//   signed __int64 v319; // rtt
			//   Object *v320; // rcx
			//   ComputeBufferHandle *v321; // rbx
			//   ComputeBufferHandle v322; // rax
			//   ComputeBufferHandle v323; // rdx
			//   ComputeBufferHandle v324; // rcx
			//   ComputeBufferHandle *v325; // rbx
			//   ComputeBufferHandle v326; // rax
			//   ComputeBufferHandle v327; // rdx
			//   ComputeBufferHandle v328; // rcx
			//   Object *v329; // rdx
			//   unsigned __int64 v330; // rdx
			//   unsigned __int64 v331; // r8
			//   char v332; // dl
			//   signed __int64 v333; // rtt
			//   Object *v334; // rbx
			//   Mesh *v335; // rax
			//   __int64 v336; // rdx
			//   __int64 v337; // rcx
			//   int v338; // eax
			//   unsigned __int64 v339; // r8
			//   signed __int64 v340; // rtt
			//   Object *v341; // rdx
			//   Object__Class *m_renderingMaterial; // rcx
			//   unsigned __int64 v343; // rdx
			//   unsigned __int64 v344; // r8
			//   char v345; // dl
			//   signed __int64 v346; // rtt
			//   Object *v347; // rdx
			//   MonitorData *v348; // rcx
			//   unsigned __int64 v349; // rdx
			//   unsigned __int64 v350; // r8
			//   signed __int64 v351; // rtt
			//   Material *v352; // rcx
			//   Shader *shader; // rax
			//   __int64 v354; // rdx
			//   Material *v355; // rcx
			//   __int64 v356; // rdx
			//   Material *v357; // rcx
			//   Shader *v358; // rax
			//   Material *v359; // rbx
			//   bool ShouldRenderRippleState; // al
			//   __int64 v361; // rdx
			//   __int64 v362; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v364; // rdx
			//   __int64 v365; // rcx
			//   __int64 v366; // rax
			//   __int64 v367; // rax
			//   __int64 v368; // rax
			//   bool enableIndirect; // [rsp+50h] [rbp-988h]
			//   Object *v370; // [rsp+58h] [rbp-980h] BYREF
			//   CBHandle inputa; // [rsp+60h] [rbp-978h] BYREF
			//   DepthBits__Enum depthBits; // [rsp+80h] [rbp-958h] BYREF
			//   Object *v373; // [rsp+88h] [rbp-950h] BYREF
			//   LocalKeyword keyword; // [rsp+90h] [rbp-948h] BYREF
			//   int v375; // [rsp+B0h] [rbp-928h]
			//   Object *v376; // [rsp+B8h] [rbp-920h] BYREF
			//   Object *v377; // [rsp+C0h] [rbp-918h] BYREF
			//   ComputeBufferHandle v378[2]; // [rsp+C8h] [rbp-910h] BYREF
			//   Matrix4x4 desc; // [rsp+E0h] [rbp-8F8h] BYREF
			//   HGWaterGlobalConfig *globalConfig; // [rsp+120h] [rbp-8B8h]
			//   TextureHandle v381; // [rsp+130h] [rbp-8A8h] BYREF
			//   TextureDesc v382; // [rsp+140h] [rbp-898h] BYREF
			//   HGRenderGraphBuilder v383; // [rsp+1A0h] [rbp-838h] BYREF
			//   __m128i si128; // [rsp+1C0h] [rbp-818h] BYREF
			//   HGWaterManager *v385; // [rsp+1D0h] [rbp-808h]
			//   TextureHandle interactionTexture; // [rsp+1E0h] [rbp-7F8h] BYREF
			//   Matrix4x4 v387; // [rsp+1F0h] [rbp-7E8h] BYREF
			//   ScriptableRenderContext v388; // [rsp+230h] [rbp-7A8h] BYREF
			//   TextureHandle sectorTexture; // [rsp+240h] [rbp-798h] BYREF
			//   HGRenderGraphBuilder v390; // [rsp+250h] [rbp-788h] BYREF
			//   HGRenderGraphBuilder v391; // [rsp+270h] [rbp-768h] BYREF
			//   TextureHandle v392; // [rsp+290h] [rbp-748h] BYREF
			//   _QWORD v393[2]; // [rsp+2A0h] [rbp-738h] BYREF
			//   HGRenderGraphBuilder v394; // [rsp+2B0h] [rbp-728h] BYREF
			//   TextureHandle v395; // [rsp+2D0h] [rbp-708h] BYREF
			//   Matrix4x4 v396; // [rsp+2E0h] [rbp-6F8h] BYREF
			//   Matrix4x4 P5; // [rsp+320h] [rbp-6B8h] BYREF
			//   Matrix4x4 P6; // [rsp+360h] [rbp-678h] BYREF
			//   LocalKeyword v399; // [rsp+3A0h] [rbp-638h] BYREF
			//   LocalKeyword v400; // [rsp+3B8h] [rbp-620h] BYREF
			//   HGRenderGraphProfilingScope v401; // [rsp+3D0h] [rbp-608h] BYREF
			//   TextureDesc v402; // [rsp+3F0h] [rbp-5E8h] BYREF
			//   Matrix4x4 P4; // [rsp+450h] [rbp-588h] BYREF
			//   Il2CppExceptionWrapper *v404; // [rsp+490h] [rbp-548h] BYREF
			//   Il2CppExceptionWrapper *v405; // [rsp+498h] [rbp-540h] BYREF
			//   Il2CppExceptionWrapper *v406; // [rsp+4A0h] [rbp-538h] BYREF
			//   Il2CppExceptionWrapper *v407; // [rsp+4A8h] [rbp-530h] BYREF
			//   Il2CppExceptionWrapper *v408; // [rsp+4B0h] [rbp-528h] BYREF
			//   Void v409[16]; // [rsp+4C0h] [rbp-518h] BYREF
			//   __int128 v410; // [rsp+4D0h] [rbp-508h]
			//   __int128 v411; // [rsp+4E0h] [rbp-4F8h]
			//   __int128 v412; // [rsp+4F0h] [rbp-4E8h]
			//   TextureDesc v413; // [rsp+500h] [rbp-4D8h] BYREF
			//   TextureDesc v414; // [rsp+560h] [rbp-478h] BYREF
			//   TextureDesc v415; // [rsp+5C0h] [rbp-418h] BYREF
			//   TextureDesc v416; // [rsp+620h] [rbp-3B8h] BYREF
			//   TextureDesc v417; // [rsp+680h] [rbp-358h] BYREF
			//   TextureDesc v418; // [rsp+6E0h] [rbp-2F8h] BYREF
			//   TextureDesc v419; // [rsp+740h] [rbp-298h] BYREF
			//   TextureDesc v420; // [rsp+7A0h] [rbp-238h] BYREF
			//   Matrix4x4 v421; // [rsp+800h] [rbp-1D8h] BYREF
			//   Void source[16]; // [rsp+840h] [rbp-198h] BYREF
			//   __int128 v423; // [rsp+850h] [rbp-188h]
			//   __int128 v424; // [rsp+860h] [rbp-178h]
			//   __int128 v425; // [rsp+870h] [rbp-168h]
			//   __int128 v426; // [rsp+880h] [rbp-158h]
			//   __int128 v427; // [rsp+890h] [rbp-148h]
			//   __int128 v428; // [rsp+8A0h] [rbp-138h]
			//   __int128 v429; // [rsp+8B0h] [rbp-128h]
			// 
			//   v9 = input;
			//   v10 = this;
			//   if ( !byte_18D919621 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::ComputeBuffer);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::WaterSettings);
			//     sub_18003C530(&off_18CDB1340);
			//     sub_18003C530(&off_18CDB14D8);
			//     sub_18003C530(&off_18CDB14F0);
			//     sub_18003C530(&off_18CDB14F8);
			//     sub_18003C530(&off_18CDB1500);
			//     sub_18003C530(&off_18CDB1508);
			//     sub_18003C530(&off_18CDB14E0);
			//     sub_18003C530(&off_18CDB14E8);
			//     byte_18D919621 = 1;
			//   }
			//   memset(&v401, 0, sizeof(v401));
			//   v388.m_Ptr = 0LL;
			//   sub_1802F01E0(&P4, 0LL, 64LL);
			//   sub_1802F01E0(&P5, 0LL, 64LL);
			//   sub_1802F01E0(&P6, 0LL, 64LL);
			//   sub_1802F01E0(&v414, 0LL, 96LL);
			//   sub_1802F01E0(&v416, 0LL, 96LL);
			//   sub_1802F01E0(&v418, 0LL, 96LL);
			//   depthBits = DepthBits__Enum_None;
			//   sub_1802F01E0(&v419, 0LL, 96LL);
			//   sub_1802F01E0(&v382, 0LL, 96LL);
			//   memset(&v394, 0, sizeof(v394));
			//   v376 = 0LL;
			//   sub_1802F01E0(source, 0LL, 192LL);
			//   memset(&v390, 0, sizeof(v390));
			//   v377 = 0LL;
			//   sub_1802F01E0(v409, 0LL, 64LL);
			//   memset(&v391, 0, sizeof(v391));
			//   v373 = 0LL;
			//   sub_1802F01E0(&v420, 0LL, 96LL);
			//   memset(&v383, 0, sizeof(v383));
			//   v370 = 0LL;
			//   memset(&v399, 0, sizeof(v399));
			//   memset(&v400, 0, sizeof(v400));
			//   if ( IFix::WrappersManagerImpl::IsPatched(2921, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2921, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v365, v364);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1055(
			//       Patch,
			//       (Object *)v10,
			//       input,
			//       output,
			//       (Object *)renderGraph,
			//       (Object *)hgCamera,
			//       wetnessHighQualityEnabled,
			//       0LL);
			//   }
			//   else
			//   {
			//     v13 = hgCamera;
			//     if ( !hgCamera )
			//       sub_180B536AC(v12, v11);
			//     ShouldRenderWater = HG::Rendering::Runtime::HGCamera::ShouldRenderWater(hgCamera, 0LL);
			//     v10.fields.m_isRendering = ShouldRenderWater;
			//     if ( ShouldRenderWater )
			//     {
			//       v15 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0x36u,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphProfilingScope::HGRenderGraphProfilingScope(
			//         &v401,
			//         renderGraph,
			//         v15,
			//         0LL);
			//       v393[0] = 0LL;
			//       v393[1] = &v401;
			//       try
			//       {
			//         currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//         if ( !currentManagerContext )
			//           sub_1802DC2C8(v18, v17);
			//         waterManager_k__BackingField = currentManagerContext.fields._waterManager_k__BackingField;
			//         v385 = waterManager_k__BackingField;
			//         v20 = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//         if ( !v20 )
			//           sub_1802DC2C8(v22, v21);
			//         v23 = v20.fields._waterManager_k__BackingField;
			//         if ( !v23 )
			//           sub_1802DC2C8(0LL, v21);
			//         globalConfig = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(v23, 0LL);
			//         v392.handle = (ResourceHandle)globalConfig;
			//         v388.m_Ptr = v9.srpContext.m_Ptr;
			//         enableIndirect = v9.enableIndirect;
			//         if ( !v10.fields.m_indirectBuffer )
			//         {
			//           v24 = (ComputeBuffer *)sub_180004920(TypeInfo::UnityEngine::ComputeBuffer);
			//           v27 = v24;
			//           if ( !v24 )
			//             sub_1802DC2C8(v26, v25);
			//           UnityEngine::ComputeBuffer::ComputeBuffer(
			//             v24,
			//             12,
			//             4,
			//             ComputeBufferType__Enum_DrawIndirect,
			//             ComputeBufferMode__Enum_Immutable,
			//             3,
			//             0LL);
			//           v10.fields.m_indirectBuffer = v27;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v28 = (((unsigned __int64)&v10.fields.m_indirectBuffer >> 12) & 0x1FFFFF) >> 6;
			//             _m_prefetchw(&qword_18D6405E0[v28 + 36190]);
			//             do
			//               v29 = qword_18D6405E0[v28 + 36190];
			//             while ( v29 != _InterlockedCompareExchange64(
			//                              &qword_18D6405E0[v28 + 36190],
			//                              v29 | (1LL << (((unsigned __int64)&v10.fields.m_indirectBuffer >> 12) & 0x3F)),
			//                              v29) );
			//           }
			//           v9 = input;
			//         }
			//         P4 = *(Matrix4x4 *)sub_182805160(&v387);
			//         P5 = *(Matrix4x4 *)sub_182805160(&v387);
			//         P6 = *(Matrix4x4 *)sub_182805160(&v387);
			//         sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//         v30 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
			//                 (CBHandle *)&keyword,
			//                 &v388,
			//                 20768,
			//                 0LL);
			//         v33 = *(_OWORD *)&v30.bufferId;
			//         ptr = v30.ptr;
			//         *(_OWORD *)&v10.fields.m_cbHandle.bufferId = *(_OWORD *)&v30.bufferId;
			//         v10.fields.m_cbHandle.ptr = ptr;
			//         settingParameters = v9.settingParameters;
			//         if ( !waterManager_k__BackingField )
			//           sub_1802DC2C8(v32, v31);
			//         if ( !byte_18D8EDBDF )
			//         {
			//           sub_18003C530(&MethodInfo::Unity::Collections::LowLevel::Unsafe::NativeArrayUnsafeUtility::GetUnsafeReadOnlyPtr<UnityEngine::Vector4>);
			//           sub_18003C530(&TypeInfo::UnityEngine::Object);
			//           sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//           sub_18003C530(&MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>);
			//           byte_18D8EDBDF = 1;
			//         }
			//         sub_1802F01E0(&v396, 0LL, 64LL);
			//         if ( IFix::WrappersManagerImpl::IsPatched(928, 0LL) )
			//         {
			//           v115 = IFix::WrappersManagerImpl::GetPatch(928, 0LL);
			//           if ( !v115 )
			//             sub_1802DC2C8(v117, v116);
			//           IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_351(
			//             v115,
			//             (Object *)waterManager_k__BackingField,
			//             (Object *)hgCamera,
			//             (Object *)settingParameters,
			//             &v10.fields.m_cbHandle,
			//             &P4,
			//             &P5,
			//             &P6,
			//             0LL);
			//         }
			//         else
			//         {
			//           v36 = (Object_1 *)HG::Rendering::Runtime::HGWaterManager::get_globalConfig(waterManager_k__BackingField, 0LL);
			//           sub_180002C70(TypeInfo::UnityEngine::Object);
			//           if ( !UnityEngine::Object::op_Equality(v36, 0LL, 0LL) )
			//           {
			//             camera = hgCamera.fields.camera;
			//             if ( !camera )
			//               sub_1802DC2C8(v38, v37);
			//             v40 = (__int64 (__fastcall *)(Camera *))qword_18D8F4D40;
			//             if ( !qword_18D8F4D40 )
			//             {
			//               v40 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Component::get_transform()");
			//               if ( !v40 )
			//               {
			//                 v366 = sub_1802DBBE8("UnityEngine.Component::get_transform()");
			//                 sub_18000F750(v366, 0LL);
			//               }
			//               qword_18D8F4D40 = (__int64)v40;
			//             }
			//             v43 = v40(camera);
			//             if ( !v43 )
			//               sub_1802DC2C8(v42, v41);
			//             v381.handle = 0LL;
			//             v381.fallBackResource.m_Value = 0;
			//             v44 = (void (__fastcall *)(__int64, TextureHandle *))qword_18D8F52E0;
			//             if ( !qword_18D8F52E0 )
			//             {
			//               v44 = (void (__fastcall *)(__int64, TextureHandle *))il2cpp_resolve_icall_0(
			//                                                                      "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//               if ( !v44 )
			//               {
			//                 v367 = sub_1802DBBE8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//                 sub_18000F750(v367, 0LL);
			//               }
			//               qword_18D8F52E0 = (__int64)v44;
			//             }
			//             v44(v43, &v381);
			//             v47 = hgCamera.fields.camera;
			//             if ( !v47 )
			//               sub_1802DC2C8(v46, v45);
			//             v48 = (__int64 (__fastcall *)(Camera *))qword_18D8F4D40;
			//             if ( !qword_18D8F4D40 )
			//             {
			//               v48 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Component::get_transform()");
			//               if ( !v48 )
			//               {
			//                 v368 = sub_1802DBBE8("UnityEngine.Component::get_transform()");
			//                 sub_18000F750(v368, 0LL);
			//               }
			//               qword_18D8F4D40 = (__int64)v48;
			//             }
			//             v49 = (Transform *)v48(v47);
			//             if ( !v49 )
			//               sub_1802DC2C8(v51, v50);
			//             UnityEngine::Transform::get_forward((Vector3 *)&inputa, v49, 0LL);
			//             if ( !settingParameters )
			//               sub_1802DC2C8(v53, v52);
			//             *(float *)&v375 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                                 settingParameters.fields._waterPrepassTextureSize_k__BackingField,
			//                                 MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//             v54 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                     settingParameters.fields._waterDisplacementWeight_k__BackingField,
			//                     MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//             v55 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                     settingParameters.fields._waterDisplacementDistance_k__BackingField,
			//                     MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//             v56 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(waterManager_k__BackingField, 0LL);
			//             if ( !v56 )
			//               sub_1802DC2C8(v58, v57);
			//             HG::Rendering::Runtime::HGWaterGlobalConfig::GetRealHeightMapXZ(v56, settingParameters, 0LL);
			//             v59 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(waterManager_k__BackingField, 0LL);
			//             if ( !v59 )
			//               sub_1802DC2C8(v61, v60);
			//             HG::Rendering::Runtime::HGWaterGlobalConfig::get_heightMapOffset(v59, 0LL);
			//             UnityEngine::Animator::GetVector((Vector3 *)&inputa, 0LL, v62, v63);
			//             m_Value = v381.handle.m_Value;
			//             System::MathF::Floor(v65, *(float *)&v33);
			//             v66 = m_Value;
			//             v67 = v381.fallBackResource.m_Value;
			//             v68 = v381.fallBackResource.m_Value;
			//             System::MathF::Floor(v69, *(float *)&v33);
			//             *(_QWORD *)&inputa.bufferId = __PAIR64__(v381.handle._type_k__BackingField, v66);
			//             type_k__BackingField = (__m128)(unsigned int)v381.handle._type_k__BackingField;
			//             inputa.size = v68;
			//             *(&inputa.size + 1) = 1065353216;
			//             *(_OWORD *)&keyword.m_SpaceInfo.m_KeywordSpace = *(_OWORD *)&inputa.bufferId;
			//             si128 = _mm_load_si128((const __m128i *)&xmmword_18A3576B0);
			//             interactionTexture = (TextureHandle)_mm_load_si128((const __m128i *)&xmmword_18A3576E0);
			//             sectorTexture = (TextureHandle)_mm_load_si128((const __m128i *)&xmmword_18A3576A0);
			//             UnityEngine::Matrix4x4::Matrix4x4(
			//               &v396,
			//               (Vector4 *)&sectorTexture,
			//               (Vector4 *)&interactionTexture,
			//               (Vector4 *)&si128,
			//               (Vector4 *)&keyword,
			//               0LL);
			//             v396 = *UnityEngine::Matrix4x4::get_inverse(&v387, &v396, 0LL);
			//             v71 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(waterManager_k__BackingField, 0LL);
			//             if ( !v71 )
			//               sub_1802DC2C8(v73, v72);
			//             HG::Rendering::Runtime::HGWaterGlobalConfig::get_heightMapY(v71, 0LL);
			//             v74 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(waterManager_k__BackingField, 0LL);
			//             if ( !v74 )
			//               sub_1802DC2C8(v76, v75);
			//             heightMapY = HG::Rendering::Runtime::HGWaterGlobalConfig::get_heightMapY(v74, 0LL);
			//             desc = *(Matrix4x4 *)sub_182A59E70((unsigned int)&v387, v78, v79, v80, (float)heightMapY * 0.5);
			//             v81 = Unity::Mathematics::float4x4::op_Implicit(&v421, (float4x4 *)&desc, 0LL);
			//             v82 = *(_OWORD *)&v81.m00;
			//             v83 = *(_OWORD *)&v81.m01;
			//             v84 = *(_OWORD *)&v81.m02;
			//             v85 = *(_OWORD *)&v81.m03;
			//             desc = v396;
			//             *(_OWORD *)&v387.m00 = v82;
			//             *(_OWORD *)&v387.m01 = v83;
			//             *(_OWORD *)&v387.m02 = v84;
			//             *(_OWORD *)&v387.m03 = v85;
			//             P4 = *UnityEngine::Matrix4x4::op_Multiply(&v421, &v387, &desc, 0LL);
			//             *(_OWORD *)&v387.m00 = v82;
			//             *(_OWORD *)&v387.m01 = v83;
			//             *(_OWORD *)&v387.m02 = v84;
			//             *(_OWORD *)&v387.m03 = v85;
			//             GPUProjectionMatrix = UnityEngine::GL::GetGPUProjectionMatrix(&v421, &v387, 1, 0LL);
			//             v387 = v396;
			//             desc = *GPUProjectionMatrix;
			//             P5 = *UnityEngine::Matrix4x4::op_Multiply(&v421, &desc, &v387, 0LL);
			//             P6 = *UnityEngine::Matrix4x4::get_inverse(&v421, &P5, 0LL);
			//             *(__m128i *)waterManager_k__BackingField.fields.waterGPUData.m_Buffer = _mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::GetColumn((Vector4 *)&keyword, &P5, 0, 0LL));
			//             *(__m128i *)&waterManager_k__BackingField.fields.waterGPUData.m_Buffer[16] = _mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::GetColumn((Vector4 *)&keyword, &P5, 1, 0LL));
			//             *(__m128i *)&waterManager_k__BackingField.fields.waterGPUData.m_Buffer[32] = _mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::GetColumn((Vector4 *)&keyword, &P5, 2, 0LL));
			//             *(__m128i *)&waterManager_k__BackingField.fields.waterGPUData.m_Buffer[48] = _mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::GetColumn((Vector4 *)&keyword, &P5, 3, 0LL));
			//             *(__m128i *)&waterManager_k__BackingField.fields.waterGPUData.m_Buffer[64] = _mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::GetColumn((Vector4 *)&keyword, &P6, 0, 0LL));
			//             *(__m128i *)&waterManager_k__BackingField.fields.waterGPUData.m_Buffer[80] = _mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::GetColumn((Vector4 *)&keyword, &P6, 1, 0LL));
			//             *(__m128i *)&waterManager_k__BackingField.fields.waterGPUData.m_Buffer[96] = _mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::GetColumn((Vector4 *)&keyword, &P6, 2, 0LL));
			//             *(__m128i *)&waterManager_k__BackingField.fields.waterGPUData.m_Buffer[112] = _mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::GetColumn((Vector4 *)&keyword, &P6, 3, 0LL));
			//             v87 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(waterManager_k__BackingField, 0LL);
			//             if ( !v87 )
			//               sub_1802DC2C8(v89, v88);
			//             RealMeshNumPerLOD = HG::Rendering::Runtime::HGWaterGlobalConfig::GetRealMeshNumPerLOD(
			//                                   v87,
			//                                   settingParameters,
			//                                   0LL);
			//             v91 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(waterManager_k__BackingField, 0LL);
			//             if ( !v91 )
			//               sub_1802DC2C8(v93, v92);
			//             RealMeshSize = HG::Rendering::Runtime::HGWaterGlobalConfig::GetRealMeshSize(v91, settingParameters, 0LL);
			//             inputa.bufferId = v66;
			//             inputa.offset = v68;
			//             *(float *)&inputa.size = (float)RealMeshNumPerLOD;
			//             *((float *)&inputa.size + 1) = (float)RealMeshSize;
			//             *(_OWORD *)&waterManager_k__BackingField.fields.waterGPUData.m_Buffer[128] = *(_OWORD *)&inputa.bufferId;
			//             v95 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(waterManager_k__BackingField, 0LL);
			//             if ( !v95 )
			//               sub_1802DC2C8(v97, v96);
			//             *(Vector2 *)&inputa.bufferId = HG::Rendering::Runtime::HGWaterGlobalConfig::get_sceneCenterOffset(v95, 0LL);
			//             v98 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(waterManager_k__BackingField, 0LL);
			//             if ( !v98 )
			//               sub_1802DC2C8(v100, v99);
			//             v378[0] = (ComputeBufferHandle)HG::Rendering::Runtime::HGWaterGlobalConfig::get_sceneCenterOffset(v98, 0LL);
			//             desc.m00 = v54;
			//             desc.m10 = v55;
			//             LODWORD(desc.m20) = inputa.bufferId;
			//             LODWORD(desc.m30) = v378[0].handle._type_k__BackingField;
			//             *(_OWORD *)&waterManager_k__BackingField.fields.waterGPUData.m_Buffer[144] = *(_OWORD *)&desc.m00;
			//             v101 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(waterManager_k__BackingField, 0LL);
			//             if ( !v101 )
			//               sub_1802DC2C8(v103, v102);
			//             v381.handle = (ResourceHandle)_mm_unpacklo_ps((__m128)v381.handle.m_Value, type_k__BackingField).m128_u64[0];
			//             v381.fallBackResource.m_Value = v67;
			//             SectorCoords = HG::Rendering::Runtime::HGWaterGlobalConfig::GetSectorCoords(v101, (Vector3 *)&v381, 0LL);
			//             v105 = SectorCoords.Item1 - 1;
			//             v106 = SectorCoords.Item2 - 1;
			//             v107 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(waterManager_k__BackingField, 0LL);
			//             if ( !v107 )
			//               sub_1802DC2C8(v109, v108);
			//             v110 = (v105 - HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorCoordsMin(v107, 0LL)) % 3;
			//             v111 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(waterManager_k__BackingField, 0LL);
			//             if ( !v111 )
			//               sub_1802DC2C8(v113, v112);
			//             sectorCoordsMin = HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorCoordsMin(v111, 0LL);
			//             desc.m00 = (float)v110 / 3.0;
			//             desc.m10 = (float)((v106 - sectorCoordsMin) % 3) / 3.0;
			//             desc.m20 = (float)v105 * 128.0;
			//             desc.m30 = (float)v106 * 128.0;
			//             *(_OWORD *)&waterManager_k__BackingField.fields.waterGPUData.m_Buffer[176] = *(_OWORD *)&desc.m00;
			//             LODWORD(desc.m00) = v375;
			//             desc.m10 = 1.0 / *(float *)&v375;
			//             desc.m20 = 16.0;
			//             desc.m30 = 0.0625;
			//             *(_OWORD *)&waterManager_k__BackingField.fields.waterGPUData.m_Buffer[192] = *(_OWORD *)&desc.m00;
			//             if ( !MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>.rgctx_data )
			//               sub_180041F40(MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>);
			//             Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(
			//               (Void *)v10.fields.m_cbHandle.ptr,
			//               waterManager_k__BackingField.fields.waterGPUData.m_Buffer,
			//               16 * waterManager_k__BackingField.fields.waterGPUData.m_Length,
			//               0LL);
			//             v13 = hgCamera;
			//           }
			//         }
			//         sectorTexture = input.sectorTexture;
			//         interactionTexture = input.interactionTexture;
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//         sub_182E7CCD0(&keyword);
			//         sub_182E7CCD0(&keyword);
			//         sub_182E7CCD0(&keyword);
			//         sub_182E7CCD0(&keyword);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::WaterSettings);
			//         static_fields = TypeInfo::HG::Rendering::Runtime::WaterSettings.static_fields;
			//         x = (int)static_fields.prepassTextureSize.x;
			//         y = (int)static_fields.prepassTextureSize.y;
			//         sub_1802F01E0(&v413, 0LL, 96LL);
			//         HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v413, x, y, 0LL);
			//         v123 = *(_OWORD *)&v413.width;
			//         *(_OWORD *)&v382.width = *(_OWORD *)&v413.width;
			//         *(_OWORD *)&v382.colorFormat = *(_OWORD *)&v413.colorFormat;
			//         *(_OWORD *)&v382.enableRandomWrite = *(_OWORD *)&v413.enableRandomWrite;
			//         *(_QWORD *)&v382.bindTextureMS = *(_QWORD *)&v413.bindTextureMS;
			//         v124 = *(_OWORD *)&v413.fastMemoryDesc.inFastMemory;
			//         *(_OWORD *)&v382.fastMemoryDesc.inFastMemory = *(_OWORD *)&v413.fastMemoryDesc.inFastMemory;
			//         clearColor = v413.clearColor;
			//         v382.clearColor = v413.clearColor;
			//         v382.name = (String *)"Water Proxy Data Texture";
			//         if ( dword_18D8E43F8 )
			//         {
			//           v126 = (((unsigned __int64)&v382.name >> 12) & 0x1FFFFF) >> 6;
			//           v121 = ((unsigned __int64)&v382.name >> 12) & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v126 + 36190]);
			//           do
			//           {
			//             v122 = qword_18D6405E0[v126 + 36190] | (1LL << v121);
			//             v127 = qword_18D6405E0[v126 + 36190];
			//           }
			//           while ( v127 != _InterlockedCompareExchange64(&qword_18D6405E0[v126 + 36190], v122, v127) );
			//           clearColor = v382.clearColor;
			//           v124 = *(_OWORD *)&v382.fastMemoryDesc.inFastMemory;
			//           v123 = *(_OWORD *)&v382.width;
			//         }
			//         v382.colorFormat = 8;
			//         *(_WORD *)&v382.useMipMap = 0;
			//         *(_OWORD *)&v414.width = v123;
			//         *(_OWORD *)&v414.colorFormat = *(_OWORD *)&v382.colorFormat;
			//         *(_OWORD *)&v414.enableRandomWrite = *(_OWORD *)&v382.enableRandomWrite;
			//         *(_OWORD *)&v414.bindTextureMS = *(_OWORD *)&v382.bindTextureMS;
			//         *(_OWORD *)&v414.fastMemoryDesc.inFastMemory = v124;
			//         v414.clearColor = clearColor;
			//         if ( !renderGraph )
			//           sub_1802DC2C8(v122, v121);
			//         v128 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                   (TextureHandle *)&keyword,
			//                   renderGraph,
			//                   &v414,
			//                   0LL);
			//         v395 = v128;
			//         sub_1802F01E0(&v415, 0LL, 96LL);
			//         HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v415, x, y, 0LL);
			//         v382 = v415;
			//         v382.colorFormat = 75;
			//         *(_WORD *)&v382.useMipMap = 0;
			//         *(_OWORD *)&v416.width = *(_OWORD *)&v415.width;
			//         *(_OWORD *)&v416.colorFormat = *(_OWORD *)&v382.colorFormat;
			//         *(_OWORD *)&v416.enableRandomWrite = *(_OWORD *)&v382.enableRandomWrite;
			//         *(_OWORD *)&v416.bindTextureMS = *(_OWORD *)&v415.bindTextureMS;
			//         *(_OWORD *)&v416.fastMemoryDesc.inFastMemory = *(_OWORD *)&v415.fastMemoryDesc.inFastMemory;
			//         v416.clearColor = v415.clearColor;
			//         v129 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                   (TextureHandle *)&keyword,
			//                   renderGraph,
			//                   &v416,
			//                   0LL);
			//         si128 = (__m128i)v129;
			//         sub_1802F01E0(&v417, 0LL, 96LL);
			//         HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v417, x, y, 0LL);
			//         v382 = v417;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//         *(_QWORD *)&v382.colorFormat = HG::Rendering::Runtime::HGUtils::GetSupportedFormatForDepth(
			//                                          GraphicsFormat__Enum_D24_UNorm_S8_UInt,
			//                                          &depthBits,
			//                                          0LL);
			//         v382.depthBufferBits = depthBits;
			//         v382.clearBuffer = 1;
			//         v382.wrapMode = 1;
			//         v418 = v382;
			//         v130 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                   (TextureHandle *)&keyword,
			//                   renderGraph,
			//                   &v418,
			//                   0LL);
			//         v381 = v130;
			//         sub_1802F01E0(&v402, 0LL, 96LL);
			//         HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v402, 512, 512, 0LL);
			//         v382 = v402;
			//         v382.colorFormat = 45;
			//         *(_WORD *)&v382.useMipMap = 0;
			//         *(_OWORD *)&v419.width = *(_OWORD *)&v402.width;
			//         *(_OWORD *)&v419.colorFormat = *(_OWORD *)&v382.colorFormat;
			//         *(_OWORD *)&v419.enableRandomWrite = *(_OWORD *)&v382.enableRandomWrite;
			//         *(_OWORD *)&v419.bindTextureMS = *(_OWORD *)&v402.bindTextureMS;
			//         *(_OWORD *)&v419.fastMemoryDesc.inFastMemory = *(_OWORD *)&v402.fastMemoryDesc.inFastMemory;
			//         v419.clearColor = v402.clearColor;
			//         *(TextureHandle *)&keyword.m_SpaceInfo.m_KeywordSpace = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                                                    (TextureHandle *)&keyword,
			//                                                                    renderGraph,
			//                                                                    &v419,
			//                                                                    0LL);
			//         v131 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//                  (Int32Enum__Enum)0x37u,
			//                  MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//         HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//           (HGRenderGraphBuilder *)&desc,
			//           renderGraph,
			//           (String *)"Water Prepass",
			//           &v376,
			//           v131,
			//           1,
			//           ProfilingHGPass__Enum_None,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
			//         *(_OWORD *)&v394.m_RenderPass = *(_OWORD *)&desc.m00;
			//         *(_OWORD *)&v394.m_RenderGraph = *(_OWORD *)&desc.m01;
			//         *(_QWORD *)&desc.m00 = 0LL;
			//         *(_QWORD *)&desc.m20 = &v394;
			//         try
			//         {
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v394, 0, 0LL);
			//           v133 = v376;
			//           if ( !v376 )
			//             sub_1802DC2C8(v132, 0LL);
			//           v376[1].klass = (Object__Class *)v13;
			//           v134 = dword_18D8E43F8;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v135 = ((unsigned __int64)&v133[1] >> 12) & 0x1FFFFF;
			//             v136 = v135 >> 6;
			//             v137 = v135 & 0x3F;
			//             _m_prefetchw(&qword_18D6405E0[v136 + 36190]);
			//             do
			//               v138 = qword_18D6405E0[v136 + 36190];
			//             while ( v138 != _InterlockedCompareExchange64(&qword_18D6405E0[v136 + 36190], v138 | (1LL << v137), v138) );
			//             v134 = dword_18D8E43F8;
			//           }
			//           v139 = v376;
			//           m_waterProxyMaterial = (Object__Class *)v10.fields.m_waterProxyMaterial;
			//           if ( !v376 )
			//             sub_1802DC2C8(m_waterProxyMaterial, 0LL);
			//           v376[4].klass = m_waterProxyMaterial;
			//           if ( v134 )
			//           {
			//             v141 = ((unsigned __int64)&v139[4] >> 12) & 0x1FFFFF;
			//             v142 = v141 >> 6;
			//             v143 = v141 & 0x3F;
			//             _m_prefetchw(&qword_18D6405E0[v142 + 36190]);
			//             do
			//               v144 = qword_18D6405E0[v142 + 36190];
			//             while ( v144 != _InterlockedCompareExchange64(&qword_18D6405E0[v142 + 36190], v144 | (1LL << v143), v144) );
			//             v134 = dword_18D8E43F8;
			//           }
			//           v145 = v376;
			//           m_waterProxyMPB = (MonitorData *)v10.fields.m_waterProxyMPB;
			//           if ( !v376 )
			//             sub_1802DC2C8(m_waterProxyMPB, 0LL);
			//           v376[5].monitor = m_waterProxyMPB;
			//           if ( v134 )
			//           {
			//             v147 = ((unsigned __int64)&v145[5].monitor >> 12) & 0x1FFFFF;
			//             v148 = v147 >> 6;
			//             v145 = (Object *)(v147 & 0x3F);
			//             _m_prefetchw(&qword_18D6405E0[v148 + 36190]);
			//             do
			//             {
			//               m_waterProxyMPB = (MonitorData *)(qword_18D6405E0[v148 + 36190] | (1LL << (char)v145));
			//               v149 = qword_18D6405E0[v148 + 36190];
			//             }
			//             while ( v149 != _InterlockedCompareExchange64(
			//                               &qword_18D6405E0[v148 + 36190],
			//                               (signed __int64)m_waterProxyMPB,
			//                               v149) );
			//           }
			//           if ( !v376 )
			//             sub_1802DC2C8(m_waterProxyMPB, v145);
			//           *(TextureHandle *)&v376[15].monitor = v128;
			//           if ( !v376 )
			//             sub_1802DC2C8(m_waterProxyMPB, v145);
			//           *(TextureHandle *)&v376[16].monitor = v129;
			//           if ( !v376 )
			//             sub_1802DC2C8(m_waterProxyMPB, v145);
			//           *(TextureHandle *)&v376[17].monitor = v130;
			//           v150 = v376;
			//           if ( !globalConfig )
			//             sub_1802DC2C8(m_waterProxyMPB, v145);
			//           flowMap = HG::Rendering::Runtime::HGWaterGlobalConfig::get_flowMap(globalConfig, 0LL);
			//           if ( !v150 )
			//             sub_1802DC2C8(v153, v152);
			//           v150[9].monitor = (MonitorData *)flowMap;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v154 = (((unsigned __int64)&v150[9].monitor >> 12) & 0x1FFFFF) >> 6;
			//             _m_prefetchw(&qword_18D6405E0[v154 + 36190]);
			//             do
			//               v155 = qword_18D6405E0[v154 + 36190];
			//             while ( v155 != _InterlockedCompareExchange64(
			//                               &qword_18D6405E0[v154 + 36190],
			//                               v155 | (1LL << (((unsigned __int64)&v150[9].monitor >> 12) & 0x3F)),
			//                               v155) );
			//           }
			//           v156 = v376;
			//           causticMap = HG::Rendering::Runtime::HGWaterGlobalConfig::get_causticMap(globalConfig, 0LL);
			//           if ( !v156 )
			//             sub_1802DC2C8(v159, v158);
			//           v156[10].klass = (Object__Class *)causticMap;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v160 = (((unsigned __int64)&v156[10] >> 12) & 0x1FFFFF) >> 6;
			//             _m_prefetchw(&qword_18D6405E0[v160 + 36190]);
			//             do
			//               v161 = qword_18D6405E0[v160 + 36190];
			//             while ( v161 != _InterlockedCompareExchange64(
			//                               &qword_18D6405E0[v160 + 36190],
			//                               v161 | (1LL << (((unsigned __int64)&v156[10] >> 12) & 0x3F)),
			//                               v161) );
			//           }
			//           sub_1802F01E0(source, 0LL, 192LL);
			//           if ( !v13 )
			//             sub_1802DC2C8(v163, v162);
			//           *(_OWORD *)source = *(_OWORD *)&v13.fields.mainViewConstants.widerFoVViewProjMatrix.m00;
			//           v423 = *(_OWORD *)&v13.fields.mainViewConstants.widerFoVViewProjMatrix.m01;
			//           v424 = *(_OWORD *)&v13.fields.mainViewConstants.widerFoVViewProjMatrix.m02;
			//           v425 = *(_OWORD *)&v13.fields.mainViewConstants.widerFoVViewProjMatrix.m03;
			//           v426 = *(_OWORD *)&v13.fields.mainViewConstants.widerFoVInvViewProjMatrix.m00;
			//           v427 = *(_OWORD *)&v13.fields.mainViewConstants.widerFoVInvViewProjMatrix.m01;
			//           v428 = *(_OWORD *)&v13.fields.mainViewConstants.widerFoVInvViewProjMatrix.m02;
			//           v429 = *(_OWORD *)&v13.fields.mainViewConstants.widerFoVInvViewProjMatrix.m03;
			//           sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//           v164 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
			//                    &inputa,
			//                    &input.srpContext,
			//                    192,
			//                    0LL);
			//           v165 = *(__m128i *)&v164.bufferId;
			//           inputa.ptr = v164.ptr;
			//           Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy((Void *)inputa.ptr, source, 192LL, 0LL);
			//           if ( !v376 )
			//             sub_1802DC2C8(v167, v166);
			//           monitor = v376[5].monitor;
			//           if ( !monitor )
			//             sub_1802DC2C8(0LL, v166);
			//           UnityEngine::MaterialPropertyBlock::Clear((MaterialPropertyBlock *)monitor, 1, 0LL);
			//           if ( !v376 )
			//             sub_1802DC2C8(v170, v169);
			//           v171 = v376[5].monitor;
			//           if ( !v171 )
			//             sub_1802DC2C8(0LL, v169);
			//           UnityEngine::MaterialPropertyBlock::SetConstantBuffer(
			//             (MaterialPropertyBlock *)v171,
			//             (String *)"_WaterProxyPerDrawData",
			//             v165.m128i_u32[0],
			//             v165.m128i_i32[1],
			//             _mm_cvtsi128_si32(_mm_srli_si128(v165, 8)),
			//             0LL);
			//           *(_OWORD *)&inputa.bufferId = 0LL;
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//             (TextureHandle *)v378,
			//             &v394,
			//             &v395,
			//             0,
			//             RenderBufferLoadAction__Enum_Clear,
			//             RenderBufferStoreAction__Enum_Store,
			//             (Color *)&inputa,
			//             0,
			//             0LL);
			//           *(_OWORD *)&inputa.bufferId = 0LL;
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//             (TextureHandle *)v378,
			//             &v394,
			//             (TextureHandle *)&si128,
			//             1,
			//             RenderBufferLoadAction__Enum_Clear,
			//             RenderBufferStoreAction__Enum_Store,
			//             (Color *)&inputa,
			//             0,
			//             0LL);
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//             (TextureHandle *)&inputa,
			//             &v394,
			//             &v381,
			//             DepthAccess__Enum_Write,
			//             RenderBufferLoadAction__Enum_Clear,
			//             RenderBufferStoreAction__Enum_Store,
			//             1.0,
			//             0,
			//             0,
			//             0LL);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass);
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//             &v394,
			//             (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass.static_fields.s_waterProxyRenderFunc,
			//             0LL,
			//             0,
			//             MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
			//         }
			//         catch ( Il2CppExceptionWrapper *v404 )
			//         {
			//           *(Il2CppExceptionWrapper *)&desc.m00 = (Il2CppExceptionWrapper)v404.ex;
			//           sub_180222690(&desc);
			//           v10 = this;
			//           waterManager_k__BackingField = v385;
			//           handle = (HGWaterGlobalConfig *)v392.handle;
			//           globalConfig = (HGWaterGlobalConfig *)v392.handle;
			//           goto LABEL_90;
			//         }
			//         sub_180222690(&desc);
			//         handle = globalConfig;
			// LABEL_90:
			//         v173 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//                  (Int32Enum__Enum)0x3Bu,
			//                  MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//         HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//           (HGRenderGraphBuilder *)&desc,
			//           renderGraph,
			//           (String *)"Water Decal",
			//           &v377,
			//           v173,
			//           1,
			//           ProfilingHGPass__Enum_None,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
			//         *(_OWORD *)&v390.m_RenderPass = *(_OWORD *)&desc.m00;
			//         *(_OWORD *)&v390.m_RenderGraph = *(_OWORD *)&desc.m01;
			//         *(_QWORD *)&desc.m00 = 0LL;
			//         *(_QWORD *)&desc.m20 = &v390;
			//         try
			//         {
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v390, 0, 0LL);
			//           v176 = (Object__Class *)v10.fields.m_cbHandle.ptr;
			//           v177 = v377;
			//           if ( !v377 )
			//             sub_1802DC2C8(v175, v174);
			//           v377[12] = *(Object *)&v10.fields.m_cbHandle.bufferId;
			//           v177[13].klass = v176;
			//           v178 = v377;
			//           v181 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                     (TextureHandle *)&inputa,
			//                     &v390,
			//                     &v395,
			//                     0LL);
			//           if ( !v178 )
			//             sub_1802DC2C8(v180, v179);
			//           *(TextureHandle *)&v178[15].monitor = v181;
			//           v182 = v377;
			//           v185 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                     (TextureHandle *)&inputa,
			//                     &v390,
			//                     &v381,
			//                     0LL);
			//           if ( !v182 )
			//             sub_1802DC2C8(v184, v183);
			//           *(TextureHandle *)&v182[17].monitor = v185;
			//           v186 = v377;
			//           v189 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                     (TextureHandle *)&inputa,
			//                     &v390,
			//                     &sectorTexture,
			//                     0LL);
			//           if ( !v186 )
			//             sub_1802DC2C8(v188, v187);
			//           *(TextureHandle *)&v186[13].monitor = v189;
			//           v190 = v377;
			//           v193 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                     (TextureHandle *)&inputa,
			//                     &v390,
			//                     &interactionTexture,
			//                     0LL);
			//           if ( !v190 )
			//             sub_1802DC2C8(v192, v191);
			//           *(TextureHandle *)&v190[14].monitor = v193;
			//           v194 = v377;
			//           if ( !handle )
			//             sub_1802DC2C8(v192, v191);
			//           v195 = HG::Rendering::Runtime::HGWaterGlobalConfig::get_flowMap(handle, 0LL);
			//           if ( !v194 )
			//             sub_1802DC2C8(v197, v196);
			//           v194[9].monitor = (MonitorData *)v195;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v198 = (((unsigned __int64)&v194[9].monitor >> 12) & 0x1FFFFF) >> 6;
			//             _m_prefetchw(&qword_18D6405E0[v198 + 36190]);
			//             do
			//               v199 = qword_18D6405E0[v198 + 36190];
			//             while ( v199 != _InterlockedCompareExchange64(
			//                               &qword_18D6405E0[v198 + 36190],
			//                               v199 | (1LL << (((unsigned __int64)&v194[9].monitor >> 12) & 0x3F)),
			//                               v199) );
			//           }
			//           v200 = v377;
			//           v201 = HG::Rendering::Runtime::HGWaterGlobalConfig::get_causticMap(handle, 0LL);
			//           if ( !v200 )
			//             sub_1802DC2C8(v203, v202);
			//           v200[10].klass = (Object__Class *)v201;
			//           v204 = dword_18D8E43F8;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v205 = (((unsigned __int64)&v200[10] >> 12) & 0x1FFFFF) >> 6;
			//             _m_prefetchw(&qword_18D6405E0[v205 + 36190]);
			//             do
			//               v206 = qword_18D6405E0[v205 + 36190];
			//             while ( v206 != _InterlockedCompareExchange64(
			//                               &qword_18D6405E0[v205 + 36190],
			//                               v206 | (1LL << (((unsigned __int64)&v200[10] >> 12) & 0x3F)),
			//                               v206) );
			//             v204 = dword_18D8E43F8;
			//           }
			//           v207 = v377;
			//           m_waterTextureProcessMaterial = (MonitorData *)v10.fields.m_waterTextureProcessMaterial;
			//           if ( !v377 )
			//             sub_1802DC2C8(m_waterTextureProcessMaterial, 0LL);
			//           v377[4].monitor = m_waterTextureProcessMaterial;
			//           if ( v204 )
			//           {
			//             v209 = ((unsigned __int64)&v207[4].monitor >> 12) & 0x1FFFFF;
			//             v210 = v209 >> 6;
			//             v211 = v209 & 0x3F;
			//             _m_prefetchw(&qword_18D6405E0[v210 + 36190]);
			//             do
			//               v212 = qword_18D6405E0[v210 + 36190];
			//             while ( v212 != _InterlockedCompareExchange64(&qword_18D6405E0[v210 + 36190], v212 | (1LL << v211), v212) );
			//             v204 = dword_18D8E43F8;
			//           }
			//           v213 = v377;
			//           m_waterProxyDisplacementMPB = (MonitorData *)v10.fields.m_waterProxyDisplacementMPB;
			//           if ( !v377 )
			//             sub_1802DC2C8(m_waterProxyDisplacementMPB, 0LL);
			//           v377[5].monitor = m_waterProxyDisplacementMPB;
			//           if ( v204 )
			//           {
			//             v215 = ((unsigned __int64)&v213[5].monitor >> 12) & 0x1FFFFF;
			//             v216 = v215 >> 6;
			//             v217 = v215 & 0x3F;
			//             _m_prefetchw(&qword_18D6405E0[v216 + 36190]);
			//             do
			//               v218 = qword_18D6405E0[v216 + 36190];
			//             while ( v218 != _InterlockedCompareExchange64(&qword_18D6405E0[v216 + 36190], v218 | (1LL << v217), v218) );
			//           }
			//           *(_OWORD *)&inputa.bufferId = 0LL;
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//             (TextureHandle *)v378,
			//             &v390,
			//             (TextureHandle *)&keyword,
			//             0,
			//             RenderBufferLoadAction__Enum_Load,
			//             RenderBufferStoreAction__Enum_Store,
			//             (Color *)&inputa,
			//             0,
			//             0LL);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass);
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//             &v390,
			//             (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass.static_fields.s_waterProxyDisplacementRenderFunc,
			//             0LL,
			//             0,
			//             MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
			//         }
			//         catch ( Il2CppExceptionWrapper *v405 )
			//         {
			//           *(Il2CppExceptionWrapper *)&desc.m00 = (Il2CppExceptionWrapper)v405.ex;
			//           sub_180222690(&desc);
			//           v10 = this;
			//           waterManager_k__BackingField = v385;
			//           globalConfig = (HGWaterGlobalConfig *)v392.handle;
			//           goto LABEL_117;
			//         }
			//         sub_180222690(&desc);
			// LABEL_117:
			//         v375 = 6 * (v10.fields.m_frameIndex & 1);
			//         depthBits = 6 * (((unsigned __int8)v10.fields.m_frameIndex - 1) & 1);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::WaterSettings);
			//         v219 = TypeInfo::HG::Rendering::Runtime::WaterSettings.static_fields;
			//         v220 = (int)v219.prepassTextureSize.x;
			//         v221 = (int)v219.prepassTextureSize.y;
			//         *(_QWORD *)&desc.m30 = 0LL;
			//         desc.m11 = 0.0;
			//         LODWORD(desc.m00) = 256;
			//         LODWORD(desc.m10) = 4;
			//         LODWORD(desc.m20) = 16;
			//         *(ComputeBufferHandle *)&inputa.bufferId = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateComputeBuffer(
			//                                                      renderGraph,
			//                                                      (ComputeBufferDesc *)&desc,
			//                                                      0LL);
			//         screenSpaceMesh = HG::Rendering::Runtime::HGWaterManager::get_screenSpaceMesh(waterManager_k__BackingField, 0LL);
			//         if ( !screenSpaceMesh )
			//           sub_1802DC2C8(v224, v223);
			//         IndexCount = UnityEngine::Mesh::GetIndexCount(screenSpaceMesh, 0, 0LL);
			//         v226 = HG::Rendering::Runtime::HGWaterManager::get_screenSpaceMesh(waterManager_k__BackingField, 0LL);
			//         if ( !v226 )
			//           sub_1802DC2C8(v228, v227);
			//         BaseVertex = UnityEngine::Mesh::GetBaseVertex(v226, 0, 0LL);
			//         v230 = (float)IndexCount;
			//         desc.m00 = v230;
			//         v231 = (float)BaseVertex;
			//         desc.m10 = v231;
			//         desc.m20 = 0.0;
			//         desc.m30 = 0.0;
			//         v232 = (float)v375;
			//         v233 = (float)(int)depthBits;
			//         v387.m01 = v232;
			//         v387.m11 = v233;
			//         *(_QWORD *)&v387.m21 = 1132462080LL;
			//         *(_OWORD *)v409 = *(unsigned __int64 *)&desc.m00;
			//         v410 = *(_OWORD *)&v387.m01;
			//         v411 = 0LL;
			//         v412 = 0LL;
			//         sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//         ConstantBuffer = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
			//                            (CBHandle *)&desc,
			//                            &input.srpContext,
			//                            64,
			//                            0LL);
			//         v235 = *(_OWORD *)&ConstantBuffer.bufferId;
			//         v236 = (Void *)ConstantBuffer.ptr;
			//         *(_QWORD *)&desc.m01 = v236;
			//         Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(v236, v409, 64LL, 0LL);
			//         v237 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//                  (Int32Enum__Enum)0x39u,
			//                  MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//         HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//           (HGRenderGraphBuilder *)&desc,
			//           renderGraph,
			//           (String *)"Water Occlusion",
			//           &v373,
			//           v237,
			//           1,
			//           ProfilingHGPass__Enum_None,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
			//         *(_OWORD *)&v391.m_RenderPass = *(_OWORD *)&desc.m00;
			//         *(_OWORD *)&v391.m_RenderGraph = *(_OWORD *)&desc.m01;
			//         *(_QWORD *)&desc.m00 = 0LL;
			//         *(_QWORD *)&desc.m20 = &v391;
			//         try
			//         {
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v391, 0, 0LL);
			//           v239 = v373;
			//           if ( !v373 )
			//             sub_1802DC2C8(v238, 0LL);
			//           v373[1].klass = (Object__Class *)hgCamera;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v240 = ((unsigned __int64)&v239[1] >> 12) & 0x1FFFFF;
			//             v241 = (unsigned __int64)v240 >> 6;
			//             v239 = (Object *)(v240 & 0x3F);
			//             _m_prefetchw(&qword_18D6405E0[v241 + 36190]);
			//             do
			//             {
			//               v238 = qword_18D6405E0[v241 + 36190] | (1LL << (char)v239);
			//               v242 = qword_18D6405E0[v241 + 36190];
			//             }
			//             while ( v242 != _InterlockedCompareExchange64(&qword_18D6405E0[v241 + 36190], v238, v242) );
			//           }
			//           LOBYTE(v238) = v10.fields.m_isFirstTime;
			//           if ( !v373 )
			//             sub_1802DC2C8(v238, v239);
			//           LOBYTE(v373[26].monitor) = v238;
			//           v243 = v373;
			//           if ( !v373 )
			//             sub_1802DC2C8(0LL, v239);
			//           BYTE1(v373[26].monitor) = enableIndirect;
			//           v244 = (Object__Class *)v10.fields.m_cbHandle.ptr;
			//           v245 = v373;
			//           if ( !v373 )
			//             sub_1802DC2C8(v243, v239);
			//           v373[12] = *(Object *)&v10.fields.m_cbHandle.bufferId;
			//           v245[13].klass = v244;
			//           v246 = v373;
			//           if ( !v373 )
			//             sub_1802DC2C8(v243, v239);
			//           *(_OWORD *)&v373[27].monitor = v235;
			//           v246[28].monitor = (MonitorData *)v236;
			//           v247 = v373;
			//           v250 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                     (TextureHandle *)v378,
			//                     &v391,
			//                     &input.sceneDepth,
			//                     0LL);
			//           if ( !v247 )
			//             sub_1802DC2C8(v249, v248);
			//           v247[36] = (Object)v250;
			//           v251 = v373;
			//           v254 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                     (TextureHandle *)v378,
			//                     &v391,
			//                     &v381,
			//                     0LL);
			//           if ( !v251 )
			//             sub_1802DC2C8(v253, v252);
			//           *(TextureHandle *)&v251[17].monitor = v254;
			//           v255 = (ComputeBufferHandle *)v373;
			//           v256 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteComputeBuffer(
			//                    &v391,
			//                    (ComputeBufferHandle *)&inputa,
			//                    0LL);
			//           if ( !v255 )
			//             sub_1802DC2C8(v258, v257);
			//           v255[58] = v256;
			//           v259 = (ComputeBufferHandle *)v373;
			//           v378[0] = HG::Rendering::RenderGraphModule::HGRenderGraph::ImportComputeBuffer(
			//                       renderGraph,
			//                       v10.fields.m_indirectBuffer,
			//                       0LL);
			//           v260 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteComputeBuffer(&v391, v378, 0LL);
			//           if ( !v259 )
			//             sub_1802DC2C8(v262, v261);
			//           v259[59] = v260;
			//           v378[0].handle.m_Value = v220;
			//           v378[0].handle._type_k__BackingField = v221;
			//           v263 = v373;
			//           if ( !v373 )
			//             sub_1802DC2C8(0LL, v261);
			//           v373[30].klass = (Object__Class *)v378[0];
			//           v264 = v373;
			//           if ( !v373 )
			//             sub_1802DC2C8(v263, 0LL);
			//           v373[30].monitor = (MonitorData *)v10.fields.m_waterOcclusionCS;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v265 = ((unsigned __int64)&v264[30].monitor >> 12) & 0x1FFFFF;
			//             v266 = (unsigned __int64)v265 >> 6;
			//             v267 = v265 & 0x3F;
			//             _m_prefetchw(&qword_18D6405E0[v266 + 36190]);
			//             do
			//               v268 = qword_18D6405E0[v266 + 36190];
			//             while ( v268 != _InterlockedCompareExchange64(&qword_18D6405E0[v266 + 36190], v268 | (1LL << v267), v268) );
			//           }
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass);
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//             &v391,
			//             (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass.static_fields.s_waterOcclustionRenderFunc,
			//             0LL,
			//             0,
			//             MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
			//         }
			//         catch ( Il2CppExceptionWrapper *v406 )
			//         {
			//           *(Il2CppExceptionWrapper *)&desc.m00 = (Il2CppExceptionWrapper)v406.ex;
			//           sub_180222690(&desc);
			//           v10 = this;
			//           waterManager_k__BackingField = v385;
			//           globalConfig = (HGWaterGlobalConfig *)v392.handle;
			//           goto LABEL_139;
			//         }
			//         sub_180222690(&desc);
			// LABEL_139:
			//         v269 = depthBits;
			//         v270 = v375;
			//         *(TextureHandle *)&v378[0].handle.m_Value = *HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(
			//                                                        (TextureHandle *)&desc,
			//                                                        &input.gBufferOutput,
			//                                                        GBufferID__Enum_GBufferB,
			//                                                        0LL);
			//         v10.fields.m_normalRoughnessWithWaterTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                                            (TextureHandle *)&desc,
			//                                                            renderGraph,
			//                                                            (TextureHandle *)v378,
			//                                                            0LL);
			//         v10.fields.m_depthWithWaterTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                                  (TextureHandle *)&desc,
			//                                                  renderGraph,
			//                                                  &input.sceneDepth,
			//                                                  0LL);
			//         sub_1802F01E0(&v402, 0LL, 96LL);
			//         HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
			//           &v402,
			//           hgCamera.fields._sceneRTSize_k__BackingField,
			//           0LL);
			//         v382 = v402;
			//         v382.colorFormat = 8;
			//         *(_WORD *)&v382.useMipMap = 0;
			//         *(_OWORD *)&v420.width = *(_OWORD *)&v402.width;
			//         *(_OWORD *)&v420.colorFormat = *(_OWORD *)&v382.colorFormat;
			//         *(_OWORD *)&v420.enableRandomWrite = *(_OWORD *)&v382.enableRandomWrite;
			//         *(_OWORD *)&v420.bindTextureMS = *(_OWORD *)&v402.bindTextureMS;
			//         *(_OWORD *)&v420.fastMemoryDesc.inFastMemory = *(_OWORD *)&v402.fastMemoryDesc.inFastMemory;
			//         v420.clearColor = v402.clearColor;
			//         v10.fields.m_waterTessellationDataTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                                         (TextureHandle *)&desc,
			//                                                         renderGraph,
			//                                                         &v420,
			//                                                         0LL);
			//         v271 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//                  (Int32Enum__Enum)0x40u,
			//                  MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//         HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//           (HGRenderGraphBuilder *)&desc,
			//           renderGraph,
			//           (String *)"Water Tessellation",
			//           &v370,
			//           v271,
			//           1,
			//           ProfilingHGPass__Enum_None,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
			//         *(_OWORD *)&v383.m_RenderPass = *(_OWORD *)&desc.m00;
			//         *(_OWORD *)&v383.m_RenderGraph = *(_OWORD *)&desc.m01;
			//         *(_QWORD *)&desc.m00 = 0LL;
			//         *(_QWORD *)&desc.m20 = &v383;
			//         try
			//         {
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v383, 0, 0LL);
			//           v274 = (Object__Class *)v10.fields.m_cbHandle.ptr;
			//           v275 = v370;
			//           if ( !v370 )
			//             sub_1802DC2C8(v273, v272);
			//           v370[12] = *(Object *)&v10.fields.m_cbHandle.bufferId;
			//           v275[13].klass = v274;
			//           v276 = v370;
			//           v279 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v392, &v383, &sectorTexture, 0LL);
			//           if ( !v276 )
			//             sub_1802DC2C8(v278, v277);
			//           *(TextureHandle *)&v276[13].monitor = v279;
			//           v280 = v370;
			//           v283 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                     &sectorTexture,
			//                     &v383,
			//                     &interactionTexture,
			//                     0LL);
			//           if ( !v280 )
			//             sub_1802DC2C8(v282, v281);
			//           *(TextureHandle *)&v280[14].monitor = v283;
			//           v284 = v370;
			//           v287 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                     &interactionTexture,
			//                     &v383,
			//                     &v395,
			//                     0LL);
			//           if ( !v284 )
			//             sub_1802DC2C8(v286, v285);
			//           v284[31] = (Object)v287;
			//           v288 = v370;
			//           v291 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                     &interactionTexture,
			//                     &v383,
			//                     (TextureHandle *)&si128,
			//                     0LL);
			//           if ( !v288 )
			//             sub_1802DC2C8(v290, v289);
			//           v288[32] = (Object)v291;
			//           v292 = v370;
			//           v295 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                     (TextureHandle *)&si128,
			//                     &v383,
			//                     (TextureHandle *)&keyword,
			//                     0LL);
			//           if ( !v292 )
			//             sub_1802DC2C8(v294, v293);
			//           v292[33] = (Object)v295;
			//           v296 = v370;
			//           v299 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                     (TextureHandle *)&keyword,
			//                     &v383,
			//                     &v381,
			//                     0LL);
			//           if ( !v296 )
			//             sub_1802DC2C8(v298, v297);
			//           v296[34] = (Object)v299;
			//           v300 = v370;
			//           v303 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                     (TextureHandle *)&keyword,
			//                     &v383,
			//                     (TextureHandle *)v378,
			//                     0LL);
			//           if ( !v300 )
			//             sub_1802DC2C8(v302, v301);
			//           v300[35] = (Object)v303;
			//           v304 = v370;
			//           v307 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                     (TextureHandle *)&keyword,
			//                     &v383,
			//                     &input.sceneDepth,
			//                     0LL);
			//           if ( !v304 )
			//             sub_1802DC2C8(v306, v305);
			//           v304[36] = (Object)v307;
			//           v308 = v370;
			//           if ( !globalConfig )
			//             sub_1802DC2C8(v306, v305);
			//           rainMap = HG::Rendering::Runtime::HGWaterGlobalConfig::get_rainMap(globalConfig, 0LL);
			//           if ( !v308 )
			//             sub_1802DC2C8(v311, v310);
			//           v308[10].monitor = (MonitorData *)rainMap;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v312 = (((unsigned __int64)&v308[10].monitor >> 12) & 0x1FFFFF) >> 6;
			//             _m_prefetchw(&qword_18D6405E0[v312 + 36190]);
			//             do
			//               v313 = qword_18D6405E0[v312 + 36190];
			//             while ( v313 != _InterlockedCompareExchange64(
			//                               &qword_18D6405E0[v312 + 36190],
			//                               v313 | (1LL << (((unsigned __int64)&v308[10].monitor >> 12) & 0x3F)),
			//                               v313) );
			//           }
			//           v314 = v370;
			//           normalMapArray = HG::Rendering::Runtime::HGWaterGlobalConfig::get_normalMapArray(globalConfig, 0LL);
			//           if ( !v314 )
			//             sub_1802DC2C8(v317, v316);
			//           v314[11].monitor = (MonitorData *)normalMapArray;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v318 = (((unsigned __int64)&v314[11].monitor >> 12) & 0x1FFFFF) >> 6;
			//             v316 = ((unsigned __int64)&v314[11].monitor >> 12) & 0x3F;
			//             _m_prefetchw(&qword_18D6405E0[v318 + 36190]);
			//             do
			//               v319 = qword_18D6405E0[v318 + 36190];
			//             while ( v319 != _InterlockedCompareExchange64(&qword_18D6405E0[v318 + 36190], v319 | (1LL << v316), v319) );
			//           }
			//           v320 = v370;
			//           if ( !v370 )
			//             sub_1802DC2C8(0LL, v316);
			//           BYTE1(v370[26].monitor) = enableIndirect;
			//           if ( !v370 )
			//             sub_1802DC2C8(v320, v316);
			//           HIDWORD(v370[26].monitor) = v270;
			//           if ( !v370 )
			//             sub_1802DC2C8(v320, v316);
			//           LODWORD(v370[27].klass) = v269;
			//           v321 = (ComputeBufferHandle *)v370;
			//           v322 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadComputeBuffer(
			//                    &v383,
			//                    (ComputeBufferHandle *)&inputa,
			//                    0LL);
			//           if ( !v321 )
			//             sub_1802DC2C8(v324, v323);
			//           v321[58] = v322;
			//           v325 = (ComputeBufferHandle *)v370;
			//           v378[0] = HG::Rendering::RenderGraphModule::HGRenderGraph::ImportComputeBuffer(
			//                       renderGraph,
			//                       v10.fields.m_indirectBuffer,
			//                       0LL);
			//           v326 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadComputeBuffer(&v383, v378, 0LL);
			//           if ( !v325 )
			//             sub_1802DC2C8(v328, v327);
			//           v325[59] = v326;
			//           v329 = v370;
			//           if ( !v370 )
			//             sub_1802DC2C8(v328, 0LL);
			//           v370[6].monitor = (MonitorData *)v10.fields.m_waterTesellationMPB;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v330 = ((unsigned __int64)&v329[6].monitor >> 12) & 0x1FFFFF;
			//             v331 = v330 >> 6;
			//             v332 = v330 & 0x3F;
			//             _m_prefetchw(&qword_18D6405E0[v331 + 36190]);
			//             do
			//               v333 = qword_18D6405E0[v331 + 36190];
			//             while ( v333 != _InterlockedCompareExchange64(&qword_18D6405E0[v331 + 36190], v333 | (1LL << v332), v333) );
			//           }
			//           v334 = v370;
			//           v335 = HG::Rendering::Runtime::HGWaterManager::get_screenSpaceMesh(waterManager_k__BackingField, 0LL);
			//           if ( !v334 )
			//             sub_1802DC2C8(v337, v336);
			//           v334[3].monitor = (MonitorData *)v335;
			//           v338 = dword_18D8E43F8;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v339 = (((unsigned __int64)&v334[3].monitor >> 12) & 0x1FFFFF) >> 6;
			//             _m_prefetchw(&qword_18D6405E0[v339 + 36190]);
			//             do
			//               v340 = qword_18D6405E0[v339 + 36190];
			//             while ( v340 != _InterlockedCompareExchange64(
			//                               &qword_18D6405E0[v339 + 36190],
			//                               v340 | (1LL << (((unsigned __int64)&v334[3].monitor >> 12) & 0x3F)),
			//                               v340) );
			//             v338 = dword_18D8E43F8;
			//           }
			//           v341 = v370;
			//           m_renderingMaterial = (Object__Class *)v10.fields.m_renderingMaterial;
			//           if ( !v370 )
			//             sub_1802DC2C8(m_renderingMaterial, 0LL);
			//           v370[5].klass = m_renderingMaterial;
			//           if ( v338 )
			//           {
			//             v343 = ((unsigned __int64)&v341[5] >> 12) & 0x1FFFFF;
			//             v344 = v343 >> 6;
			//             v345 = v343 & 0x3F;
			//             _m_prefetchw(&qword_18D6405E0[v344 + 36190]);
			//             do
			//               v346 = qword_18D6405E0[v344 + 36190];
			//             while ( v346 != _InterlockedCompareExchange64(&qword_18D6405E0[v344 + 36190], v346 | (1LL << v345), v346) );
			//             v338 = dword_18D8E43F8;
			//           }
			//           v347 = v370;
			//           v348 = (MonitorData *)v10.fields.m_waterTextureProcessMaterial;
			//           if ( !v370 )
			//             sub_1802DC2C8(v348, 0LL);
			//           v370[4].monitor = v348;
			//           if ( v338 )
			//           {
			//             v349 = ((unsigned __int64)&v347[4].monitor >> 12) & 0x1FFFFF;
			//             v350 = v349 >> 6;
			//             v347 = (Object *)(v349 & 0x3F);
			//             _m_prefetchw(&qword_18D6405E0[v350 + 36190]);
			//             do
			//               v351 = qword_18D6405E0[v350 + 36190];
			//             while ( v351 != _InterlockedCompareExchange64(
			//                               &qword_18D6405E0[v350 + 36190],
			//                               v351 | (1LL << (char)v347),
			//                               v351) );
			//           }
			//           v352 = v10.fields.m_renderingMaterial;
			//           if ( !v352 )
			//             sub_1802DC2C8(0LL, v347);
			//           shader = UnityEngine::Material::get_shader(v352, 0LL);
			//           UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v399, shader, (String *)"ENABLE_RAIN", 0LL);
			//           v355 = v10.fields.m_renderingMaterial;
			//           if ( !v355 )
			//             sub_1802DC2C8(0LL, v354);
			//           keyword = v399;
			//           UnityEngine::Material::SetLocalKeyword_Injected(v355, &keyword, wetnessHighQualityEnabled, 0LL);
			//           v357 = v10.fields.m_renderingMaterial;
			//           if ( !v357 )
			//             sub_1802DC2C8(0LL, v356);
			//           v358 = UnityEngine::Material::get_shader(v357, 0LL);
			//           UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v400, v358, (String *)"ENABLE_WATER_RIPPLE", 0LL);
			//           v359 = v10.fields.m_renderingMaterial;
			//           ShouldRenderRippleState = HG::Rendering::Runtime::HGWaterManager::GetShouldRenderRippleState(
			//                                       waterManager_k__BackingField,
			//                                       0LL);
			//           if ( !v359 )
			//             sub_1802DC2C8(v362, v361);
			//           keyword = v400;
			//           UnityEngine::Material::SetLocalKeyword_Injected(v359, &keyword, ShouldRenderRippleState, 0LL);
			//           *(_OWORD *)&keyword.m_SpaceInfo.m_KeywordSpace = 0LL;
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//             (TextureHandle *)&si128,
			//             &v383,
			//             &v10.fields.m_normalRoughnessWithWaterTexture,
			//             0,
			//             RenderBufferLoadAction__Enum_Load,
			//             RenderBufferStoreAction__Enum_Store,
			//             (Color *)&keyword,
			//             0,
			//             0LL);
			//           *(_OWORD *)&keyword.m_SpaceInfo.m_KeywordSpace = 0LL;
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//             (TextureHandle *)&si128,
			//             &v383,
			//             &v10.fields.m_waterTessellationDataTexture,
			//             1,
			//             RenderBufferLoadAction__Enum_Load,
			//             RenderBufferStoreAction__Enum_Store,
			//             (Color *)&keyword,
			//             0,
			//             0LL);
			//           sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//           if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input.sceneMV, 0LL) )
			//           {
			//             *(__m128i *)&keyword.m_SpaceInfo.m_KeywordSpace = _mm_load_si128((const __m128i *)&xmmword_18C1755F0);
			//             HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//               (TextureHandle *)&si128,
			//               &v383,
			//               &input.sceneMV,
			//               2,
			//               RenderBufferLoadAction__Enum_Load,
			//               RenderBufferStoreAction__Enum_Store,
			//               (Color *)&keyword,
			//               0,
			//               0LL);
			//           }
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//             (TextureHandle *)&keyword,
			//             &v383,
			//             &v10.fields.m_depthWithWaterTexture,
			//             DepthAccess__Enum_Write,
			//             RenderBufferLoadAction__Enum_Load,
			//             RenderBufferStoreAction__Enum_Store,
			//             1.0,
			//             0,
			//             0,
			//             0LL);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass);
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//             &v383,
			//             (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass.static_fields.s_waterTessellationRenderFunc,
			//             0LL,
			//             0,
			//             MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
			//         }
			//         catch ( Il2CppExceptionWrapper *v407 )
			//         {
			//           *(Il2CppExceptionWrapper *)&desc.m00 = (Il2CppExceptionWrapper)v407.ex;
			//           sub_180222690(&desc);
			//           v10 = this;
			//           goto LABEL_189;
			//         }
			//         sub_180222690(&desc);
			// LABEL_189:
			//         v10.fields.m_isFirstTime = 0;
			//         v10.fields.m_frameIndex = ((unsigned __int8)v10.fields.m_frameIndex + 1) & 0x3F;
			//       }
			//       catch ( Il2CppExceptionWrapper *v408 )
			//       {
			//         v393[0] = v408.ex;
			//       }
			//       sub_180224750(v393);
			//     }
			//     else
			//     {
			//       HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::RenderFallback(
			//         v10,
			//         v9,
			//         output,
			//         renderGraph,
			//         hgCamera,
			//         0LL);
			//     }
			//   }
			// }
			// 
		}

		internal void RenderPrepassV2(ref WaterDefaultDeferredRenderingPass.PassInput input, ref WaterDefaultDeferredRenderingPass.PassOutput output, HGRenderGraph renderGraph, HGCamera hgCamera, [MetadataOffset(Offset = "0x01F91938")] bool wetnessHighQualityEnabled = false)
		{
			// // Void RenderPrepassV2(WaterDefaultDeferredRenderingPass+PassInput ByRef, WaterDefaultDeferredRenderingPass+PassOutput ByRef, HGRenderGraph, HGCamera, Boolean)
			// // Hidden C++ exception states: #wind=8
			// void HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::RenderPrepassV2(
			//         WaterDefaultDeferredRenderingPass *this,
			//         WaterDefaultDeferredRenderingPass_PassInput *input,
			//         WaterDefaultDeferredRenderingPass_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *hgCamera,
			//         bool wetnessHighQualityEnabled,
			//         MethodInfo *method)
			// {
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   ProfilingSampler *v13; // rax
			//   HGManagerContext *currentManagerContext; // rax
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   HGWaterManager *waterManager_k__BackingField; // rdi
			//   HGManagerContext *v18; // rax
			//   __int64 v19; // rdx
			//   __int64 v20; // rcx
			//   HGWaterManager *v21; // rcx
			//   CBHandle *v22; // rax
			//   __int64 v23; // rdx
			//   __int64 v24; // rcx
			//   void *ptr; // xmm0_8
			//   __int64 v26; // rdx
			//   HGSettingParameters *settingParameters; // rcx
			//   __int64 v28; // rdx
			//   Int32Enum__Enum v29; // edi
			//   HGSettingParameters *v30; // rcx
			//   Int32Enum__Enum v31; // r13d
			//   unsigned __int64 v32; // rdx
			//   signed __int64 v33; // rcx
			//   __int128 v34; // xmm2
			//   __int128 v35; // xmm3
			//   Color clearColor; // xmm4
			//   unsigned __int64 v37; // r8
			//   signed __int64 v38; // rtt
			//   ProfilingSampler *v39; // rax
			//   __int64 v40; // rdx
			//   __int64 v41; // rcx
			//   TextureHandle v42; // xmm0
			//   __int64 v43; // rdx
			//   __int64 v44; // rcx
			//   TextureHandle v45; // xmm0
			//   Object *v46; // rdx
			//   int v47; // eax
			//   unsigned __int64 v48; // rdx
			//   unsigned __int64 v49; // r8
			//   char v50; // dl
			//   signed __int64 v51; // rtt
			//   Object *v52; // rdx
			//   MonitorData *m_waterTextureProcessMaterial; // rcx
			//   unsigned __int64 v54; // rdx
			//   unsigned __int64 v55; // r8
			//   char v56; // dl
			//   signed __int64 v57; // rtt
			//   __int64 v58; // rdx
			//   __int64 v59; // rcx
			//   ProfilingSampler *v60; // rax
			//   signed __int64 v61; // rcx
			//   Object *v62; // rdx
			//   unsigned __int64 v63; // rdx
			//   unsigned __int64 v64; // r8
			//   signed __int64 v65; // rtt
			//   Object__Class *v66; // xmm1_8
			//   Object *v67; // rax
			//   Object *v68; // r15
			//   __int64 v69; // rdx
			//   __int64 v70; // rcx
			//   TextureHandle v71; // xmm0
			//   Object *v72; // r15
			//   __int64 v73; // rdx
			//   __int64 v74; // rcx
			//   TextureHandle v75; // xmm0
			//   Object *v76; // r15
			//   Texture2D *v77; // rax
			//   __int64 v78; // rdx
			//   __int64 v79; // rcx
			//   unsigned __int64 v80; // r8
			//   signed __int64 v81; // rtt
			//   Object *v82; // r15
			//   Texture2D *v83; // rax
			//   __int64 v84; // rdx
			//   __int64 v85; // rcx
			//   unsigned __int64 v86; // r9
			//   signed __int64 v87; // rtt
			//   Object *v88; // r15
			//   Texture2DArray *v89; // rax
			//   __int64 v90; // rdx
			//   __int64 v91; // rcx
			//   int v92; // eax
			//   unsigned __int64 v93; // r8
			//   signed __int64 v94; // rtt
			//   Object *v95; // rdx
			//   Object__Class *v96; // rcx
			//   unsigned __int64 v97; // rdx
			//   unsigned __int64 v98; // r8
			//   char v99; // dl
			//   signed __int64 v100; // rtt
			//   Object *v101; // rdx
			//   MonitorData *v102; // rcx
			//   unsigned __int64 v103; // rdx
			//   unsigned __int64 v104; // r8
			//   signed __int64 v105; // rtt
			//   Material *v106; // rcx
			//   Shader *v107; // rax
			//   __int64 v108; // rdx
			//   Material *v109; // rcx
			//   __int64 v110; // rdx
			//   Material *v111; // rcx
			//   Shader *v112; // rax
			//   Material *v113; // rdi
			//   bool v114; // al
			//   __int64 v115; // rdx
			//   __int64 v116; // rcx
			//   ComputeBuffer *v117; // rax
			//   __int64 v118; // rdx
			//   __int64 v119; // rcx
			//   ComputeBuffer *v120; // r13
			//   unsigned __int64 v121; // r8
			//   signed __int64 v122; // rtt
			//   int32_t i; // r13d
			//   int32_t j; // r13d
			//   ProfilingSampler *v125; // rax
			//   ProfilingSampler *v126; // rax
			//   __int64 v127; // rdx
			//   HGRenderGraphPass *v128; // rcx
			//   HGRenderGraphPass *v129; // rdx
			//   int v130; // eax
			//   unsigned __int64 v131; // rdx
			//   unsigned __int64 v132; // r8
			//   char v133; // dl
			//   signed __int64 v134; // rtt
			//   HGRenderGraphPass *v135; // rdx
			//   Object__Class *m_waterProxyMaterial_V2; // rcx
			//   unsigned __int64 v137; // rdx
			//   unsigned __int64 v138; // r8
			//   char v139; // dl
			//   signed __int64 v140; // rtt
			//   HGRenderGraphPass *v141; // rdx
			//   MonitorData *m_waterProxyMPB_V2; // rcx
			//   unsigned __int64 v143; // rdx
			//   unsigned __int64 v144; // r8
			//   char v145; // dl
			//   signed __int64 v146; // rtt
			//   __int64 v147; // rdx
			//   MaterialPropertyBlock *v148; // rcx
			//   __int64 v149; // rdx
			//   MaterialPropertyBlock *v150; // rcx
			//   ProfilingSampler *v151; // rax
			//   __int128 v152; // xmm6
			//   ProfilingSampler *v153; // xmm7_8
			//   HGRenderGraphPass *m_RenderPass; // rax
			//   HGRenderGraphPass *v155; // rdx
			//   unsigned __int64 v156; // rdx
			//   unsigned __int64 v157; // r8
			//   char v158; // dl
			//   signed __int64 v159; // rtt
			//   Color v160; // xmm6
			//   TextureHandle v161; // xmm6
			//   TextureHandle v162; // xmm6
			//   TextureHandle v163; // xmm6
			//   __int64 v164; // rdx
			//   __int64 v165; // rcx
			//   TextureHandle v166; // xmm0
			//   __int64 v167; // rdx
			//   Texture2D *flowMap; // rcx
			//   HGRenderGraphPass *v169; // rax
			//   unsigned __int64 v170; // r8
			//   signed __int64 v171; // rtt
			//   MonitorData *normalMapArray; // rax
			//   __int64 v173; // rdx
			//   HGRenderGraphPass *v174; // rcx
			//   int v175; // eax
			//   unsigned __int64 v176; // r8
			//   signed __int64 v177; // rtt
			//   HGRenderGraphPass *v178; // rdx
			//   MonitorData *m_waterTextureProcessMaterial_V2; // rcx
			//   unsigned __int64 v180; // rdx
			//   unsigned __int64 v181; // r8
			//   char v182; // dl
			//   signed __int64 v183; // rtt
			//   HGRenderGraphPass *v184; // rdx
			//   MonitorData *m_waterHeightDecalMPB; // rcx
			//   unsigned __int64 v186; // rdx
			//   unsigned __int64 v187; // r8
			//   char v188; // dl
			//   signed __int64 v189; // rtt
			//   ProfilingSampler *v190; // rax
			//   Mesh *screenSpaceMesh; // rax
			//   __int64 v192; // rdx
			//   __int64 v193; // rcx
			//   Mesh *v194; // rax
			//   __int64 v195; // rdx
			//   __int64 v196; // rcx
			//   signed int BaseVertex; // eax
			//   float m_RenderPass_low; // xmm1_4
			//   float v199; // xmm1_4
			//   unsigned int v200; // xmm4_4
			//   unsigned int v201; // xmm0_4
			//   CBHandle *ConstantBuffer; // rax
			//   __int128 v203; // xmm7
			//   Void *v204; // xmm6_8
			//   signed __int64 v205; // rcx
			//   HGRenderGraphPass *v206; // rdx
			//   unsigned __int64 v207; // rdx
			//   unsigned __int64 v208; // r8
			//   signed __int64 v209; // rtt
			//   __int64 v210; // rcx
			//   __int64 v211; // rcx
			//   ProfilingSampler *v212; // xmm1_8
			//   HGRenderGraphPass *v213; // rax
			//   HGRenderGraphPass *v214; // rax
			//   ComputeBufferHandle v215; // rax
			//   ComputeBufferHandle v216; // rdx
			//   ComputeBufferHandle v217; // rax
			//   ComputeBufferHandle v218; // rdx
			//   __int64 v219; // rdx
			//   __int64 v220; // rcx
			//   TextureHandle v221; // xmm0
			//   __int64 v222; // rdx
			//   __int64 v223; // rcx
			//   TextureHandle v224; // xmm0
			//   __int64 v225; // rdx
			//   __int64 v226; // rcx
			//   TextureHandle v227; // xmm0
			//   HGRenderGraphPass *v228; // rdx
			//   unsigned __int64 v229; // rdx
			//   unsigned __int64 v230; // r8
			//   char v231; // dl
			//   signed __int64 v232; // rtt
			//   ProfilingSampler *v233; // rax
			//   signed __int64 v234; // rcx
			//   Object *v235; // rdx
			//   unsigned __int64 v236; // rdx
			//   unsigned __int64 v237; // r8
			//   signed __int64 v238; // rtt
			//   Object__Class *v239; // xmm1_8
			//   Object *v240; // rax
			//   Object *v241; // rdx
			//   __int64 v242; // rcx
			//   ComputeBufferHandle *v243; // r13
			//   ComputeBufferHandle v244; // rax
			//   ComputeBufferHandle v245; // rdx
			//   ComputeBufferHandle v246; // rcx
			//   ComputeBufferHandle *v247; // r15
			//   ComputeBufferHandle v248; // rax
			//   ComputeBufferHandle v249; // rdx
			//   ComputeBufferHandle v250; // rcx
			//   Object *v251; // r15
			//   __int64 v252; // rdx
			//   __int64 v253; // rcx
			//   TextureHandle v254; // xmm0
			//   Object *v255; // r15
			//   __int64 v256; // rdx
			//   __int64 v257; // rcx
			//   TextureHandle v258; // xmm0
			//   Object *v259; // r15
			//   __int64 v260; // rdx
			//   __int64 v261; // rcx
			//   TextureHandle v262; // xmm0
			//   Object *v263; // r15
			//   __int64 v264; // rdx
			//   __int64 v265; // rcx
			//   TextureHandle v266; // xmm0
			//   Object *v267; // r15
			//   __int64 v268; // rdx
			//   __int64 v269; // rcx
			//   TextureHandle v270; // xmm0
			//   Object *v271; // r15
			//   __int64 v272; // rdx
			//   __int64 v273; // rcx
			//   TextureHandle v274; // xmm0
			//   Object *v275; // r15
			//   HGWaterGlobalConfig *m_KeywordSpace; // r13
			//   Texture2D *v277; // rax
			//   __int64 v278; // rdx
			//   __int64 v279; // rcx
			//   unsigned __int64 v280; // r8
			//   signed __int64 v281; // rtt
			//   Object *v282; // r15
			//   Texture2D *rainMap; // rax
			//   __int64 v284; // rdx
			//   __int64 v285; // rcx
			//   unsigned __int64 v286; // r8
			//   signed __int64 v287; // rtt
			//   Object *v288; // r15
			//   Texture2DArray *v289; // rax
			//   __int64 v290; // rdx
			//   __int64 v291; // rcx
			//   unsigned __int64 v292; // r8
			//   signed __int64 v293; // rtt
			//   Object *v294; // r15
			//   HGWaterManager *v295; // r13
			//   Mesh *v296; // rax
			//   __int64 v297; // rdx
			//   __int64 v298; // rcx
			//   int v299; // eax
			//   unsigned __int64 v300; // r8
			//   signed __int64 v301; // rtt
			//   Object *v302; // rdx
			//   Object__Class *m_waterTessellationMPB; // rcx
			//   unsigned __int64 v304; // rdx
			//   unsigned __int64 v305; // r8
			//   char v306; // dl
			//   signed __int64 v307; // rtt
			//   Object *v308; // rdx
			//   MonitorData *m_waterTessellationMaterial; // rcx
			//   unsigned __int64 v310; // rdx
			//   unsigned __int64 v311; // r8
			//   signed __int64 v312; // rtt
			//   Material *v313; // rcx
			//   Shader *shader; // rax
			//   __int64 v315; // rdx
			//   Material *v316; // rcx
			//   __int64 v317; // rdx
			//   Material *v318; // rcx
			//   Shader *v319; // rax
			//   Material *v320; // rdi
			//   bool ShouldRenderRippleState; // al
			//   __int64 v322; // rdx
			//   __int64 v323; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Object *v325; // [rsp+58h] [rbp-C70h] BYREF
			//   HGRenderGraphBuilder inputa; // [rsp+60h] [rbp-C68h] BYREF
			//   int32_t RealLODNum; // [rsp+80h] [rbp-C48h]
			//   GraphicsFormat__Enum SupportedFormatForDepth; // [rsp+84h] [rbp-C44h]
			//   HGRenderGraphPass *v329; // [rsp+88h] [rbp-C40h] BYREF
			//   HGRenderGraphPass *v330; // [rsp+90h] [rbp-C38h] BYREF
			//   Vector3 viewPosition; // [rsp+A0h] [rbp-C28h] BYREF
			//   DepthBits__Enum depthBits[2]; // [rsp+B0h] [rbp-C18h] BYREF
			//   uint32_t cullHandle; // [rsp+B8h] [rbp-C10h] BYREF
			//   Object *v334; // [rsp+C0h] [rbp-C08h] BYREF
			//   LocalKeyword v335; // [rsp+D0h] [rbp-BF8h] BYREF
			//   HGRenderGraphPass *v336; // [rsp+F0h] [rbp-BD8h] BYREF
			//   HGWaterManager *v337; // [rsp+F8h] [rbp-BD0h]
			//   TextureHandle v338; // [rsp+100h] [rbp-BC8h] BYREF
			//   uint32_t visibleCount[4]; // [rsp+110h] [rbp-BB8h] BYREF
			//   TextureHandle v340; // [rsp+120h] [rbp-BA8h] BYREF
			//   TextureDesc v341; // [rsp+130h] [rbp-B98h] BYREF
			//   signed int v342; // [rsp+190h] [rbp-B38h]
			//   int v343; // [rsp+194h] [rbp-B34h]
			//   Object *v344; // [rsp+198h] [rbp-B30h] BYREF
			//   _QWORD v345[2]; // [rsp+1A0h] [rbp-B28h] BYREF
			//   TextureHandle v346; // [rsp+1B0h] [rbp-B18h] BYREF
			//   TextureHandle si128; // [rsp+1C0h] [rbp-B08h] BYREF
			//   HGRenderGraphBuilder v348; // [rsp+1D0h] [rbp-AF8h] BYREF
			//   int v349; // [rsp+1F0h] [rbp-AD8h]
			//   LocalKeyword keyword; // [rsp+200h] [rbp-AC8h] BYREF
			//   HGRenderGraphBuilder v351; // [rsp+220h] [rbp-AA8h] BYREF
			//   HGRenderGraphBuilder v352; // [rsp+240h] [rbp-A88h] BYREF
			//   ScriptableRenderContext v353; // [rsp+260h] [rbp-A68h] BYREF
			//   _QWORD v354[2]; // [rsp+268h] [rbp-A60h] BYREF
			//   HGRenderGraphBuilder v355; // [rsp+278h] [rbp-A50h] BYREF
			//   HGRenderGraphBuilder v356; // [rsp+298h] [rbp-A30h] BYREF
			//   _QWORD v357[2]; // [rsp+2B8h] [rbp-A10h] BYREF
			//   TextureHandle v358; // [rsp+2C8h] [rbp-A00h] BYREF
			//   TextureHandle v359; // [rsp+2D8h] [rbp-9F0h] BYREF
			//   _QWORD v360[2]; // [rsp+2E8h] [rbp-9E0h] BYREF
			//   _QWORD v361[2]; // [rsp+2F8h] [rbp-9D0h] BYREF
			//   __int128 v362; // [rsp+308h] [rbp-9C0h]
			//   HGRenderGraphBuilder v363; // [rsp+318h] [rbp-9B0h] BYREF
			//   ComputeBufferDesc desc; // [rsp+338h] [rbp-990h] BYREF
			//   Matrix4x4 viewProj; // [rsp+350h] [rbp-978h] BYREF
			//   TextureHandle sectorTexture; // [rsp+390h] [rbp-938h] BYREF
			//   TextureHandle v367; // [rsp+3A0h] [rbp-928h] BYREF
			//   TextureHandle interactionTexture; // [rsp+3B0h] [rbp-918h] BYREF
			//   LocalKeyword v369; // [rsp+3C0h] [rbp-908h] BYREF
			//   LocalKeyword v370; // [rsp+3D8h] [rbp-8F0h] BYREF
			//   LocalKeyword v371; // [rsp+3F0h] [rbp-8D8h] BYREF
			//   LocalKeyword v372; // [rsp+408h] [rbp-8C0h] BYREF
			//   HGRenderGraphProfilingScope v373; // [rsp+420h] [rbp-8A8h] BYREF
			//   HGRenderGraphProfilingScope v374; // [rsp+438h] [rbp-890h] BYREF
			//   Matrix4x4 orthoViewProj; // [rsp+450h] [rbp-878h] BYREF
			//   Matrix4x4 orthoDeviceViewProj; // [rsp+490h] [rbp-838h] BYREF
			//   Matrix4x4 orthoDeviceInvViewProj; // [rsp+4D0h] [rbp-7F8h] BYREF
			//   _BYTE v378[16]; // [rsp+550h] [rbp-778h] BYREF
			//   __int128 v379; // [rsp+560h] [rbp-768h]
			//   Void v380[16]; // [rsp+590h] [rbp-738h] BYREF
			//   __int128 v381; // [rsp+5A0h] [rbp-728h]
			//   __int128 v382; // [rsp+5B0h] [rbp-718h]
			//   __int128 v383; // [rsp+5C0h] [rbp-708h]
			//   TextureDesc v384; // [rsp+5D0h] [rbp-6F8h] BYREF
			//   TextureDesc v385; // [rsp+630h] [rbp-698h] BYREF
			//   TextureDesc v386; // [rsp+690h] [rbp-638h] BYREF
			//   TextureDesc v387; // [rsp+6F0h] [rbp-5D8h] BYREF
			//   TextureDesc v388; // [rsp+750h] [rbp-578h] BYREF
			//   TextureDesc v389; // [rsp+7B0h] [rbp-518h] BYREF
			//   TextureDesc v390; // [rsp+810h] [rbp-4B8h] BYREF
			//   TextureDesc v391; // [rsp+870h] [rbp-458h] BYREF
			//   TextureDesc v392; // [rsp+8D0h] [rbp-3F8h] BYREF
			//   TextureDesc v393; // [rsp+930h] [rbp-398h] BYREF
			//   TextureDesc v394; // [rsp+990h] [rbp-338h] BYREF
			//   TextureDesc v395; // [rsp+9F0h] [rbp-2D8h] BYREF
			//   TextureHandle v396; // [rsp+A50h] [rbp-278h] BYREF
			//   TextureHandle v397; // [rsp+A60h] [rbp-268h] BYREF
			//   TextureHandle v398; // [rsp+A70h] [rbp-258h] BYREF
			//   TextureHandle v399; // [rsp+A80h] [rbp-248h] BYREF
			//   TextureHandle v400; // [rsp+A90h] [rbp-238h] BYREF
			//   TextureHandle v401; // [rsp+AA0h] [rbp-228h] BYREF
			//   TextureHandle v402; // [rsp+AB0h] [rbp-218h] BYREF
			//   TextureHandle v403; // [rsp+AC0h] [rbp-208h] BYREF
			//   TextureHandle v404; // [rsp+AD0h] [rbp-1F8h] BYREF
			//   TextureHandle v405; // [rsp+AE0h] [rbp-1E8h] BYREF
			//   TextureHandle v406; // [rsp+AF0h] [rbp-1D8h] BYREF
			//   TextureHandle v407; // [rsp+B00h] [rbp-1C8h] BYREF
			//   TextureHandle v408; // [rsp+B10h] [rbp-1B8h] BYREF
			//   TextureHandle v409; // [rsp+B20h] [rbp-1A8h] BYREF
			//   TextureHandle v410; // [rsp+B30h] [rbp-198h] BYREF
			//   TextureHandle v411; // [rsp+B40h] [rbp-188h] BYREF
			//   TextureHandle v412; // [rsp+B50h] [rbp-178h] BYREF
			//   TextureHandle v413; // [rsp+B60h] [rbp-168h] BYREF
			//   TextureHandle v414; // [rsp+B70h] [rbp-158h] BYREF
			//   TextureHandle v415; // [rsp+B80h] [rbp-148h] BYREF
			//   TextureHandle v416; // [rsp+B90h] [rbp-138h] BYREF
			//   TextureHandle v417; // [rsp+BA0h] [rbp-128h] BYREF
			//   Void source[16]; // [rsp+BB0h] [rbp-118h] BYREF
			//   __int128 v419; // [rsp+BC0h] [rbp-108h]
			//   __int128 v420; // [rsp+BD0h] [rbp-F8h]
			//   __int128 v421; // [rsp+BE0h] [rbp-E8h]
			//   Matrix4x4 v422; // [rsp+BF0h] [rbp-D8h]
			// 
			//   if ( !byte_18D8EDB04 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::ComputeBuffer);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass);
			//     sub_18003C530(&off_18CDB1340);
			//     sub_18003C530(&off_18CDB14D8);
			//     sub_18003C530(&off_18CDB14F0);
			//     sub_18003C530(&off_18CDB14F8);
			//     sub_18003C530(&off_18CDB1500);
			//     sub_18003C530(&off_18CDB1508);
			//     sub_18003C530(&off_18CDB14E0);
			//     sub_18003C530(&off_18CDB14E8);
			//     byte_18D8EDB04 = 1;
			//   }
			//   memset(&v373, 0, sizeof(v373));
			//   v353.m_Ptr = 0LL;
			//   sub_1802F01E0(&orthoViewProj, 0LL, 64LL);
			//   sub_1802F01E0(&orthoDeviceViewProj, 0LL, 64LL);
			//   sub_1802F01E0(&orthoDeviceInvViewProj, 0LL, 64LL);
			//   visibleCount[0] = 0;
			//   cullHandle = 0;
			//   sub_1802F01E0(&v385, 0LL, 96LL);
			//   sub_1802F01E0(&v387, 0LL, 96LL);
			//   depthBits[0] = DepthBits__Enum_None;
			//   sub_1802F01E0(&v389, 0LL, 96LL);
			//   sub_1802F01E0(&v391, 0LL, 96LL);
			//   sub_1802F01E0(&v393, 0LL, 96LL);
			//   sub_1802F01E0(&v341, 0LL, 96LL);
			//   sub_1802F01E0(&v395, 0LL, 96LL);
			//   memset(&v355, 0, sizeof(v355));
			//   v344 = 0LL;
			//   sub_1802F01E0(source, 0LL, 192LL);
			//   memset(&v374, 0, sizeof(v374));
			//   memset(&v363, 0, sizeof(v363));
			//   v336 = 0LL;
			//   memset(&v351, 0, sizeof(v351));
			//   v329 = 0LL;
			//   memset(&v356, 0, sizeof(v356));
			//   v330 = 0LL;
			//   sub_1802F01E0(v380, 0LL, 64LL);
			//   sub_1802F01E0(v378, 0LL, 64LL);
			//   memset(&v348, 0, sizeof(v348));
			//   v325 = 0LL;
			//   memset(&v370, 0, sizeof(v370));
			//   memset(&v369, 0, sizeof(v369));
			//   memset(&v352, 0, sizeof(v352));
			//   v334 = 0LL;
			//   memset(&v372, 0, sizeof(v372));
			//   memset(&v371, 0, sizeof(v371));
			//   if ( IFix::WrappersManagerImpl::IsPatched(2923, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2923, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1055(
			//         Patch,
			//         (Object *)this,
			//         input,
			//         output,
			//         (Object *)renderGraph,
			//         (Object *)hgCamera,
			//         wetnessHighQualityEnabled,
			//         0LL);
			//       return;
			//     }
			// LABEL_195:
			//     sub_1802DC2C8(v12, v11);
			//   }
			//   if ( !hgCamera )
			//     goto LABEL_195;
			//   this.fields.m_isRendering = HG::Rendering::Runtime::HGCamera::ShouldRenderWater(hgCamera, 0LL);
			//   if ( HG::Rendering::Runtime::HGCamera::ShouldRenderWater(hgCamera, 0LL) )
			//   {
			//     v13 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//             (Int32Enum__Enum)0x36u,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     HG::Rendering::RenderGraphModule::HGRenderGraphProfilingScope::HGRenderGraphProfilingScope(
			//       &v373,
			//       renderGraph,
			//       v13,
			//       0LL);
			//     v354[0] = 0LL;
			//     v354[1] = &v373;
			//     currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//     if ( !currentManagerContext )
			//       sub_1802DC2C8(v16, v15);
			//     waterManager_k__BackingField = currentManagerContext.fields._waterManager_k__BackingField;
			//     v337 = waterManager_k__BackingField;
			//     v18 = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//     if ( !v18 )
			//       sub_1802DC2C8(v20, v19);
			//     v21 = v18.fields._waterManager_k__BackingField;
			//     if ( !v21 )
			//       sub_1802DC2C8(0LL, v19);
			//     v335.m_SpaceInfo.m_KeywordSpace = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(v21, 0LL);
			//     v345[0] = v335.m_SpaceInfo.m_KeywordSpace;
			//     v353.m_Ptr = input.srpContext.m_Ptr;
			//     orthoViewProj = *(Matrix4x4 *)sub_182805160(&viewProj);
			//     orthoDeviceViewProj = *(Matrix4x4 *)sub_182805160(&viewProj);
			//     orthoDeviceInvViewProj = *(Matrix4x4 *)sub_182805160(&viewProj);
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     v22 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
			//             (CBHandle *)&viewProj,
			//             &v353,
			//             20768,
			//             0LL);
			//     ptr = v22.ptr;
			//     *(_OWORD *)&this.fields.m_cbHandle.bufferId = *(_OWORD *)&v22.bufferId;
			//     this.fields.m_cbHandle.ptr = ptr;
			//     if ( !waterManager_k__BackingField )
			//       sub_1802DC2C8(v24, v23);
			//     HG::Rendering::Runtime::HGWaterManager::SetWaterDataCB(
			//       waterManager_k__BackingField,
			//       hgCamera,
			//       input.settingParameters,
			//       &this.fields.m_cbHandle,
			//       &orthoViewProj,
			//       &orthoDeviceViewProj,
			//       &orthoDeviceInvViewProj,
			//       0LL);
			//     cullHandle = -1;
			//     inputa.m_RenderPass = 0LL;
			//     *(_QWORD *)&viewPosition.x = 0LL;
			//     viewPosition.z = 0.0;
			//     viewProj = orthoViewProj;
			//     UnityEngine::HyperGryph::HGWaterRender::CullWaterProxy_Injected(
			//       hgCamera.fields.cullingViewHandle,
			//       &viewProj,
			//       2u,
			//       0,
			//       visibleCount,
			//       &cullHandle,
			//       0,
			//       &viewPosition,
			//       0LL);
			//     settingParameters = input.settingParameters;
			//     if ( !settingParameters )
			//       sub_1802DC2C8(0LL, v26);
			//     v29 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//             (SettingParameter_1_System_Int32Enum_ *)settingParameters.fields._waterHeightTextureSize_k__BackingField,
			//             MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     v30 = input.settingParameters;
			//     if ( !v30 )
			//       sub_1802DC2C8(0LL, v28);
			//     v31 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//             (SettingParameter_1_System_Int32Enum_ *)v30.fields._waterHeightTextureSize_k__BackingField,
			//             MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     sectorTexture = input.sectorTexture;
			//     interactionTexture = input.interactionTexture;
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_182E7CCD0(&v338);
			//     sub_182E7CCD0(&v338);
			//     sub_182E7CCD0(&v338);
			//     sub_182E7CCD0(&v338);
			//     sub_182E7CCD0(&v338);
			//     sub_1802F01E0(&v384, 0LL, 96LL);
			//     HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v384, v29, v31, 0LL);
			//     v34 = *(_OWORD *)&v384.width;
			//     *(_OWORD *)&v341.width = *(_OWORD *)&v384.width;
			//     *(_OWORD *)&v341.colorFormat = *(_OWORD *)&v384.colorFormat;
			//     *(_OWORD *)&v341.enableRandomWrite = *(_OWORD *)&v384.enableRandomWrite;
			//     *(_QWORD *)&v341.bindTextureMS = *(_QWORD *)&v384.bindTextureMS;
			//     v35 = *(_OWORD *)&v384.fastMemoryDesc.inFastMemory;
			//     *(_OWORD *)&v341.fastMemoryDesc.inFastMemory = *(_OWORD *)&v384.fastMemoryDesc.inFastMemory;
			//     clearColor = v384.clearColor;
			//     v341.clearColor = v384.clearColor;
			//     v341.name = (String *)"Water Proxy Data Texture";
			//     if ( dword_18D8E43F8 )
			//     {
			//       v37 = (((unsigned __int64)&v341.name >> 12) & 0x1FFFFF) >> 6;
			//       v32 = ((unsigned __int64)&v341.name >> 12) & 0x3F;
			//       _m_prefetchw(&qword_18D6405E0[v37 + 36190]);
			//       do
			//       {
			//         v33 = qword_18D6405E0[v37 + 36190] | (1LL << v32);
			//         v38 = qword_18D6405E0[v37 + 36190];
			//       }
			//       while ( v38 != _InterlockedCompareExchange64(&qword_18D6405E0[v37 + 36190], v33, v38) );
			//       clearColor = v341.clearColor;
			//       v35 = *(_OWORD *)&v341.fastMemoryDesc.inFastMemory;
			//       v34 = *(_OWORD *)&v341.width;
			//     }
			//     v341.colorFormat = 8;
			//     *(_WORD *)&v341.useMipMap = 0;
			//     *(_OWORD *)&v385.width = v34;
			//     *(_OWORD *)&v385.colorFormat = *(_OWORD *)&v341.colorFormat;
			//     *(_OWORD *)&v385.enableRandomWrite = *(_OWORD *)&v341.enableRandomWrite;
			//     *(_OWORD *)&v385.bindTextureMS = *(_OWORD *)&v341.bindTextureMS;
			//     *(_OWORD *)&v385.fastMemoryDesc.inFastMemory = v35;
			//     v385.clearColor = clearColor;
			//     if ( !renderGraph )
			//       sub_1802DC2C8(v33, v32);
			//     v367 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v338, renderGraph, &v385, 0LL);
			//     sub_1802F01E0(&v386, 0LL, 96LL);
			//     HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v386, v29, v31, 0LL);
			//     v341 = v386;
			//     v341.colorFormat = 75;
			//     *(_WORD *)&v341.useMipMap = 0;
			//     *(_OWORD *)&v387.width = *(_OWORD *)&v386.width;
			//     *(_OWORD *)&v387.colorFormat = *(_OWORD *)&v341.colorFormat;
			//     *(_OWORD *)&v387.enableRandomWrite = *(_OWORD *)&v341.enableRandomWrite;
			//     *(_OWORD *)&v387.bindTextureMS = *(_OWORD *)&v386.bindTextureMS;
			//     *(_OWORD *)&v387.fastMemoryDesc.inFastMemory = *(_OWORD *)&v386.fastMemoryDesc.inFastMemory;
			//     v387.clearColor = v386.clearColor;
			//     v358 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v338, renderGraph, &v387, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     SupportedFormatForDepth = HG::Rendering::Runtime::HGUtils::GetSupportedFormatForDepth(
			//                                 GraphicsFormat__Enum_D24_UNorm_S8_UInt,
			//                                 depthBits,
			//                                 0LL);
			//     sub_1802F01E0(&v388, 0LL, 96LL);
			//     HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v388, v29, v31, 0LL);
			//     *(_OWORD *)&v341.width = *(_OWORD *)&v388.width;
			//     v341.dimension = v388.dimension;
			//     *(_OWORD *)&v341.enableRandomWrite = *(_OWORD *)&v388.enableRandomWrite;
			//     *(_OWORD *)&v341.bindTextureMS = *(_OWORD *)&v388.bindTextureMS;
			//     *(_OWORD *)&v341.fastMemoryDesc.inFastMemory = *(_OWORD *)&v388.fastMemoryDesc.inFastMemory;
			//     v341.clearColor = v388.clearColor;
			//     *(_QWORD *)&v341.colorFormat = SupportedFormatForDepth;
			//     v341.depthBufferBits = depthBits[0];
			//     v341.clearBuffer = 1;
			//     v341.wrapMode = 1;
			//     *(_OWORD *)&v389.width = *(_OWORD *)&v341.width;
			//     *(_OWORD *)&v389.colorFormat = *(_OWORD *)&v341.colorFormat;
			//     *(_OWORD *)&v389.enableRandomWrite = *(_OWORD *)&v388.enableRandomWrite;
			//     *(_OWORD *)&v389.bindTextureMS = *(_OWORD *)&v388.bindTextureMS;
			//     *(_OWORD *)&v389.fastMemoryDesc.inFastMemory = *(_OWORD *)&v341.fastMemoryDesc.inFastMemory;
			//     v389.clearColor = v388.clearColor;
			//     v359 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v338, renderGraph, &v389, 0LL);
			//     sub_1802F01E0(&v390, 0LL, 96LL);
			//     HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v390, v29, v31, 0LL);
			//     v341 = v390;
			//     v341.colorFormat = 45;
			//     *(_WORD *)&v341.useMipMap = 0;
			//     *(_OWORD *)&v391.width = *(_OWORD *)&v390.width;
			//     *(_OWORD *)&v391.colorFormat = *(_OWORD *)&v341.colorFormat;
			//     *(_OWORD *)&v391.enableRandomWrite = *(_OWORD *)&v341.enableRandomWrite;
			//     *(_OWORD *)&v391.bindTextureMS = *(_OWORD *)&v390.bindTextureMS;
			//     *(_OWORD *)&v391.fastMemoryDesc.inFastMemory = *(_OWORD *)&v390.fastMemoryDesc.inFastMemory;
			//     v391.clearColor = v390.clearColor;
			//     si128 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v338, renderGraph, &v391, 0LL);
			//     sub_1802F01E0(&v392, 0LL, 96LL);
			//     HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v392, v29, v31, 0LL);
			//     *(_OWORD *)&v341.width = *(_OWORD *)&v392.width;
			//     v341.dimension = v392.dimension;
			//     *(_OWORD *)&v341.enableRandomWrite = *(_OWORD *)&v392.enableRandomWrite;
			//     *(_OWORD *)&v341.bindTextureMS = *(_OWORD *)&v392.bindTextureMS;
			//     *(_OWORD *)&v341.fastMemoryDesc.inFastMemory = *(_OWORD *)&v392.fastMemoryDesc.inFastMemory;
			//     v341.clearColor = v392.clearColor;
			//     *(_QWORD *)&v341.colorFormat = SupportedFormatForDepth;
			//     v341.depthBufferBits = depthBits[0];
			//     v341.clearBuffer = 1;
			//     v341.wrapMode = 1;
			//     *(_OWORD *)&v393.width = *(_OWORD *)&v341.width;
			//     *(_OWORD *)&v393.colorFormat = *(_OWORD *)&v341.colorFormat;
			//     *(_OWORD *)&v393.enableRandomWrite = *(_OWORD *)&v392.enableRandomWrite;
			//     *(_OWORD *)&v393.bindTextureMS = *(_OWORD *)&v392.bindTextureMS;
			//     *(_OWORD *)&v393.fastMemoryDesc.inFastMemory = *(_OWORD *)&v341.fastMemoryDesc.inFastMemory;
			//     v393.clearColor = v392.clearColor;
			//     v338 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v338, renderGraph, &v393, 0LL);
			//     v340 = *HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(
			//               &v340,
			//               &input.gBufferOutput,
			//               GBufferID__Enum_GBufferB,
			//               0LL);
			//     this.fields.m_normalRoughnessWithWaterTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                                         &v346,
			//                                                         renderGraph,
			//                                                         &v340,
			//                                                         0LL);
			//     this.fields.m_depthWithWaterTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                               &v346,
			//                                               renderGraph,
			//                                               &input.sceneDepth,
			//                                               0LL);
			//     sub_1802F01E0(&v394, 0LL, 96LL);
			//     HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
			//       &v394,
			//       hgCamera.fields._sceneRTSize_k__BackingField,
			//       0LL);
			//     v341 = v394;
			//     v341.colorFormat = 8;
			//     *(_WORD *)&v341.useMipMap = 0;
			//     *(_OWORD *)&v395.width = *(_OWORD *)&v394.width;
			//     *(_OWORD *)&v395.colorFormat = *(_OWORD *)&v341.colorFormat;
			//     *(_OWORD *)&v395.enableRandomWrite = *(_OWORD *)&v341.enableRandomWrite;
			//     *(_OWORD *)&v395.bindTextureMS = *(_OWORD *)&v394.bindTextureMS;
			//     *(_OWORD *)&v395.fastMemoryDesc.inFastMemory = *(_OWORD *)&v394.fastMemoryDesc.inFastMemory;
			//     v395.clearColor = v394.clearColor;
			//     this.fields.m_waterTessellationDataTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                                      &v346,
			//                                                      renderGraph,
			//                                                      &v395,
			//                                                      0LL);
			//     v39 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//             (Int32Enum__Enum)0x47u,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       (HGRenderGraphBuilder *)&viewProj,
			//       renderGraph,
			//       (String *)"Water Tessellation",
			//       &v344,
			//       v39,
			//       1,
			//       ProfilingHGPass__Enum_None,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
			//     *(_OWORD *)&v355.m_RenderPass = *(_OWORD *)&viewProj.m00;
			//     *(_OWORD *)&v355.m_RenderGraph = *(_OWORD *)&viewProj.m01;
			//     inputa.m_RenderPass = 0LL;
			//     inputa.m_Resources = (HGRenderGraphResourceRegistry *)&v355;
			//     HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v355, 0, 0LL);
			//     *(_QWORD *)&viewPosition.x = v344;
			//     v42 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v346, &v355, &v340, 0LL);
			//     if ( !*(_QWORD *)&viewPosition.x )
			//       sub_1802DC2C8(v41, v40);
			//     *(TextureHandle *)(*(_QWORD *)&viewPosition.x + 560LL) = v42;
			//     *(_QWORD *)&viewPosition.x = v344;
			//     v45 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v340, &v355, &input.sceneDepth, 0LL);
			//     if ( !*(_QWORD *)&viewPosition.x )
			//       sub_1802DC2C8(v44, v43);
			//     *(TextureHandle *)(*(_QWORD *)&viewPosition.x + 576LL) = v45;
			//     v46 = v344;
			//     if ( !v344 )
			//       sub_1802DC2C8(v44, 0LL);
			//     v344[8].klass = (Object__Class *)this.fields.m_waterCopyMPB;
			//     v47 = dword_18D8E43F8;
			//     if ( dword_18D8E43F8 )
			//     {
			//       v48 = ((unsigned __int64)&v46[8] >> 12) & 0x1FFFFF;
			//       v49 = v48 >> 6;
			//       v50 = v48 & 0x3F;
			//       _m_prefetchw(&qword_18D6405E0[v49 + 36190]);
			//       do
			//         v51 = qword_18D6405E0[v49 + 36190];
			//       while ( v51 != _InterlockedCompareExchange64(&qword_18D6405E0[v49 + 36190], v51 | (1LL << v50), v51) );
			//       v47 = dword_18D8E43F8;
			//     }
			//     v52 = v344;
			//     m_waterTextureProcessMaterial = (MonitorData *)this.fields.m_waterTextureProcessMaterial;
			//     if ( !v344 )
			//       sub_1802DC2C8(m_waterTextureProcessMaterial, 0LL);
			//     v344[4].monitor = m_waterTextureProcessMaterial;
			//     if ( v47 )
			//     {
			//       v54 = ((unsigned __int64)&v52[4].monitor >> 12) & 0x1FFFFF;
			//       v55 = v54 >> 6;
			//       v56 = v54 & 0x3F;
			//       _m_prefetchw(&qword_18D6405E0[v55 + 36190]);
			//       do
			//         v57 = qword_18D6405E0[v55 + 36190];
			//       while ( v57 != _InterlockedCompareExchange64(&qword_18D6405E0[v55 + 36190], v57 | (1LL << v56), v57) );
			//     }
			//     v340 = 0LL;
			//     HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//       &v346,
			//       &v355,
			//       &this.fields.m_normalRoughnessWithWaterTexture,
			//       0,
			//       RenderBufferLoadAction__Enum_Load,
			//       RenderBufferStoreAction__Enum_Store,
			//       (Color *)&v340,
			//       0,
			//       0LL);
			//     v340 = 0LL;
			//     HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//       &v346,
			//       &v355,
			//       &this.fields.m_waterTessellationDataTexture,
			//       1,
			//       RenderBufferLoadAction__Enum_Clear,
			//       RenderBufferStoreAction__Enum_Store,
			//       (Color *)&v340,
			//       0,
			//       0LL);
			//     HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//       &v340,
			//       &v355,
			//       &this.fields.m_depthWithWaterTexture,
			//       DepthAccess__Enum_Write,
			//       RenderBufferLoadAction__Enum_Load,
			//       RenderBufferStoreAction__Enum_Store,
			//       1.0,
			//       0,
			//       0,
			//       0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass);
			//     HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//       &v355,
			//       (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass.static_fields.s_waterCopyRenderFunc,
			//       0LL,
			//       0,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
			//     sub_180222690(&inputa);
			//     if ( visibleCount[0] )
			//     {
			//       if ( !v335.m_SpaceInfo.m_KeywordSpace )
			//         sub_1802DC2C8(v59, v58);
			//       RealLODNum = HG::Rendering::Runtime::HGWaterGlobalConfig::GetRealLODNum(
			//                      (HGWaterGlobalConfig *)v335.m_SpaceInfo.m_KeywordSpace,
			//                      input.settingParameters,
			//                      0LL);
			//       visibleCount[1] = RealLODNum;
			//       depthBits[0] = HG::Rendering::Runtime::HGWaterGlobalConfig::GetRealMeshNumPerLOD(
			//                        (HGWaterGlobalConfig *)v335.m_SpaceInfo.m_KeywordSpace,
			//                        input.settingParameters,
			//                        0LL);
			//       SupportedFormatForDepth = depthBits[0];
			//       v342 = 32 * (this.fields.m_frameIndexV2 & 1);
			//       v349 = 32 * (((unsigned __int8)this.fields.m_frameIndexV2 - 1) & 1);
			//       if ( !this.fields.m_indirectBufferV2 )
			//       {
			//         v117 = (ComputeBuffer *)sub_180004920(TypeInfo::UnityEngine::ComputeBuffer);
			//         v120 = v117;
			//         if ( !v117 )
			//           sub_1802DC2C8(v119, v118);
			//         UnityEngine::ComputeBuffer::ComputeBuffer(
			//           v117,
			//           64,
			//           4,
			//           ComputeBufferType__Enum_DrawIndirect,
			//           ComputeBufferMode__Enum_Immutable,
			//           3,
			//           0LL);
			//         this.fields.m_indirectBufferV2 = v120;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v121 = (((unsigned __int64)&this.fields.m_indirectBufferV2 >> 12) & 0x1FFFFF) >> 6;
			//           _m_prefetchw(&qword_18D6405E0[v121 + 36190]);
			//           do
			//             v122 = qword_18D6405E0[v121 + 36190];
			//           while ( v122 != _InterlockedCompareExchange64(
			//                             &qword_18D6405E0[v121 + 36190],
			//                             v122 | (1LL << (((unsigned __int64)&this.fields.m_indirectBufferV2 >> 12) & 0x3F)),
			//                             v122) );
			//         }
			//       }
			//       *(_QWORD *)(&desc.type + 1) = 0LL;
			//       HIDWORD(desc.name) = 0;
			//       desc.count = 4 * RealLODNum * depthBits[0] * depthBits[0];
			//       desc.stride = 4;
			//       desc.type = 16;
			//       *(ComputeBufferHandle *)&viewPosition.x = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateComputeBuffer(
			//                                                   renderGraph,
			//                                                   &desc,
			//                                                   0LL);
			//       v343 = -1;
			//       for ( i = 0; i < 4; ++i )
			//       {
			//         if ( UnityEngine::HyperGryph::HGWaterRender::IsHeightLayerVisible(cullHandle, 3u, i, 0LL) )
			//         {
			//           v343 = i;
			//           break;
			//         }
			//       }
			//       sub_1802F01E0(source, 0LL, 192LL);
			//       *(_OWORD *)source = *(_OWORD *)&orthoDeviceViewProj.m00;
			//       v419 = *(_OWORD *)&orthoDeviceViewProj.m01;
			//       v420 = *(_OWORD *)&orthoDeviceViewProj.m02;
			//       v421 = *(_OWORD *)&orthoDeviceViewProj.m03;
			//       v422 = orthoDeviceInvViewProj;
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//       keyword = *(LocalKeyword *)UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
			//                                    (CBHandle *)&viewProj,
			//                                    &input.srpContext,
			//                                    192,
			//                                    0LL);
			//       Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(*(Void **)&keyword.m_Index, source, 192LL, 0LL);
			//       for ( j = 0; j < 4; ++j )
			//       {
			//         if ( UnityEngine::HyperGryph::HGWaterRender::IsHeightLayerVisible(cullHandle, 3u, j, 0LL) )
			//         {
			//           v125 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//                    (Int32Enum__Enum)0x36u,
			//                    MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//           HG::Rendering::RenderGraphModule::HGRenderGraphProfilingScope::HGRenderGraphProfilingScope(
			//             &v374,
			//             renderGraph,
			//             v125,
			//             0LL);
			//           v340.handle = 0LL;
			//           v340.fallBackResource = (ResourceHandle)&v374;
			//           v126 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//                    (Int32Enum__Enum)0x37u,
			//                    MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//           HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//             &inputa,
			//             renderGraph,
			//             (String *)"Water Prepass",
			//             (Object **)&v336,
			//             v126,
			//             1,
			//             ProfilingHGPass__Enum_None,
			//             MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
			//           v363 = inputa;
			//           v360[0] = 0LL;
			//           v360[1] = &v363;
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v363, 0, 0LL);
			//           if ( !v336 )
			//             sub_1802DC2C8(0LL, v127);
			//           *(&v336.fields._index_k__BackingField + 1) = visibleCount[0];
			//           v128 = v336;
			//           if ( !v336 )
			//             sub_1802DC2C8(0LL, v127);
			//           LODWORD(v336.fields._customSampler_k__BackingField) = cullHandle;
			//           if ( !v336 )
			//             sub_1802DC2C8(v128, v127);
			//           HIDWORD(v336.fields._customSampler_k__BackingField) = j;
			//           v129 = v336;
			//           if ( !v336 )
			//             sub_1802DC2C8(v128, 0LL);
			//           v336.fields._name_k__BackingField = (String *)hgCamera;
			//           v130 = dword_18D8E43F8;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v131 = ((unsigned __int64)&v129.fields >> 12) & 0x1FFFFF;
			//             v132 = v131 >> 6;
			//             v133 = v131 & 0x3F;
			//             _m_prefetchw(&qword_18D6405E0[v132 + 36190]);
			//             do
			//               v134 = qword_18D6405E0[v132 + 36190];
			//             while ( v134 != _InterlockedCompareExchange64(&qword_18D6405E0[v132 + 36190], v134 | (1LL << v133), v134) );
			//             v130 = dword_18D8E43F8;
			//           }
			//           v135 = v336;
			//           m_waterProxyMaterial_V2 = (Object__Class *)this.fields.m_waterProxyMaterial_V2;
			//           if ( !v336 )
			//             sub_1802DC2C8(m_waterProxyMaterial_V2, 0LL);
			//           *(_QWORD *)&v336.fields.depthAttachment.loadAction = m_waterProxyMaterial_V2;
			//           if ( v130 )
			//           {
			//             v137 = ((unsigned __int64)&v135.fields.depthAttachment.loadAction >> 12) & 0x1FFFFF;
			//             v138 = v137 >> 6;
			//             v139 = v137 & 0x3F;
			//             _m_prefetchw(&qword_18D6405E0[v138 + 36190]);
			//             do
			//               v140 = qword_18D6405E0[v138 + 36190];
			//             while ( v140 != _InterlockedCompareExchange64(&qword_18D6405E0[v138 + 36190], v140 | (1LL << v139), v140) );
			//             v130 = dword_18D8E43F8;
			//           }
			//           v141 = v336;
			//           m_waterProxyMPB_V2 = (MonitorData *)this.fields.m_waterProxyMPB_V2;
			//           if ( !v336 )
			//             sub_1802DC2C8(m_waterProxyMPB_V2, 0LL);
			//           *(_QWORD *)&v336.fields.depthAttachment.depthSlice = m_waterProxyMPB_V2;
			//           if ( v130 )
			//           {
			//             v143 = ((unsigned __int64)&v141.fields.depthAttachment.depthSlice >> 12) & 0x1FFFFF;
			//             v144 = v143 >> 6;
			//             v145 = v143 & 0x3F;
			//             _m_prefetchw(&qword_18D6405E0[v144 + 36190]);
			//             do
			//               v146 = qword_18D6405E0[v144 + 36190];
			//             while ( v146 != _InterlockedCompareExchange64(&qword_18D6405E0[v144 + 36190], v146 | (1LL << v145), v146) );
			//           }
			//           inputa.m_RenderPass = v336;
			//           sub_180002BF0(v336);
			//           v148 = *(MaterialPropertyBlock **)&inputa.m_RenderPass.fields.depthAttachment.depthSlice;
			//           if ( !v148 )
			//             sub_1802DC2C8(0LL, v147);
			//           UnityEngine::MaterialPropertyBlock::Clear(v148, 1, 0LL);
			//           inputa.m_RenderPass = v336;
			//           sub_180002BF0(v336);
			//           v150 = *(MaterialPropertyBlock **)&inputa.m_RenderPass.fields.depthAttachment.depthSlice;
			//           if ( !v150 )
			//             sub_1802DC2C8(0LL, v149);
			//           UnityEngine::MaterialPropertyBlock::SetConstantBuffer(
			//             v150,
			//             (String *)"_WaterProxyPerDrawData",
			//             (uint32_t)keyword.m_SpaceInfo.m_KeywordSpace,
			//             SHIDWORD(keyword.m_SpaceInfo.m_KeywordSpace),
			//             (int32_t)keyword.m_Name,
			//             0LL);
			//           *(_OWORD *)&inputa.m_RenderPass = 0LL;
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//             &v412,
			//             &v363,
			//             &v367,
			//             0,
			//             RenderBufferLoadAction__Enum_Clear,
			//             RenderBufferStoreAction__Enum_Store,
			//             (Color *)&inputa,
			//             0,
			//             0LL);
			//           *(_OWORD *)&inputa.m_RenderPass = 0LL;
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//             &v411,
			//             &v363,
			//             &v358,
			//             1,
			//             RenderBufferLoadAction__Enum_Clear,
			//             RenderBufferStoreAction__Enum_Store,
			//             (Color *)&inputa,
			//             0,
			//             0LL);
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//             &v410,
			//             &v363,
			//             &v359,
			//             DepthAccess__Enum_Write,
			//             RenderBufferLoadAction__Enum_Clear,
			//             RenderBufferStoreAction__Enum_Store,
			//             1.0,
			//             0,
			//             0,
			//             0LL);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass);
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//             &v363,
			//             (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass.static_fields.s_waterHeightRenderFunc,
			//             0LL,
			//             0,
			//             MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
			//           sub_180222690(v360);
			//           v151 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//                    (Int32Enum__Enum)0x3Bu,
			//                    MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//           HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//             &inputa,
			//             renderGraph,
			//             (String *)"Water Decal",
			//             (Object **)&v329,
			//             v151,
			//             1,
			//             ProfilingHGPass__Enum_None,
			//             MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
			//           v351 = inputa;
			//           v361[0] = 0LL;
			//           v361[1] = &v351;
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v351, 0, 0LL);
			//           inputa.m_RenderPass = v329;
			//           v152 = *(_OWORD *)&this.fields.m_cbHandle.bufferId;
			//           v153 = (ProfilingSampler *)this.fields.m_cbHandle.ptr;
			//           sub_180002BF0(v329);
			//           m_RenderPass = inputa.m_RenderPass;
			//           *(_OWORD *)&inputa.m_RenderPass[1].fields._name_k__BackingField = v152;
			//           m_RenderPass[1].fields._customSampler_k__BackingField = v153;
			//           inputa.m_RenderPass = v329;
			//           sub_180002BF0(v329);
			//           v155 = inputa.m_RenderPass;
			//           inputa.m_RenderPass.fields._name_k__BackingField = (String *)hgCamera;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v156 = ((unsigned __int64)&v155.fields >> 12) & 0x1FFFFF;
			//             v157 = v156 >> 6;
			//             v158 = v156 & 0x3F;
			//             _m_prefetchw(&qword_18D6405E0[v157 + 36190]);
			//             do
			//               v159 = qword_18D6405E0[v157 + 36190];
			//             while ( v159 != _InterlockedCompareExchange64(&qword_18D6405E0[v157 + 36190], v159 | (1LL << v158), v159) );
			//           }
			//           inputa.m_RenderPass = v329;
			//           sub_180002BF0(v329);
			//           HIDWORD(inputa.m_RenderPass.fields._customSampler_k__BackingField) = j;
			//           inputa.m_RenderPass = v329;
			//           v160 = (Color)*HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v409, &v351, &v367, 0LL);
			//           sub_180002BF0(inputa.m_RenderPass);
			//           inputa.m_RenderPass[1].fields.depthAttachment.clearColor = v160;
			//           inputa.m_RenderPass = v329;
			//           v161 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v408, &v351, &v358, 0LL);
			//           sub_180002BF0(inputa.m_RenderPass);
			//           *(TextureHandle *)&inputa.m_RenderPass[1].fields.depthAttachment.depthSlice = v161;
			//           inputa.m_RenderPass = v329;
			//           v162 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v407, &v351, &v359, 0LL);
			//           sub_180002BF0(inputa.m_RenderPass);
			//           *(TextureHandle *)&inputa.m_RenderPass[1].fields.colorAttachments = v162;
			//           inputa.m_RenderPass = v329;
			//           v163 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v406, &v351, &sectorTexture, 0LL);
			//           sub_180002BF0(inputa.m_RenderPass);
			//           *(TextureHandle *)&inputa.m_RenderPass[1].fields._profilingHgPass_k__BackingField = v163;
			//           inputa.m_RenderPass = v329;
			//           v166 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                     &v413,
			//                     &v351,
			//                     &interactionTexture,
			//                     0LL);
			//           if ( !inputa.m_RenderPass )
			//             sub_1802DC2C8(v165, v164);
			//           *(TextureHandle *)&inputa.m_RenderPass[1].fields.depthAttachment.textureHandle.fallBackResource.m_Value = v166;
			//           inputa.m_RenderPass = v329;
			//           flowMap = HG::Rendering::Runtime::HGWaterGlobalConfig::get_flowMap(
			//                       (HGWaterGlobalConfig *)v335.m_SpaceInfo.m_KeywordSpace,
			//                       0LL);
			//           v169 = inputa.m_RenderPass;
			//           if ( !inputa.m_RenderPass )
			//             sub_1802DC2C8(flowMap, v167);
			//           inputa.m_RenderPass.fields.dependsOnRendererListList = (List_1_HG_Rendering_RenderGraphModule_RendererListHandle_ *)flowMap;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v170 = (((unsigned __int64)&v169.fields.dependsOnRendererListList >> 12) & 0x1FFFFF) >> 6;
			//             _m_prefetchw(&qword_18D6405E0[v170 + 36190]);
			//             do
			//               v171 = qword_18D6405E0[v170 + 36190];
			//             while ( v171 != _InterlockedCompareExchange64(
			//                               &qword_18D6405E0[v170 + 36190],
			//                               v171 | (1LL << (((unsigned __int64)&v169.fields.dependsOnRendererListList >> 12) & 0x3F)),
			//                               v171) );
			//           }
			//           inputa.m_RenderPass = v329;
			//           normalMapArray = (MonitorData *)HG::Rendering::Runtime::HGWaterGlobalConfig::get_normalMapArray(
			//                                             (HGWaterGlobalConfig *)v335.m_SpaceInfo.m_KeywordSpace,
			//                                             0LL);
			//           v174 = inputa.m_RenderPass;
			//           if ( !inputa.m_RenderPass )
			//             sub_1802DC2C8(0LL, v173);
			//           inputa.m_RenderPass[1].monitor = normalMapArray;
			//           v175 = dword_18D8E43F8;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v176 = (((unsigned __int64)&v174[1].monitor >> 12) & 0x1FFFFF) >> 6;
			//             _m_prefetchw(&qword_18D6405E0[v176 + 36190]);
			//             do
			//               v177 = qword_18D6405E0[v176 + 36190];
			//             while ( v177 != _InterlockedCompareExchange64(
			//                               &qword_18D6405E0[v176 + 36190],
			//                               v177 | (1LL << (((unsigned __int64)&v174[1].monitor >> 12) & 0x3F)),
			//                               v177) );
			//             v175 = dword_18D8E43F8;
			//           }
			//           v178 = v329;
			//           m_waterTextureProcessMaterial_V2 = (MonitorData *)this.fields.m_waterTextureProcessMaterial_V2;
			//           if ( !v329 )
			//             sub_1802DC2C8(m_waterTextureProcessMaterial_V2, 0LL);
			//           *(_QWORD *)&v329.fields.depthAttachment.clearColor.r = m_waterTextureProcessMaterial_V2;
			//           if ( v175 )
			//           {
			//             v180 = ((unsigned __int64)&v178.fields.depthAttachment.clearColor >> 12) & 0x1FFFFF;
			//             v181 = v180 >> 6;
			//             v182 = v180 & 0x3F;
			//             _m_prefetchw(&qword_18D6405E0[v181 + 36190]);
			//             do
			//               v183 = qword_18D6405E0[v181 + 36190];
			//             while ( v183 != _InterlockedCompareExchange64(&qword_18D6405E0[v181 + 36190], v183 | (1LL << v182), v183) );
			//             v175 = dword_18D8E43F8;
			//           }
			//           v184 = v329;
			//           m_waterHeightDecalMPB = (MonitorData *)this.fields.m_waterHeightDecalMPB;
			//           if ( !v329 )
			//             sub_1802DC2C8(m_waterHeightDecalMPB, 0LL);
			//           v329.fields.transientResourceList = (List_1_HG_Rendering_RenderGraphModule_ResourceHandle___Array *)m_waterHeightDecalMPB;
			//           if ( v175 )
			//           {
			//             v186 = ((unsigned __int64)&v184.fields.transientResourceList >> 12) & 0x1FFFFF;
			//             v187 = v186 >> 6;
			//             v188 = v186 & 0x3F;
			//             _m_prefetchw(&qword_18D6405E0[v187 + 36190]);
			//             do
			//               v189 = qword_18D6405E0[v187 + 36190];
			//             while ( v189 != _InterlockedCompareExchange64(&qword_18D6405E0[v187 + 36190], v189 | (1LL << v188), v189) );
			//           }
			//           *(_OWORD *)&inputa.m_RenderPass = 0LL;
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//             &v414,
			//             &v351,
			//             &si128,
			//             0,
			//             RenderBufferLoadAction__Enum_Load,
			//             RenderBufferStoreAction__Enum_Store,
			//             (Color *)&inputa,
			//             0,
			//             0LL);
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//             &v415,
			//             &v351,
			//             &v338,
			//             DepthAccess__Enum_Write,
			//             RenderBufferLoadAction__Enum_Load,
			//             RenderBufferStoreAction__Enum_Store,
			//             1.0,
			//             0,
			//             0,
			//             0LL);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass);
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//             &v351,
			//             (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass.static_fields.s_waterDecalRenderFunc,
			//             0LL,
			//             0,
			//             MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
			//           sub_180222690(v361);
			//           v190 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//                    (Int32Enum__Enum)0x39u,
			//                    MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//           HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//             &inputa,
			//             renderGraph,
			//             (String *)"Water Occlusion",
			//             (Object **)&v330,
			//             v190,
			//             1,
			//             ProfilingHGPass__Enum_None,
			//             MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
			//           v356 = inputa;
			//           v357[0] = 0LL;
			//           v357[1] = &v356;
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v356, 0, 0LL);
			//           sub_1802F01E0(v378, 0LL, 64LL);
			//           screenSpaceMesh = HG::Rendering::Runtime::HGWaterManager::get_screenSpaceMesh(v337, 0LL);
			//           if ( !screenSpaceMesh )
			//             sub_1802DC2C8(v193, v192);
			//           LODWORD(inputa.m_RenderPass) = UnityEngine::Mesh::GetIndexCount(screenSpaceMesh, 0, 0LL);
			//           v194 = HG::Rendering::Runtime::HGWaterManager::get_screenSpaceMesh(v337, 0LL);
			//           if ( !v194 )
			//             sub_1802DC2C8(v196, v195);
			//           BaseVertex = UnityEngine::Mesh::GetBaseVertex(v194, 0, 0LL);
			//           m_RenderPass_low = (float)SLODWORD(inputa.m_RenderPass);
			//           *(float *)&v362 = m_RenderPass_low;
			//           v199 = (float)BaseVertex;
			//           *((float *)&v362 + 1) = v199;
			//           *((_QWORD *)&v362 + 1) = COERCE_UNSIGNED_INT((float)j);
			//           *(float *)&v200 = (float)v342;
			//           *(float *)&v201 = (float)v349;
			//           *(_QWORD *)&v379 = __PAIR64__(v201, v200);
			//           *((float *)&v379 + 2) = (float)RealLODNum;
			//           *((float *)&v379 + 3) = (float)(int)depthBits[0];
			//           *(_OWORD *)v380 = v362;
			//           v381 = v379;
			//           v382 = 0LL;
			//           v383 = 0LL;
			//           inputa.m_RenderPass = (HGRenderGraphPass *)&input.srpContext;
			//           sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//           ConstantBuffer = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
			//                              (CBHandle *)&inputa,
			//                              (ScriptableRenderContext *)inputa.m_RenderPass,
			//                              64,
			//                              0LL);
			//           v203 = *(_OWORD *)&ConstantBuffer.bufferId;
			//           v204 = (Void *)ConstantBuffer.ptr;
			//           *(_QWORD *)&viewProj.m01 = v204;
			//           Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(v204, v380, 64LL, 0LL);
			//           v206 = v330;
			//           if ( !v330 )
			//             sub_1802DC2C8(v205, 0LL);
			//           v330.fields._name_k__BackingField = (String *)hgCamera;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v207 = ((unsigned __int64)&v206.fields >> 12) & 0x1FFFFF;
			//             v208 = v207 >> 6;
			//             v206 = (HGRenderGraphPass *)(v207 & 0x3F);
			//             _m_prefetchw(&qword_18D6405E0[v208 + 36190]);
			//             do
			//             {
			//               v205 = qword_18D6405E0[v208 + 36190] | (1LL << (char)v206);
			//               v209 = qword_18D6405E0[v208 + 36190];
			//             }
			//             while ( v209 != _InterlockedCompareExchange64(&qword_18D6405E0[v208 + 36190], v205, v209) );
			//           }
			//           if ( !v330 )
			//             sub_1802DC2C8(v205, v206);
			//           v210 = depthBits[0];
			//           *(DepthBits__Enum *)&v330.fields._enableAsyncCompute_k__BackingField = depthBits[0];
			//           if ( !v330 )
			//             sub_1802DC2C8(v210, v206);
			//           v211 = (unsigned int)RealLODNum;
			//           v330.fields.depthAttachment.textureHandle.handle.m_Value = RealLODNum;
			//           LOBYTE(v211) = this.fields.m_isFirstTimeV2;
			//           if ( !v330 )
			//             sub_1802DC2C8(v211, v206);
			//           LOBYTE(v330[2].fields.depthAttachment.clearColor.r) = v211;
			//           v212 = (ProfilingSampler *)this.fields.m_cbHandle.ptr;
			//           v213 = v330;
			//           if ( !v330 )
			//             sub_1802DC2C8(v211, v206);
			//           *(_OWORD *)&v330[1].fields._name_k__BackingField = *(_OWORD *)&this.fields.m_cbHandle.bufferId;
			//           v213[1].fields._customSampler_k__BackingField = v212;
			//           v214 = v330;
			//           if ( !v330 )
			//             sub_1802DC2C8(v211, v206);
			//           *(_OWORD *)&v330[2].fields.depthAttachment.depthSlice = v203;
			//           v214[2].fields.colorAttachments = (DynamicArray_1_HG_Rendering_RenderGraphModule_AttachDesc_ *)v204;
			//           *(_QWORD *)depthBits = v330;
			//           inputa.m_RenderPass = (HGRenderGraphPass *)HG::Rendering::RenderGraphModule::HGRenderGraph::ImportComputeBuffer(
			//                                                        renderGraph,
			//                                                        this.fields.m_indirectBufferV2,
			//                                                        0LL);
			//           v215 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteComputeBuffer(
			//                    &v356,
			//                    (ComputeBufferHandle *)&inputa,
			//                    0LL);
			//           if ( !*(_QWORD *)depthBits )
			//             sub_1802DC2C8(0LL, v216);
			//           *(ComputeBufferHandle *)(*(_QWORD *)depthBits + 472LL) = v215;
			//           inputa.m_RenderPass = v330;
			//           v217 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteComputeBuffer(
			//                    &v356,
			//                    (ComputeBufferHandle *)&viewPosition,
			//                    0LL);
			//           if ( !inputa.m_RenderPass )
			//             sub_1802DC2C8(0LL, v218);
			//           *(ComputeBufferHandle *)&inputa.m_RenderPass[2].fields._refCount_k__BackingField = v217;
			//           inputa.m_RenderPass = v330;
			//           v221 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v416, &v356, &v359, 0LL);
			//           if ( !inputa.m_RenderPass )
			//             sub_1802DC2C8(v220, v219);
			//           *(TextureHandle *)&inputa.m_RenderPass[2].fields.depthAttachment.textureHandle.fallBackResource.m_Value = v221;
			//           inputa.m_RenderPass = v330;
			//           v224 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v417, &v356, &si128, 0LL);
			//           if ( !inputa.m_RenderPass )
			//             sub_1802DC2C8(v223, v222);
			//           *(TextureHandle *)&inputa.m_RenderPass[2].fields._index_k__BackingField = v224;
			//           inputa.m_RenderPass = v330;
			//           v227 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v396, &v356, &v358, 0LL);
			//           if ( !inputa.m_RenderPass )
			//             sub_1802DC2C8(v226, v225);
			//           *(TextureHandle *)&inputa.m_RenderPass[2].fields.m_childPasses = v227;
			//           v228 = v330;
			//           if ( !v330 )
			//             sub_1802DC2C8(v226, 0LL);
			//           v330[2].fields.transientResourceList = (List_1_HG_Rendering_RenderGraphModule_ResourceHandle___Array *)this.fields.m_waterOcclusionCS;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v229 = ((unsigned __int64)&v228[2].fields.transientResourceList >> 12) & 0x1FFFFF;
			//             v230 = v229 >> 6;
			//             v231 = v229 & 0x3F;
			//             _m_prefetchw(&qword_18D6405E0[v230 + 36190]);
			//             do
			//               v232 = qword_18D6405E0[v230 + 36190];
			//             while ( v232 != _InterlockedCompareExchange64(&qword_18D6405E0[v230 + 36190], v232 | (1LL << v231), v232) );
			//           }
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass);
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//             &v356,
			//             (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass.static_fields.s_waterOcclustionRenderFuncV2,
			//             0LL,
			//             0,
			//             MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
			//           sub_180222690(v357);
			//           v233 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//                    (Int32Enum__Enum)0x40u,
			//                    MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//           HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//             &inputa,
			//             renderGraph,
			//             (String *)"Water Tessellation",
			//             &v325,
			//             v233,
			//             1,
			//             ProfilingHGPass__Enum_None,
			//             MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
			//           v348 = inputa;
			//           v346.handle = 0LL;
			//           v346.fallBackResource = (ResourceHandle)&v348;
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v348, 0, 0LL);
			//           v235 = v325;
			//           if ( !v325 )
			//             sub_1802DC2C8(v234, 0LL);
			//           v325[1].klass = (Object__Class *)hgCamera;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v236 = ((unsigned __int64)&v235[1] >> 12) & 0x1FFFFF;
			//             v237 = v236 >> 6;
			//             v235 = (Object *)(v236 & 0x3F);
			//             _m_prefetchw(&qword_18D6405E0[v237 + 36190]);
			//             do
			//             {
			//               v234 = qword_18D6405E0[v237 + 36190] | (1LL << (char)v235);
			//               v238 = qword_18D6405E0[v237 + 36190];
			//             }
			//             while ( v238 != _InterlockedCompareExchange64(&qword_18D6405E0[v237 + 36190], v234, v238) );
			//           }
			//           v239 = (Object__Class *)this.fields.m_cbHandle.ptr;
			//           v240 = v325;
			//           if ( !v325 )
			//             sub_1802DC2C8(v234, v235);
			//           v325[12] = *(Object *)&this.fields.m_cbHandle.bufferId;
			//           v240[13].klass = v239;
			//           v241 = v325;
			//           if ( !v325 )
			//             sub_1802DC2C8(v234, 0LL);
			//           v242 = (unsigned int)(v342 + 8 * j);
			//           HIDWORD(v325[26].monitor) = v242;
			//           if ( !v325 )
			//             sub_1802DC2C8(v242, v241);
			//           HIDWORD(v325[2].klass) = j;
			//           if ( !v325 )
			//             sub_1802DC2C8(0LL, v241);
			//           LODWORD(v325[2].monitor) = v343;
			//           v243 = (ComputeBufferHandle *)v325;
			//           inputa.m_RenderPass = (HGRenderGraphPass *)HG::Rendering::RenderGraphModule::HGRenderGraph::ImportComputeBuffer(
			//                                                        renderGraph,
			//                                                        this.fields.m_indirectBufferV2,
			//                                                        0LL);
			//           v244 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadComputeBuffer(
			//                    &v348,
			//                    (ComputeBufferHandle *)&inputa,
			//                    0LL);
			//           if ( !v243 )
			//             sub_1802DC2C8(v246, v245);
			//           v243[59] = v244;
			//           v247 = (ComputeBufferHandle *)v325;
			//           v248 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadComputeBuffer(
			//                    &v348,
			//                    (ComputeBufferHandle *)&viewPosition,
			//                    0LL);
			//           if ( !v247 )
			//             sub_1802DC2C8(v250, v249);
			//           v247[58] = v248;
			//           v251 = v325;
			//           v254 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v397, &v348, &sectorTexture, 0LL);
			//           if ( !v251 )
			//             sub_1802DC2C8(v253, v252);
			//           *(TextureHandle *)&v251[13].monitor = v254;
			//           v255 = v325;
			//           v258 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                     &v398,
			//                     &v348,
			//                     &interactionTexture,
			//                     0LL);
			//           if ( !v255 )
			//             sub_1802DC2C8(v257, v256);
			//           *(TextureHandle *)&v255[14].monitor = v258;
			//           v259 = v325;
			//           v262 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v399, &v348, &v367, 0LL);
			//           if ( !v259 )
			//             sub_1802DC2C8(v261, v260);
			//           v259[31] = (Object)v262;
			//           v263 = v325;
			//           v266 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v400, &v348, &v358, 0LL);
			//           if ( !v263 )
			//             sub_1802DC2C8(v265, v264);
			//           v263[32] = (Object)v266;
			//           v267 = v325;
			//           v270 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v401, &v348, &si128, 0LL);
			//           if ( !v267 )
			//             sub_1802DC2C8(v269, v268);
			//           v267[33] = (Object)v270;
			//           v271 = v325;
			//           v274 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v402, &v348, &v359, 0LL);
			//           if ( !v271 )
			//             sub_1802DC2C8(v273, v272);
			//           v271[34] = (Object)v274;
			//           v275 = v325;
			//           m_KeywordSpace = (HGWaterGlobalConfig *)v335.m_SpaceInfo.m_KeywordSpace;
			//           v277 = HG::Rendering::Runtime::HGWaterGlobalConfig::get_flowMap(
			//                    (HGWaterGlobalConfig *)v335.m_SpaceInfo.m_KeywordSpace,
			//                    0LL);
			//           if ( !v275 )
			//             sub_1802DC2C8(v279, v278);
			//           v275[9].monitor = (MonitorData *)v277;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v280 = (((unsigned __int64)&v275[9].monitor >> 12) & 0x1FFFFF) >> 6;
			//             _m_prefetchw(&qword_18D6405E0[v280 + 36190]);
			//             do
			//               v281 = qword_18D6405E0[v280 + 36190];
			//             while ( v281 != _InterlockedCompareExchange64(
			//                               &qword_18D6405E0[v280 + 36190],
			//                               v281 | (1LL << (((unsigned __int64)&v275[9].monitor >> 12) & 0x3F)),
			//                               v281) );
			//           }
			//           v282 = v325;
			//           rainMap = HG::Rendering::Runtime::HGWaterGlobalConfig::get_rainMap(m_KeywordSpace, 0LL);
			//           if ( !v282 )
			//             sub_1802DC2C8(v285, v284);
			//           v282[10].monitor = (MonitorData *)rainMap;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v286 = (((unsigned __int64)&v282[10].monitor >> 12) & 0x1FFFFF) >> 6;
			//             _m_prefetchw(&qword_18D6405E0[v286 + 36190]);
			//             do
			//               v287 = qword_18D6405E0[v286 + 36190];
			//             while ( v287 != _InterlockedCompareExchange64(
			//                               &qword_18D6405E0[v286 + 36190],
			//                               v287 | (1LL << (((unsigned __int64)&v282[10].monitor >> 12) & 0x3F)),
			//                               v287) );
			//           }
			//           v288 = v325;
			//           v289 = HG::Rendering::Runtime::HGWaterGlobalConfig::get_normalMapArray(m_KeywordSpace, 0LL);
			//           if ( !v288 )
			//             sub_1802DC2C8(v291, v290);
			//           v288[11].monitor = (MonitorData *)v289;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v292 = (((unsigned __int64)&v288[11].monitor >> 12) & 0x1FFFFF) >> 6;
			//             _m_prefetchw(&qword_18D6405E0[v292 + 36190]);
			//             do
			//               v293 = qword_18D6405E0[v292 + 36190];
			//             while ( v293 != _InterlockedCompareExchange64(
			//                               &qword_18D6405E0[v292 + 36190],
			//                               v293 | (1LL << (((unsigned __int64)&v288[11].monitor >> 12) & 0x3F)),
			//                               v293) );
			//           }
			//           v294 = v325;
			//           v295 = v337;
			//           v296 = HG::Rendering::Runtime::HGWaterManager::get_screenSpaceMesh(v337, 0LL);
			//           if ( !v294 )
			//             sub_1802DC2C8(v298, v297);
			//           v294[3].monitor = (MonitorData *)v296;
			//           v299 = dword_18D8E43F8;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v300 = (((unsigned __int64)&v294[3].monitor >> 12) & 0x1FFFFF) >> 6;
			//             _m_prefetchw(&qword_18D6405E0[v300 + 36190]);
			//             do
			//               v301 = qword_18D6405E0[v300 + 36190];
			//             while ( v301 != _InterlockedCompareExchange64(
			//                               &qword_18D6405E0[v300 + 36190],
			//                               v301 | (1LL << (((unsigned __int64)&v294[3].monitor >> 12) & 0x3F)),
			//                               v301) );
			//             v299 = dword_18D8E43F8;
			//           }
			//           v302 = v325;
			//           m_waterTessellationMPB = (Object__Class *)this.fields.m_waterTessellationMPB;
			//           if ( !v325 )
			//             sub_1802DC2C8(m_waterTessellationMPB, 0LL);
			//           v325[9].klass = m_waterTessellationMPB;
			//           if ( v299 )
			//           {
			//             v304 = ((unsigned __int64)&v302[9] >> 12) & 0x1FFFFF;
			//             v305 = v304 >> 6;
			//             v306 = v304 & 0x3F;
			//             _m_prefetchw(&qword_18D6405E0[v305 + 36190]);
			//             do
			//               v307 = qword_18D6405E0[v305 + 36190];
			//             while ( v307 != _InterlockedCompareExchange64(&qword_18D6405E0[v305 + 36190], v307 | (1LL << v306), v307) );
			//             v299 = dword_18D8E43F8;
			//           }
			//           v308 = v325;
			//           m_waterTessellationMaterial = (MonitorData *)this.fields.m_waterTessellationMaterial;
			//           if ( !v325 )
			//             sub_1802DC2C8(m_waterTessellationMaterial, 0LL);
			//           v325[7].monitor = m_waterTessellationMaterial;
			//           if ( v299 )
			//           {
			//             v310 = ((unsigned __int64)&v308[7].monitor >> 12) & 0x1FFFFF;
			//             v311 = v310 >> 6;
			//             v308 = (Object *)(v310 & 0x3F);
			//             _m_prefetchw(&qword_18D6405E0[v311 + 36190]);
			//             do
			//               v312 = qword_18D6405E0[v311 + 36190];
			//             while ( v312 != _InterlockedCompareExchange64(
			//                               &qword_18D6405E0[v311 + 36190],
			//                               v312 | (1LL << (char)v308),
			//                               v312) );
			//           }
			//           v313 = this.fields.m_waterTessellationMaterial;
			//           if ( !v313 )
			//             sub_1802DC2C8(0LL, v308);
			//           shader = UnityEngine::Material::get_shader(v313, 0LL);
			//           UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v370, shader, (String *)"ENABLE_RAIN", 0LL);
			//           v316 = this.fields.m_waterTessellationMaterial;
			//           if ( !v316 )
			//             sub_1802DC2C8(0LL, v315);
			//           v335 = v370;
			//           UnityEngine::Material::SetLocalKeyword_Injected(v316, &v335, wetnessHighQualityEnabled, 0LL);
			//           v318 = this.fields.m_waterTessellationMaterial;
			//           if ( !v318 )
			//             sub_1802DC2C8(0LL, v317);
			//           v319 = UnityEngine::Material::get_shader(v318, 0LL);
			//           UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v369, v319, (String *)"ENABLE_WATER_RIPPLE", 0LL);
			//           v320 = this.fields.m_waterTessellationMaterial;
			//           ShouldRenderRippleState = HG::Rendering::Runtime::HGWaterManager::GetShouldRenderRippleState(v295, 0LL);
			//           if ( !v320 )
			//             sub_1802DC2C8(v323, v322);
			//           v335 = v369;
			//           UnityEngine::Material::SetLocalKeyword_Injected(v320, &v335, ShouldRenderRippleState, 0LL);
			//           *(_OWORD *)&v335.m_SpaceInfo.m_KeywordSpace = 0LL;
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//             &v403,
			//             &v348,
			//             &this.fields.m_normalRoughnessWithWaterTexture,
			//             0,
			//             RenderBufferLoadAction__Enum_Load,
			//             RenderBufferStoreAction__Enum_Store,
			//             (Color *)&v335,
			//             0,
			//             0LL);
			//           *(_OWORD *)&v335.m_SpaceInfo.m_KeywordSpace = 0LL;
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//             &v404,
			//             &v348,
			//             &this.fields.m_waterTessellationDataTexture,
			//             1,
			//             RenderBufferLoadAction__Enum_Load,
			//             RenderBufferStoreAction__Enum_Store,
			//             (Color *)&v335,
			//             0,
			//             0LL);
			//           sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//           if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input.sceneMV, 0LL) )
			//           {
			//             *(__m128i *)&v335.m_SpaceInfo.m_KeywordSpace = _mm_load_si128((const __m128i *)&xmmword_18C1755F0);
			//             HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//               &v405,
			//               &v348,
			//               &input.sceneMV,
			//               2,
			//               RenderBufferLoadAction__Enum_Load,
			//               RenderBufferStoreAction__Enum_Store,
			//               (Color *)&v335,
			//               0,
			//               0LL);
			//           }
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//             (TextureHandle *)&desc,
			//             &v348,
			//             &this.fields.m_depthWithWaterTexture,
			//             DepthAccess__Enum_Write,
			//             RenderBufferLoadAction__Enum_Load,
			//             RenderBufferStoreAction__Enum_Store,
			//             1.0,
			//             0,
			//             0,
			//             0LL);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass);
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//             &v348,
			//             (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass.static_fields.s_waterTessellationRenderFuncV2,
			//             0LL,
			//             0,
			//             MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
			//           sub_180222690(&v346);
			//           sub_180224750(&v340);
			//           break;
			//         }
			//       }
			//       this.fields.m_frameIndexV2 = ((unsigned __int8)this.fields.m_frameIndexV2 + 1) & 0x3F;
			//       this.fields.m_isFirstTimeV2 = 0;
			//       sub_180224750(v354);
			//     }
			//     else
			//     {
			//       v60 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0x40u,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//         (HGRenderGraphBuilder *)&viewProj,
			//         renderGraph,
			//         (String *)"Water Tessellation",
			//         &v334,
			//         v60,
			//         1,
			//         ProfilingHGPass__Enum_None,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
			//       *(_OWORD *)&v352.m_RenderPass = *(_OWORD *)&viewProj.m00;
			//       *(_OWORD *)&v352.m_RenderGraph = *(_OWORD *)&viewProj.m01;
			//       v345[0] = 0LL;
			//       v345[1] = &v352;
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v352, 0, 0LL);
			//       v62 = v334;
			//       if ( !v334 )
			//         sub_1802DC2C8(v61, 0LL);
			//       v334[1].klass = (Object__Class *)hgCamera;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v63 = ((unsigned __int64)&v62[1] >> 12) & 0x1FFFFF;
			//         v64 = v63 >> 6;
			//         v62 = (Object *)(v63 & 0x3F);
			//         _m_prefetchw(&qword_18D6405E0[v64 + 36190]);
			//         do
			//         {
			//           v61 = qword_18D6405E0[v64 + 36190] | (1LL << (char)v62);
			//           v65 = qword_18D6405E0[v64 + 36190];
			//         }
			//         while ( v65 != _InterlockedCompareExchange64(&qword_18D6405E0[v64 + 36190], v61, v65) );
			//       }
			//       v66 = (Object__Class *)this.fields.m_cbHandle.ptr;
			//       v67 = v334;
			//       if ( !v334 )
			//         sub_1802DC2C8(v61, v62);
			//       v334[12] = *(Object *)&this.fields.m_cbHandle.bufferId;
			//       v67[13].klass = v66;
			//       v68 = v334;
			//       v71 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v338, &v352, &sectorTexture, 0LL);
			//       if ( !v68 )
			//         sub_1802DC2C8(v70, v69);
			//       *(TextureHandle *)&v68[13].monitor = v71;
			//       v72 = v334;
			//       v75 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v338, &v352, &interactionTexture, 0LL);
			//       if ( !v72 )
			//         sub_1802DC2C8(v74, v73);
			//       *(TextureHandle *)&v72[14].monitor = v75;
			//       v76 = v334;
			//       if ( !v335.m_SpaceInfo.m_KeywordSpace )
			//         sub_1802DC2C8(v74, v73);
			//       v77 = HG::Rendering::Runtime::HGWaterGlobalConfig::get_flowMap(
			//               (HGWaterGlobalConfig *)v335.m_SpaceInfo.m_KeywordSpace,
			//               0LL);
			//       if ( !v76 )
			//         sub_1802DC2C8(v79, v78);
			//       v76[9].monitor = (MonitorData *)v77;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v80 = (((unsigned __int64)&v76[9].monitor >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v80 + 36190]);
			//         do
			//           v81 = qword_18D6405E0[v80 + 36190];
			//         while ( v81 != _InterlockedCompareExchange64(
			//                          &qword_18D6405E0[v80 + 36190],
			//                          v81 | (1LL << (((unsigned __int64)&v76[9].monitor >> 12) & 0x3F)),
			//                          v81) );
			//       }
			//       v82 = v334;
			//       v83 = HG::Rendering::Runtime::HGWaterGlobalConfig::get_rainMap(
			//               (HGWaterGlobalConfig *)v335.m_SpaceInfo.m_KeywordSpace,
			//               0LL);
			//       if ( !v82 )
			//         sub_1802DC2C8(v85, v84);
			//       v82[10].monitor = (MonitorData *)v83;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v86 = (((unsigned __int64)&v82[10].monitor >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v86 + 36190]);
			//         do
			//           v87 = qword_18D6405E0[v86 + 36190];
			//         while ( v87 != _InterlockedCompareExchange64(
			//                          &qword_18D6405E0[v86 + 36190],
			//                          v87 | (1LL << (((unsigned __int64)&v82[10].monitor >> 12) & 0x3F)),
			//                          v87) );
			//       }
			//       v88 = v334;
			//       v89 = HG::Rendering::Runtime::HGWaterGlobalConfig::get_normalMapArray(
			//               (HGWaterGlobalConfig *)v335.m_SpaceInfo.m_KeywordSpace,
			//               0LL);
			//       if ( !v88 )
			//         sub_1802DC2C8(v91, v90);
			//       v88[11].monitor = (MonitorData *)v89;
			//       v92 = dword_18D8E43F8;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v93 = (((unsigned __int64)&v88[11].monitor >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v93 + 36190]);
			//         do
			//           v94 = qword_18D6405E0[v93 + 36190];
			//         while ( v94 != _InterlockedCompareExchange64(
			//                          &qword_18D6405E0[v93 + 36190],
			//                          v94 | (1LL << (((unsigned __int64)&v88[11].monitor >> 12) & 0x3F)),
			//                          v94) );
			//         v92 = dword_18D8E43F8;
			//       }
			//       v95 = v334;
			//       v96 = (Object__Class *)this.fields.m_waterTessellationMPB;
			//       if ( !v334 )
			//         sub_1802DC2C8(v96, 0LL);
			//       v334[9].klass = v96;
			//       if ( v92 )
			//       {
			//         v97 = ((unsigned __int64)&v95[9] >> 12) & 0x1FFFFF;
			//         v98 = v97 >> 6;
			//         v99 = v97 & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v98 + 36190]);
			//         do
			//           v100 = qword_18D6405E0[v98 + 36190];
			//         while ( v100 != _InterlockedCompareExchange64(&qword_18D6405E0[v98 + 36190], v100 | (1LL << v99), v100) );
			//         v92 = dword_18D8E43F8;
			//       }
			//       v101 = v334;
			//       v102 = (MonitorData *)this.fields.m_waterTessellationMaterial;
			//       if ( !v334 )
			//         sub_1802DC2C8(v102, 0LL);
			//       v334[7].monitor = v102;
			//       if ( v92 )
			//       {
			//         v103 = ((unsigned __int64)&v101[7].monitor >> 12) & 0x1FFFFF;
			//         v104 = v103 >> 6;
			//         v101 = (Object *)(v103 & 0x3F);
			//         _m_prefetchw(&qword_18D6405E0[v104 + 36190]);
			//         do
			//           v105 = qword_18D6405E0[v104 + 36190];
			//         while ( v105 != _InterlockedCompareExchange64(&qword_18D6405E0[v104 + 36190], v105 | (1LL << (char)v101), v105) );
			//       }
			//       v106 = this.fields.m_waterTessellationMaterial;
			//       if ( !v106 )
			//         sub_1802DC2C8(0LL, v101);
			//       v107 = UnityEngine::Material::get_shader(v106, 0LL);
			//       UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v372, v107, (String *)"ENABLE_RAIN", 0LL);
			//       v109 = this.fields.m_waterTessellationMaterial;
			//       if ( !v109 )
			//         sub_1802DC2C8(0LL, v108);
			//       keyword = v372;
			//       UnityEngine::Material::SetLocalKeyword_Injected(v109, &keyword, wetnessHighQualityEnabled, 0LL);
			//       v111 = this.fields.m_waterTessellationMaterial;
			//       if ( !v111 )
			//         sub_1802DC2C8(0LL, v110);
			//       v112 = UnityEngine::Material::get_shader(v111, 0LL);
			//       UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v371, v112, (String *)"ENABLE_WATER_RIPPLE", 0LL);
			//       v113 = this.fields.m_waterTessellationMaterial;
			//       v114 = HG::Rendering::Runtime::HGWaterManager::GetShouldRenderRippleState(v337, 0LL);
			//       if ( !v113 )
			//         sub_1802DC2C8(v116, v115);
			//       keyword = v371;
			//       UnityEngine::Material::SetLocalKeyword_Injected(v113, &keyword, v114, 0LL);
			//       si128 = 0LL;
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//         &v338,
			//         &v352,
			//         &this.fields.m_normalRoughnessWithWaterTexture,
			//         0,
			//         RenderBufferLoadAction__Enum_Load,
			//         RenderBufferStoreAction__Enum_Store,
			//         (Color *)&si128,
			//         0,
			//         0LL);
			//       si128 = 0LL;
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//         &v338,
			//         &v352,
			//         &this.fields.m_waterTessellationDataTexture,
			//         1,
			//         RenderBufferLoadAction__Enum_Load,
			//         RenderBufferStoreAction__Enum_Store,
			//         (Color *)&si128,
			//         0,
			//         0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input.sceneMV, 0LL) )
			//       {
			//         si128 = (TextureHandle)_mm_load_si128((const __m128i *)&xmmword_18C1755F0);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//           &v338,
			//           &v352,
			//           &input.sceneMV,
			//           2,
			//           RenderBufferLoadAction__Enum_Load,
			//           RenderBufferStoreAction__Enum_Store,
			//           (Color *)&si128,
			//           0,
			//           0LL);
			//       }
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//         &v338,
			//         &v352,
			//         &this.fields.m_depthWithWaterTexture,
			//         DepthAccess__Enum_Write,
			//         RenderBufferLoadAction__Enum_Load,
			//         RenderBufferStoreAction__Enum_Store,
			//         1.0,
			//         0,
			//         0,
			//         0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v352,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass.static_fields.s_waterGBufferRenderFuncV2,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
			//       sub_180222690(v345);
			//       sub_180224750(v354);
			//     }
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::RenderFallback(
			//       this,
			//       input,
			//       output,
			//       renderGraph,
			//       hgCamera,
			//       0LL);
			//   }
			// }
			// 
		}

		internal void RenderLighting(ref WaterDefaultDeferredRenderingPass.PassInput input, ref WaterDefaultDeferredRenderingPass.PassOutput output, HGRenderGraph renderGraph, HGCamera hgCamera)
		{
			// // Void RenderLighting(WaterDefaultDeferredRenderingPass+PassInput ByRef, WaterDefaultDeferredRenderingPass+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=2
			// void HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::RenderLighting(
			//         WaterDefaultDeferredRenderingPass *this,
			//         WaterDefaultDeferredRenderingPass_PassInput *input,
			//         WaterDefaultDeferredRenderingPass_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   Object *v6; // r15
			//   WaterDefaultDeferredRenderingPass *v9; // rsi
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   Object__Class *v12; // r13
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   HGManagerContext *currentManagerContext; // rax
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			//   Vector2Int sceneRTSize_k__BackingField; // rbx
			//   TextureHandle v19; // xmm8
			//   TextureHandle m_depthWithWaterTexture; // xmm7
			//   ProfilingSampler *v21; // rax
			//   __int64 v22; // rdx
			//   __int64 v23; // rcx
			//   __int64 v24; // rcx
			//   __int64 v25; // rdx
			//   int v26; // eax
			//   unsigned int v27; // edx
			//   unsigned __int64 v28; // r8
			//   char v29; // dl
			//   signed __int64 v30; // rtt
			//   __int64 v31; // rdx
			//   MaterialPropertyBlock *m_waterDecalDeferredMPB; // rcx
			//   unsigned int v33; // edx
			//   unsigned __int64 v34; // r8
			//   char v35; // dl
			//   signed __int64 v36; // rtt
			//   TextureHandle *v37; // r14
			//   __int64 v38; // rdx
			//   __int64 v39; // rcx
			//   TextureHandle v40; // xmm0
			//   TextureHandle *v41; // r14
			//   __int64 v42; // rdx
			//   __int64 v43; // rcx
			//   TextureHandle v44; // xmm0
			//   RenderFunc_1_HG_Rendering_Runtime_WaterDefaultDeferredRenderingPass_PassData_ *_9__51_0; // r14
			//   Object *v46; // r12
			//   RenderFunc_1_System_Object_ *v47; // rax
			//   __int64 v48; // rdx
			//   __int64 v49; // rcx
			//   unsigned __int64 v50; // rdx
			//   unsigned __int64 v51; // r8
			//   signed __int64 v52; // rtt
			//   ProfilingSampler *v53; // rax
			//   __int64 v54; // rdx
			//   __int64 v55; // rcx
			//   __int64 v56; // rdx
			//   __int64 v57; // rcx
			//   Object__Class *ptr; // xmm1_8
			//   Object *v59; // rax
			//   Object *v60; // rdx
			//   unsigned __int64 v61; // rdx
			//   unsigned __int64 v62; // r8
			//   char v63; // dl
			//   signed __int64 v64; // rtt
			//   Object *v65; // r14
			//   __int64 v66; // rdx
			//   __int64 v67; // rcx
			//   TextureHandle v68; // xmm0
			//   Object *v69; // r14
			//   __int64 v70; // rdx
			//   __int64 v71; // rcx
			//   TextureHandle v72; // xmm0
			//   Object *v73; // r14
			//   __int64 v74; // rdx
			//   __int64 v75; // rcx
			//   TextureHandle v76; // xmm0
			//   Object *v77; // r14
			//   __int64 v78; // rdx
			//   __int64 v79; // rcx
			//   TextureHandle v80; // xmm0
			//   Object *v81; // r14
			//   __int64 v82; // rdx
			//   __int64 v83; // rcx
			//   TextureHandle v84; // xmm0
			//   Object *v85; // r14
			//   __int64 v86; // rdx
			//   __int64 v87; // rcx
			//   TextureHandle v88; // xmm0
			//   Object *v89; // r14
			//   Texture2D *causticMap; // rax
			//   unsigned __int64 v91; // rdx
			//   __int64 v92; // rcx
			//   int v93; // eax
			//   unsigned __int64 v94; // r8
			//   signed __int64 v95; // rtt
			//   Object *v96; // r8
			//   Object__Class *m_renderingMaterial; // rcx
			//   unsigned __int64 v98; // r8
			//   unsigned __int64 v99; // r9
			//   char v100; // r8
			//   signed __int64 v101; // rtt
			//   HGEnvironmentPhase *InterpolatedPhase; // rax
			//   __int64 v103; // rdx
			//   __int64 v104; // rcx
			//   __int128 v105; // xmm6
			//   Material *v106; // rcx
			//   Shader *shader; // rax
			//   __int64 v108; // rdx
			//   Material *v109; // rcx
			//   bool v110; // r8
			//   __int64 v111; // rcx
			//   Object *v112; // rdx
			//   unsigned __int64 v113; // rdx
			//   unsigned __int64 v114; // r8
			//   char v115; // dl
			//   signed __int64 v116; // rtt
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v118; // rdx
			//   __int64 v119; // rcx
			//   Object *v120; // [rsp+50h] [rbp-158h] BYREF
			//   HGRenderGraphBuilder keyword; // [rsp+60h] [rbp-148h] BYREF
			//   __int64 v122; // [rsp+80h] [rbp-128h] BYREF
			//   Rect v123; // [rsp+90h] [rbp-118h] BYREF
			//   TextureHandle v124; // [rsp+A0h] [rbp-108h] BYREF
			//   HGRenderGraphBuilder v125; // [rsp+B0h] [rbp-F8h] BYREF
			//   HGRenderGraphBuilder v126; // [rsp+D0h] [rbp-D8h] BYREF
			//   HGWaterGlobalConfig *globalConfig; // [rsp+F0h] [rbp-B8h]
			//   TextureHandle v128; // [rsp+100h] [rbp-A8h] BYREF
			//   LocalKeyword v129; // [rsp+110h] [rbp-98h] BYREF
			//   Il2CppExceptionWrapper *v130; // [rsp+128h] [rbp-80h] BYREF
			//   Il2CppExceptionWrapper *v131; // [rsp+130h] [rbp-78h] BYREF
			// 
			//   v6 = (Object *)renderGraph;
			//   v9 = this;
			//   if ( !byte_18D919622 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::__c::_RenderLighting_b__51_0);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::__c);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass);
			//     sub_18003C530(&off_18D50A5B8);
			//     sub_18003C530(&off_18D50A5C8);
			//     byte_18D919622 = 1;
			//   }
			//   memset(&v126, 0, sizeof(v126));
			//   v122 = 0LL;
			//   memset(&v125, 0, sizeof(v125));
			//   v120 = 0LL;
			//   memset(&v129, 0, sizeof(v129));
			//   if ( IFix::WrappersManagerImpl::IsPatched(2925, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2925, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v119, v118);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1054(Patch, (Object *)v9, input, output, v6, (Object *)hgCamera, 0LL);
			//   }
			//   else
			//   {
			//     v12 = (Object__Class *)hgCamera;
			//     if ( !hgCamera )
			//       sub_180B536AC(v11, v10);
			//     if ( HG::Rendering::Runtime::HGCamera::ShouldRenderWater(hgCamera, 0LL) )
			//     {
			//       if ( !HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL) )
			//         sub_180B536AC(v14, v13);
			//       currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//       if ( !currentManagerContext )
			//         sub_180B536AC(v17, v16);
			//       if ( !currentManagerContext.fields._waterManager_k__BackingField )
			//         sub_180B536AC(v17, v16);
			//       globalConfig = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(
			//                        currentManagerContext.fields._waterManager_k__BackingField,
			//                        0LL);
			//       sceneRTSize_k__BackingField = hgCamera.fields._sceneRTSize_k__BackingField;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//       v19 = *HG::Rendering::Runtime::HGRenderPipeline::CreateDepthBuffer(
			//                (TextureHandle *)&keyword,
			//                (HGRenderGraph *)v6,
			//                sceneRTSize_k__BackingField,
			//                0LL);
			//       v128 = v19;
			//       m_depthWithWaterTexture = v9.fields.m_depthWithWaterTexture;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
			//       v123 = 0LL;
			//       v124 = v19;
			//       *(TextureHandle *)&keyword.m_RenderPass = m_depthWithWaterTexture;
			//       HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
			//         (HGRenderGraph *)v6,
			//         (TextureHandle *)&keyword,
			//         &v124,
			//         0,
			//         -1,
			//         0,
			//         &v123,
			//         0,
			//         0LL);
			//       if ( hgCamera.fields.waterDecalVisibleCount )
			//       {
			//         v21 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//                 (Int32Enum__Enum)0x3Bu,
			//                 MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//         if ( !v6 )
			//           sub_180B536AC(v23, v22);
			//         v126 = *(HGRenderGraphBuilder *)sub_180831150(
			//                                           (unsigned int)&keyword,
			//                                           (_DWORD)v6,
			//                                           (unsigned int)"WaterLighting",
			//                                           (unsigned int)&v122,
			//                                           (__int64)v21);
			//         *(_QWORD *)&v123.m_XMin = 0LL;
			//         *(_QWORD *)&v123.m_Width = &v126;
			//         try
			//         {
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v126, 0, 0LL);
			//           v25 = v122;
			//           if ( !v122 )
			//             sub_1802DC2C8(v24, 0LL);
			//           *(_QWORD *)(v122 + 16) = hgCamera;
			//           v26 = dword_18D8E43F8;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v27 = ((unsigned __int64)(v25 + 16) >> 12) & 0x1FFFFF;
			//             v28 = (unsigned __int64)v27 >> 6;
			//             v29 = v27 & 0x3F;
			//             _m_prefetchw(&qword_18D6405E0[v28 + 36190]);
			//             do
			//               v30 = qword_18D6405E0[v28 + 36190];
			//             while ( v30 != _InterlockedCompareExchange64(&qword_18D6405E0[v28 + 36190], v30 | (1LL << v29), v30) );
			//             v26 = dword_18D8E43F8;
			//           }
			//           v31 = v122;
			//           m_waterDecalDeferredMPB = v9.fields.m_waterDecalDeferredMPB;
			//           if ( !v122 )
			//             sub_1802DC2C8(m_waterDecalDeferredMPB, 0LL);
			//           *(_QWORD *)(v122 + 96) = m_waterDecalDeferredMPB;
			//           if ( v26 )
			//           {
			//             v33 = ((unsigned __int64)(v31 + 96) >> 12) & 0x1FFFFF;
			//             v34 = (unsigned __int64)v33 >> 6;
			//             v35 = v33 & 0x3F;
			//             _m_prefetchw(&qword_18D6405E0[v34 + 36190]);
			//             do
			//               v36 = qword_18D6405E0[v34 + 36190];
			//             while ( v36 != _InterlockedCompareExchange64(&qword_18D6405E0[v34 + 36190], v36 | (1LL << v35), v36) );
			//           }
			//           v37 = (TextureHandle *)v122;
			//           v40 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                    (TextureHandle *)&keyword,
			//                    &v126,
			//                    &v128,
			//                    0LL);
			//           if ( !v37 )
			//             sub_1802DC2C8(v39, v38);
			//           v37[38] = v40;
			//           v41 = (TextureHandle *)v122;
			//           v44 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                    (TextureHandle *)&keyword,
			//                    &v126,
			//                    &v9.fields.m_normalRoughnessWithWaterTexture,
			//                    0LL);
			//           if ( !v41 )
			//             sub_1802DC2C8(v43, v42);
			//           v41[35] = v44;
			//           *(_OWORD *)&keyword.m_RenderPass = 0LL;
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//             &v124,
			//             &v126,
			//             &v9.fields.m_waterTessellationDataTexture,
			//             0,
			//             RenderBufferLoadAction__Enum_Load,
			//             RenderBufferStoreAction__Enum_Store,
			//             (Color *)&keyword,
			//             0,
			//             0LL);
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//             (TextureHandle *)&keyword,
			//             &v126,
			//             &v9.fields.m_depthWithWaterTexture,
			//             DepthAccess__Enum_Read,
			//             RenderBufferLoadAction__Enum_Load,
			//             RenderBufferStoreAction__Enum_DontCare,
			//             1.0,
			//             0,
			//             0,
			//             0LL);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::__c);
			//           _9__51_0 = TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::__c.static_fields.__9__51_0;
			//           if ( !_9__51_0 )
			//           {
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::__c);
			//             v46 = (Object *)TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::__c.static_fields.__9;
			//             v47 = (RenderFunc_1_System_Object_ *)sub_180004920(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>[0]);
			//             _9__51_0 = (RenderFunc_1_HG_Rendering_Runtime_WaterDefaultDeferredRenderingPass_PassData_ *)v47;
			//             if ( !v47 )
			//               sub_1802DC2C8(v49, v48);
			//             HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
			//               v47,
			//               v46,
			//               MethodInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::__c::_RenderLighting_b__51_0,
			//               0LL);
			//             TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::__c.static_fields.__9__51_0 = _9__51_0;
			//             if ( dword_18D8E43F8 )
			//             {
			//               v50 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::__c.static_fields.__9__51_0 >> 12) & 0x1FFFFF) >> 6;
			//               v51 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::__c.static_fields.__9__51_0 >> 12) & 0x3F;
			//               _m_prefetchw(&qword_18D6405E0[v50 + 36190]);
			//               do
			//                 v52 = qword_18D6405E0[v50 + 36190];
			//               while ( v52 != _InterlockedCompareExchange64(&qword_18D6405E0[v50 + 36190], v52 | (1LL << v51), v52) );
			//             }
			//           }
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//             &v126,
			//             (RenderFunc_1_System_Object_ *)_9__51_0,
			//             0LL,
			//             0,
			//             MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
			//         }
			//         catch ( Il2CppExceptionWrapper *v130 )
			//         {
			//           *(Il2CppExceptionWrapper *)&v123.m_XMin = (Il2CppExceptionWrapper)v130.ex;
			//           sub_180222690(&v123);
			//           v12 = (Object__Class *)hgCamera;
			//           v6 = (Object *)renderGraph;
			//           v9 = this;
			//           goto LABEL_30;
			//         }
			//         sub_180222690(&v123);
			//       }
			// LABEL_30:
			//       v53 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0x41u,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       if ( !v6 )
			//         sub_1802DC2C8(v55, v54);
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//         &keyword,
			//         (HGRenderGraph *)v6,
			//         (String *)"WaterLighting",
			//         &v120,
			//         v53,
			//         1,
			//         ProfilingHGPass__Enum_None,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
			//       v125 = keyword;
			//       *(_QWORD *)&v123.m_XMin = 0LL;
			//       *(_QWORD *)&v123.m_Width = &v125;
			//       try
			//       {
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v125, 0, 0LL);
			//         ptr = (Object__Class *)v9.fields.m_cbHandle.ptr;
			//         v59 = v120;
			//         if ( !v120 )
			//           sub_1802DC2C8(v57, v56);
			//         v120[12] = *(Object *)&v9.fields.m_cbHandle.bufferId;
			//         v59[13].klass = ptr;
			//         v60 = v120;
			//         if ( !v120 )
			//           sub_1802DC2C8(v57, 0LL);
			//         v120[1].klass = v12;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v61 = ((unsigned __int64)&v60[1] >> 12) & 0x1FFFFF;
			//           v62 = v61 >> 6;
			//           v63 = v61 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v62 + 36190]);
			//           do
			//             v64 = qword_18D6405E0[v62 + 36190];
			//           while ( v64 != _InterlockedCompareExchange64(&qword_18D6405E0[v62 + 36190], v64 | (1LL << v63), v64) );
			//         }
			//         v65 = v120;
			//         v68 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                  (TextureHandle *)&keyword,
			//                  &v125,
			//                  &input.sceneDepthCopied,
			//                  0LL);
			//         if ( !v65 )
			//           sub_1802DC2C8(v67, v66);
			//         v65[37] = (Object)v68;
			//         v69 = v120;
			//         v72 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                  (TextureHandle *)&keyword,
			//                  &v125,
			//                  &v128,
			//                  0LL);
			//         if ( !v69 )
			//           sub_1802DC2C8(v71, v70);
			//         v69[38] = (Object)v72;
			//         v73 = v120;
			//         v76 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                  (TextureHandle *)&keyword,
			//                  &v125,
			//                  &v9.fields.m_normalRoughnessWithWaterTexture,
			//                  0LL);
			//         if ( !v73 )
			//           sub_1802DC2C8(v75, v74);
			//         v73[35] = (Object)v76;
			//         v77 = v120;
			//         v80 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                  (TextureHandle *)&keyword,
			//                  &v125,
			//                  &input.deferredSSRLightingTexture,
			//                  0LL);
			//         if ( !v77 )
			//           sub_1802DC2C8(v79, v78);
			//         v77[39] = (Object)v80;
			//         v81 = v120;
			//         v84 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                  (TextureHandle *)&keyword,
			//                  &v125,
			//                  &input.ssrFadenessTexture,
			//                  0LL);
			//         if ( !v81 )
			//           sub_1802DC2C8(v83, v82);
			//         v81[40] = (Object)v84;
			//         v85 = v120;
			//         v88 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                  (TextureHandle *)&keyword,
			//                  &v125,
			//                  &v9.fields.m_waterTessellationDataTexture,
			//                  0LL);
			//         if ( !v85 )
			//           sub_1802DC2C8(v87, v86);
			//         v85[41] = (Object)v88;
			//         v89 = v120;
			//         if ( !globalConfig )
			//           sub_1802DC2C8(0LL, v86);
			//         causticMap = HG::Rendering::Runtime::HGWaterGlobalConfig::get_causticMap(globalConfig, 0LL);
			//         if ( !v89 )
			//           sub_1802DC2C8(v92, v91);
			//         v89[10].klass = (Object__Class *)causticMap;
			//         v93 = dword_18D8E43F8;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v94 = (((unsigned __int64)&v89[10] >> 12) & 0x1FFFFF) >> 6;
			//           v91 = ((unsigned __int64)&v89[10] >> 12) & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v94 + 36190]);
			//           do
			//             v95 = qword_18D6405E0[v94 + 36190];
			//           while ( v95 != _InterlockedCompareExchange64(&qword_18D6405E0[v94 + 36190], v95 | (1LL << v91), v95) );
			//           v93 = dword_18D8E43F8;
			//         }
			//         v96 = v120;
			//         m_renderingMaterial = (Object__Class *)v9.fields.m_renderingMaterial;
			//         if ( !v120 )
			//           sub_1802DC2C8(m_renderingMaterial, v91);
			//         v120[5].klass = m_renderingMaterial;
			//         if ( v93 )
			//         {
			//           v98 = ((unsigned __int64)&v96[5] >> 12) & 0x1FFFFF;
			//           v99 = v98 >> 6;
			//           v100 = v98 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v99 + 36190]);
			//           do
			//             v101 = qword_18D6405E0[v99 + 36190];
			//           while ( v101 != _InterlockedCompareExchange64(&qword_18D6405E0[v99 + 36190], v101 | (1LL << v100), v101) );
			//         }
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//         InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase((HGCamera *)v12, 0LL);
			//         if ( !InterpolatedPhase )
			//           sub_1802DC2C8(v104, v103);
			//         v105 = *(_OWORD *)&InterpolatedPhase.fields.inkSimulationConfig.influence;
			//         keyword.m_RenderGraph = *(HGRenderGraph **)&InterpolatedPhase.fields.inkSimulationConfig.m_active;
			//         v106 = v9.fields.m_renderingMaterial;
			//         if ( !v106 )
			//           sub_1802DC2C8(0LL, v103);
			//         shader = UnityEngine::Material::get_shader(v106, 0LL);
			//         UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v129, shader, (String *)"ENABLE_INK_RENDER", 0LL);
			//         v109 = v9.fields.m_renderingMaterial;
			//         v110 = *(float *)&v105 > 0.0 && BYTE4(v105) == 0;
			//         if ( !v109 )
			//           sub_1802DC2C8(0LL, v108);
			//         *(_OWORD *)&keyword.m_RenderPass = *(_OWORD *)&v129.m_SpaceInfo.m_KeywordSpace;
			//         keyword.m_RenderGraph = *(HGRenderGraph **)&v129.m_Index;
			//         UnityEngine::Material::SetLocalKeyword_Injected(v109, (LocalKeyword *)&keyword, v110, 0LL);
			//         v112 = v120;
			//         if ( !v120 )
			//           sub_1802DC2C8(v111, 0LL);
			//         v120[7].klass = (Object__Class *)v9.fields.m_waterLightingMPB;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v113 = ((unsigned __int64)&v112[7] >> 12) & 0x1FFFFF;
			//           v114 = v113 >> 6;
			//           v115 = v113 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v114 + 36190]);
			//           do
			//             v116 = qword_18D6405E0[v114 + 36190];
			//           while ( v116 != _InterlockedCompareExchange64(&qword_18D6405E0[v114 + 36190], v116 | (1LL << v115), v116) );
			//         }
			//         *(__m128i *)&keyword.m_RenderPass = _mm_load_si128((const __m128i *)&xmmword_18A3576D0);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//           &v128,
			//           &v125,
			//           &input.sceneColor,
			//           0,
			//           RenderBufferLoadAction__Enum_Load,
			//           RenderBufferStoreAction__Enum_Store,
			//           (Color *)&keyword,
			//           0,
			//           0LL);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//           (TextureHandle *)&keyword,
			//           &v125,
			//           &v9.fields.m_depthWithWaterTexture,
			//           DepthAccess__Enum_Read,
			//           RenderBufferLoadAction__Enum_Load,
			//           RenderBufferStoreAction__Enum_DontCare,
			//           1.0,
			//           0,
			//           0,
			//           0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v125,
			//           (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass.static_fields.s_waterLightingRenderFunc,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
			//       }
			//       catch ( Il2CppExceptionWrapper *v131 )
			//       {
			//         *(Il2CppExceptionWrapper *)&v123.m_XMin = (Il2CppExceptionWrapper)v131.ex;
			//       }
			//       sub_180222690(&v123);
			//     }
			//   }
			// }
			// 
		}

		internal void RenderFallback(ref WaterDefaultDeferredRenderingPass.PassInput input, ref WaterDefaultDeferredRenderingPass.PassOutput output, HGRenderGraph renderGraph, HGCamera hgCamera)
		{
			// // Void RenderFallback(WaterDefaultDeferredRenderingPass+PassInput ByRef, WaterDefaultDeferredRenderingPass+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::RenderFallback(
			//         WaterDefaultDeferredRenderingPass *this,
			//         WaterDefaultDeferredRenderingPass_PassInput *input,
			//         WaterDefaultDeferredRenderingPass_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   ProfilingSampler *v10; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   __int64 v16; // [rsp+40h] [rbp-58h] BYREF
			//   Il2CppExceptionWrapper *v17; // [rsp+48h] [rbp-50h] BYREF
			//   _QWORD v18[4]; // [rsp+50h] [rbp-48h] BYREF
			//   HGRenderGraphBuilder v19; // [rsp+70h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D919623 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass);
			//     sub_18003C530(&off_18D50A598);
			//     byte_18D919623 = 1;
			//   }
			//   memset(&v19, 0, sizeof(v19));
			//   v16 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2922, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2922, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v15, v14);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1054(
			//       Patch,
			//       (Object *)this,
			//       input,
			//       output,
			//       (Object *)renderGraph,
			//       (Object *)hgCamera,
			//       0LL);
			//   }
			//   else
			//   {
			//     v10 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//             (Int32Enum__Enum)0x43u,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !renderGraph )
			//       sub_180B536AC(v12, v11);
			//     v19 = *(HGRenderGraphBuilder *)sub_180831150(
			//                                      (unsigned int)v18,
			//                                      (_DWORD)renderGraph,
			//                                      (unsigned int)"Water Fallback",
			//                                      (unsigned int)&v16,
			//                                      (__int64)v10);
			//     v18[0] = 0LL;
			//     v18[1] = &v19;
			//     try
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v19, 0, 0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v19,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass.static_fields.s_RenderFallbackFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v17 )
			//     {
			//       v18[0] = v17.ex;
			//     }
			//     sub_180222690(v18);
			//   }
			// }
			// 
		}

		internal void RenderWaterWetnessMask(ref WaterDefaultDeferredRenderingPass.PassInput input, ref WaterDefaultDeferredRenderingPass.PassOutput output, HGRenderGraph renderGraph, HGCamera hgCamera, in GBufferOutput gbufferOutput)
		{
			// // Void RenderWaterWetnessMask(WaterDefaultDeferredRenderingPass+PassInput ByRef, WaterDefaultDeferredRenderingPass+PassOutput ByRef, HGRenderGraph, HGCamera, GBufferOutput ByRef)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::RenderWaterWetnessMask(
			//         WaterDefaultDeferredRenderingPass *this,
			//         WaterDefaultDeferredRenderingPass_PassInput *input,
			//         WaterDefaultDeferredRenderingPass_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *hgCamera,
			//         GBufferOutput *gbufferOutput,
			//         MethodInfo *method)
			// {
			//   bool v11; // r13
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   bool IsCompoundRendererListDrawable; // r12
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   uint32_t cullingViewHandle; // r15d
			//   HGRenderGraphContext *m_RenderGraphContext; // r14
			//   __int64 v19; // rdx
			//   __int64 v20; // rcx
			//   uint32_t v21; // r15d
			//   HGRenderGraphContext *v22; // r14
			//   uint32_t v23; // r15d
			//   bool ShouldRenderWater; // r14
			//   bool v25; // dl
			//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v26; // rdx
			//   VolumetricRenderer_VolumetricBounds *v27; // r8
			//   Material *v28; // r9
			//   ProfilingSampler *v29; // rax
			//   __int64 v30; // rdx
			//   __int64 v31; // rcx
			//   __int64 v32; // r8
			//   int v33; // eax
			//   unsigned __int64 v34; // r8
			//   unsigned __int64 v35; // r9
			//   char v36; // r8
			//   signed __int64 v37; // rtt
			//   __int64 v38; // r8
			//   Material *m_waterProxyMaterial; // rcx
			//   unsigned __int64 v40; // r8
			//   unsigned __int64 v41; // r9
			//   char v42; // r8
			//   signed __int64 v43; // rtt
			//   __int64 v44; // r8
			//   MaterialPropertyBlock *m_waterProxyMPB; // rcx
			//   unsigned __int64 v46; // r8
			//   unsigned __int64 v47; // r9
			//   char v48; // r8
			//   signed __int64 v49; // rtt
			//   __int64 v50; // r8
			//   Texture3D *m_wetnessMask3DNoise; // rcx
			//   unsigned __int64 v52; // r8
			//   unsigned __int64 v53; // r9
			//   char v54; // r8
			//   signed __int64 v55; // rtt
			//   __int64 v56; // rsi
			//   __int64 v57; // rdx
			//   __int64 v58; // rcx
			//   TextureHandle v59; // xmm0
			//   __int64 v60; // rsi
			//   __int64 v61; // rdx
			//   __int64 v62; // rcx
			//   TextureHandle v63; // xmm0
			//   __int64 v64; // rcx
			//   TextureHandle *v65; // rbx
			//   __int64 v66; // rdx
			//   __int64 v67; // rcx
			//   TextureHandle v68; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v70; // rdx
			//   __int64 v71; // rcx
			//   HGRenderKeyword__Enum globalKeywords; // [rsp+20h] [rbp-1E8h]
			//   MethodInfo *globalKeywordsa; // [rsp+20h] [rbp-1E8h]
			//   MethodInfo *context; // [rsp+28h] [rbp-1E0h]
			//   int32_t drawableFeedbackPtr; // [rsp+30h] [rbp-1D8h]
			//   int32_t multiDraw; // [rsp+38h] [rbp-1D0h]
			//   float transparentSorting; // [rsp+40h] [rbp-1C8h]
			//   int32_t v78; // [rsp+48h] [rbp-1C0h]
			//   bool noAlphaTest; // [rsp+50h] [rbp-1B8h]
			//   bool excludeGPUDriven; // [rsp+58h] [rbp-1B0h]
			//   MethodInfo *v81; // [rsp+60h] [rbp-1A8h]
			//   __int64 v82; // [rsp+70h] [rbp-198h] BYREF
			//   TextureHandle si128; // [rsp+80h] [rbp-188h] BYREF
			//   uint32_t RendererList; // [rsp+90h] [rbp-178h]
			//   TextureHandle v85; // [rsp+98h] [rbp-170h] BYREF
			//   void *outPtr; // [rsp+A8h] [rbp-160h] BYREF
			//   void *v87; // [rsp+B0h] [rbp-158h] BYREF
			//   TextureHandle v88; // [rsp+B8h] [rbp-150h] BYREF
			//   HGRenderGraphBuilder v89; // [rsp+C8h] [rbp-140h] BYREF
			//   GBufferOutput v90; // [rsp+E8h] [rbp-120h] BYREF
			//   TextureDesc v91; // [rsp+110h] [rbp-F8h] BYREF
			//   Il2CppExceptionWrapper *v92; // [rsp+170h] [rbp-98h] BYREF
			//   TextureDesc v93; // [rsp+180h] [rbp-88h] BYREF
			// 
			//   v11 = 0;
			//   if ( !byte_18D919624 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass);
			//     sub_18003C530(&off_18D50A460);
			//     sub_18003C530(&off_18D50A468);
			//     byte_18D919624 = 1;
			//   }
			//   sub_1802F01E0(&v91, 0LL, 96LL);
			//   memset(&v89, 0, sizeof(v89));
			//   v82 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2942, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2942, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v71, v70);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1057(
			//       Patch,
			//       (Object *)this,
			//       input,
			//       output,
			//       (Object *)renderGraph,
			//       (Object *)hgCamera,
			//       gbufferOutput,
			//       0LL);
			//   }
			//   else
			//   {
			//     if ( !hgCamera )
			//       sub_180B536AC(v13, v12);
			//     hgCamera.fields.useWetnessMask = 0;
			//     IsCompoundRendererListDrawable = 0;
			//     if ( this.fields.m_decalFeedbackID )
			//     {
			//       IsCompoundRendererListDrawable = UnityEngine::HyperGryph::HGGraphicsUtils::IsCompoundRendererListDrawable(
			//                                          this.fields.m_decalFeedbackID,
			//                                          0LL);
			//       hgCamera.fields.useWetnessMask = IsCompoundRendererListDrawable || hgCamera.fields.useWetnessMask;
			//     }
			//     outPtr = 0LL;
			//     this.fields.m_decalFeedbackID = UnityEngine::HyperGryph::HGGraphicsUtils::AllocateTempCompoundRendererListFromScript(
			//                                        &outPtr,
			//                                        0LL);
			//     cullingViewHandle = hgCamera.fields.cullingViewHandle;
			//     if ( !renderGraph )
			//       sub_180B536AC(v16, v15);
			//     m_RenderGraphContext = renderGraph.fields.m_RenderGraphContext;
			//     if ( !m_RenderGraphContext )
			//       sub_180B536AC(v16, v15);
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     RendererList = UnityEngine::HyperGryph::HGDecalRender::CreateRendererList(
			//                      cullingViewHandle,
			//                      0x10000u,
			//                      m_RenderGraphContext.fields.renderContext.m_Ptr,
			//                      (uint32_t *)outPtr,
			//                      0LL);
			//     if ( this.fields.m_objFeedbackID )
			//     {
			//       v11 = UnityEngine::HyperGryph::HGGraphicsUtils::IsCompoundRendererListDrawable(this.fields.m_objFeedbackID, 0LL);
			//       hgCamera.fields.useWetnessMask = v11 || hgCamera.fields.useWetnessMask;
			//     }
			//     v87 = 0LL;
			//     this.fields.m_objFeedbackID = UnityEngine::HyperGryph::HGGraphicsUtils::AllocateTempCompoundRendererListFromScript(
			//                                      &v87,
			//                                      0LL);
			//     v21 = hgCamera.fields.cullingViewHandle;
			//     v22 = renderGraph.fields.m_RenderGraphContext;
			//     if ( !v22 )
			//       sub_180B536AC(v20, v19);
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     LOWORD(globalKeywords) = 0;
			//     v23 = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
			//             v21,
			//             HGRenderFlags__Enum_ShadowOnly|HGRenderFlags__Enum_Transparent,
			//             HGRenderFlags__Enum_Transparent,
			//             HGShaderLightMode__Enum_WetnessDecal,
			//             globalKeywords,
			//             v22.fields.renderContext.m_Ptr,
			//             v87,
			//             0,
			//             0,
			//             0xFFFFFFFF,
			//             0,
			//             0,
			//             0LL);
			//     ShouldRenderWater = HG::Rendering::Runtime::HGCamera::ShouldRenderWater(hgCamera, 0LL);
			//     v25 = ShouldRenderWater || hgCamera.fields.useWetnessMask;
			//     hgCamera.fields.useWetnessMask = v25;
			//     if ( v25 )
			//     {
			//       HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
			//         &v91,
			//         hgCamera.fields._sceneRTSize_k__BackingField,
			//         0LL);
			//       v91.name = (String *)"Water Wetness Mask Texture";
			//       sub_1800054D0(
			//         (VolumetricRenderer_VolumetricRenderItem *)&v91.name,
			//         v26,
			//         v27,
			//         v28,
			//         globalKeywordsa,
			//         context,
			//         drawableFeedbackPtr,
			//         multiDraw,
			//         transparentSorting,
			//         v78,
			//         noAlphaTest,
			//         excludeGPUDriven,
			//         v81);
			//       v91.colorFormat = 6;
			//       *(_WORD *)&v91.useMipMap = 0;
			//       v93 = v91;
			//       this.fields.m_waterWetnessMaskTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                                   &v88,
			//                                                   renderGraph,
			//                                                   &v93,
			//                                                   0LL);
			//       v29 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0x46u,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       v89 = *(HGRenderGraphBuilder *)sub_180831150(
			//                                        (unsigned int)&v90,
			//                                        (_DWORD)renderGraph,
			//                                        (unsigned int)"Water Wetness Mask",
			//                                        (unsigned int)&v82,
			//                                        (__int64)v29);
			//       v88.handle = 0LL;
			//       v88.fallBackResource = (ResourceHandle)&v89;
			//       try
			//       {
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v89, 0, 0LL);
			//         v32 = v82;
			//         if ( !v82 )
			//           sub_1802DC2C8(v31, v30);
			//         *(_QWORD *)(v82 + 16) = hgCamera;
			//         v33 = dword_18D8E43F8;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v34 = ((unsigned __int64)(v32 + 16) >> 12) & 0x1FFFFF;
			//           v35 = v34 >> 6;
			//           v36 = v34 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v35 + 36190]);
			//           do
			//             v37 = qword_18D6405E0[v35 + 36190];
			//           while ( v37 != _InterlockedCompareExchange64(&qword_18D6405E0[v35 + 36190], v37 | (1LL << v36), v37) );
			//           v33 = dword_18D8E43F8;
			//         }
			//         v38 = v82;
			//         m_waterProxyMaterial = this.fields.m_waterProxyMaterial;
			//         if ( !v82 )
			//           sub_1802DC2C8(m_waterProxyMaterial, qword_18D6405E0);
			//         *(_QWORD *)(v82 + 64) = m_waterProxyMaterial;
			//         if ( v33 )
			//         {
			//           v40 = ((unsigned __int64)(v38 + 64) >> 12) & 0x1FFFFF;
			//           v41 = v40 >> 6;
			//           v42 = v40 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v41 + 36190]);
			//           do
			//             v43 = qword_18D6405E0[v41 + 36190];
			//           while ( v43 != _InterlockedCompareExchange64(&qword_18D6405E0[v41 + 36190], v43 | (1LL << v42), v43) );
			//           v33 = dword_18D8E43F8;
			//         }
			//         v44 = v82;
			//         m_waterProxyMPB = this.fields.m_waterProxyMPB;
			//         if ( !v82 )
			//           sub_1802DC2C8(m_waterProxyMPB, qword_18D6405E0);
			//         *(_QWORD *)(v82 + 88) = m_waterProxyMPB;
			//         if ( v33 )
			//         {
			//           v46 = ((unsigned __int64)(v44 + 88) >> 12) & 0x1FFFFF;
			//           v47 = v46 >> 6;
			//           v48 = v46 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v47 + 36190]);
			//           do
			//             v49 = qword_18D6405E0[v47 + 36190];
			//           while ( v49 != _InterlockedCompareExchange64(&qword_18D6405E0[v47 + 36190], v49 | (1LL << v48), v49) );
			//           v33 = dword_18D8E43F8;
			//         }
			//         if ( !v82 )
			//           sub_1802DC2C8(0LL, qword_18D6405E0);
			//         *(TextureHandle *)(v82 + 296) = this.fields.m_waterWetnessMaskTexture;
			//         v50 = v82;
			//         m_wetnessMask3DNoise = this.fields.m_wetnessMask3DNoise;
			//         if ( !v82 )
			//           sub_1802DC2C8(m_wetnessMask3DNoise, qword_18D6405E0);
			//         *(_QWORD *)(v82 + 176) = m_wetnessMask3DNoise;
			//         if ( v33 )
			//         {
			//           v52 = ((unsigned __int64)(v50 + 176) >> 12) & 0x1FFFFF;
			//           v53 = v52 >> 6;
			//           v54 = v52 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v53 + 36190]);
			//           do
			//             v55 = qword_18D6405E0[v53 + 36190];
			//           while ( v55 != _InterlockedCompareExchange64(&qword_18D6405E0[v53 + 36190], v55 | (1LL << v54), v55) );
			//         }
			//         v56 = v82;
			//         v90 = *gbufferOutput;
			//         si128 = *HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(
			//                    &si128,
			//                    &v90,
			//                    GBufferID__Enum_GBufferA,
			//                    0LL);
			//         v59 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v85, &v89, &si128, 0LL);
			//         if ( !v56 )
			//           sub_1802DC2C8(v58, v57);
			//         *(TextureHandle *)(v56 + 312) = v59;
			//         v60 = v82;
			//         v90 = *gbufferOutput;
			//         si128 = *HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(&v85, &v90, GBufferID__Enum_GBufferB, 0LL);
			//         v63 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v85, &v89, &si128, 0LL);
			//         if ( !v60 )
			//           sub_1802DC2C8(v62, v61);
			//         *(TextureHandle *)(v60 + 328) = v63;
			//         if ( !v82 )
			//           sub_1802DC2C8(v62, v61);
			//         v64 = RendererList;
			//         *(_DWORD *)(v82 + 672) = RendererList;
			//         if ( !v82 )
			//           sub_1802DC2C8(v64, v61);
			//         *(_DWORD *)(v82 + 676) = v23;
			//         v65 = (TextureHandle *)v82;
			//         v68 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                  &v85,
			//                  &v89,
			//                  &input.sceneDepthCopied,
			//                  0LL);
			//         if ( !v65 )
			//           sub_1802DC2C8(v67, v66);
			//         v65[37] = v68;
			//         if ( !v82 )
			//           sub_1802DC2C8(v67, v66);
			//         *(_BYTE *)(v82 + 680) = IsCompoundRendererListDrawable;
			//         if ( !v82 )
			//           sub_1802DC2C8(v67, v66);
			//         *(_BYTE *)(v82 + 681) = v11;
			//         if ( !v82 )
			//           sub_1802DC2C8(v67, v66);
			//         *(_BYTE *)(v82 + 682) = ShouldRenderWater;
			//         si128 = (TextureHandle)_mm_load_si128((const __m128i *)&xmmword_18A357460);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//           &v85,
			//           &v89,
			//           &this.fields.m_waterWetnessMaskTexture,
			//           0,
			//           RenderBufferLoadAction__Enum_Clear,
			//           RenderBufferStoreAction__Enum_Store,
			//           (Color *)&si128,
			//           0,
			//           0LL);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//           &v85,
			//           &v89,
			//           &input.sceneDepth,
			//           DepthAccess__Enum_Read,
			//           RenderBufferLoadAction__Enum_Load,
			//           RenderBufferStoreAction__Enum_Store,
			//           0.0,
			//           0,
			//           0,
			//           0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v89,
			//           (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass.static_fields.s_waterWetnessMaskRenderFunc,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
			//       }
			//       catch ( Il2CppExceptionWrapper *v92 )
			//       {
			//         v88.handle = (ResourceHandle)v92.ex;
			//       }
			//       sub_180222690(&v88);
			//     }
			//     else
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       this.fields.m_waterWetnessMaskTexture = *(TextureHandle *)sub_182E7CCD0(&v85);
			//     }
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         WaterDefaultDeferredRenderingPass *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2943, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2943, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_340(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         WaterDefaultDeferredRenderingPass *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2944, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2944, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         WaterDefaultDeferredRenderingPass *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2945, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2945, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph renderGraph)
		{
		}

		private bool m_isRendering;

		private const int INDIRECT_NUM = 6;

		private const int WATER_DISPLACEMENT_TEXTURE_SIZE = 512;

		private bool m_isFirstTime;

		private uint m_frameIndex;

		private ComputeBuffer m_indirectBuffer;

		private const int INDIRECT_ARGS_NUM_V2 = 8;

		private const int INDIRECT_NUM_V2 = 32;

		private bool m_isFirstTimeV2;

		private uint m_frameIndexV2;

		private ComputeBuffer m_indirectBufferV2;

		private CBHandle m_cbHandle;

		private Texture3D m_wetnessMask3DNoise;

		private Material m_waterProxyMaterial;

		private Material m_waterTextureProcessMaterial;

		private Material m_renderingMaterial;

		private MaterialPropertyBlock m_waterProxyMPB;

		private MaterialPropertyBlock m_waterProxyDisplacementMPB;

		private MaterialPropertyBlock m_waterDecalDeferredMPB;

		private MaterialPropertyBlock m_waterTesellationMPB;

		private MaterialPropertyBlock m_waterLightingMPB;

		private Material m_waterProxyMaterial_V2;

		private Material m_waterTextureProcessMaterial_V2;

		private Material m_waterTessellationMaterial;

		private MaterialPropertyBlock m_waterCopyMPB;

		private MaterialPropertyBlock m_waterProxyMPB_V2;

		private MaterialPropertyBlock m_waterHeightDecalMPB;

		private MaterialPropertyBlock m_waterTessellationMPB;

		private ComputeShader m_waterOcclusionCS;

		private TextureHandle m_normalRoughnessWithWaterTexture;

		private TextureHandle m_depthWithWaterTexture;

		private TextureHandle m_waterTessellationDataTexture;

		private TextureHandle m_waterWetnessMaskTexture;

		private uint m_decalFeedbackID;

		private uint m_objFeedbackID;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly RenderFunc<WaterDefaultDeferredRenderingPass.PassData> s_RenderFallbackFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static readonly RenderFunc<WaterDefaultDeferredRenderingPass.PassData> s_waterProxyRenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		private static readonly RenderFunc<WaterDefaultDeferredRenderingPass.PassData> s_waterWetnessMaskRenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x18")]
		private static readonly RenderFunc<WaterDefaultDeferredRenderingPass.PassData> s_waterProxyDisplacementRenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x20")]
		private static readonly RenderFunc<WaterDefaultDeferredRenderingPass.PassData> s_waterOcclustionRenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x28")]
		private static readonly RenderFunc<WaterDefaultDeferredRenderingPass.PassData> s_waterTessellationRenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x30")]
		private static readonly RenderFunc<WaterDefaultDeferredRenderingPass.PassData> s_waterCopyRenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x38")]
		private static readonly RenderFunc<WaterDefaultDeferredRenderingPass.PassData> s_waterHeightRenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x40")]
		private static readonly RenderFunc<WaterDefaultDeferredRenderingPass.PassData> s_waterDecalRenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x48")]
		private static readonly RenderFunc<WaterDefaultDeferredRenderingPass.PassData> s_waterOcclustionRenderFuncV2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x50")]
		private static readonly RenderFunc<WaterDefaultDeferredRenderingPass.PassData> s_waterTessellationRenderFuncV2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x58")]
		private static readonly RenderFunc<WaterDefaultDeferredRenderingPass.PassData> s_waterGBufferRenderFuncV2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x60")]
		private static readonly RenderFunc<WaterDefaultDeferredRenderingPass.PassData> s_waterLightingRenderFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct PassInput
		{
			internal bool enableIndirect;

			internal GraphicsFormat depthFormat;

			internal DepthBits depthBits;

			internal TextureHandle sectorTexture;

			internal TextureHandle interactionTexture;

			internal TextureHandle sceneColor;

			internal TextureHandle sceneColorCopied;

			internal TextureHandle sceneDepth;

			internal TextureHandle sceneDepthCopied;

			internal TextureHandle sceneMV;

			internal TextureHandle deferredSSRLightingTexture;

			internal TextureHandle ssrFadenessTexture;

			internal ScriptableRenderContext srpContext;

			internal GBufferOutput gBufferOutput;

			internal HGSettingParameters settingParameters;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 32)]
		internal struct PassOutput
		{
			internal TextureHandle gbufferBWithWaterTexture;

			internal TextureHandle depthWithWaterTexture;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 64)]
		private struct WaterOcclusionData
		{
			public Vector4 param0;

			public Vector4 param1;

			public Vector4 param2;

			public Vector4 param3;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 32)]
		private struct WaterEdgeDampenData
		{
			public Vector4 param0;

			public Vector4 param1;
		}

		private class PassData
		{
			public PassData()
			{
				// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
				// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
				//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
				//         HGWindConfig *cSrc,
				//         HGWindConfig *cDst,
				//         float t,
				//         MethodInfo *method)
				// {
				//   ;
				// }
				// 
			}

			public HGCamera hgCamera;

			public uint cullHandle;

			public uint waterHeightVisibleCount;

			public uint waterHeightCullingHandle;

			public int heightLayer;

			public int lastHeightLayer;

			public int waterOcclusionGroupXYNum;

			public int waterOcclusionGroupZNum;

			public Mesh waterScreenSpaceMesh;

			public Material waterProxyMaterial;

			public Material waterTextureProcessMaterial;

			public Material waterRenderingMaterial;

			public MaterialPropertyBlock waterProxyMPB;

			public MaterialPropertyBlock waterDecalMPB;

			public MaterialPropertyBlock waterTesellationMPB;

			public MaterialPropertyBlock waterLightingMPB;

			public Material waterTessellationMaterial;

			public MaterialPropertyBlock waterCopyMPB;

			public MaterialPropertyBlock waterHeightDecalMPB;

			public MaterialPropertyBlock waterTessellationMPB;

			public Texture2D globalFlowmapTexture;

			public Texture2D globalCausticTexture;

			public Texture2D globalRainTexture;

			public Texture3D wetnessMask3DNoise;

			public Texture2DArray globalNormalTextureArray;

			public CBHandle cbHandle;

			public TextureHandle waterLocalFlowmapTexture;

			public TextureHandle waterInteractionTexture;

			public TextureHandle waterProxyDataTexture;

			public TextureHandle waterProxyNormalTexture;

			public TextureHandle waterProxyDepthTexture;

			public TextureHandle waterWetnessMaskTexture;

			public TextureHandle gbufferATexture;

			public TextureHandle gbufferBTexture;

			public TextureHandle waterDecalDataTexture;

			public TextureHandle waterDecalNormalTexture;

			public TextureHandle waterDecalDisplacementTexture;

			public TextureHandle waterDecalSmoothDisplacementTexture;

			public TextureHandle waterDecalDepthTexture;

			public bool firstTime;

			public bool enableIndirect;

			public uint useOffset;

			public uint clearOffset;

			public CBHandle occlusionCB;

			public ComputeBufferHandle tileBuffer;

			public ComputeBufferHandle indirectBuffer;

			public Vector2Int waterProxyTextureSize;

			public ComputeShader waterOcclusionCS;

			public TextureHandle waterPrepassDataTexture;

			public TextureHandle waterPrepassNormalTexture;

			public TextureHandle waterPrepassDisplacementTexture;

			public TextureHandle waterPrepassDepthTexture;

			public TextureHandle normalRoughnessTexture;

			public TextureHandle sceneDepthTexture;

			public TextureHandle sceneDepthTextureCopy;

			public TextureHandle sceneDepthWithWaterTextureCopy;

			public TextureHandle reflectionLightingTexture;

			public TextureHandle reflectionFadenessTexture;

			public TextureHandle waterTessellationDataTexture;

			public uint wetnessDecalECSList;

			public uint wetnessObjECSList;

			public bool renderWetnessDecal;

			public bool renderWetnessObj;

			public bool renderWaterProxy;

			public int waterLODInstanceCount;
		}
	}
}

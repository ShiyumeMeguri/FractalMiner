using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	[VolumeComponentMenuForRenderPipeline("HG/GTAmbientOcclusion", new System.Type[1] {typeof(HGRenderPipeline) })]
	public class GTAmbientOcclusion : VolumeComponent // TypeDefIndex: 38012
	{
		// Fields
		public BoolParameter enable; // 0x30
		public BoolParameter enableFP32Depths; // 0x38
		private BoolParameter enableBentNormals; // 0x40
		public BoolParameter generateNormalsInplace; // 0x48
		public ClampedIntParameter qualityLevel; // 0x50
		public ClampedIntParameter denoisePasses; // 0x58
		public ClampedFloatParameter radius; // 0x60
		public MinFloatParameter radiusMultiplier; // 0x68
		public MinFloatParameter falloffRange; // 0x70
		public MinFloatParameter sampleDistributionPower; // 0x78
		public MinFloatParameter thinOccluderCompensation; // 0x80
		public MinFloatParameter finalValuePower; // 0x88
		public MinFloatParameter depthMIPSamplingOffset; // 0x90
		public MinFloatParameter mvFactor; // 0x98
		public MinFloatParameter depthFactor; // 0xA0
	
		// Constructors
		public GTAmbientOcclusion() {} // 0x0000000184405A20-0x0000000184406750
		// GTAmbientOcclusion()
		void HG::Rendering::Runtime::GTAmbientOcclusion::GTAmbientOcclusion(GTAmbientOcclusion *this, MethodInfo *method)
		{
		  BoolParameter *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  bool v6; // zf
		  unsigned __int64 v7; // rdx
		  signed __int64 v8; // rtt
		  BoolParameter *v9; // rax
		  unsigned __int64 v10; // rdx
		  signed __int64 v11; // rtt
		  BoolParameter *v12; // rax
		  unsigned __int64 v13; // rdx
		  signed __int64 v14; // rtt
		  BoolParameter *v15; // rax
		  unsigned __int64 v16; // rdx
		  signed __int64 v17; // rtt
		  ClampedIntParameter *v18; // rbp
		  void (__fastcall __noreturn **v19)(); // rdi
		  unsigned int v20; // r8d
		  __int64 v21; // rsi
		  void (__fastcall __noreturn **v22)(); // rdx
		  unsigned int v23; // eax
		  unsigned int v24; // r8d
		  unsigned int v25; // eax
		  __int64 v26; // rax
		  __int64 v27; // r8
		  signed __int64 v28; // r9
		  unsigned __int64 v29; // rdx
		  unsigned __int64 v30; // r8
		  signed __int64 v31; // rtt
		  __int64 v32; // rsi
		  __int64 v33; // rax
		  __int64 v34; // rsi
		  _QWORD **v35; // rcx
		  __int64 v36; // r8
		  __int64 v37; // rax
		  __int64 v38; // rdx
		  unsigned __int64 v39; // rdx
		  signed __int64 v40; // rtt
		  ClampedIntParameter *v41; // rbp
		  unsigned int v42; // r8d
		  __int64 v43; // rsi
		  unsigned int v44; // eax
		  unsigned int v45; // r8d
		  unsigned int v46; // eax
		  __int64 v47; // rax
		  unsigned __int64 v48; // rdx
		  signed __int64 v49; // rtt
		  __int64 v50; // rax
		  unsigned __int64 v51; // rdx
		  signed __int64 v52; // rtt
		  __int64 v53; // rax
		  unsigned __int64 v54; // rdx
		  signed __int64 v55; // rtt
		  __int64 v56; // rax
		  unsigned __int64 v57; // rdx
		  signed __int64 v58; // rtt
		  __int64 v59; // rax
		  unsigned __int64 v60; // rdx
		  signed __int64 v61; // rtt
		  __int64 v62; // rax
		  unsigned __int64 v63; // rdx
		  signed __int64 v64; // rtt
		  __int64 v65; // rax
		  unsigned __int64 v66; // rdx
		  signed __int64 v67; // rtt
		  __int64 v68; // rax
		  unsigned __int64 v69; // rdx
		  signed __int64 v70; // rtt
		  __int64 v71; // rax
		  unsigned __int64 v72; // rdx
		  signed __int64 v73; // rtt
		  __int64 v74; // rax
		  int v75; // ecx
		  unsigned __int64 v76; // rdx
		  signed __int64 v77; // rtt
		  unsigned __int64 v78; // rdx
		  signed __int64 v79; // rtt
		  __int64 v80; // r8
		  signed __int64 v81; // r9
		  unsigned __int64 v82; // rdx
		  unsigned __int64 v83; // r8
		  signed __int64 v84; // rtt
		  __int64 v85; // rdi
		  __int64 v86; // rax
		  __int64 v87; // rdi
		  _QWORD **v88; // rcx
		  __int64 v89; // rcx
		  __int64 v90; // rax
		  __int64 v91; // rdx
		  _DWORD v92[14]; // [rsp+30h] [rbp-38h] BYREF
		
		  v3 = (BoolParameter *)sub_18002C620(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v3 )
		    goto LABEL_127;
		  v6 = dword_18F35FD08 == 0;
		  v3->fields._.m_Value = 0;
		  v3->fields._._.overrideState = 1;
		  this->fields.enable = v3;
		  if ( !v6 )
		  {
		    v7 = (((unsigned __int64)&this->fields.enable >> 12) & 0x1FFFFF) >> 6;
		    _m_prefetchw(&qword_18F103690[v7]);
		    do
		      v8 = qword_18F103690[v7];
		    while ( v8 != _InterlockedCompareExchange64(
		                    &qword_18F103690[v7],
		                    v8 | (1LL << (((unsigned __int64)&this->fields.enable >> 12) & 0x3F)),
		                    v8) );
		  }
		  v9 = (BoolParameter *)sub_18002C620(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v9 )
		    goto LABEL_127;
		  v6 = dword_18F35FD08 == 0;
		  v9->fields._.m_Value = 1;
		  v9->fields._._.overrideState = 0;
		  this->fields.enableFP32Depths = v9;
		  if ( !v6 )
		  {
		    v10 = (((unsigned __int64)&this->fields.enableFP32Depths >> 12) & 0x1FFFFF) >> 6;
		    _m_prefetchw(&qword_18F103690[v10]);
		    do
		      v11 = qword_18F103690[v10];
		    while ( v11 != _InterlockedCompareExchange64(
		                     &qword_18F103690[v10],
		                     v11 | (1LL << (((unsigned __int64)&this->fields.enableFP32Depths >> 12) & 0x3F)),
		                     v11) );
		  }
		  v12 = (BoolParameter *)sub_18002C620(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v12 )
		    goto LABEL_127;
		  v6 = dword_18F35FD08 == 0;
		  v12->fields._.m_Value = 1;
		  v12->fields._._.overrideState = 0;
		  this->fields.enableBentNormals = v12;
		  if ( !v6 )
		  {
		    v13 = (((unsigned __int64)&this->fields.enableBentNormals >> 12) & 0x1FFFFF) >> 6;
		    _m_prefetchw(&qword_18F103690[v13]);
		    do
		      v14 = qword_18F103690[v13];
		    while ( v14 != _InterlockedCompareExchange64(
		                     &qword_18F103690[v13],
		                     v14 | (1LL << (((unsigned __int64)&this->fields.enableBentNormals >> 12) & 0x3F)),
		                     v14) );
		  }
		  v15 = (BoolParameter *)sub_18002C620(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v15 )
		    goto LABEL_127;
		  v6 = dword_18F35FD08 == 0;
		  v15->fields._.m_Value = 0;
		  v15->fields._._.overrideState = 0;
		  this->fields.generateNormalsInplace = v15;
		  if ( !v6 )
		  {
		    v16 = (((unsigned __int64)&this->fields.generateNormalsInplace >> 12) & 0x1FFFFF) >> 6;
		    _m_prefetchw(&qword_18F103690[v16]);
		    do
		      v17 = qword_18F103690[v16];
		    while ( v17 != _InterlockedCompareExchange64(
		                     &qword_18F103690[v16],
		                     v17 | (1LL << (((unsigned __int64)&this->fields.generateNormalsInplace >> 12) & 0x3F)),
		                     v17) );
		  }
		  v18 = (ClampedIntParameter *)sub_18002C620(TypeInfo::UnityEngine::Rendering::ClampedIntParameter);
		  if ( !v18 )
		    goto LABEL_127;
		  v19 = off_18B8C2EC0;
		  if ( !byte_18F36E4F3 )
		  {
		    v20 = _InterlockedExchangeAdd64(
		            (volatile signed __int64 *)&MethodInfo::UnityEngine::Rendering::VolumeParameter<int>::VolumeParameter,
		            0LL);
		    if ( (v20 & 1) != 0 )
		    {
		      v21 = (v20 >> 1) & 0xFFFFFFF;
		      switch ( v20 >> 29 )
		      {
		        case 1u:
		          v22 = (void (__fastcall __noreturn **)())sub_180036020((unsigned int)v21);
		          goto LABEL_46;
		        case 2u:
		          v22 = (void (__fastcall __noreturn **)())sub_1800362C0((unsigned int)v21);
		          goto LABEL_46;
		        case 3u:
		        case 6u:
		          v23 = v20;
		          v24 = v20 >> 29;
		          v25 = (v23 >> 1) & 0xFFFFFFF;
		          if ( v24 )
		          {
		            if ( v24 == 3 )
		            {
		              v22 = (void (__fastcall __noreturn **)())sub_180009A40(v25);
		              goto LABEL_46;
		            }
		            if ( v24 == 6 )
		            {
		              v26 = sub_1802F8800(v25);
		              v22 = (void (__fastcall __noreturn **)())sub_180026660(v26, 0LL);
		              goto LABEL_46;
		            }
		          }
		          else if ( v25 == 1 )
		          {
		            v22 = off_18B8C2EC0;
		            goto LABEL_46;
		          }
		LABEL_45:
		          v22 = 0LL;
		LABEL_46:
		          if ( v22 )
		            _InterlockedExchange64(
		              (volatile __int64 *)&MethodInfo::UnityEngine::Rendering::VolumeParameter<int>::VolumeParameter,
		              (__int64)v22);
		          break;
		        case 4u:
		          v22 = (void (__fastcall __noreturn **)())sub_1802F8760((unsigned int)v21);
		          goto LABEL_46;
		        case 5u:
		          v27 = 8 * v21;
		          if ( *(_QWORD *)(qword_18F371F68 + 8 * v21) )
		          {
		            v22 = *(void (__fastcall __noreturn ***)())(v27 + qword_18F371F68);
		          }
		          else
		          {
		            v28 = il2cpp_string_new_len(
		                    qword_18F360DF8
		                  + *(int *)(v27 + *(int *)(qword_18F360E00 + 8) + qword_18F360DF8 + 4)
		                  + *(int *)(qword_18F360E00 + 16),
		                    *(unsigned int *)(v27 + *(int *)(qword_18F360E00 + 8) + qword_18F360DF8));
		            v22 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
		                                                       (volatile signed __int64 *)(qword_18F371F68 + 8 * v21),
		                                                       v28,
		                                                       0LL);
		            if ( !v22 )
		            {
		              if ( dword_18F35FD08 )
		              {
		                v29 = (((unsigned __int64)(qword_18F371F68 + 8 * v21) >> 12) & 0x1FFFFF) >> 6;
		                v30 = ((unsigned __int64)(qword_18F371F68 + 8 * v21) >> 12) & 0x3F;
		                _m_prefetchw(&qword_18F103690[v29]);
		                do
		                  v31 = qword_18F103690[v29];
		                while ( v31 != _InterlockedCompareExchange64(&qword_18F103690[v29], v31 | (1LL << v30), v31) );
		              }
		              v22 = (void (__fastcall __noreturn **)())v28;
		            }
		          }
		          goto LABEL_46;
		        case 7u:
		          v32 = sub_1802F8760((unsigned int)v21);
		          v33 = *(_QWORD *)(v32 + 16);
		          v34 = (v32 - *(_QWORD *)(v33 + 128)) >> 5;
		          if ( *(_BYTE *)(v33 + 42) == 21 )
		          {
		            v35 = *(_QWORD ***)(v33 + 96);
		            if ( *v35 )
		            {
		              v36 = **v35 - *(int *)(qword_18F360E00 + 160) - qword_18F360DF8;
		              v33 = sub_180009B10(v36 / 92 + v36);
		            }
		            else
		            {
		              v33 = 0LL;
		            }
		          }
		          v92[0] = v34 + *(_DWORD *)(*(_QWORD *)(v33 + 104) + 32LL);
		          v37 = sub_1801CD744(
		                  (unsigned int)v92,
		                  (int)qword_18F360DF8 + *(_DWORD *)(qword_18F360E00 + 64),
		                  *(int *)(qword_18F360E00 + 68) / 0xCuLL,
		                  12,
		                  (__int64)sub_1802F7130);
		          if ( !v37 )
		            goto LABEL_45;
		          v38 = *(unsigned int *)(v37 + 8);
		          if ( (_DWORD)v38 == -1 )
		            goto LABEL_45;
		          v22 = (void (__fastcall __noreturn **)())(qword_18F360DF8 + *(int *)(qword_18F360E00 + 72) + v38);
		          goto LABEL_46;
		        default:
		          break;
		      }
		    }
		    byte_18F36E4F3 = 1;
		  }
		  v6 = dword_18F35FD08 == 0;
		  v18->fields._._.m_Value = 2;
		  v18->fields._._._.overrideState = 0;
		  v18->fields.min = 0;
		  v18->fields.max = 3;
		  this->fields.qualityLevel = v18;
		  if ( !v6 )
		  {
		    v39 = (((unsigned __int64)&this->fields.qualityLevel >> 12) & 0x1FFFFF) >> 6;
		    _m_prefetchw(&qword_18F103690[v39]);
		    do
		      v40 = qword_18F103690[v39];
		    while ( v40 != _InterlockedCompareExchange64(
		                     &qword_18F103690[v39],
		                     v40 | (1LL << (((unsigned __int64)&this->fields.qualityLevel >> 12) & 0x3F)),
		                     v40) );
		  }
		  v41 = (ClampedIntParameter *)sub_18002C620(TypeInfo::UnityEngine::Rendering::ClampedIntParameter);
		  if ( !v41 )
		    goto LABEL_127;
		  if ( !byte_18F36E4F3 )
		  {
		    v42 = _InterlockedExchangeAdd64(
		            (volatile signed __int64 *)&MethodInfo::UnityEngine::Rendering::VolumeParameter<int>::VolumeParameter,
		            0LL);
		    if ( (v42 & 1) != 0 )
		    {
		      v43 = (v42 >> 1) & 0xFFFFFFF;
		      switch ( v42 >> 29 )
		      {
		        case 1u:
		          v19 = (void (__fastcall __noreturn **)())sub_180036020((unsigned int)v43);
		          goto LABEL_65;
		        case 2u:
		          v19 = (void (__fastcall __noreturn **)())sub_1800362C0((unsigned int)v43);
		          goto LABEL_65;
		        case 3u:
		        case 6u:
		          v44 = v42;
		          v45 = v42 >> 29;
		          v46 = (v44 >> 1) & 0xFFFFFFF;
		          if ( v45 )
		          {
		            if ( v45 == 3 )
		            {
		              v19 = (void (__fastcall __noreturn **)())sub_180009A40(v46);
		              goto LABEL_65;
		            }
		            if ( v45 == 6 )
		            {
		              v47 = sub_1802F8800(v46);
		              v19 = (void (__fastcall __noreturn **)())sub_180026660(v47, 0LL);
		              goto LABEL_65;
		            }
		          }
		          else if ( v46 == 1 )
		          {
		            goto LABEL_65;
		          }
		LABEL_64:
		          v19 = 0LL;
		LABEL_65:
		          if ( v19 )
		            _InterlockedExchange64(
		              (volatile __int64 *)&MethodInfo::UnityEngine::Rendering::VolumeParameter<int>::VolumeParameter,
		              (__int64)v19);
		          break;
		        case 4u:
		          v19 = (void (__fastcall __noreturn **)())sub_1802F8760((unsigned int)v43);
		          goto LABEL_65;
		        case 5u:
		          v80 = 8 * v43;
		          if ( *(_QWORD *)(qword_18F371F68 + 8 * v43) )
		          {
		            v19 = *(void (__fastcall __noreturn ***)())(v80 + qword_18F371F68);
		          }
		          else
		          {
		            v81 = il2cpp_string_new_len(
		                    qword_18F360DF8
		                  + *(int *)(v80 + *(int *)(qword_18F360E00 + 8) + qword_18F360DF8 + 4)
		                  + *(int *)(qword_18F360E00 + 16),
		                    *(unsigned int *)(v80 + *(int *)(qword_18F360E00 + 8) + qword_18F360DF8));
		            v19 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
		                                                       (volatile signed __int64 *)(qword_18F371F68 + 8 * v43),
		                                                       v81,
		                                                       0LL);
		            if ( !v19 )
		            {
		              if ( dword_18F35FD08 )
		              {
		                v82 = (((unsigned __int64)(qword_18F371F68 + 8 * v43) >> 12) & 0x1FFFFF) >> 6;
		                v83 = ((unsigned __int64)(qword_18F371F68 + 8 * v43) >> 12) & 0x3F;
		                _m_prefetchw(&qword_18F103690[v82]);
		                do
		                  v84 = qword_18F103690[v82];
		                while ( v84 != _InterlockedCompareExchange64(&qword_18F103690[v82], v84 | (1LL << v83), v84) );
		              }
		              v19 = (void (__fastcall __noreturn **)())v81;
		            }
		          }
		          goto LABEL_65;
		        case 7u:
		          v85 = sub_1802F8760((unsigned int)v43);
		          v86 = *(_QWORD *)(v85 + 16);
		          v87 = (v85 - *(_QWORD *)(v86 + 128)) >> 5;
		          if ( *(_BYTE *)(v86 + 42) == 21 )
		          {
		            v88 = *(_QWORD ***)(v86 + 96);
		            if ( *v88 )
		            {
		              v89 = **v88 - *(int *)(qword_18F360E00 + 160) - qword_18F360DF8;
		              v86 = sub_180009B10(v89 / 92 + v89);
		            }
		            else
		            {
		              v86 = 0LL;
		            }
		          }
		          v92[0] = v87 + *(_DWORD *)(*(_QWORD *)(v86 + 104) + 32LL);
		          v90 = sub_1801CD744(
		                  (unsigned int)v92,
		                  (int)qword_18F360DF8 + *(_DWORD *)(qword_18F360E00 + 64),
		                  *(int *)(qword_18F360E00 + 68) / 0xCuLL,
		                  12,
		                  (__int64)sub_1802F7130);
		          if ( !v90 )
		            goto LABEL_64;
		          v91 = *(unsigned int *)(v90 + 8);
		          if ( (_DWORD)v91 == -1 )
		            goto LABEL_64;
		          v19 = (void (__fastcall __noreturn **)())(v91 + qword_18F360DF8 + *(int *)(qword_18F360E00 + 72));
		          goto LABEL_65;
		        default:
		          break;
		      }
		    }
		    byte_18F36E4F3 = 1;
		  }
		  v6 = dword_18F35FD08 == 0;
		  v41->fields._._.m_Value = 1;
		  v41->fields._._._.overrideState = 0;
		  v41->fields.min = 0;
		  v41->fields.max = 3;
		  this->fields.denoisePasses = v41;
		  if ( !v6 )
		  {
		    v48 = (((unsigned __int64)&this->fields.denoisePasses >> 12) & 0x1FFFFF) >> 6;
		    _m_prefetchw(&qword_18F103690[v48]);
		    do
		      v49 = qword_18F103690[v48];
		    while ( v49 != _InterlockedCompareExchange64(
		                     &qword_18F103690[v48],
		                     v49 | (1LL << (((unsigned __int64)&this->fields.denoisePasses >> 12) & 0x3F)),
		                     v49) );
		  }
		  v50 = sub_18002C620(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v50 )
		    goto LABEL_127;
		  v6 = dword_18F35FD08 == 0;
		  *(_DWORD *)(v50 + 24) = 1084227584;
		  *(_BYTE *)(v50 + 16) = 0;
		  *(_DWORD *)(v50 + 32) = 0;
		  *(_DWORD *)(v50 + 36) = 1092616192;
		  *(_DWORD *)(v50 + 40) = 1065353216;
		  this->fields.radius = (ClampedFloatParameter *)v50;
		  if ( !v6 )
		  {
		    v51 = (((unsigned __int64)&this->fields.radius >> 12) & 0x1FFFFF) >> 6;
		    _m_prefetchw(&qword_18F103690[v51]);
		    do
		      v52 = qword_18F103690[v51];
		    while ( v52 != _InterlockedCompareExchange64(
		                     &qword_18F103690[v51],
		                     v52 | (1LL << (((unsigned __int64)&this->fields.radius >> 12) & 0x3F)),
		                     v52) );
		  }
		  v53 = sub_18002C620(TypeInfo::UnityEngine::Rendering::MinFloatParameter);
		  if ( !v53 )
		    goto LABEL_127;
		  v6 = dword_18F35FD08 == 0;
		  *(_DWORD *)(v53 + 24) = 0x40000000;
		  *(_BYTE *)(v53 + 16) = 0;
		  *(_DWORD *)(v53 + 32) = 0;
		  this->fields.radiusMultiplier = (MinFloatParameter *)v53;
		  if ( !v6 )
		  {
		    v54 = (((unsigned __int64)&this->fields.radiusMultiplier >> 12) & 0x1FFFFF) >> 6;
		    _m_prefetchw(&qword_18F103690[v54]);
		    do
		      v55 = qword_18F103690[v54];
		    while ( v55 != _InterlockedCompareExchange64(
		                     &qword_18F103690[v54],
		                     v55 | (1LL << (((unsigned __int64)&this->fields.radiusMultiplier >> 12) & 0x3F)),
		                     v55) );
		  }
		  v56 = sub_18002C620(TypeInfo::UnityEngine::Rendering::MinFloatParameter);
		  if ( !v56 )
		    goto LABEL_127;
		  v6 = dword_18F35FD08 == 0;
		  *(_DWORD *)(v56 + 24) = 1061997773;
		  *(_BYTE *)(v56 + 16) = 0;
		  *(_DWORD *)(v56 + 32) = 0;
		  this->fields.falloffRange = (MinFloatParameter *)v56;
		  if ( !v6 )
		  {
		    v57 = (((unsigned __int64)&this->fields.falloffRange >> 12) & 0x1FFFFF) >> 6;
		    _m_prefetchw(&qword_18F103690[v57]);
		    do
		      v58 = qword_18F103690[v57];
		    while ( v58 != _InterlockedCompareExchange64(
		                     &qword_18F103690[v57],
		                     v58 | (1LL << (((unsigned __int64)&this->fields.falloffRange >> 12) & 0x3F)),
		                     v58) );
		  }
		  v59 = sub_18002C620(TypeInfo::UnityEngine::Rendering::MinFloatParameter);
		  if ( !v59 )
		    goto LABEL_127;
		  v6 = dword_18F35FD08 == 0;
		  *(_DWORD *)(v59 + 24) = 0x40000000;
		  *(_BYTE *)(v59 + 16) = 0;
		  *(_DWORD *)(v59 + 32) = 0;
		  this->fields.sampleDistributionPower = (MinFloatParameter *)v59;
		  if ( !v6 )
		  {
		    v60 = (((unsigned __int64)&this->fields.sampleDistributionPower >> 12) & 0x1FFFFF) >> 6;
		    _m_prefetchw(&qword_18F103690[v60]);
		    do
		      v61 = qword_18F103690[v60];
		    while ( v61 != _InterlockedCompareExchange64(
		                     &qword_18F103690[v60],
		                     v61 | (1LL << (((unsigned __int64)&this->fields.sampleDistributionPower >> 12) & 0x3F)),
		                     v61) );
		  }
		  v62 = sub_18002C620(TypeInfo::UnityEngine::Rendering::MinFloatParameter);
		  if ( !v62 )
		    goto LABEL_127;
		  v6 = dword_18F35FD08 == 0;
		  *(_DWORD *)(v62 + 24) = 0x40000000;
		  *(_BYTE *)(v62 + 16) = 0;
		  *(_DWORD *)(v62 + 32) = 0;
		  this->fields.thinOccluderCompensation = (MinFloatParameter *)v62;
		  if ( !v6 )
		  {
		    v63 = (((unsigned __int64)&this->fields.thinOccluderCompensation >> 12) & 0x1FFFFF) >> 6;
		    _m_prefetchw(&qword_18F103690[v63]);
		    do
		      v64 = qword_18F103690[v63];
		    while ( v64 != _InterlockedCompareExchange64(
		                     &qword_18F103690[v63],
		                     v64 | (1LL << (((unsigned __int64)&this->fields.thinOccluderCompensation >> 12) & 0x3F)),
		                     v64) );
		  }
		  v65 = sub_18002C620(TypeInfo::UnityEngine::Rendering::MinFloatParameter);
		  if ( !v65 )
		    goto LABEL_127;
		  v6 = dword_18F35FD08 == 0;
		  *(_DWORD *)(v65 + 24) = 1074580685;
		  *(_BYTE *)(v65 + 16) = 0;
		  *(_DWORD *)(v65 + 32) = 0;
		  this->fields.finalValuePower = (MinFloatParameter *)v65;
		  if ( !v6 )
		  {
		    v66 = (((unsigned __int64)&this->fields.finalValuePower >> 12) & 0x1FFFFF) >> 6;
		    _m_prefetchw(&qword_18F103690[v66]);
		    do
		      v67 = qword_18F103690[v66];
		    while ( v67 != _InterlockedCompareExchange64(
		                     &qword_18F103690[v66],
		                     v67 | (1LL << (((unsigned __int64)&this->fields.finalValuePower >> 12) & 0x3F)),
		                     v67) );
		  }
		  v68 = sub_18002C620(TypeInfo::UnityEngine::Rendering::MinFloatParameter);
		  if ( !v68 )
		    goto LABEL_127;
		  v6 = dword_18F35FD08 == 0;
		  *(_DWORD *)(v68 + 24) = 1079194419;
		  *(_BYTE *)(v68 + 16) = 0;
		  *(_DWORD *)(v68 + 32) = 0;
		  this->fields.depthMIPSamplingOffset = (MinFloatParameter *)v68;
		  if ( !v6 )
		  {
		    v69 = (((unsigned __int64)&this->fields.depthMIPSamplingOffset >> 12) & 0x1FFFFF) >> 6;
		    _m_prefetchw(&qword_18F103690[v69]);
		    do
		      v70 = qword_18F103690[v69];
		    while ( v70 != _InterlockedCompareExchange64(
		                     &qword_18F103690[v69],
		                     v70 | (1LL << (((unsigned __int64)&this->fields.depthMIPSamplingOffset >> 12) & 0x3F)),
		                     v70) );
		  }
		  v71 = sub_18002C620(TypeInfo::UnityEngine::Rendering::MinFloatParameter);
		  if ( !v71 )
		    goto LABEL_127;
		  v6 = dword_18F35FD08 == 0;
		  *(_DWORD *)(v71 + 24) = 981668463;
		  *(_BYTE *)(v71 + 16) = 0;
		  *(_DWORD *)(v71 + 32) = 0;
		  this->fields.mvFactor = (MinFloatParameter *)v71;
		  if ( !v6 )
		  {
		    v72 = (((unsigned __int64)&this->fields.mvFactor >> 12) & 0x1FFFFF) >> 6;
		    _m_prefetchw(&qword_18F103690[v72]);
		    do
		      v73 = qword_18F103690[v72];
		    while ( v73 != _InterlockedCompareExchange64(
		                     &qword_18F103690[v72],
		                     v73 | (1LL << (((unsigned __int64)&this->fields.mvFactor >> 12) & 0x3F)),
		                     v73) );
		  }
		  v74 = sub_18002C620(TypeInfo::UnityEngine::Rendering::MinFloatParameter);
		  if ( !v74 )
		LABEL_127:
		    sub_1800D8250(v5, v4);
		  v75 = dword_18F35FD08;
		  *(_DWORD *)(v74 + 24) = 1075838976;
		  *(_BYTE *)(v74 + 16) = 0;
		  *(_DWORD *)(v74 + 32) = 0;
		  this->fields.depthFactor = (MinFloatParameter *)v74;
		  if ( v75 )
		  {
		    v76 = (((unsigned __int64)&this->fields.depthFactor >> 12) & 0x1FFFFF) >> 6;
		    _m_prefetchw(&qword_18F103690[v76]);
		    do
		      v77 = qword_18F103690[v76];
		    while ( v77 != _InterlockedCompareExchange64(
		                     &qword_18F103690[v76],
		                     v77 | (1LL << (((unsigned __int64)&this->fields.depthFactor >> 12) & 0x3F)),
		                     v77) );
		    v75 = dword_18F35FD08;
		  }
		  this->fields._.active = 1;
		  this->fields._._displayName_k__BackingField = (String *)"";
		  if ( v75 )
		  {
		    v78 = (((unsigned __int64)&this->fields._._displayName_k__BackingField >> 12) & 0x1FFFFF) >> 6;
		    _m_prefetchw(&qword_18F103690[v78]);
		    do
		      v79 = qword_18F103690[v78];
		    while ( v79 != _InterlockedCompareExchange64(
		                     &qword_18F103690[v78],
		                     v79 | (1LL << (((unsigned __int64)&this->fields._._displayName_k__BackingField >> 12) & 0x3F)),
		                     v79) );
		  }
		  UnityEngine::ScriptableObject::ScriptableObject((ScriptableObject *)this, 0LL);
		}
		
	
		// Methods
		public bool IsActive() => default; // 0x0000000183C2F320-0x0000000183C2F430
		// Boolean IsActive()
		bool HG::Rendering::Runtime::GTAmbientOcclusion::IsActive(GTAmbientOcclusion *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  BoolParameter *enable; // rbx
		  bool (*v6)(RuntimeType *, MethodInfo *); // r8
		  Il2CppMethodPointer methodPtr; // rdx
		  VolumeParameter__Fields v9; // rax
		  char v10; // al
		  VolumeParameter__Fields v11; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_21;
		  if ( wrapperArray->max_length.size <= 1093 )
		    goto LABEL_5;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_21;
		  if ( LODWORD(v3->_0.namespaze) <= 0x445 )
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( !v3[23]._0.fields )
		  {
		LABEL_5:
		    enable = this->fields.enable;
		    if ( enable )
		    {
		      sub_1800049A0(enable->klass);
		      v6 = (bool (*)(RuntimeType *, MethodInfo *))enable->klass->vtable.get_value.method;
		      methodPtr = enable->klass->vtable.set_value.methodPtr;
		      if ( v6 == System::RuntimeType::HasElementTypeImpl )
		      {
		        v9 = enable->fields._._;
		        if ( (*(_DWORD *)(*(_QWORD *)&v9 + 8LL) & 0x20000000) != 0 )
		          return 1;
		        v10 = *(_BYTE *)(*(_QWORD *)&v9 + 10LL);
		        if ( v10 == 29 || v10 == 16 || v10 == 20 || v10 == 15 )
		          return 1;
		      }
		      else
		      {
		        if ( v6 == System::RuntimeType::get_IsGenericType )
		          return System::RuntimeTypeHandle::HasInstantiation(enable, methodPtr);
		        if ( v6 != System::RuntimeType::get_IsGenericParameter )
		          return ((__int64 (__fastcall *)(BoolParameter *, Il2CppMethodPointer))v6)(enable, methodPtr);
		        v11 = enable->fields._._;
		        if ( (*(_DWORD *)(*(_QWORD *)&v11 + 8LL) & 0x20000000) == 0
		          && (*(_BYTE *)(*(_QWORD *)&v11 + 10LL) == 19 || *(_BYTE *)(*(_QWORD *)&v11 + 10LL) == 30) )
		        {
		          return 1;
		        }
		      }
		      return 0;
		    }
		LABEL_21:
		    sub_1800D8260(v3, wrapperArray);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1093, 0LL);
		  if ( !Patch )
		    goto LABEL_21;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
	}
}

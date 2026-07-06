using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[AddComponentMenu("HG/Effect/VFXSceneColorAdjustment(场景颜色调节)")]
	[ExecuteAlways]
	public class VFXSceneDark : VFXPlayableMonoBase
	{
		// (get) Token: 0x06000BD6 RID: 3030 RVA: 0x000025D2 File Offset: 0x000007D2
		public Vector3 sceneDark
		{
			get
			{
				// // Vector3 get_sceneDark()
				// Vector3 *HG::Rendering::Runtime::VFXSceneDark::get_sceneDark(
				//         Vector3 *__return_ptr retstr,
				//         VFXSceneDark *this,
				//         MethodInfo *method)
				// {
				//   MethodInfo *v5; // rdx
				//   Vector3 *v6; // rax
				//   __m128 g_low; // xmm3
				//   Vector3 *one; // rax
				//   unsigned __int64 v9; // xmm0_8
				//   __int64 v10; // xmm1_8
				//   float v11; // xmm4_4
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v13; // rdx
				//   __int64 v14; // rcx
				//   __int64 v15; // xmm0_8
				//   float z; // eax
				//   __int64 v18; // [rsp+30h] [rbp-38h] BYREF
				//   int v19; // [rsp+38h] [rbp-30h]
				//   Vector3 v20; // [rsp+40h] [rbp-28h] BYREF
				//   Vector3 v21[2]; // [rsp+50h] [rbp-18h] BYREF
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(1973, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1973, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v14, v13);
				//     v6 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_328(v21, Patch, (Object *)this, 0LL);
				//   }
				//   else if ( this.fields._sceneDark < 0.99 )
				//   {
				//     g_low = (__m128)LODWORD(this.fields._sceneDarkColor.g);
				//     one = UnityEngine::Vector3::get_one(&v20, v5);
				//     v9 = _mm_unpacklo_ps((__m128)LODWORD(this.fields._sceneDarkColor.r), g_low).m128_u64[0];
				//     v10 = *(_QWORD *)&one.x;
				//     *(float *)&one = one.z;
				//     v20.z = v11;
				//     v18 = v10;
				//     v19 = (int)one;
				//     *(_QWORD *)&v20.x = v9;
				//     v6 = (Vector3 *)sub_18238EF30(v21, &v20, &v18);
				//   }
				//   else
				//   {
				//     v6 = UnityEngine::Vector3::get_one(&v20, v5);
				//   }
				//   v15 = *(_QWORD *)&v6.x;
				//   z = v6.z;
				//   *(_QWORD *)&retstr.x = v15;
				//   retstr.z = z;
				//   return retstr;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000BD7 RID: 3031 RVA: 0x000025F0 File Offset: 0x000007F0
		public float sceneSaturation
		{
			get
			{
				// // Single get_sceneSaturation()
				// float HG::Rendering::Runtime::VFXSceneDark::get_sceneSaturation(VFXSceneDark *this, MethodInfo *method)
				// {
				//   if ( this.fields._useSceneSaturation )
				//     return this.fields._sceneSaturation;
				//   else
				//     return 1.0;
				// }
				// 
				return 0f;
			}
		}

		// (get) Token: 0x06000BD8 RID: 3032 RVA: 0x000025D8 File Offset: 0x000007D8
		public bool stopAutoExposure
		{
			get
			{
				// // Boolean get_Preview()
				// bool PaintIn3D::P3dHitParticles::get_Preview(P3dHitParticles *this, MethodInfo *method)
				// {
				//   return this.fields.preview;
				// }
				// 
				return default(bool);
			}
		}

		public VFXSceneDark()
		{
			// // VFXSceneDark()
			// void HG::Rendering::Runtime::VFXSceneDark::VFXSceneDark(VFXSceneDark *this, MethodInfo *method)
			// {
			//   Quaternion v2; // xmm1
			//   __int64 v3; // r8
			//   Quaternion v4; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   this.fields._sceneDark = 1.0;
			//   v2 = *UnityEngine::Quaternion::get_identity(&v4, method);
			//   *(_BYTE *)(v3 + 24) = 1;
			//   *(Quaternion *)(v3 + 36) = v2;
			//   UnityEngine::Component::Component((Component *)v3, 0LL);
			// }
			// 
		}

		protected override void OnPlay()
		{
			// // Void OnPlay()
			// void HG::Rendering::Runtime::VFXSceneDark::OnPlay(VFXSceneDark *this, MethodInfo *method)
			// {
			//   HGVFXManager *instance; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2159, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2159, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     instance = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
			//     if ( instance )
			//       HG::Rendering::Runtime::HGVFXManager::AddSceneDarkToManager(instance, this, 0LL);
			//   }
			// }
			// 
		}

		protected override void OnStop()
		{
			// // Void OnStop()
			// void HG::Rendering::Runtime::VFXSceneDark::OnStop(VFXSceneDark *this, MethodInfo *method)
			// {
			//   HGVFXManager *instance; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2160, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2160, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     instance = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
			//     if ( instance )
			//       HG::Rendering::Runtime::HGVFXManager::RemoveSceneDarkToManager(instance, this, 0LL);
			//   }
			// }
			// 
		}

		public void <>iFixBaseProxy_OnPlay()
		{
			// // Void <>iFixBaseProxy_OnPlay()
			// void HG::Rendering::Runtime::VFXSceneDark::__iFixBaseProxy_OnPlay(VFXSceneDark *this, MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::VFXPlayableMonoBase::OnPlay((VFXPlayableMonoBase *)this, 0LL);
			// }
			// 
		}

		public void <>iFixBaseProxy_OnStop()
		{
			// // Void <>iFixBaseProxy_OnStop()
			// void HG::Rendering::Runtime::VFXSceneDark::__iFixBaseProxy_OnStop(VFXSceneDark *this, MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::VFXPlayableMonoBase::OnStop((VFXPlayableMonoBase *)this, 0LL);
			// }
			// 
		}

		[Range(0f, 1f)]
		[SerializeField]
		private float _sceneDark;

		[SerializeField]
		private Color _sceneDarkColor;

		[SerializeField]
		private bool _useSceneSaturation;

		[SerializeField]
		[Range(0f, 1f)]
		private float _sceneSaturation;

		[SerializeField]
		private bool _stopAutoExposure;
	}
}

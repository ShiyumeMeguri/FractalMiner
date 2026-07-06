using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 52)]
	public struct HGWindMotorData
	{
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x000025D8 File Offset: 0x000007D8
		public bool IsSphere
		{
			get
			{
				// // Boolean get_isEmpty()
				// bool UnityEngine::InputSystem::Utilities::MemoryHelpers::BitRegion::get_isEmpty(
				//         MemoryHelpers_BitRegion *this,
				//         MethodInfo *method)
				// {
				//   return this.sizeInBits == 0;
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x0600075B RID: 1883 RVA: 0x000025D8 File Offset: 0x000007D8
		public bool IsRect
		{
			get
			{
				// // Boolean get_IsRect()
				// bool HG::Rendering::Runtime::HGWindMotorData::get_IsRect(HGWindMotorData *this, MethodInfo *method)
				// {
				//   return this.shape == 1;
				// }
				// 
				return default(bool);
			}
		}

		public HGWindPriority windPriority;

		public HGWindShape shape;

		public float rangeIn;

		[HideInInspector]
		public float length;

		[HideInInspector]
		public float width;

		[HideInInspector]
		public float height;

		public bool rectBackward;

		[HideInInspector]
		public float radius;

		[Range(0f, 360f)]
		public float angle;

		[Range(0f, 40f)]
		public float windSpeed;

		public Orient focus;

		public int motorInfo;

		[HideInInspector]
		public float distanceToCamera;
	}
}

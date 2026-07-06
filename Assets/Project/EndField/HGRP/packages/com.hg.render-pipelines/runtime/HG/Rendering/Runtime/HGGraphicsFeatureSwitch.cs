using System;

namespace HG.Rendering.Runtime
{
	public class HGGraphicsFeatureSwitch : IHGGraphicsFeatureSwitch
	{
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x000025D8 File Offset: 0x000007D8
		public bool enabled
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

		// (get) Token: 0x060003FD RID: 1021 RVA: 0x000025D8 File Offset: 0x000007D8
		public bool enabledForCPUCommands
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

		public HGGraphicsFeatureSwitch([MetadataOffset(Offset = "0x01F90B8E")] bool defaultValue = true)
		{
			// // Void set_override(Boolean)
			// void HG::Rendering::Runtime::ScalableSettingValue<bool>::set_override(
			//         ScalableSettingValue_1_System_Boolean_ *this,
			//         bool value,
			//         MethodInfo *method)
			// {
			//   this.fields.m_Override = value;
			// }
			// 
		}

		private bool m_defaultValue;
	}
}

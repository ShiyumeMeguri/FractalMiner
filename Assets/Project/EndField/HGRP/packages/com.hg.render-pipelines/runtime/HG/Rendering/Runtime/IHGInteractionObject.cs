using System;
using System.Collections.Generic;

namespace HG.Rendering.Runtime
{
	public interface IHGInteractionObject
	{
		void CollectInteractionNodes(List<HGInteractionNode> nodes);
	}
}

using System;
using System.Collections.Generic;
using Terraria.ModLoader;
using Terraria.UI;

namespace minusGN
{
	public class MinusGn : Mod
	{
		public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
		{
			var config = ModContent.GetInstance<FlashlightConfig>();
			layers.Insert(Math.Min(layers.Count - 1, config.Layer), new FlashlightLayer(this));
		}
	}
}

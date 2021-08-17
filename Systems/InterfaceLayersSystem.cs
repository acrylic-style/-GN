using System;
using System.Collections.Generic;
using Terraria.ModLoader;
using Terraria.UI;

namespace minusGN.Systems
{
    public class InterfaceLayersSystem : ModSystem
    {
        public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
        {
            var config = ModContent.GetInstance<FlashlightConfig>();
            layers.Insert(Math.Min(layers.Count - 1, config.Layer), new FlashlightLayer(MinusGn.StaticMod));
        }
    }
}
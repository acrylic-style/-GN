using System.ComponentModel;
using Terraria.ModLoader.Config;

// ReSharper disable UnusedAutoPropertyAccessor.Global
namespace minusGN
{
    public class FlashlightConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;
        
        [DefaultValue(true)] // easy mode
        public bool AttachToCursor { get; set; }
        
        [DefaultValue(0)]
        [Range(0, 50)]
        public int Layer { get; set; }
    }
}
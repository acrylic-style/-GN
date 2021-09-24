using System.ComponentModel;
using Terraria.ModLoader.Config;

// ReSharper disable UnusedAutoPropertyAccessor.Global
namespace minusGN
{
    public class FlashlightConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;
        
        [DefaultValue(true)] // easy mode
        [Label("Attach flashlight to cursor instead of player")]
        [Tooltip("On = Flashlight will be placed at cursor, Off = Player")]
        public bool AttachToCursor { get; set; }
        
        [DefaultValue(0)]
        [Label("Layer")]
        [Tooltip("0 = All UIs are visible; 19 = map is hidden; 33 = (almost) everything is hidden")]
        [Range(0, 50)]
        public int Layer { get; set; }
    }
}
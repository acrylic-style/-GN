using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;
using Terraria.UI;
using Color = Microsoft.Xna.Framework.Color;

namespace minusGN
{
    public class FlashlightLayer : GameInterfaceLayer
    {
        private static readonly Vector2 Offset = new Vector2(3840, 2160);
        private readonly Texture2D _flashlightTexture;
        
        public FlashlightLayer(Mod mod) : base("flashlight", InterfaceScaleType.Game)
        {
            _flashlightTexture = mod.Assets.Request<Texture2D>("Images/Flashlight").Value;
        }
        
        protected override bool DrawSelf()
        {
            var config = ModContent.GetInstance<FlashlightConfig>();
            var pos = config.AttachToCursor ? Main.MouseScreen : (Main.LocalPlayer.Center - Main.screenPosition);
            Main.spriteBatch.Draw(_flashlightTexture, pos - Offset, Color.Black);
            return true;
        }
    }
}

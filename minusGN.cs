using Terraria.ModLoader;

namespace minusGN
{
	public class MinusGn : Mod
	{
		public static Mod StaticMod { private set; get; }

		public override void Load()
		{
			StaticMod = this;
		}
	}
}

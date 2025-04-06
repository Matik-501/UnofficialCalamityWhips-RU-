using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria;
using System.Reflection;

namespace UnofficialCalamityWhipsRu
{
	public class UnofficialCalamityWhipsRu : Mod
	{
		public static Mod UnofficialCalamityWhips;


        public static string buffPath = "UnofficialCalamityWhips/DefaultDebuff";

		public override void Load() {
			if (ModLoader.HasMod("UnofficialCalamityWhips")) {
                UnofficialCalamityWhips = ModLoader.GetMod("UnofficialCalamityWhips");
            }
			else {
				UnofficialCalamityWhips = null;
            }
		}
		
	}
}
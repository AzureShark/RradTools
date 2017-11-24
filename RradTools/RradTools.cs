using Terraria.ModLoader;

namespace OpTools
{
	class OpTools : Mod
	{
		public OpTools()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}

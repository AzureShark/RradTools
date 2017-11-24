using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RradTools.Items
{
	public class OpPick : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("This is a pick of the GODS!.");
		}

		public override void SetDefaults()
		{
			item.damage = 2000000;
			item.melee = true;
			item.width = 80;
			item.height = 80;
			item.useTime = 1;
			item.useAnimation = 10;
			item.pick = 50000;
			item.useStyle = 1;
			item.knockBack = 600;
			item.value = 10000000;
			item.rare = 12;
			item.tileBoost = +100;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 1);
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(10) == 0)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("Sparkle"));
			}
		}
	}
}
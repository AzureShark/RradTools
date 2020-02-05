using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RradTools.Items
{
	[AutoloadEquip(EquipType.Wings)]
    public class OpWings : ModItem
    {
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Wings of The Gods");
			Tooltip.SetDefault("These wings were forged in the bowels of a black hole. A black hole made of dirt, don't ask me how."
				+ "\nDEFENSE FOR DAYS!"
				+ "\nSo much POWER!");
		}
		
        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 20;
            item.value = 10000000;
            item.rare = 2;
			item.defense = 10000;
            item.accessory = true;
        }
		
		public override void UpdateEquip(Player player)
		{
			player.buffImmune[BuffID.OnFire] = true;
			player.statManaMax2 += 2000;
			player.statLifeMax2 += 2000;
			player.maxMinions++;
		}

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.wingTimeMax = 30000;  //wings Height
        }

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 0.85f;
			ascentWhenRising = 0.15f;
			maxCanAscendMultiplier = 1f;
			maxAscentMultiplier = 3f;
			constantAscend = 0.135f;
		}

        public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
        {
            speed = 9f;
            acceleration *= 2.5f;
        }

        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 10); 
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

using Terraria.ID;
using Terraria.ModLoader;

namespace stuckraria.Items.weapons
{
	public class xyliumblade : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Xylium Blade");
			Tooltip.SetDefault("This thing pulses with a strong power of the end.\nDeveloper item: Dualfighter1"); // Weapon changed to item for consistency
		}

		public override void SetDefaults() 
		{
			item.damage = 260;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
                        item.maxStack = 1;
		}	

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
                        recipe.AddIngredient(ModContent.ItemType<buildgrist>(), 1000);
                        recipe.AddIngredient(ModContent.ItemType<meatgrist>(), 500);
                        recipe.AddIngredient(ModContent.ItemType<candygrist>(), 500);
                        recipe.AddIngredient(ModContent.ItemType<illithiumbar>(), 50);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

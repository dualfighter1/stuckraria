using Terraria.ID;
using Terraria.ModLoader;

namespace stuckraria.Items.weapons
{
	public class scarletribit: ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("scarlet ribbitar");
			Tooltip.SetDefault("a legendary sword made of illegal ingrediants");
		}

		public override void SetDefaults() 
		{
			item.damage = 100;
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
                        recipe.AddIngredient(ModContent.ItemType<buildgrist>(), 200);
                        recipe.AddIngredient(ModContent.ItemType<rubygrist>(), 200);
                        recipe.AddIngredient(ModContent.ItemType<shale>(), 100);
			recipe.AddTile(mod.GetTile("megacrafter"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
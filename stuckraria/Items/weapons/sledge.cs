using Terraria.ID;
using Terraria.ModLoader;

namespace stuckraria.Items.weapons
{
	public class sledge: ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("sledge-hammer");
			Tooltip.SetDefault("found among washing machines");
		}

		public override void SetDefaults() 
		{
			item.damage = 75;
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
                        recipe.AddIngredient(ItemID.IronBar, 10);
                        recipe.AddIngredient(ModContent.ItemType<buildgrist>(), 10);
                        recipe.AddIngredient(ModContent.ItemType<shale>(), 5);
                        recipe.AddIngredient(ModContent.ItemType<hammer>(), 1);
			recipe.AddTile(mod.GetTile("megacrafter"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
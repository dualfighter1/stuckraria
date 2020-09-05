using Terraria.ID;
using Terraria.ModLoader;

namespace stuckraria.Items.weapons
{
	public class onethreeclawkind: ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("1/3 claw kind");
			Tooltip.SetDefault("This has a smell of fire and cavepaints.          developer item: shou");
		}

		public override void SetDefaults() 
		{
			item.damage = 160;
			item.melee = true;
			item.width = 80;
			item.height = 80;
			item.useAnimation = 1;
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
                        recipe.AddIngredient(ModContent.ItemType<fightbook>(), 1);
                        recipe.AddIngredient(ModContent.ItemType<shale>(), 100);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
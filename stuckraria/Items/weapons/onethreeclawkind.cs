using Terraria.ID;
using Terraria.ModLoader;

namespace stuckraria.Items.weapons
{
	public class onethreeclawkind: ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("1/3 Claw Kind");
			Tooltip.SetDefault("Smells of fire and parietal art.\nDeveloper item: Shou");
		}

		public override void SetDefaults() 
		{
			item.damage = 160;
			item.melee = true;
			item.width = 65;
			item.height = 65;
			item.useAnimation = 5; //For comparison, the Fetid Baghnakhs have an Use Time of 8.
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
                        recipe.AddIngredient(ModContent.ItemType<shale>(), 100);
                        recipe.AddIngredient(ModContent.ItemType<clawkindcrux>(), 1);
			recipe.AddTile(mod.GetTile("totemlathe"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
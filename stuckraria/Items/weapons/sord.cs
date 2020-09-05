using Terraria.ID;
using Terraria.ModLoader;

namespace stuckraria.Items.weapons
{
	public class sord : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("sord");
			Tooltip.SetDefault("This thing is so unspeakably shitty you are having a hard time even holding it.");
		}

		public override void SetDefaults() 
		{
			item.damage = 1;
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
                        item.maxStack = 934584578;
		}	

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
                        recipe.AddIngredient(ModContent.ItemType<buildgrist>(), 785653646);
                        recipe.AddIngredient(ModContent.ItemType<shale>(), 785653646);
                        recipe.AddIngredient(ModContent.ItemType<meatgrist>(), 785656);
                        recipe.AddIngredient(ModContent.ItemType<candygrist>(), 785653564);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
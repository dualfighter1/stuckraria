using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace stuckraria.Items
 {

     public class illithiumbar : ModItem
     {
     
         public override void SetStaticDefaults()
         {
             DisplayName.SetDefault("illithium bar");
         }

         public override void SetDefaults()
         {
           item.width = 15;
           item.height = 12;
           item.rare = ItemRarityID.White;
           item.value = Item.sellPrice(silver: 2);
           item.maxStack = 999;
           item.useStyle = 1;
           item.useTime = 10;
           item.useAnimation = 10;
           item.autoReuse = true;
        }

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
                        recipe.AddIngredient(ModContent.ItemType<shale>(), 50);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
     }
 }
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace stuckraria.Items
 {

     public class shadestone : ModItem
     {
     
         public override void SetStaticDefaults()
         {
             DisplayName.SetDefault("shade stone");
         }

         public override void SetDefaults()
         {
           item.width = 15;
           item.height = 12;
           item.rare = ItemRarityID.White;
           item.maxStack = 999;
           item.consumable = true;
           item.useStyle = 1;
           item.useTime = 10;
           item.useAnimation = 10;
           item.createTile = mod.TileType("shadestone");
           item.autoReuse = true;
        }
     }
 }
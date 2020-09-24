using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace stuckraria.Items
 {

     public class prospitanbrick : ModItem
     {
     
         public override void SetStaticDefaults()
         {
             DisplayName.SetDefault("prospitan brick");
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
           item.createTile = mod.TileType("prospitanbrick");
           item.autoReuse = true;
        }
     }
 }
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace stuckraria.Items
 {

     public class shale : ModItem
     {
     
         public override void SetStaticDefaults()
         {
             DisplayName.SetDefault("shale");
         }

         public override void SetDefaults()
         {
           item.width = 15;
           item.height = 12;
           item.rare = ItemRarityID.White;
           item.value = Item.sellPrice(silver: 2);
           item.maxStack = 999;
        }
     }
 }
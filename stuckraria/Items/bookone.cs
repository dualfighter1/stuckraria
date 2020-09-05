using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace stuckraria.Items
 {

     public class bookone : ModItem
     {
     
         public override void SetStaticDefaults()
         {
             DisplayName.SetDefault("homestuck book 1");
             Tooltip.SetDefault("A young man stands in his bedroom. It just so happens that today, the 13th of April, 2009, is this young ma- ya know what? no");
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
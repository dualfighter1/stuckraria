// This item is referenced in \weapons\onethreeclawkind.cs
// So I made a really basic file
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace stuckraria.Items
 {

     public class clawkindcrux : ModItem
     {
         public override void SetStaticDefaults()
         {
             DisplayName.SetDefault("Clawkind Cruxite");
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
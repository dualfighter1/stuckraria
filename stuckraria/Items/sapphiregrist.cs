using Terraria;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace stuckraria.Items
 {

     public class sapphiregrist : ModItem
     {
         public override void SetStaticDefaults()
         {
             DisplayName.SetDefault("sapphire grist");
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
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace stuckraria.blocks
 {
     public class cruxiteore : ModTile
     {
         public override void SetDefaults()
         {
             Main.tileSolid[Type] = true;
             Main.tileMergeDirt[Type] = true;

             drop = mod.ItemType("cruxiteore");

             ModTranslation name = CreateMapEntryName();
             name.SetDefault("cruxite ore");
             AddMapEntry(Color.Gray);

             minPick = 20;
         }
     }
 }
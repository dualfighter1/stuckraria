using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace stuckraria.blocks
 {
     public class prospitanbrick : ModTile
     {
         public override void SetDefaults()
         {
             Main.tileSolid[Type] = true;
             Main.tileMergeDirt[Type] = true;

             drop = mod.ItemType("prospitanbrick");

             ModTranslation name = CreateMapEntryName();
             name.SetDefault("prospitanbrick");
             AddMapEntry(Color.Yellow);

             minPick = 20;
         }
     }
 }
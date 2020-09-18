using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace stuckraria.blocks
 {
     public class shalestone : ModTile
     {
         public override void SetDefaults()
         {
             Main.tileSolid[Type] = true;
             Main.tileMergeDirt[Type] = true;

             drop = mod.ItemType("shale");

             ModTranslation name = CreateMapEntryName();
             name.SetDefault("shalestone");
             AddMapEntry(Color.Gray);

             minPick = 20;
         }
     }
 }
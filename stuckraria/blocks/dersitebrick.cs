using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace stuckraria.blocks
 {
     public class dersitebrick : ModTile
     {
         public override void SetDefaults()
         {
             Main.tileSolid[Type] = true;
             Main.tileMergeDirt[Type] = true;

             drop = mod.ItemType("dersitebrick");

             ModTranslation name = CreateMapEntryName();
             name.SetDefault("dersitebrick");
             AddMapEntry(Color.Purple);

             minPick = 20;
         }
     }
 }
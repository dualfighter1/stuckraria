using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace stuckraria.blocks
 {
     public class griststone : ModTile
     {
         public override void SetDefaults()
         {
             Main.tileSolid[Type] = true;
             Main.tileMergeDirt[Type] = true;

             drop = mod.ItemType("buildgrist");

             ModTranslation name = CreateMapEntryName();
             name.SetDefault("griststone");
             AddMapEntry(Color.Gray);

             minPick = 20;
         }
     }
 }
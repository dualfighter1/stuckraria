using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace stuckraria.blocks
 {
     public class bioilumush : ModTile
     {
         public override void SetDefaults()
         {
             Main.tileSolid[Type] = true;
             Main.tileMergeDirt[Type] = true;

             drop = mod.ItemType("bioilumush");

             ModTranslation name = CreateMapEntryName();
             name.SetDefault("bio-iluminescent mushroom");
             AddMapEntry(Color.Gray);

             minPick = 20;
         }
     }
 }
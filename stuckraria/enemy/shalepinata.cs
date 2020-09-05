using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace stuckraria.enemy
{ 
     public class shalepinata : ModNPC
     {
         public override void SetStaticDefaults()
         {
             DisplayName.SetDefault("shale pinata");
             Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.DemonEye];
         }

         public override void SetDefaults()
         {
             npc.width = 12;
             npc.height = 7;
             npc.lifeMax = 75;
             npc.damage = 10;
             npc.defense = 2;
             npc.HitSound = SoundID.NPCHit1;
             npc.DeathSound = SoundID.NPCDeath3;
             npc.value = 10f;
             npc.knockBackResist = 0.75f;
             npc.aiStyle = 2;
             aiType = NPCID.DemonEye;
             animationType = NPCID.DemonEye;
         }

         public override float SpawnChance(NPCSpawnInfo spawnInfo)
         {
            return SpawnCondition.OverworldNightMonster.Chance * 0.25f;
         }
     
       public override void NPCLoot()
       {
           Item.NewItem(npc.position, ItemID.SilverCoin, 2);
           Item.NewItem(npc.position, mod.ItemType("shale"));
           Item.NewItem(npc.position, mod.ItemType("buildgrist"));
       }
     }
}
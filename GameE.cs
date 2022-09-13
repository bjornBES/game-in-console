using game_in_console.crafting;
using game_in_console.Shoping;
using game_in_console.NPC.Name;
using game_in_console.dun;
using game_in_console.dun.enemys;
using game_in_console.data.items;
using game_in_console;
using game_in_console.otherSystem;
using game_in_console.enums;
namespace GameEMain
{

    #region enum
    public enum city
    {
        Strombard,
        ironmake,
        firestromb,
        the_roads
    }
    public enum ShopOp
    {
        none,
        WCIB,
        GO,
        buy,
        wcidih,
        help
    }
    public enum CraftOp
    {
        none,
        GO,
        craft,
        wcic,
        help
    }
    #endregion
    public class GameE
    {
        public string TownMap { get; } =
          @"    Shop             Craft                          " + "\n" +
           " ___________      ___________                       " + "\n" +
          @"/###########\    /###########\                      " + "\n" +
           "|###########|    |###########|                      " + "\n" +
           "|#####()####|    |#####()####|                      " + "\n" +
           "____________________________________________________" + "\n" +
           "____________________________________________________" + "\n" +
           "____________________________________________________" + "\n";
        public string WorldMap { get; } =
          @"Strombard   IronMake  Firestromb " + "\n" +
           "######    ####          ##       " + "\n" +
           "#####    ####          ###       " + "\n" +
           "####     ////       ////         " + "\n" +
          @"\\\\    ////       ////          " + "\n" +
          @" \\\\|||||||||||\////            " + "\n" +
          @"  \\||||||||||\\\\               " + "\n" +
          @" the wild   \\\\_____            " + "\n";
        public int password { get; } = 3479;
        public Converter converter;
        public Player Player;
        public Dun Dun;
        public CraftItems craft;
        public gear gear;
        public shop Shop { get; set; }
        public NPCNames NPCNames { get; set; }
        public OtherSystem mine { get; set; }
        public items[] Taple { get; } = { items.none, items.stick, items.stone, items.ironore, items.flint, items.coal, items.IronSword};
        public int[] Con { get; } = { 0, 2, 3, 2, 2, 2, 1 };
        public int[] cost { get; } = { 0, 10, 15, 20, 10, 15, 100 };
        public int[] Chance { get; } = { 0, 25, 20, 15, 25, 20, 10};
        public void Start()
        {
            #region Get Stuff
            //converter
            converter = new Converter();
            //player
            Player = new Player();
            //npc
            NPCNames = new NPCNames();
            NPCNames.player = Player;
            //craft
            craft = new CraftItems();
            craft.C_Player = Player;
            //shop
            Shop = new shop();
            Shop.S_player = Player;
            Shop.S_NPC = NPCNames;
            //dun
            Dun = new Dun();
            Dun.player = Player;
            Dun.nPCNames = NPCNames;
            //mine
            mine = new OtherSystem();
            mine.player = Player;
            //gear
            gear = new gear();
            gear.Player = Player;
            #endregion
        }
    }
}

using game_in_console.crafting;
using game_in_console.Shoping;
using game_in_console.NPC.Name;
using game_in_console.dun;
using game_in_console.dun.enemys;
using game_in_console;
using game_in_console.map;
namespace GameEMain
{
    #region enum
    public enum items
    {
        none,
        stone,
        flint,
        ironore,
        ironIngot,
        coal,
        stick,

        Ironsword,
        Ironaxe,
        woodenSword,
        woodenAxe,
    }
    public enum itemType
    {
        craft,
        combat,
    }
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
    #endregion
    public class GameE
    {
        public string TownMap =
          @"    Shop             Craft                          " + "\n" +
           " ___________      ___________                       " + "\n" +
          @"/###########\    /###########\                      " + "\n" +
           "|###########|    |###########|                      " + "\n" +
           "|#####()####|    |#####()####|                      " + "\n" +
           "____________________________________________________" + "\n" +
           "____________________________________________________" + "\n" +
           "____________________________________________________" + "\n";
        public string WorldMap =
          @"Strombard   IronMake  Firestromb " + "\n" +
           "######    ####          ##       " + "\n" +
           "#####    ####          ###       " + "\n" +
           "####     ////       ////         " + "\n" +
          @"\\\\    ////       ////          " + "\n" +
          @" \\\\|||||||||||\////            " + "\n" +
          @"  \\||||||||||\\\\               " + "\n" +
          @" the wild   \\\\_____            " + "\n";
        public int password = 3479;
        public Player Player;
        public Dun Dun;
        public item item;
        public CraftItems craft;
        public shop Shop { get; set; }
        public NPCNames NPCNames { get; set; }
        public Level1 Level1;
        public items[] Taple = { items.none, items.stick, items.stone, items.ironore, items.flint };
        public int[] Con = { 0, 2, 3, 2, 2 };
        public int[] cost = { 0, 10, 15, 20, 10 };
        public void Start()
        {
            #region Get Stuff
            //level1
            Level1 = new Level1();
            //npc
            NPCNames = new NPCNames();
            //player
            Player = new Player();
            Player.P_Start();
            //craft
            craft = new CraftItems();
            craft.C_Player = Player;
            //shop
            Shop = new shop();
            Shop.S_player = Player;
            Shop.S_NPC = NPCNames;
            //item
            item = new item();
            //dun
            Dun = new Dun();
            #endregion
        }
    }
}

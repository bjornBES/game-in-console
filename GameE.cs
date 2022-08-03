using game_in_console.crafting;
using game_in_console.Shoping;
using game_in_console.NPC.Name;
using game_in_console.dun;
using game_in_console.dun.enemys;
using game_in_console;
using game_in_console.map;
namespace GameEMain
{
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
        #region enum
        public enum items
        {
            stone,
            flint,
            ironbar,
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
        public enum startOp
        {
            none,
            StartDun,//SD
            Run,
            How_many_coins_go_i_have, //hmcgih coins
            Shop, //shop
            Inv, //inv
            Craft, //craft
            WorldMap,
            TownMap,
        }
        #endregion
        public Player Player;
        public Dun Dun;
        public item item;
        public CraftItems craft;
        public shop Shop;
        public NPCNames NPCNames;
        public Level1 Level1;
        public string[] Taple = { "em", "Sticks", "Stones", "irons", "flints" };
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
            Player.Start();
            //craft
            craft = new CraftItems();
            craft.Start();
            craft.Player = Player;
            //shop
            Shop = new shop();
            Shop.Player = Player;
            Shop.NPCNames = NPCNames;
            //item
            item = new item();
            //dun
            Dun = new Dun();
            #endregion
        }
    }
}

using game_in_console.crafting;
using game_in_console.Shoping;
using game_in_console.NPC.Name;
using game_in_console.dun;
using game_in_console.dun.enemys;
using game_in_console.data.items;
using game_in_console;
using game_in_console.otherSystem;
using game_in_console.enums;
using game_in_console.player;
namespace GameEMain
{
    public static class GameE
    {
        public static string TownMap { get; } =
          @"    Shop             Craft                          " + "\n" +
           " ___________      ___________                       " + "\n" +
          @"/###########\    /###########\                      " + "\n" +
           "|###########|    |###########|                      " + "\n" +
           "|#####()####|    |#####()####|                      " + "\n" +
           "____________________________________________________" + "\n" +
           "____________________________________________________" + "\n" +
           "____________________________________________________" + "\n";
        public static string WorldMap { get; } =
          @"Strombard   IronMake  Firestromb " + "\n" +
           "######    ####          ##       " + "\n" +
           "#####    ####          ###       " + "\n" +
           "####     ////       ////         " + "\n" +
          @"\\\\    ////       ////          " + "\n" +
          @" \\\\|||||||||||\////            " + "\n" +
          @"  \\||||||||||\\\\               " + "\n" +
          @" the wild   \\\\_____            " + "\n";
        public static int Password { get; } = 3479;
        public static Converter converter;
        public static Player Player = new Player();
        public static Dun Dun;
        public static CraftItems craft;
        public static Gear gear;
        public static CraftMeun CraftMeun;
        public static Shop Shop;
        public static OtherSystem OtherSystem;
        public static void Start()
        {
            #region Get Stuff
            //converter
            converter = new Converter();
            //gear
            gear = new Gear{
                Player = Player
            };
            //player
            Player.gear = gear;
            Player.SetPLayerD();
            CraftMeun = new CraftMeun
            {

            };
            //craft
            craft = new CraftItems{
                C_Player = Player
            };
            //shop
            Shop = new Shop{
                S_player = Player,
            };
            //dun
            Dun = new Dun{
                player = Player,
            };
            //mine
            OtherSystem = new OtherSystem {
                player = Player,
            };
            #endregion
        }
    }
}

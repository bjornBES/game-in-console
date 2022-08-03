using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_in_console.map
{
    public class Level1
    {
        public string DunRoomMap1 = " ";
        public string DunRoomMap2 = " ";
        public string DunRoomMap3 = " ";
        public string DunRoomMap4 = " ";
        public string DunRoomMap5 = " ";
    }
    public class Map
    {
        public string TownMap = "";
        public string WorldMap = "";
        public Level1 Level1 = new Level1();
        public void Start()
        {
            TownMap =
          @"    Shop             Craft                          " + "\n" +
           " ___________      ___________                       " + "\n" +
          @"/###########\    /###########\                      " + "\n" +
           "|###########|    |###########|                      " + "\n" +
           "|#####()####|    |#####()####|                      " + "\n" +
           "____________________________________________________" + "\n" +
           "____________________________________________________" + "\n" +
           "____________________________________________________" + "\n";
            WorldMap =
          @"Strombard   IronMake  Firestromb " + "\n" +
           "######    ####          ##       " + "\n" +
           "#####    ####          ###       " + "\n" +
           "####     ////       ////         " + "\n" +
          @"\\\\    ////       ////          " + "\n" +
          @" \\\\|||||||||||\////            " + "\n" +
          @"  \\||||||||||\\\\               " + "\n" +
          @" the wild   \\\\_____            " + "\n";;
        }
    }
}

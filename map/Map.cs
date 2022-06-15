using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_in_console.map
{
    public class Map
    {
        public string[] TownMap = new string[8];
        public int TownIndex;
        public string[] WorldMap = new string[8];
        public string DunMap;
        public void Start()
        {
            TownMap[TownIndex] = @"    Shop             Craft    ";
            TownIndex++;
            TownMap[TownIndex] = @" ___________      ___________ ";
            TownIndex++;
            TownMap[TownIndex] = @"/           \    /           \";
            TownIndex++;
            TownMap[TownIndex] = @"|           |    |           |";
            TownIndex++;
            TownMap[TownIndex] = @"|           |    |           |";
            TownIndex++;
            TownMap[TownIndex] = @"____________________________________________________";
            TownIndex++;
            TownMap[TownIndex] = @"____________________________________________________";
            TownIndex++;
            TownMap[TownIndex] = @"____________________________________________________";
            WorldMap[0] = @"Strombard       Firestromb";
            WorldMap[1] = @"######         ##";
            WorldMap[2] = @"#####          ###";
            WorldMap[3] = @"####          ////";
            WorldMap[4] = @"\\\\         ////";
            WorldMap[5] = @" \\\\||||||\////";
            WorldMap[6] = @"  \\|||||||\\\\";
            WorldMap[7] = @" the wild   \\\\";
        }
    }
}

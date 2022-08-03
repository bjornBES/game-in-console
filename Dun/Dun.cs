using System;
using System.Collections.Generic;
using System.Text;
using game_in_console.dun.enemys;

namespace game_in_console.dun
{
    public class Dun
    {
        Data EnemyData;
        int DunLevel;
        public map.Map Map;

        int Enemylimit = 11;
        int enemyC = 0;
        int min = 0;
        int Max = 6;
        int Rooms = 4;
        /// <summary>
        /// this is the start fun not the start Dun
        /// </summary>
        public void Start()
        {
            GenDun();
            if(DunLevel > 7)
            {
                Enemylimit = Enemylimit + 2;
                Rooms = Rooms + 2;
            }
            switch (DunLevel)
            {
                case 1:
                    Enemylimit = 11;
                    Rooms = 5;
                    break;
                case 2:
                    Enemylimit = 16;
                    Rooms = 7;
                    break;
                case 3:
                    Enemylimit = 21;
                    Rooms = 10;
                    break;
                case 4:
                    Enemylimit = 26;
                    Rooms = 14;
                    break;
                case 5:
                    Enemylimit = 31;
                    Rooms = 17;
                    break;
                case 6:
                    Enemylimit = 38;
                    Rooms = 20;
                    break;
                case 7:
                    Enemylimit = 44;
                    Rooms = 22;
                    break;
            }
        }
        Random random;
        void GenDun()
        {
            string TempDunRoom = "";
            random = new Random();
            for (int s = 0; s < Rooms; s++)
            {
                TempDunRoom = "";
                for (int i = 0; i < 8*8; i++)
                {
                    TempDunRoom =
                    random.Next(min, Max).ToString() +
                    TempDunRoom;
                    if(i == 8 || i == 16 || i == 24 || i == 32 || i == 40 || i == 48 || i == 56 || i == 64)
                    {
                        TempDunRoom = "\r\n" + TempDunRoom;
                    }
                }
                //Console.WriteLine(s + " " + TempDunRoom[i]);
                if (TempDunRoom.Contains('2') ||
                    TempDunRoom.Contains('3'))
                {
                    enemyC++;
                }
                TempDunRoom = TempDunRoom.Replace('0', ' ');//air
                TempDunRoom = TempDunRoom.Replace('1', '#');//tile
                if (enemyC! < Enemylimit)
                {
                    TempDunRoom = TempDunRoom.Replace('2', 'E');//enemy
                    TempDunRoom = TempDunRoom.Replace('3', 'E');//enemy
                }
                else
                {
                    TempDunRoom = TempDunRoom.Replace('2', 'C');//enemy
                    TempDunRoom = TempDunRoom.Replace('3', 'C');//enemy
                }
                TempDunRoom = TempDunRoom.Replace('4', 'X');//tile
                TempDunRoom = TempDunRoom.Replace('5', 'L');//loot
                TempDunRoom = TempDunRoom.Replace('6', 'T');//tarp
                switch (s)
                {
                    case 0:
                        Map.Level1.DunRoomMap1 = TempDunRoom;
                        break;
                    case 1:
                        Map.Level1.DunRoomMap2 = TempDunRoom;
                        break;
                    case 2:
                        Map.Level1.DunRoomMap3 = TempDunRoom;
                        break;
                    case 3:
                        Map.Level1.DunRoomMap4 = TempDunRoom;
                        break;
                    case 4:
                        Map.Level1.DunRoomMap5 = TempDunRoom;
                        break;
                    case 5:
                        break;
                }
            }
        }
    }
}

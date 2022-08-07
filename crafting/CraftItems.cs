using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameEMain;
namespace game_in_console.crafting
{
    [Serializable]
    public class CraftingRe
    {
        public string ItemName1;
        public string ItemName2;
        public string ItemName3;
        public string ItemName4;
        public string ItemName5;
    }
    public class CraftItems
    {
        public CraftingRe Re = new CraftingRe();
        public Player C_Player;
        /// <summary>
        /// this is for the craftSystemDataBase
        /// </summary>
        /// <returns></returns>
        string GetData()
        {
            return File.ReadAllText(@"C:\Users\bjornBEs\Source\Repos\game-in-console\crafting\CraftSystemDataBase.txt");
        }
        string[] TrimAspilt(string Data)
        {
            string S_Data = Data.Replace('#', ' ');
            return S_Data.Split(',', '!', '.', '_');
        }
        int FindItem(string[] A_Data, string item)
        {
            int Re = -1;
            for (int i = 0; i < A_Data.Length; i++)
            {
                if (item == A_Data[i])
                {
                    Re = i;
                }
            }
            return Re;
        }
        public void Craft(string Item)
        {
            string[] craftRes = TrimAspilt(GetData());
            //make a crafting system 
            for (int c = 0; c < craftRes.Length; c++)
            {
                if(c == 0)
                    Console.WriteLine("system finding item form database " + c);
                if ("Stone pickaxe" == Item || "SP" == Item || "sp" == Item)
                {
                    Console.WriteLine("system Get Item form database " + c);
                    for (int s = 0; s < C_Player.InvIndex; s++)
                    {
                        for (int a = 0; a < C_Player.InvIndex; a++)
                        {
                            if (C_Player.inv[s] == items.stone && C_Player.inv[a] == items.stick)
                            {
                                Console.WriteLine("Inv item ok");
                                int Re = 0;
                                if(C_Player.invCon[s] >= 3)
                                {
                                    C_Player.invCon[s] -= 3;
                                    Re++;
                                }
                                if(C_Player.invCon[a] >= 2)
                                {
                                    C_Player.invCon[a] -= 3;
                                    Re++;
                                }
                                if(Re == 2)
                                {
                                    Console.WriteLine("good " + Re);

                                }
                            }
                            else
                            {
                                Bug.MessBug("01010", Bugs.shop);
                            }
                        }
                    }
                    //SP
                }
                else
                {
                    Bug.MessBug("01001", Bugs.shop);
                }
            }
        }
    }
}

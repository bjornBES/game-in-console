using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        string res;
        public CraftingRe Re = new CraftingRe();
        public Player Player;
        public void Start()
        {
            Player = new Player();
            Re = new CraftingRe();
        }
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
                if(item == A_Data[i])
                {
                    Re = i;
                }
            }
            return Re;
        }
        public void Craft(string Item)
        {
            string[] craftRes = TrimAspilt(GetData());
            if (FindItem(craftRes, Item) == -1)
                Bug.MessBug(01023, Bugs.shop);
            //make a crafting system 
            for (int i = 0; i < Player.InvIndex; i++)
            {
                int II = i + 1;

            }
        }
    }
}

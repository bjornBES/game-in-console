using System;
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
    public class Re
    {
        public string result;
        public CraftingRe craftingRe = new CraftingRe();
    }
    public class CraftItems
    {
        Re[] Re;
        int CraftReIndex = 2;
        Mat mat;
        public Player Player;
        public string CraftintItems = "Stone pickaxe for 3 Stones and 2 Sticks";
        public void Start()
        {
            Player = new Player();
            Re = new Re[CraftReIndex];
        }
        public void Craft(string Item)
        {
            Re[0].craftingRe.ItemName1 = "3 Stones";
            Re[0].craftingRe.ItemName2 = "2 Sticks";
            //make a crafting system 
            for (int i = 0; i < Player.InvIndex; i++)
            {
                int II = i + 1;
                if(Item == "SP")
                {
                    if(Re[0].craftingRe.ItemName1 == Player.inv[i] + " " + Player.invCon[i] &&
                        Re[0].craftingRe.ItemName2 == Player.inv[II] + " " + Player.invCon[II])
                    {
                        if (Player.invCon[i] == 0)
                        {
                            Player.inv[i] = "";
                            Player.invCon[i] = Player.invCon[i] - 3;
                            Player.inv[i] = "SP";
                            Player.invCon[i] = 1;
                        }
                        if (Player.invCon[II] == 0)
                        {
                            Player.inv[II] = "";
                            Player.invCon[II] = Player.invCon[II] - 2;
                            if (Player.inv[i] != "SP")
                            {
                                Player.inv[II] = "SP";
                                Player.invCon[II] = 1;
                            }
                        }
                    }
                    if (Re[0].craftingRe.ItemName2 == Player.inv[i] + " " + Player.invCon[i] &&
                        Re[0].craftingRe.ItemName1 == Player.inv[II] + " " + Player.invCon[II])
                    {
                        if (Player.invCon[II] == 0)
                        {
                            Player.inv[II] = "";
                            Player.invCon[II] = Player.invCon[II] - 3;
                            if(Player.inv[i] != "SP")
                            {
                                Player.inv[II] = "SP";
                                Player.invCon[II] = 1;
                            }
                        }
                        if (Player.invCon[i] == 0)
                        {
                            Player.inv[i] = "";
                            Player.invCon[i] = Player.invCon[i] - 2;
                            Player.inv[i] = "SP";
                            Player.invCon[i] = 1;
                        }
                    }
                }
            }
        }
    }
}

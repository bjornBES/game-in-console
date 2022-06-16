using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game_in_console.items;

namespace game_in_console.crafting
{
    [Serializable]
    public class CraftingRe
    {
        public string Slot1ItemName;
        public string Slot2ItemName;
        public string Slot3ItemName;
        public string Slot4ItemName;
        public string Slot5ItemName;
    }
    public class CraftItems
    {
        int SlotItemNameIndex = 2;
        public string[] Slot1ItemName;
        public string[] Slot2ItemName;
        public string[] Slot3ItemName;
        public string[] Slot4ItemName;
        public string[] Slot5ItemName;
        Mat mat;
        public Player Player;
        public string CraftintItems = "Stone pickaxe for 3 Stones and 2 Sticks";
        public void Start()
        {
            Slot1ItemName = new string[SlotItemNameIndex];
            Slot2ItemName = new string[SlotItemNameIndex];
            Slot3ItemName = new string[SlotItemNameIndex];
            Slot4ItemName = new string[SlotItemNameIndex];
            Slot5ItemName = new string[SlotItemNameIndex];
            mat = new Mat();
            Slot1ItemName[0] = "Stones";
            Slot2ItemName[0] = "Sticks";
        }
        public void Craft(string Item)
        {
            if(Item == "SP" || Item == "StonePickaxe" || Item == "stonepickaxe")
            {
                for (int i = 0; i < Player.InvIndex; i++)
                {
                    int II = i + 1;
                    int IIM = i - 1;
                    if(Player.inv[II] == Slot1ItemName[0] && Player.inv[i] == Slot2ItemName[0] ||
                        Player.inv[i] == Slot1ItemName[0] && Player.inv[II] == Slot2ItemName[0])
                    {
                        if(Player.invCon[i] >= 2 && Player.invCon[II] >= 3 ||
                            Player.invCon[i] >= 3 && Player.invCon[II] >= 2)
                        {
                            if (Player.inv[i] == "Stones")
                            {
                                Player.invCon[i] -= 3;
                            }
                            else if (Player.inv[i] == "Sticks")
                            {
                                Player.invCon[i] -= 2;
                            }
                            Player.inv[i] = "";
                            if (i != 0)
                            {
                                if (Player.inv[IIM] == "Stones")
                                {
                                    Player.invCon[IIM] -= 3;
                                }
                                else if(Player.inv[IIM] == "Sticks")
                                {
                                    Player.invCon[IIM] -= 2;
                                }
                                Player.inv[IIM] = "";
                            }
                            else
                            {
                                if (Player.inv[II] == "Stones")
                                {
                                    Player.invCon[II] -= 3;
                                }
                                else if (Player.inv[II] == "Sticks")
                                {
                                    Player.invCon[II] -= 2;
                                }
                                Player.inv[II] = "";
                            }
                            int III = i + 2;
                            if (Player.invCon[i] == 0)
                            {
                                Player.invCon[i] = 1;
                                Player.inv[i] = "StonePickaxe";
                            }
                            else if (Player.invCon[II] == 0)
                            {
                                Player.invCon[II] = 1;
                                Player.inv[II] = "StonePickaxe";
                            }
                            else if(Player.invCon[IIM] == 0)
                            {
                                Player.invCon[IIM] = 1;
                                Player.inv[IIM] = "StonePickaxe";
                            }
                            else if (Player.invCon[III] == 0)
                            {
                                Player.invCon[III] = 1;
                                Player.inv[III] = "StonePickaxe";
                            }
                        }
                    }
                }
            }
        }
    }
}

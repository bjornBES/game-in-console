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
        public int Slot1ItemID;
        public int Slot2ItemID;
        public int Slot3ItemID;
        public int Slot4ItemID;
        public int Slot5ItemID;
        public int Slot6ItemID;
        public int Slot7ItemID;
        public int Slot8ItemID;
        public int Slot9ItemID;
    }
    public class CraftItems
    {
        CraftingRe[] CraftingRe;
        Mat mat;
        public void Start()
        {
            mat = new Mat();
            CraftingRe = new CraftingRe[2];
            CraftingRe[0].Slot1ItemID = 1;
            CraftingRe[0].Slot2ItemID = 1;
            CraftingRe[0].Slot3ItemID = 1;
            CraftingRe[0].Slot5ItemID = 3;
            CraftingRe[0].Slot8ItemID = 3;
        }
    }
}

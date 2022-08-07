using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameEMain;
namespace game_in_console
{
    public class Player : GameE
    {
        public bool IsDun;
        public items[] inv;
        public int[] invCon;
        public int InvIndex = 0;
        public int SpaceInInv = 50;
        public int coins = 50;
        public void P_Start()
        {
            inv = new items[SpaceInInv];
            for (int i = 0; i < inv.Length; i++)
            {
                inv[i] = items.none;
            }
            invCon = new int[SpaceInInv];
        }
        public void StartDun()
        {
            IsDun = true;
        }
        public void EndDun()
        {
            IsDun = false;
        }
    }
}

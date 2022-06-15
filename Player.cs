using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game_in_console.enums;

namespace game_in_console
{
    public class Player
    {
        public bool ToXTo;
        public bool IsDun;
        public string[] inv;
        public int[] invCon;
        public int InvIndex = 0;
        public float x, y;
        public int SpaceInInv = 50;
        public int coins = 50;
        public void Start()
        {
            inv = new string[SpaceInInv];
            invCon = new int[SpaceInInv];
        }
        public float GetX()
        {
            return x;
        }
        public float GetY()
        {
            return y;
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

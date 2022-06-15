using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game_in_console.items.all;
namespace game_in_console.enums
{
    public enum items
    {
        stone,
        flint,
        ironbar,
        ironIngot,
        coal,
        stick,

        Ironsword,
        Ironaxe,
        woodenSword,
        woodenAxe,
    }
}
namespace game_in_console
{
    [Serializable]
    public class Mat
    {
        public Stone Stone;
        public Flint Flint;
        public Stick Stick;
    }
    public class item
    {
        float matID = 50;
        float WeID = 100;
        public Mat mat;
        public void start()
        {
            mat = new Mat();
            mat.Stone = new Stone();
            mat.Flint = new Flint();
            mat.Stick = new Stick();
        }
        public float GetItemDPS(int ID)
        {
            float DPS = 0;
            if (mat.Stone.ID == ID)
                DPS = mat.Stone.DPS;
            if (mat.Stick.ID == ID)
                DPS = mat.Stick.DPS;
            return DPS;
        }
    }
}

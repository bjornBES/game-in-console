using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    public enum itemType
    {
        craft,
        combat,
    }
}
namespace game_in_console
{
    //.SO file ItemInfo Start-
    //string ItemName
    //int ItemID
    //bool[] itemtype(1+)
    //mat, we, 
    //if item == mat 
    //
    [Serializable]
    public class Mat
    {
        public string Name;
        public int ID;
        public float DPS;
        public float Dy;
        public enums.itemType type;
    }
    public class item
    {
        float matID = 50;
        float WeID = 100;
        public Mat[] mat = new Mat[3];
        int MatIndex;
        public void start()
        {
        }
        public void SetMatItems()
        {
            #region ID 1-10
            mat[MatIndex].Name = "Stick";
            mat[MatIndex].ID = 1;
            mat[MatIndex].type = enums.itemType.craft;
            mat[MatIndex].Name = "flint";
            mat[MatIndex].ID = 2;
            mat[MatIndex].type = enums.itemType.craft;
            mat[MatIndex].Name = "stone";
            mat[MatIndex].ID = 3;
            mat[MatIndex].type = enums.itemType.craft;
            mat[MatIndex].Name = "ironore";
            mat[MatIndex].ID = 4;
            mat[MatIndex].type = enums.itemType.craft;
            mat[MatIndex].Name = "ironIngot";
            mat[MatIndex].ID = 5;
            mat[MatIndex].type = enums.itemType.craft;
            mat[MatIndex].Name = "coal";
            mat[MatIndex].ID = 6;
            mat[MatIndex].type = enums.itemType.craft;
            #endregion
        }
        public float GetItemDPS(int ID)
        {
            float DPS = 0;

            return DPS;
        }
    }
}

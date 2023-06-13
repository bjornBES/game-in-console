using System;
using System.Collections.Generic;
using System.Text;
using game_in_console.Shoping;
using game_in_console.NPC.Name;
using game_in_console.dun;
using game_in_console.dun.enemys;
using game_in_console.data.items;
using game_in_console;
using game_in_console.otherSystem;
using game_in_console.enums;
using game_in_console.player;

namespace game_in_console.LootTable
{
    public class ShopTableTemp
    {
        public Items Item;
        public int Con;
        public int Cost;
        public int Chance;
    }
    public static class Tables
    {
        public static ShopTableTemp[] shopTableTemps;
        public static void Start()
        {
            //Items.stone, Items.ironore, Items.flint, Items.coal, Items.IronSword
            //3, 2, 2, 2, 1
            //15, 20, 10, 15, 100
            //20, 15, 25, 20, 10
            shopTableTemps = new ShopTableTemp[6];
            int index = 0;
            shopTableTemps[index] = new ShopTableTemp
            {
                Item = Items.none,
                Con = 0,
                Cost = 0,
                Chance = 0
            };
            index++;
            shopTableTemps[index] = new ShopTableTemp
            {
                Item = Items.stick,
                Con = 2,
                Cost = 10,
                Chance = 25
            };
            index++;
            shopTableTemps[index] = new ShopTableTemp
            {
                Item = Items.none,
                Con = 0,
                Cost = 0,
                Chance = 0
            };
            index++;
            shopTableTemps[index] = new ShopTableTemp
            {
                Item = Items.none,
                Con = 0,
                Cost = 0,
                Chance = 0
            };
            index++;
            shopTableTemps[index] = new ShopTableTemp
            {
                Item = Items.none,
                Con = 0,
                Cost = 0,
                Chance = 0
            };
            index++;
            shopTableTemps[index] = new ShopTableTemp
            {
                Item = Items.none,
                Con = 0,
                Cost = 0,
                Chance = 0
            };
            index++;
            shopTableTemps[index] = new ShopTableTemp
            {
                Item = Items.none,
                Con = 0,
                Cost = 0,
                Chance = 0
            };
        }
    }
}

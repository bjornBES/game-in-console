using System;
using game_in_console.crafting;
using game_in_console.Shoping;
using game_in_console.NPC.Name;
using game_in_console.dun;
using game_in_console.dun.enemys;
using GameEMain;
using game_in_console.otherSystem;
using game_in_console.enums;

namespace game_in_console
{
    public class Converter
    {
        public startOp UserToStartOp(string user)
        {
            startOp Re = startOp.none;
            switch (user)
            {
                case "Help":
                    Re = startOp.help;
                    break;
                case "help":
                    Re = startOp.help;
                    break;
                case "StartDun":
                    Re = startOp.StartDun;
                    break;
                case "Run":
                    Re = startOp.Run;
                    break;
                case "How many coins go i have":
                    Re = startOp.How_many_coins_go_i_have;
                    break;
                case "hmcgih":
                    Re = startOp.How_many_coins_go_i_have;
                    break;
                case "coins":
                    Re = startOp.How_many_coins_go_i_have;
                    break;
                case "Shop":
                    Re = startOp.Shop;
                    break;
                case "shop":
                    Re = startOp.Shop;
                    break;
                case "Inv":
                    Re = startOp.Inv;
                    break;
                case "inv":
                    Re = startOp.Inv;
                    break;
                case "mine":
                    Re = startOp.mine;
                    break;
                case "Craft":
                    Re = startOp.Craft;
                    break;
                case "craft":
                    Re = startOp.Craft;
                    break;
                case "WorldMap":
                    Re = startOp.WorldMap;
                    break;
                case "TownMap":
                    Re = startOp.TownMap;
                    break;
                case "WM":
                    Re = startOp.WorldMap;
                    break;
                case "TM":
                    Re = startOp.TownMap;
                    break;
                case "wm":
                    Re = startOp.WorldMap;
                    break;
                case "tm":
                    Re = startOp.TownMap;
                    break;
                case "speed":
                    Re = startOp.speed;
                    break;
            }
            return Re;
        }
        public CraftOp UserToCraftOp(string user)
        {
            CraftOp Re = CraftOp.none;
            switch (user)
            {
                case "Help":
                    Re = CraftOp.help;
                    break;
                case "help":
                    Re = CraftOp.help;
                    break;
                case "what can i craft":
                    Re = CraftOp.wcic;
                    break;
                case "wcic":
                    Re = CraftOp.wcic;
                    break;
                case "WCIC":
                    Re = CraftOp.wcic;
                    break;
                case "goout":
                    Re = CraftOp.GO;
                    break;
                case "GoOut":
                    Re = CraftOp.GO;
                    break;
                case "GO":
                    Re = CraftOp.GO;
                    break;
                case "Craft":
                    Re = CraftOp.craft;
                    break;
                case "craft":
                    Re = CraftOp.craft;
                    break;
            }
            return Re;
        }
    }
}

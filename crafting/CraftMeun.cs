using System;
using System.Collections.Generic;
using System.Text;
using game_in_console.crafting;
using GameEMain;
using game_in_console.Shoping;
using game_in_console.NPC.Name;
using game_in_console.dun;
using game_in_console.dun.enemys;
using game_in_console.data.items;
using game_in_console;
using game_in_console.otherSystem;
using game_in_console.enums;
using game_in_console.player;

namespace game_in_console.crafting
{
    public class CraftMeun
    {
        bool EnC = false;
        public void Craft(bool Start)
        {
            if (EnC == false)
            {
                Console.WriteLine(@"what to do say ""help"" and get help");
                EnC = true;
            }
            string Help = @"";
            string WCIC = "\r\n";
            string UserCraft = Console.ReadLine();
            switch (GameE.converter.StringToEnum(UserCraft, typeof(CraftOp)))
            {
                case CraftOp.none:
                    break;
                case CraftOp.GO:
                    Console.WriteLine("exit craft menu");
                    EnC = false;
                    break;
                case CraftOp.craft:
                    Console.WriteLine("what to craft");
                    string HTC = Console.ReadLine();
                    GameE.craft.Craft(HTC);
                    break;
                case CraftOp.wcic:
                    //1. for loop player inventory
                    for (int i = 0; i < GameE.Player.InvIndex; i++)
                    {
                        string[] Re = new string[100];
                        int index = 0;
                        Items Item = GameE.Player.Inv[i];
                        switch (Item)
                        {
                            case Items.stone:
                                Re[index] = "furnace";
                                index++;
                                Re[index] = "stone tools";
                                break;
                            case Items.ironore:
                                Re[index] = "steel";
                                index++;
                                Re[index] = "iron";
                                index++;
                                Re[index] = "iron2";
                                break;
                            case Items.coal:
                                Re[index] = "torch";
                                break;
                            case Items.Wood:
                                Re[index] = "sticks";
                                break;
                            case Items.Piece_of_wood:
                                Re[index] = "wood";
                                index++;
                                Re[index] = "stick";
                                break;
                            case Items.tinore:
                                Re[index] = "bronzen";
                                break;
                            case Items.stick:
                                Re[index] = "all tools";
                                index++;
                                Re[index] = "wood";
                                break;
                            case Items.iron_block:
                                Re[index] = "anvil";
                                break;
                            case Items.ironIngot:
                                Re[index] = "iron block";
                                index++;
                                Re[index] = "iron tools";
                                index++;
                                Re[index] = "steel";
                                index++;
                                Re[index] = "iron armor";
                                break;
                            case Items.steel:
                                Re[index] = "steel tools";
                                index++;
                                Re[index] = "steel armor";
                                break;
                            case Items.bronze:
                                Re[index] = "bronze tools";
                                index++;
                                Re[index] = "bronze armor";
                                break;
                            case Items.lava_bukkit:
                                Re[index] = "steel";
                                break;
                            default:
                                break;
                        }
                    }
                    //2. see what items is in there
                    //3. print
                    Console.WriteLine("for loop test");
                    break;
                case CraftOp.help:
                    Console.WriteLine("what do you need help with?");
                    Console.WriteLine("the over all crafting system (system)");
                    Console.WriteLine("how do i craft stuff (craft)");
                    string user = Console.ReadLine();
                    switch (GameE.converter.StringToEnum(user, typeof(CraftHelpOp)))
                    {
                        case CraftHelpOp.none:
                            break;
                        case CraftHelpOp.systemHelp:
                            SystemHelp();
                            break;
                        case CraftHelpOp.craftHelp:
                            CraftHelp();
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            if (EnC == true)
                Craft(Start);
        }
        public void SystemHelp()
        {
            Console.WriteLine("the crafting system is in a ranks called crafting stations \r\n" +
                              "there is 5 ranks in the system there is...\r\n" +
                              "wood working,\r\n" +
                              "stone working,\r\n" +
                              "smlting station,\r\n" +
                              "alloy smelt and the \r\n" +
                              "anvil\r\n" +
                              "you need to craft or make items/stations for example,\r\n" +
                              "to get the stone works you need to get a stone,\r\n" +
                              "to get the smelting station you need to get a furnace,\r\n" +
                              "to get the alloys smelt you need 2 bronze and\r\n" +
                              "to get the anvil you need an... anvil");
        }
        public void CraftHelp()
        {
            Console.WriteLine("you can say (craft) in the crafting meun and you make a item \r\n" +
                              "if you need to see what you can make say (WCIC(what can i craft))\r\n" +
                              "and there will come a list of item you can make with the items in your inventory like this\r\n" +
                              "with the stone works(UL) stone pickaxe for 3 stone and 2 sticks,\r\n" +
                              "with the stone works(UL) furnace for 8 stone(you have this item in your inventory) and\r\n" +
                              "with the alloys smelt(NUL) steel for 2 iron ore, 4 coal and 1 lava bukkit \r\n" +
                              "The (with the stone works) that is the crafting station you need\r\n" +
                              "the (UL) is the crafting stations you have,\r\n" +
                              "the (NUL) is the crafting stations you do not have\r\n" +
                              "and the (you have this in your inventory) is what you have in your inventory");
        }
    }
}

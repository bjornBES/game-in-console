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
    /*
                 if(PlayerName == "by engine develop")
            {
                Console.WriteLine("Ok here we go........");
                Console.ReadKey();
                Console.WriteLine("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
                Console.WriteLine("full releas coming in 2022");
                Console.ReadKey();
                Console.WriteLine("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
                Console.ReadKey();
                Console.WriteLine("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
                Console.ReadKey();
                Console.WriteLine("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
                Console.Clear();
                Console.WriteLine("...");
                Console.ReadKey();
                int Time = 1000000000;
                do
                {
                    Time--;
                } while (Time != 0);
                Console.WriteLine("high graphics?");
                Console.ReadKey();
                Time = 1000000000;
                do
                {
                    Time--;
                } while (Time != 0);
                Console.WriteLine("?");
                Console.ReadKey();
                Console.WriteLine("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
                Console.WriteLine("explore dungeons with enemy");
                Console.WriteLine("and find the wild");
                Console.ReadKey();
                Time = 50;
                do
                {
                    Time--;
                    Console.WriteLine("\r\n");
                } while (Time != 0);
                Console.Clear();
                Console.WriteLine("are you up to the challenage");
                Console.WriteLine("download it now on engine.develop.itch.io/game-in-console");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("download it now we need the money :D");
                Console.ReadKey();
                Console.Clear();
            }
     */
    public class Program : GameE
    {
        string PlayerName;
        static void Main()
        {
            Console.WriteLine("Hello you there what is your name?");
            //Console.WriteLine("who maked this? start with a by and a name ilke this...");
            Console.Title = "Game in a console";
            Program program = new Program(); 
            program.PStart();
        }
        public void PStart()
        {
            PlayerName = Console.ReadLine();
            if(PlayerName == "the wild" || PlayerName == "The Wild" || PlayerName == "wild")
            {
                Console.WriteLine("you can no longer hear the voice");
                Console.WriteLine("unknown voice:" + "YOU!");
                Console.WriteLine("unknown voice:" + "how are you");
                Console.WriteLine("you:" + "what is that?");
                Console.WriteLine("unknown voice:" + "you have now been banished form this place");
                Console.WriteLine("another unknown voice:" + "ok then i WILL find the human my self");
                Console.WriteLine("unknown voice:" + "HAHA... i will see forward to that moment and i will kill you both if i need to");
                Console.WriteLine("unknown voice:" + "MY SELF!!");
            }
            Start();
            if (PlayerName == "devB" || PlayerName == "BEsBB")
                new Dev(Player, Password, PlayerName);
            if (PlayerName != "skipto" || PlayerName == "devB" || PlayerName == "BEsBB")
                To();
            Update();
        }
        void To()
        {
            NPCNames.PlayerName = PlayerName;
            if (settings.Settings.Dev == false)
            {
                NPCNames.BolvarDialog(0);
                NPCNames.BolvarDialog(1);
            }
            Console.WriteLine("there is a thing coming your way");
            Console.WriteLine(NPCNames.PlayerHelperName + ": hello " + NPCNames.PlayerName + " im "+ NPCNames.PlayerHelperName + " and i am here to help you just say help to me if you need help");
        }
        void Update()
        {
            Player.UpdatePlayer();
            if (Console.CapsLock == true)
                Console.WriteLine("Game in a console with CapsLock");
            else
                Console.WriteLine("Game in a console");
            string User = Console.ReadLine();
            if (settings.Settings.DunDev)
                User = "StartDun";
            switch (converter.UserToStartOp(User))
            {
                case StartOp.none:
                    break;
                case StartOp.mine:
                    OtherSystem.Mine(Player.PTools.Pickaxe);
                    break;
                case StartOp.wood:
                    OtherSystem.Wood(Player.PTools.Axe);
                    break;
                case StartOp.StartDun:
                    Dun.D_Start();
                    break;
                case StartOp.Run:
                    break;
                case StartOp.How_many_coins_go_i_have:
                    Console.WriteLine(Player.Coins);
                    break;
                case StartOp.Shop:
                    Shop.ShopStart(true, false);
                    break;
                case StartOp.Inv:
                    Player.GetPlayerInv();
                    break;
                case StartOp.Craft:
                    Craft(true);
                    break;
                case StartOp.WorldMap:
                        Console.WriteLine(WorldMap);
                    break;
                case StartOp.TownMap:
                        Console.WriteLine(TownMap);
                    break;
                case StartOp.speed:
                    if(settings.Settings.Dev)
                    {
                    Console.WriteLine("what speed");
                    Player.SkillsBase.speed = int.Parse(Console.ReadLine());
                    }
                    break;
                case StartOp.help:
                    Console.WriteLine();
                    break;
            }
            Player.UpdatePlayer();
            Update();
        }
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
            switch (converter.UserToCraftOp(UserCraft))
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
                    craft.Craft(HTC);
                    break;
                case CraftOp.wcic:
                    //1. for loop player inventory
                    for (int i = 0; i < Player.InvIndex; i++)
                    {
                        string[] Re = new string[100];
                        Items[] Item1Re = new Items[100];
                        Items[] Item2Re = new Items[100];
                        Items[] Item3Re = new Items[100];
                        int index = 0;
                        Items Item = Player.Inv[i];
                        switch (Item)
                        {
                            case Items.stone:
                                Re[index] = "furnace";
                                index++;
                                Re[index] = "stone tools";
                                index++;
                                break;
                            case Items.ironore:
                                Re[index] = "steel";
                                index++;
                                Re[index] = "iron";
                                index++;
                                Re[index] = "iron2";
                                index++;
                                break;
                            case Items.coal:
                                Re[index] = "torch";
                                index++;
                                break;
                            case Items.Wood:
                                Re[index] = "sticks";
                                index++;
                                break;
                            case Items.Piece_of_wood:
                                Re[index] = "wood";
                                index++;
                                Re[index] = "stick";
                                index++;
                                break;
                            case Items.tinore:
                                Re[index] = "bronzen";
                                index++;
                                break;
                            case Items.stick:
                                Re[index] = "all tools";
                                index++;
                                Re[index] = "wood";
                                index++;
                                break;
                            case Items.iron_block:
                                Re[index] = "anvil";
                                index++;
                                break;
                            case Items.ironIngot:
                                Re[index] = "iron block";
                                index++;
                                Re[index] = "iron tools";
                                index++;
                                Re[index] = "steel";
                                index++;
                                Re[index] = "iron armor";
                                index++;
                                break;
                            case Items.steel:
                                Re[index] = "steel tools";
                                index++;
                                Re[index] = "steel armor";
                                index++;
                                break;
                            case Items.bronze:
                                Re[index] = "bronze tools";
                                index++;
                                Re[index] = "bronze armor";
                                index++;
                                break;
                            case Items.lava_bukkit:
                                Re[index] = "steel";
                                index++;
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
                    switch (converter.UserToHelpCraft(user))
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

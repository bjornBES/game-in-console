using System;
using game_in_console.map;
using game_in_console.crafting;
using game_in_console.Shoping;
using game_in_console.NPC.Name;
using game_in_console.dun;
using game_in_console.dun.enemys;
using GameEMain;
namespace game_in_console
{
    public enum startOp
    {
        none,
        StartDun,//SD
        Run,
        How_many_coins_go_i_have, //hmcgih coins
        Shop, //shop
        Inv, //inv
        Craft, //craft
        WorldMap,
        TownMap,
        help
    }
    class Program : GameE
    {
        
        string PlayerName;
        
        static void Main()
        {
            Console.WriteLine("Hello you there what is your name?");
            Program program = new Program(); 
            program.start();
        }
        void start()
        {
            PlayerName = Console.ReadLine();
            Start();
            if (PlayerName == "devB" || PlayerName == "BEsBB")
            {
                Console.WriteLine("Password hint its not 1234 or y4");
                string Number = Console.ReadLine();
                if (Number == password.ToString() || Number == "debug" || Number == "db")
                {
                    Player.InvIndex++;
                    Player.inv[0] = items.stick;
                    Player.invCon[0] = 999;
                    Player.InvIndex++;
                    Player.inv[0] = items.stone;
                    Player.invCon[0] = 999;
                    Player.InvIndex++;
                    Player.inv[0] = items.ironIngot;
                    Player.invCon[0] = 999;
                    Player.InvIndex++;
                    Player.inv[0] = items.ironore;
                    Player.invCon[0] = 999;
                }
                else
                {
                    Bug.MessBug("196813785696849373228402159147087096127008678178", Bugs.Dev);
                    PlayerName = "Not devB or not BEsBB";
                }
            }
            if (PlayerName != "skipto")
            {
                To();
            }
            Update();
        }
        void To()
        {
            NPCNames.PlayerName = PlayerName;
            NPCNames._1NPCNameDialog(0);
            NPCNames._1NPCNameDialog(1);
        }
        void Update()
        { 
            string User = Console.ReadLine();
            switch (UserToStartOp(User))
            {
                case startOp.none:
                    break;
                case startOp.StartDun:
                    isDun(true);
                    break;
                case startOp.Run:
                    isDun(false);
                    break;
                case startOp.How_many_coins_go_i_have:
                    Console.WriteLine(Player.coins);
                    break;
                case startOp.Shop:
                    Shop.S_Shop(true, true, false);
                    break;
                case startOp.Inv:
                    Console.WriteLine("you have");
                    for (int i = 0; i < Player.InvIndex; i++)
                    {
                        Console.WriteLine(Player.invCon[i].ToString() + " " + Player.inv[i].ToString() + ", ");
                    }
                    break;
                case startOp.Craft:
                    Craft(true);
                    break;
                case startOp.WorldMap:
                        Console.WriteLine(WorldMap);
                    break;
                case startOp.TownMap:
                        Console.WriteLine(TownMap);
                    break;
                case startOp.help:
                    Console.WriteLine();
                    break;
                default:
                    break;
            }
            Update();
        }
        public void isDun(bool Bool)
        {
            if(Bool == true)
            {
                Player.StartDun();
                Dun.Start();
            }
            else
            {
                Player.EndDun();
            }
        }
        startOp UserToStartOp(string user)
        {
            startOp Re = startOp.none;
            switch (user)
            {
                case "Help":
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
            }
            return Re;
        }
        bool EnC = false;
        public void Craft(bool Start)
        {
            string Help = @"you can say ""what can i craft"" or ""wcic""";
            if(EnC == false)
            {
                Console.WriteLine(@"what to do say ""help"" and get help");
                EnC = true;
            }
            string UserCraft = Console.ReadLine();
            if (UserCraft == "Help" || UserCraft == "help")
                Console.WriteLine(Help);
            if (UserCraft == "what can i craft" || UserCraft == "wcic" || UserCraft == "WCIC")
                Console.WriteLine("HW");
            if (UserCraft == "Craft" || UserCraft == "craft")
            {
                Console.WriteLine("what to craft");
                string HTC = Console.ReadLine();
                if(HTC == "SP")
                    craft.Craft(HTC);
            }
            if (UserCraft == "goout" || UserCraft == "GoOut" || UserCraft == "GO")
            {
                EnC = false;
            }
            if (EnC == true)
                Craft(Start);
        }
    }
}

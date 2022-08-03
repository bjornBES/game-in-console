using System;
using game_in_console.map;
using game_in_console.enums;
using game_in_console.crafting;
using game_in_console.Shoping;
using game_in_console.NPC.Name;
using game_in_console.dun;
using game_in_console.dun.enemys;

namespace game_in_console.enums
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
    }
}
namespace game_in_console
{
    class Program
    {
        Player Player;
        Dun Dun;
        item item;
        Map Map;
        CraftItems craft;
        shop Shop;
        NPCNames NPCNames;
        
        string PlayerName;
        
        static void Main()
        {
            Console.WriteLine("Hello you there what is your name?");
            Program program = new Program(); program.start();
        }
        void To()
        {
            NPCNames.PlayerName = PlayerName;
            NPCNames._1NPCNameDialog(0, Map);
            NPCNames._1NPCNameDialog(1, Map);
        }
        void start()
        {
            #region Get Stuff
            NPCNames = new NPCNames();
            Player = new Player();
            Player.Start();
            craft = new CraftItems();
            craft.Start();
            craft.Player = Player;
            Shop = new shop();
            Shop.Player = Player;
            Shop.nPCNames = NPCNames;
            item = new item();
            Map = new Map();
            Map.Start();
            Dun = new Dun();
            Dun.Map = Map;
            #endregion
            PlayerName = Console.ReadLine();
            if (PlayerName != "skipto")
            {
                To();
            }
            Update();
        }
        bool First = true;
        void Update()
        { 
            string User = "";
            User = Console.ReadLine();
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
                    Shop.Shop(true, true, false);
                    break;
                case startOp.Inv:
                    Console.WriteLine("you have");
                    for (int i = 0; i < Player.InvIndex; i++)
                    {
                        Console.WriteLine(Player.invCon[i] + " " + Player.inv[i] + ", ");
                    }
                    break;
                case startOp.Craft:
                    Craft(true);
                    break;
                case startOp.WorldMap:
                        Console.WriteLine(Map.WorldMap);
                    break;
                case startOp.TownMap:
                        Console.WriteLine(Map.TownMap);
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

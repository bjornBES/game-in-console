using System;
using game_in_console.map;
using game_in_console.enums;
using game_in_console.crafting;
using game_in_console.Shoping;
namespace game_in_console.Shoping.Class
{

}

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
    public class ShopItemsList
    {
        public string name;
        public int Con;
        public int cost;
    }
    class Program
    {
        float PlayerX, PlayerY;
        Player Player;
        item item;
        Map Map;
        CraftItems craft;
        Shoping.shop Shop;
        
        string PlayerName;
        
        static void Main()
        {
            Console.WriteLine("Hello you there what is your name?");
            Program program = new Program(); program.start();
        }
        void To()
        {
            Console.WriteLine("Hello " + PlayerName);
            Console.WriteLine("You: " + "where am i? and who are you?");
            Console.WriteLine("i am Bolvar and you are in Strombard");
            Console.WriteLine("You: " + "you said where?");
            Console.WriteLine("Bolvar: " + "do you have a map?");
            Console.WriteLine("say no to lie or say yes to not lie");
            string User = Console.ReadLine();
            if (User == "yes" || User == "Yes" || User == "y" || User == "Y")
            {
                Console.WriteLine("You: " + "yes i have a map");
                Console.WriteLine("Bolvar: " + "yes yes can you open it");
            }
            if (User == "no" || User == "No" || User == "n" || User == "N")

            {
                Console.WriteLine("You: " + "no i do not have a map");
                Console.WriteLine("Bolvar: " + "ok here take this map and open it");
            }
            Console.WriteLine(@"say ""WorldMap"" to open your map");
            User = "";
            User = Console.ReadLine();
            if (User == "WorldMap" || User == "worldmap" || User == "wm" || User == "WM")
            {
                for (int i = 0; i < Map.WorldMap.Length; i++)
                {
                    Console.WriteLine(Map.WorldMap[i]);
                }
            }
            Console.WriteLine("You: " + "what is Firestormb and what is the wild?");
            Console.WriteLine("Bolvar: " + "Firestromb is a friend and the wild is a place where no one has gone to in over 1000 years");
            Console.WriteLine("You: " + "what... over 1000 years :O ");
            Console.WriteLine("Bolvar: " + "if you want to go there you need to train for it");
            Console.WriteLine("Bolvar: " + "get your gear at the shop");
            Console.WriteLine(@"say ""shop"" to go to the shop");
        }
        void start()
        {
            Player = new Player();
            Player.Start();

            craft = new crafting.CraftItems();
            craft.Start();
            craft.Player = Player;

            Shop = new shop();
            Shop.Player = Player;

            item = new item();

            Map = new Map();
            Map.Start();
            PlayerX = Player.GetX();
            PlayerY = Player.GetY();
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
                    Shop.Shop(true, false);
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
                    for (int i = 0; i < Map.WorldMap.Length; i++)
                    {
                        Console.WriteLine(Map.WorldMap[i]);
                    }
                    break;
                case startOp.TownMap:
                    for (int i = 0; i < Map.TownMap.Length; i++)
                    {
                        Console.WriteLine(Map.TownMap[i]);
                    }
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
                Console.WriteLine(craft.CraftintItems);
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

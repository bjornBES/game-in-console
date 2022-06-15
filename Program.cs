using System;
using game_in_console.map;
using game_in_console.enums;

namespace game_in_console
{
    class Program
    {
        float PlayerX, PlayerY;
        Player Player;
        item item;
        Map Map;
        string PlayerName;
        
        static void Main()
        {
            Console.WriteLine("Hello World!");
            Program program = new Program(); program.start();
        }
        void start()
        {
            Player = new Player();
            Player.Start();
            item = new item();
            Map = new Map();
            Map.Start();
            PlayerX = Player.GetX();
            PlayerY = Player.GetY();
            Console.WriteLine("Hello you there what is your name?");
            PlayerName = Console.ReadLine();
            Console.WriteLine("Hello " + PlayerName);
            Console.WriteLine("You: " + "where am i? and who are you?");
            Console.WriteLine("i am Bolvar and you are in Strombard");
            Console.WriteLine("You: " + "you said where?");
            Console.WriteLine("Bolvar: " + "do you have a map?");
            Console.WriteLine("say no to lie or say yes to not lie");
            string User = Console.ReadLine();
            if(User == "yes" || User == "Yes")
            {
                Console.WriteLine("You: " + "yes i have a map");
                Console.WriteLine("Bolvar: " + "yes yes can you open it");
            }
            else
            {
                Console.WriteLine("You: " + "no i do not have a map");
                Console.WriteLine("Bolvar: " + "ok here take this map and open it");
            }
            Console.WriteLine(@"say ""Map"" to open your map");
            User = Console.ReadLine();
            if(User == "Map")
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
            Update();
        }
        void Update()
        { 
            string User = Console.ReadLine();
            if (User == "StartDun" || User == "SD")
                isDun(true);
            if (User == "Run")
                isDun(false);
            if (User == "Shop" || User == "shop" && Player.IsDun != true)
                Shop(true);
            if(User == "Inv")
            {
                Console.WriteLine("you have");
                for (int i = 0; i < Player.InvIndex; i++)
                {
                    Console.WriteLine(Player.invCon[i] + " " + Player.inv[i] + ", ");
                }
            }
            if (User == "Craft" || User == "craft" && Player.IsDun != true)
            {

            }
            if(User == "WorldMap" && Player.IsDun != true)
            {
                for (int i = 0; i < Map.WorldMap.Length; i++)
                {
                    Console.WriteLine(Map.WorldMap[i]);
                }
            }
            if (User == "TownMap" && Player.IsDun != true)
            {
                for (int i = 0; i < Map.TownMap.Length; i++)
                {
                    Console.WriteLine(Map.TownMap[i]);
                }
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
        bool En = false;
        bool EnR = false;
        int item1 = 0;
        int item2 = 0;
        int item3 = 0;
        public void Shop(bool shop)
        {
            string[] Taple = { "em" ,"Sticks", "Stones", "irons", "flints"};
            int[] Con = { 0, 2 , 3, 2, 2 };
            string Help = @"you can say ""GO"" or ""GoOut"" to Go out of the shop or if you want to buy stuff say ""what can i buy"" or ""WCIB"" to see what the shopkepper has in stok and then say ""buy"" to buy";
            string[] ShopKeeperIn = { "hello what can i do for you?", "it's it not a good day", "The Shop has all the items you need :D" };
            string[] ShopKeeperOut = { "thanks you and bye", "bye", "farewell hero" };
            if (shop == true)
            {
                Random RNG = new Random();
                if (En == false)
                {
                    item1 = RNG.Next(0, Taple.Length);
                    item2 = RNG.Next(0, Taple.Length);
                    item3 = RNG.Next(0, Taple.Length);
                    if (item2 == item1)
                        item2 = RNG.Next(0, Taple.Length);
                    if (item3 == item2)
                        item3++;
                    if (item3 == Taple.Length)
                        item3 -= 2;
                    if (item1 == 0)
                        item1++;
                    if (item2 == 0)
                        item2+= 2;
                    if (item3 == 0)
                        item3+= 3;
                    Console.WriteLine("the ShopKeeper: " + ShopKeeperIn[RNG.Next(0, ShopKeeperIn.Length)]);
                    En = true;
                }
                string User = Console.ReadLine();
                if (User == "goout" || User == "GoOut" || User == "GO")
                {
                    Console.WriteLine("the ShopKeeper: " + ShopKeeperOut[RNG.Next(0, ShopKeeperOut.Length)]);
                    EnR = true;
                    En = false;
                }
                if (User == "what can i buy" || User == "what can i buy?" || User == "WCIB")
                    Console.WriteLine("the ShopKeeper: " + "i have " + Con[item1] + " " + Taple[item1] + ", " + 
                        Con[item2] + " " + Taple[item2] + ", " + 
                        Con[item3] + " " + Taple[item3]);
                if (User == "Help" || User == "help" || User == "_h")
                    Console.WriteLine(Help);
                if (User == "Buy" || User == "buy")
                {
                    Console.WriteLine("the ShopKeeper: " + "what to buy?");
                    Console.WriteLine("to a buy a thing you need to say the item number eg " + "item1 to buy " + Con[item1] + " of " + Taple[item1]);
                    string UserBuy = Console.ReadLine();
                    if (UserBuy == "item1" || UserBuy == "Item1")
                    {
                        Player.inv[Player.InvIndex] = Taple[item1];
                        Player.invCon[Player.InvIndex] = Con[item1];
                        Player.InvIndex++;
                        Console.WriteLine("the ShopKeeper: " + "thank you for purchaseing " + Con[item1] + " " + Taple[item1]);
                        Taple[item1] = "";
                        Con[item1] = 0;
                    }
                    if (UserBuy == "item2" || UserBuy == "Item2")
                    {
                        Player.inv[Player.InvIndex] = Taple[item2];
                        Player.invCon[Player.InvIndex] = Con[item2];
                        Player.InvIndex++;
                        Console.WriteLine("the ShopKeeper: " + "thank you for purchaseing " + Con[item2] + " " + Taple[item2]);
                        Taple[item2] = "";
                        Con[item2] = 0;
                    }
                    if (UserBuy == "item3" || UserBuy == "Item3")
                    {
                        Player.inv[Player.InvIndex] = Taple[item3];
                        Player.invCon[Player.InvIndex] = Con[item3];
                        Player.InvIndex++;
                        Console.WriteLine("the ShopKeeper: " + "thank you for purchaseing " + Con[item3] + " " + Taple[item3]);
                        Taple[item3] = "";
                        Con[item3] = 0;
                    }
                }
                if (User == "what can i do in here" || User == "wcidih")
                {
                    Console.WriteLine(@"say ""help"" to get help");
                }
                User = "";
                if(EnR == false)
                    Shop(shop);
            }
        }
    }
}

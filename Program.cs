using System;

namespace game_in_console
{
    class Program
    {
        float PlayerX, PlayerY;
        Player Player;
        item item;
        static void Main()
        {
            Console.WriteLine("Hello World!");
            Program program = new Program(); program.start();
        }
        void start()
        {
            Player = new Player();
            item = new item();
            PlayerX = Player.GetX();
            PlayerY = Player.GetY();
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
            if (User == "Craft" || User == "craft" && Player.IsDun != true)
            {

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
        public void Shop(bool shop)
        {
            string[] Taple = { "Stick" };
            int[] Con = { 2 };
            int item1 = 0;
            string Help = @"you can say ""GoOut"" to Go out of the shop or if you want to buy stuff say ""what can i buy""";
            string[] ShopKeeperIn = { "What can i do for you?", "it's it not a good day", "The Shop has all the items you need :D" };
            string[] ShopKeeperOut = { "thanks you and bye", "bye", "farewell hero" };
            if (shop == true)
            {
                Random RNG = new Random();
                item1 = RNG.Next(0, Taple.Length);
                Console.WriteLine(ShopKeeperIn[RNG.Next(0, ShopKeeperIn.Length)]);
                string User = Console.ReadLine();
                if (User == "goout" || User == "GoOut" || User == "GO")
                {
                    Console.WriteLine(ShopKeeperOut[RNG.Next(0, ShopKeeperOut.Length)]);
                    Shop(false);
                }
                if (User == "what can i buy" || User == "what can i buy?" || User == "WCIB")
                    Console.WriteLine("i have " + Con[item1] + " of " + Taple[item1]);
                if (User == "Help" || User == "help" || User == "_h")
                    Console.WriteLine(Help);
            }
        }
    }
}

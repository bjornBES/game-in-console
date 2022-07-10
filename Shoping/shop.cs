using System;
using System.Collections.Generic;
using System.Text;
using game_in_console.Shoping.Enum;
namespace game_in_console.Shoping.Enum
{
    public enum ShopOp
    {
        none,
        WCIB,
        GO,
        buy,
        wcidih,
        help
    }
}
namespace game_in_console.Shoping
{
    public class shop
    {
        public Player Player;
        bool En = false;
        bool EnR = false;
        int item1 = 0;
        int item2 = 0;
        int item3 = 0;
        /// <summary>
        /// a taple for all the items you can get!
        /// </summary>
        string[] Taple = { "em", "Sticks", "Stones", "irons", "flints" };
        int[] Con = { 0, 2, 3, 2, 2 };
        int[] cost = { 0, 10, 15, 20, 10 };
        ShopItemsList[] itemsList = new ShopItemsList[3];
        int ItemsListIndex;
        public void Shop(bool shop, bool start)
        {
            int Items = 3;
            for (int i = 0; i < itemsList.Length; i++)
            {
                itemsList[i] = new ShopItemsList();
            }
            string Help = @"you can say ""GO"" or ""GoOut"" to Go out of the shop or if you want to buy stuff say ""what can i buy"" or ""WCIB"" to see what the shopkepper has in stok and then say ""buy"" to buy";
            string[] ShopKeeperOut = { "thanks you and bye", "bye", "farewell hero" };
            if (shop == true)
            {
                Random RNG = new Random();
                if (En == false)
                    S_setup(RNG, start);

                string User = Console.ReadLine();
                /*
                 * if(user == enumAsString ) or Publuc Enum name ; << global then in a method switch(name){case Enum.Vale: break;;}
                 */
                switch (UserToShopOp(User))
                {
                    case ShopOp.none:
                        break;
                    case ShopOp.WCIB:
                        S_WCIB();
                        break;
                    case ShopOp.GO:
                        Console.WriteLine("the ShopKeeper: " + ShopKeeperOut[RNG.Next(0, ShopKeeperOut.Length)]);
                        EnR = true;
                        En = false;
                        break;
                    case ShopOp.buy:
                        S_Buy();
                        break;
                    case ShopOp.wcidih:
                        Console.WriteLine(@"say ""help"" to get help");
                        break;
                    case ShopOp.help:
                        Console.WriteLine(Help);
                        break;
                    default:
                        break;
                }
                User = "";
                if (EnR == false)
                    Shop(shop, false);
            }
        }
        ShopOp UserToShopOp(string user)
        {
            ShopOp Re = ShopOp.none;
            switch (user)
            {
                case "WCIB":
                    Re = ShopOp.WCIB;
                    break;
                case "GO":
                    Re = ShopOp.GO;
                    break;
                case "buy":
                    Re = ShopOp.buy;
                    break;
                case "wcidih":
                    Re = ShopOp.wcidih;
                    break;
                case "help":
                    Re = ShopOp.help;
                    break;
            }
            return Re;
        }
        void S_setup(Random RNG, bool start)
        {
            string[] ShopKeeperIn = { "hello what can i do for you?", "it's it not a good day", "The Shop has all the items you need :D" };
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
                item2 += 2;
            if (item3 == 0)
                item3 += Taple.Length - 1;
            if (start == false)
                Console.WriteLine("the ShopKeeper: " + ShopKeeperIn[RNG.Next(0, ShopKeeperIn.Length)]);
            itemsList[ItemsListIndex].name = Taple[item1];
            itemsList[ItemsListIndex].Con = Con[item1];
            itemsList[ItemsListIndex].cost = cost[item1];
            ItemsListIndex++;
            itemsList[ItemsListIndex].name = Taple[item2];
            itemsList[ItemsListIndex].Con = Con[item2];
            itemsList[ItemsListIndex].cost = cost[item2];
            ItemsListIndex++;
            itemsList[ItemsListIndex].name = Taple[item3];
            itemsList[ItemsListIndex].Con = Con[item3];
            itemsList[ItemsListIndex].cost = cost[item3];
            En = true;
        }
        void S_WCIB()
        {
            Console.WriteLine("The ShopKeeper: " + "i have");
            for (int i = 0; i < itemsList.Length; i++)
            {
                Console.WriteLine(itemsList[i].Con + " " + itemsList[i].name + " for " + itemsList[i].cost + ", ");
            }
        }
        void S_Buy()
        {
            Console.WriteLine("the ShopKeeper: " + "what to buy?");
            Console.WriteLine("to a buy a thing you need to say the item number eg " + "item1 to buy " + Con[item1] + " " + Taple[item1] + " for " + cost[item1]);
            string UserBuy = Console.ReadLine();
            #region Buy Item1
            if (UserBuy == "item1" || UserBuy == "Item1")
            {
                if (Player.coins >= cost[item1])
                {
                    Player.inv[Player.InvIndex] = Taple[item1];
                    Player.invCon[Player.InvIndex] = Con[item1];
                    Player.InvIndex++;
                    Console.WriteLine("the ShopKeeper: " + "thank you for purchaseing " + Con[item1] + " " + Taple[item1] + " for " + cost[item1]);
                    Player.coins -= cost[item1];
                    Taple[item1] = "";
                    Con[item1] = 0;
                    cost[item1] = 0;
                }
                else
                    Console.WriteLine("the ShopKeeper: " + "Sorry but you do not have enough coins you need " + cost[item1] + " coins");
            }
            #endregion
            #region Buy Item2
            if (UserBuy == "item2" || UserBuy == "Item2")
            {
                if (Player.coins >= cost[item2])
                {
                    Player.inv[Player.InvIndex] = Taple[item2];
                    Player.invCon[Player.InvIndex] = Con[item2];
                    Player.InvIndex++;
                    Console.WriteLine("the ShopKeeper: " + "thank you for purchaseing " + Con[item2] + " " + Taple[item2] + " for " + cost[item2]);
                    Player.coins -= cost[item2];
                    Taple[item2] = "";
                    Con[item2] = 0;
                    cost[item2] = 0;
                }
                else
                    Console.WriteLine("the ShopKeeper: " + "Sorry but you do not have enough coins you need " + cost[item2] + " coins");
            }
            #endregion
            #region Buy Item3
            if (UserBuy == "item3" || UserBuy == "Item3")
            {
                if (Player.coins >= cost[item3])
                {
                    Player.inv[Player.InvIndex] = Taple[item3];
                    Player.invCon[Player.InvIndex] = Con[item3];
                    Player.InvIndex++;
                    Console.WriteLine("the ShopKeeper: " + "thank you for purchaseing " + Con[item3] + " " + Taple[item3] + " for " + cost[item3]);
                    Player.coins -= cost[item3];
                    Taple[item3] = "";
                    Con[item3] = 0;
                    cost[item3] = 0;
                }
                else
                    Console.WriteLine("the ShopKeeper: " + "Sorry but you do not have enough coins you need " + cost[item3] + " coins");
            }
            #endregion
        }
    }
}

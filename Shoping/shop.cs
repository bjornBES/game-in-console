using System;
using System.Collections.Generic;
using System.Text;
using game_in_console.Shoping.Enum;
using game_in_console.Shoping.Class;
using game_in_console.NPC.Name;
namespace game_in_console.Shoping.Class
{
    public class ShopItemsList
    {
        public string name;
        public int Con;
        public int cost;
    }
}
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
        bool _exit = false;
        public NPCNames nPCNames;
        public Player Player;
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
        public void Shop(bool shop, bool start, bool exit)
        {
            if(exit == false)
            {
                if(start == true)
                {
                    for (int i = 0; i < itemsList.Length; i++)
                    {
                        itemsList[i] = new ShopItemsList();
                    }
                }
                string Help = @"you can say ""GO"" or ""GoOut"" to Go out of the shop or if you want to buy stuff say ""what can i buy"" or ""WCIB"" to see what the shopkepper has in stok and then say ""buy"" to buy";
                if (shop == true)
                {
                    Random RNG = new Random();
                    if(start == true)
                        S_setup(RNG, start);

                    string User = Console.ReadLine();
                    switch (UserToShopOp(User))
                    {
                        case ShopOp.none:
                            break;
                        case ShopOp.WCIB:
                            S_WCIB();
                            break;
                        case ShopOp.GO:
                            Console.WriteLine(nPCNames.ShopKeeperName + ": " + nPCNames.Dia_ShopKeeperOut[RNG.Next(0, nPCNames.Dia_ShopKeeperOut.Length)]);
                            _exit = true;
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
                    Shop(shop, false, _exit);
                }
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
        void SetAllItems(int Index)
        {
            itemsList[ItemsListIndex].name = Taple[Index];
            itemsList[ItemsListIndex].Con = Con[Index];
            itemsList[ItemsListIndex].cost = cost[Index];
        }
        void SetNumbers(Random RNG)
        {
            item1 = RNG.Next(1, Taple.Length);
            item2 = RNG.Next(1, Taple.Length);
            item3 = RNG.Next(1, Taple.Length);
            if (item2 == item1)
                item2++;
            if (item2 == item3)
                item2--;
            if (item3 == item1)
                item3++;
            if (item3 == item2)
                item3--;
            if (item3 == Taple.Length)
                item3--;
            if (item3 == Taple.Length)
                item2 -= 2;
        }
        void S_setup(Random RNG, bool start)
        {
            SetNumbers(RNG);
            if (start == false)
                Console.WriteLine(nPCNames.ShopKeeperName + ": " + nPCNames.Dia_ShopKeeperIn[RNG.Next(0, nPCNames.Dia_ShopKeeperIn.Length)]);
            SetAllItems(item1);
            ItemsListIndex++;
            SetAllItems(item2);
            ItemsListIndex++;
            SetAllItems(item3);
        }
        void S_WCIB()
        {
            Console.WriteLine(nPCNames.ShopKeeperName + ": " + "i have");
            for (int i = 0; i < itemsList.Length; i++)
            {
                Console.WriteLine(itemsList[i].Con + " " + itemsList[i].name + " for " + itemsList[i].cost + ", ");
            }
        }
        void DeleteingItems(int Index)
        {
            Taple[Index] = "";
            Con[Index] = 0;
            cost[Index] = 0;
        }
        void AddingItemsToInv(int index)
        {
            Player.inv[Player.InvIndex] = Taple[index];
            Player.invCon[Player.InvIndex] = Con[index];
            Player.InvIndex++;
        }
        void BuyItem(int Index, bool buy)
        {
            int NeedCoins = Player.coins - cost[Index];
            switch (buy)
            {
                case true:
                    Console.WriteLine(nPCNames.ShopKeeperName + ": " + "thank you for purchaseing " + Con[Index] + " " + Taple[Index] + " for " + cost[Index]);
                    break;
                case false:
                    Console.WriteLine(nPCNames.ShopKeeperName + ": " + "Sorry but you do not have enough coins you need " + cost[Index] + " coins and you have " + Player.coins + " coins you need " + NeedCoins + " coins");
                    break;
            }
        }
        void S_Buy()
        {
            Console.WriteLine(nPCNames.ShopKeeperName + ": " + "what to buy?");
            Console.WriteLine("to a buy a thing you need to say the item number eg " + "item1 to buy " + Con[item1] + " " + Taple[item1] + " for " + cost[item1]);
            string UserBuy = Console.ReadLine();
            switch (UserBuy)
            {
                case "Item1":
                    #region Buy Item1
                    if (Player.coins >= cost[item1])
                    {
                        //geting the items to Player Inv
                        AddingItemsToInv(item1);
                        BuyItem(item1, true);
                        //sub the coins form the player
                        Player.coins -= cost[item1];
                        //deleteing the items form the shop
                        DeleteingItems(item1);
                    }
                    else
                        BuyItem(item1, false);
                    #endregion
                    break;
                case "item1":
                    #region Buy Item1
                    if (Player.coins >= cost[item1])
                    {
                        //geting the items to Player Inv
                        AddingItemsToInv(item1);
                        BuyItem(item1, true);
                        //sub the coins form the player
                        Player.coins -= cost[item1];
                        //deleteing the items form the shop
                        DeleteingItems(item1);
                    }
                    else
                        BuyItem(item1, false);
                    #endregion
                    break;
                case "Item2":
                    #region Buy Item2
                    if (Player.coins >= cost[item2])
                    {
                        //geting the items to Player Inv
                        AddingItemsToInv(item2);
                        BuyItem(item2, true);
                        //sub the coins form the player
                        Player.coins -= cost[item3];
                        //deleteing the items form the shop
                        DeleteingItems(item3);
                    }
                    else
                        BuyItem(item2, false);
                    #endregion
                    break;
                case "item2":
                    #region Buy Item2
                    if (Player.coins >= cost[item2])
                    {
                        //geting the items to Player Inv
                        AddingItemsToInv(item2);
                        BuyItem(item2, true);
                        //sub the coins form the player
                        Player.coins -= cost[item3];
                        //deleteing the items form the shop
                        DeleteingItems(item3);
                    }
                    else
                        BuyItem(item2, false);
                    #endregion
                    break;
                case "Item3":
                    #region Buy Item3
                    if (Player.coins >= cost[item3])
                    {
                        //geting the items to Player Inv
                        AddingItemsToInv(item3);
                        BuyItem(item3, true);
                        //sub the coins form the player
                        Player.coins -= cost[item3];
                        //deleteing the items form the shop
                        DeleteingItems(item3);
                    }
                    else
                        BuyItem(item3, false);
                    #endregion
                    break;
                case "item3":
                    #region Buy Item3
                    if (Player.coins >= cost[item3])
                    {
                        //geting the items to Player Inv
                        AddingItemsToInv(item3);
                        BuyItem(item3, true);
                        //sub the coins form the player
                        Player.coins -= cost[item3];
                        //deleteing the items form the shop
                        DeleteingItems(item3);
                    }
                    else
                        BuyItem(item3, false);
                    #endregion
                    break;
            }
        }
    }
}

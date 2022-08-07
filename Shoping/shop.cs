using System;
using System.Collections.Generic;
using System.Text;
using game_in_console.Shoping.Class;
using game_in_console.NPC.Name;
using GameEMain;
namespace game_in_console.Shoping.Class
{
    public class ShopItemsList : GameE
    {
        public items name;
        public int S_Con;
        public int S_cost;
    }
}
namespace game_in_console.Shoping
{
    public class shop : GameEMain.GameE
    {
        bool _exit = false;
        int item1 = 0;
        int item2 = 0;
        int item3 = 0;
        public NPCNames S_NPC;
        public Player S_player;
        /// <summary>
        /// a taple for all the items you can get!
        /// </summary>
        ShopItemsList[] itemsList = new ShopItemsList[3];
        int ItemsListIndex;
        public void S_Shop(bool shop, bool start, bool exit)
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
                            Console.WriteLine(S_NPC.ShopKeeperName + ": " + S_NPC.Dia_ShopKeeperOut[RNG.Next(0, S_NPC.Dia_ShopKeeperOut.Length)]);
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
                    S_Shop(shop, false, _exit);
                }
            }
        }
        /// <summary>
        /// the op for moveing to the buy or WCIB
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
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
        /// <summary>
        /// sets all items to there item index in the arr
        /// </summary>
        /// <param name="Index"></param>
        void SetAllItems(int Index)
        {
            itemsList[ItemsListIndex].name = Taple[Index];
            itemsList[ItemsListIndex].S_Con = Con[Index];
            itemsList[ItemsListIndex].S_cost = cost[Index];
        }
        /// <summary>
        /// gets the item in numbers
        /// </summary>
        /// <param name="RNG"></param>
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
            if (start == true)
                Console.WriteLine(S_NPC.ShopKeeperName + ": " + S_NPC.Dia_ShopKeeperIn[RNG.Next(0, S_NPC.Dia_ShopKeeperIn.Length)]);
            SetAllItems(item1);
            ItemsListIndex++;
            SetAllItems(item2);
            ItemsListIndex++;
            SetAllItems(item3);
        }
        void S_WCIB()
        {
            Console.WriteLine(S_NPC.ShopKeeperName + ": " + "i have");
            for (int i = 0; i < itemsList.Length; i++)
            {
                Console.WriteLine(itemsList[i].S_Con + " " + itemsList[i].name + " for " + itemsList[i].S_cost + ", ");
            }
            if(itemsList[0] == null)
            {
                Bug.MessBug("01920", Bugs.craft);
            }
        }
        void S_DeleteingItems(int Index)
        {
            Taple[Index] = items.none;
            Con[Index] = 0;
            cost[Index] = 0;
        }
        int ChacePlayerInv(items Items)
        {
            int Re = -1;
            for (int i = 0; i < S_player.inv.Length; i++)
            {
                if(S_player.inv[i] == Items)
                {
                    Re = i;
                }
            }
            return Re;
        }
        void S_AddingItemsToInv(int index)
        {
            if(ChacePlayerInv(Taple[index]) != -1)
            {
                S_player.invCon[ChacePlayerInv(Taple[index])] += Con[index];
            }
            else
            {
                S_player.inv[S_player.InvIndex] = Taple[index];
                S_player.invCon[S_player.InvIndex] = Con[index];
                S_player.InvIndex++;
            }

        }
        void BuyItem(int Index, bool buy)
        {
            int NeedCoins = S_player.coins - cost[Index];
            switch (buy)
            {
                case true:
                    Console.WriteLine(S_NPC.ShopKeeperName + ": " + "thank you for purchaseing " + Con[Index] + " " + Taple[Index] + " for " + cost[Index]);
                    break;
                case false:
                    Console.WriteLine(S_NPC.ShopKeeperName + ": " + "Sorry but you do not have enough coins you need " + cost[Index] + " coins and you have " + S_player.coins + " coins you need " + NeedCoins + " coins");
                    break;
            }
        }
        void S_Buy()
        {
            Console.WriteLine(S_NPC.ShopKeeperName + ": " + "what to buy?");
            Console.WriteLine("to a buy a thing you need to say the item number eg " + "item1 to buy " + Con[item1] + " " + Taple[item1] + " for " + cost[item1]);
            string UserBuy = Console.ReadLine();
            switch (UserBuy)
            {
                case "Item1":
                    #region Buy Item1
                    if (S_player.coins >= cost[item1])
                    {
                        //geting the items to Player Inv
                        S_AddingItemsToInv(item1);
                        BuyItem(item1, true);
                        //sub the coins form the player
                        S_player.coins -= cost[item1];
                        //deleteing the items form the shop
                        S_DeleteingItems(item1);
                    }
                    else
                        BuyItem(item1, false);
                    #endregion
                    break;
                case "item1":
                    #region Buy Item1
                    if (S_player.coins >= cost[item1])
                    {
                        //geting the items to Player Inv
                        S_AddingItemsToInv(item1);
                        BuyItem(item1, true);
                        //sub the coins form the player
                        S_player.coins -= cost[item1];
                        //deleteing the items form the shop
                        S_DeleteingItems(item1);
                    }
                    else
                        BuyItem(item1, false);
                    #endregion
                    break;
                case "Item2":
                    #region Buy Item2
                    if (S_player.coins >= cost[item2])
                    {
                        //geting the items to Player Inv
                        S_AddingItemsToInv(item2);
                        BuyItem(item2, true);
                        //sub the coins form the player
                        S_player.coins -= cost[item3];
                        //deleteing the items form the shop
                        S_DeleteingItems(item3);
                    }
                    else
                        BuyItem(item2, false);
                    #endregion
                    break;
                case "item2":
                    #region Buy Item2
                    if (S_player.coins >= cost[item2])
                    {
                        //geting the items to Player Inv
                        S_AddingItemsToInv(item2);
                        BuyItem(item2, true);
                        //sub the coins form the player
                        S_player.coins -= cost[item3];
                        //deleteing the items form the shop
                        S_DeleteingItems(item3);
                    }
                    else
                        BuyItem(item2, false);
                    #endregion
                    break;
                case "Item3":
                    #region Buy Item3
                    if (S_player.coins >= cost[item3])
                    {
                        //geting the items to Player Inv
                        S_AddingItemsToInv(item3);
                        BuyItem(item3, true);
                        //sub the coins form the player
                        S_player.coins -= cost[item3];
                        //deleteing the items form the shop
                        S_DeleteingItems(item3);
                    }
                    else
                        BuyItem(item3, false);
                    #endregion
                    break;
                case "item3":
                    #region Buy Item3
                    if (S_player.coins >= cost[item3])
                    {
                        //geting the items to Player Inv
                        S_AddingItemsToInv(item3);
                        BuyItem(item3, true);
                        //sub the coins form the player
                        S_player.coins -= cost[item3];
                        //deleteing the items form the shop
                        S_DeleteingItems(item3);
                    }
                    else
                        BuyItem(item3, false);
                    #endregion
                    break;
            }
        }
    }
}

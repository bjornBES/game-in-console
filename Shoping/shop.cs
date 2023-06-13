using System;
using System.Collections.Generic;
using System.Text;
using game_in_console.Shoping.Class;
using game_in_console.NPC.Name;
using game_in_console.bug;
using game_in_console.enums;
using GameEMain;
using game_in_console.player;
namespace game_in_console.Shoping.Class
{
    public class ShopItemsList
    {
        public Items name;
        public int S_Con;
        public int S_cost;
        public int S_Chance;
    }
}
namespace game_in_console.Shoping
{
    public class Shop
    {
        bool GetInFrist = true;
        bool First = true;
        bool _exit = false;
        int item1 = 0;
        int item2 = 0;
        int item3 = 0;
        public Player S_player;

        /// <summary>
        /// a taple for all the items you can get!
        /// </summary>
        readonly ShopItemsList[] itemsList = new ShopItemsList[3];
        int ItemsListIndex;
        public void ShopStart(bool shop, bool exit)
        {
            if(exit == false)
            {
                if(First == true)
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
                        Setup(RNG, First);

                    string User = Console.ReadLine();
                    switch (UserToShopOp(User))
                    {
                        case ShopOp.none:
                            break;
                        case ShopOp.WCIB:
                            WCIB();
                            break;
                        case ShopOp.GO:
                            Console.WriteLine(NPCNames.ShopKeeperName + ": " + NPCNames.Dia_ShopKeeperOut[RNG.Next(0, NPCNames.Dia_ShopKeeperOut.Length)]);
                            GetInFrist = true;
                            _exit = true;
                            break;
                        case ShopOp.buy:
                            Buy();
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
                    if (_exit == false)
                        GetInFrist = false;
                    First = false;
                    ShopStart(shop, _exit);
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
        /// <summary>
        /// sets all items to there item index in the arr
        /// </summary>
        /// <param name="Index"></param>
        void SetAllItems(int Index)
        {
            itemsList[ItemsListIndex].name = Taple[Index];
            itemsList[ItemsListIndex].S_Con = Con[Index];
            itemsList[ItemsListIndex].S_cost = Cost[Index];
        }
        /// <summary>
        /// gets the item in numbers
        /// </summary>
        /// <param name="RNG"></param>
        void SetNumbers(Random RNG)
        {
            for (int i = 0; i < 3; i++)
            {
                int perCent = RNG.Next(0, 25);
                if (perCent < 10)
                {
                    if (item3 == 0 && item2 != 0 && item1 != 0)
                        item3 = 6;
                    if (item2 == 0 && item1 != 0)
                        item2 = 6;
                    if (item1 == 0)
                        item1 = 6;
                }
                else if (perCent < 10 + 5)
                {
                    if (item3 == 0 && item2 != 0 && item1 != 0)
                        item3 = 3;
                    if (item2 == 0 && item1 != 0)
                        item2 = 3;
                    if (item1 == 0)
                        item1 = 3;
                }
                else if (perCent < 10 + 10)
                {
                    int ff = RNG.Next(0, 100);
                    if (ff < 50)
                    {
                        if (item3 == 0 && item2 != 0 && item1 != 0)
                            item3 = 5;
                        if (item2 == 0 && item1 != 0)
                            item2 = 5;
                        if (item1 == 0)
                            item1 = 5;
                    }
                    else if (ff < 50 + 50)
                    {
                        if (item3 == 0 && item2 != 0 && item1 != 0)
                            item3 = 2;
                        if (item2 == 0 && item1 != 0)
                            item2 = 2;
                        if (item1 == 0)
                            item1 = 2;
                    }
                }
                else if (perCent < 10 + 10 + 5)
                {
                    int ff = RNG.Next(0, 100);
                    if (ff < 50)
                    {
                        if (item3 == 0 && item2 != 0 && item1 != 0)
                            item3 = 1;
                        if (item2 == 0 && item1 != 0)
                            item2 = 1;
                        if (item1 == 0)
                            item1 = 1;
                    }
                    else if (ff < 50 + 50)
                    {
                        if (item3 == 0 && item2 != 0 && item1 != 0)
                            item3 = 4;
                        if (item2 == 0 && item1 != 0)
                            item2 = 4;
                        if (item1 == 0)
                            item1 = 4;
                    }
                }
            }
            if(item1 == item2 || item2 == item3 || item3 == item1)
            {
                int perCent = RNG.Next(0, 25);
                if (perCent < 10)
                {
                    if (item1 == item2)
                        item2 = 6;
                    if (item2 == item3)
                        item3 = 6;
                    if (item3 == item1)
                        item1 = 6;
                }
                else if (perCent < 10 + 5)
                {
                    if (item1 == item2)
                        item2 = 3;
                    if (item2 == item3)
                        item3 = 3;
                    if (item3 == item1)
                        item1 = 3;
                }
                else if (perCent < 10 + 10)
                {
                    int ff = RNG.Next(0, 100);
                    if (ff < 50)
                    {
                        if (item1 == item2)
                            item2 = 5;
                        if (item2 == item3)
                            item3 = 5;
                        if (item3 == item1)
                            item1 = 5;
                    }
                    else if (ff < 50 + 50)
                    {
                        if (item1 == item2)
                            item2 = 2;
                        if (item2 == item3)
                            item3 = 2;
                        if (item3 == item1)
                            item1 = 2;
                    }
                }
                else if (perCent < 10 + 10 + 5)
                {
                    int ff = RNG.Next(0, 100);
                    if (ff < 50)
                    {
                        if (item1 == item2)
                            item2 = 1;
                        if (item2 == item3)
                            item3 = 1;
                        if (item3 == item1)
                            item1 = 1;
                    }
                    else if (ff < 50 + 50)
                    {
                        if (item1 == item2)
                            item2 = 4;
                        if (item2 == item3)
                            item3 = 4;
                        if (item3 == item1)
                            item1 = 4;
                    }
                }
            }
        }
        void Setup(Random RNG, bool start)
        {
            if(GetInFrist == true)
                Console.WriteLine(NPCNames.ShopKeeperName + ": " + NPCNames.Dia_ShopKeeperIn[RNG.Next(0, NPCNames.Dia_ShopKeeperIn.Length)]);
            if(start == true)
            {
                SetNumbers(RNG);
                SetAllItems(item1);
                ItemsListIndex++;
                SetAllItems(item2);
                ItemsListIndex++;
                SetAllItems(item3);
            }
        }
        void WCIB()
        {
            Console.WriteLine(NPCNames.ShopKeeperName + ": " + "i have");
            for (int i = 0; i < itemsList.Length; i++)
            {
                Console.WriteLine(itemsList[i].S_Con + " " + itemsList[i].name + " for " + itemsList[i].S_cost + ", ");
            }
            if(itemsList[0] == null)
            {
                Bug.MessBug("01920", Bugs.craft);
            }
        }
        void DeleteingItems(int Index)
        {
            Taple[Index] = Items.none;
            Con[Index] = 0;
            Cost[Index] = 0;
        }
        int ChacePlayerInv(Items Items)
        {
            int Re = -1;
            for (int i = 0; i < S_player.Inv.Length; i++)
            {
                if(S_player.Inv[i] == Items)
                {
                    Re = i;
                }
            }
            return Re;
        }
        void AddingItemsToInv(int index)
        {
            if(ChacePlayerInv(Taple[index]) != -1)
            {
                S_player.InvCon[ChacePlayerInv(Taple[index])] += Con[index];
            }
            else
            {
                S_player.Inv[S_player.InvIndex] = Taple[index];
                S_player.InvCon[S_player.InvIndex] = Con[index];
                S_player.InvIndex++;
            }

        }
        void BuyItem(int Index, bool buy)
        {
            int NeedCoins = S_player.Coins - Cost[Index];
            switch (buy)
            {
                case true:
                    Console.WriteLine(NPCNames.ShopKeeperName + ": " + "thank you for purchaseing " + Con[Index] + " " + Taple[Index] + " for " + Cost[Index]);
                    break;
                case false:
                    Console.WriteLine(NPCNames.ShopKeeperName + ": " + "Sorry but you do not have enough coins you need " + Cost[Index] + " coins and you have " + S_player.Coins + " coins you need " + NeedCoins + " coins");
                    break;
            }
        }
        void Buy()
        {
            Console.WriteLine(NPCNames.ShopKeeperName + ": " + "what to buy?");
            Console.WriteLine("to a buy a thing you need to say the item number eg " + "1 to buy " + Con[item1] + " " + Taple[item1] + " for " + Cost[item1]);
            int UserBuy = Console.Read();
            switch (UserBuy)
            {
                case 1:
                    BuyItem(item1);
                    break;
                case 2:
                    BuyItem(item2);
                    break;
                case 3:
                    BuyItem(item3);
                    break;
            }
        }
        void BuyItem(int index)
        {
            if (S_player.Coins >= Cost[index])
            {
                //geting the items to Player Inv
                AddingItemsToInv(index);
                BuyItem(index, true);
                //sub the coins form the player
                S_player.Coins -= Cost[index];
                //deleteing the items form the shop
                DeleteingItems(index);
            }
            else
                BuyItem(index, false);
        }
    }
}

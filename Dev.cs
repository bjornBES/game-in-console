using System;
using System.Collections.Generic;
using System.Text;
using game_in_console.crafting;
using game_in_console.Shoping;
using game_in_console.NPC.Name;
using game_in_console.dun;
using game_in_console.dun.enemys;
using game_in_console.bug;
using game_in_console.enums;
using game_in_console.player;
using GameEMain;
namespace game_in_console
{
    public class Dev
    {
        public bool DevAA { get; } = false;
        public Dev(Player Player, int password, string playername)
        {
            if (DevAA == true)
            {
                Console.WriteLine("Password hint its not 1234 or y4");
                Console.WriteLine("nomal dev = db , dun master = DM");
                string Number = Console.ReadLine();
                if (Number == password.ToString() || Number == "debug" || Number == "db")
                {
                    settings.Settings.Dev = true;
                    Player.Gear.MainHand = Items.IronSword;
                    Player.Coins = 99999;
                    Player.GetItem(Items.stick, 999);
                    Player.GetItem(Items.stone, 999);
                    Player.GetItem(Items.ironore, 999);
                    Player.GetItem(Items.StonePickaxe, 1);
                    Player.GetItem(Items.StoneAxe, 1);
                    Player.StoneW = true;
                    Player.smeltingS = true;
                    Player.alloysS = true;
                    Player.anvil = true;
                }
                else if (Number == password.ToString() || Number == "dm")
                {
                    settings.Settings.DunDev = true;
                    settings.Settings.Dev = true;
                    Player.PTools.torch = true;
                    Player.Gear.MainHand = Items.IronSword;
                    Player.Coins = 99999;
                    Player.InvIndex++;
                    Player.GetItem(Items.stick, 999);
                    Player.GetItem(Items.stone, 999);
                    Player.GetItem(Items.ironore, 999);
                    Player.GetItem(Items.StonePickaxe, 1);
                }
                else
                {
                    Bug.MessBug("196813785696849373228402159147087096127008678178", Bugs.Dev);
                }
                Playername = playername;
            }
            else
            {
                Console.WriteLine("the dev fun is not here");
                Bug.MessBug("404100", Bugs.Dev);
            }
        }

        public string Playername { get; }
    }
}

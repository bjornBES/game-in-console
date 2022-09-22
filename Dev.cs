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
        public bool DevAA { get; } = true;
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
                    Player.InvIndex++;
                    Player.Inv[0] = Items.stick;
                    Player.InvCon[0] = 999;
                    Player.InvIndex++;
                    Player.Inv[1] = Items.stone;
                    Player.InvCon[1] = 999;
                    Player.InvIndex++;
                    Player.Inv[2] = Items.ironore;
                    Player.InvCon[2] = 999;
                    Player.InvIndex++;
                    Player.Inv[3] = Items.StonePickaxe;
                    Player.InvCon[3] = 1;
                }
                else if (Number == password.ToString() || Number == "dm")
                {
                    settings.Settings.DunDev = true;
                    settings.Settings.Dev = true;
                    Player.Tools.torch = true;
                    Player.Gear.MainHand = Items.IronSword;
                    Player.Coins = 99999;
                    Player.InvIndex++;
                    Player.Inv[0] = Items.stick;
                    Player.InvCon[0] = 999;
                    Player.InvIndex++;
                    Player.Inv[1] = Items.stone;
                    Player.InvCon[1] = 999;
                    Player.InvIndex++;
                    Player.Inv[2] = Items.ironore;
                    Player.InvCon[2] = 999;
                    Player.InvIndex++;
                    Player.Inv[3] = Items.StonePickaxe;
                    Player.InvCon[3] = 1;
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

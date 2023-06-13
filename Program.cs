using System;
using game_in_console.crafting;
using game_in_console.Shoping;
using game_in_console.NPC.Name;
using game_in_console.dun;
using game_in_console.dun.enemys;
using GameEMain;
using game_in_console.otherSystem;
using game_in_console.enums;
namespace game_in_console
{
    public class Program
    {
        string PlayerName;
        static void Main()
        {
            Console.WriteLine("Hello you there what is your name?");
            //Console.WriteLine("who maked this? start with a by and a name ilke this...");
            Console.Title = "Game in a console";
            Program program = new Program(); 
            program.PStart();
        }
        public void PStart()
        {
            PlayerName = Console.ReadLine();
            if(PlayerName == "the wild" || PlayerName == "The Wild" || PlayerName == "wild")
            {
                Console.WriteLine("you can no longer hear the voice");
                Console.WriteLine("unknown voice:" + "YOU!");
                Console.WriteLine("unknown voice:" + "how are you");
                Console.WriteLine("you:" + "what is that?");
                Console.WriteLine("unknown voice:" + "you have now been banished form this place");
                Console.WriteLine("another unknown voice:" + "ok then i WILL find the human my self");
                Console.WriteLine("unknown voice:" + "HAHA... i will see forward to that moment and i will kill you both if i need to");
                Console.WriteLine("unknown voice:" + "MY SELF!!");
            }
            GameE.Start();
            if (PlayerName == "devB" || PlayerName == "BEsBB")
                new Dev(GameE.Player, GameE.Password, PlayerName);
            if (PlayerName != "skipto" || PlayerName == "devB" || PlayerName == "BEsBB")
                To();
            Update();
        }
        void To()
        {
            NPCNames.PlayerName = PlayerName;
            if (settings.Settings.Dev == false)
            {
                NPCNames.BolvarDialog(0);
                NPCNames.BolvarDialog(1);
            }
            Console.WriteLine("there is a thing coming your way");
            Console.WriteLine(NPCNames.PlayerHelperName + ": hello " + NPCNames.PlayerName + " im "+ NPCNames.PlayerHelperName + " and i am here to help you just say help to me if you need help");
        }
        void Update()
        {
            GameE.Player.UpdatePlayer();
            if (Console.CapsLock == true)
                Console.WriteLine("Game in a console with CapsLock");
            else
                Console.WriteLine("Game in a console");
            string User = Console.ReadLine();
            StartOp Item = (StartOp)GameE.converter.StringToEnum(User, typeof(StartOp));
            switch (Item)
            {
                case StartOp.none:
                    break;
                case StartOp.mine:
                    GameE.OtherSystem.Mine(GameE.Player.PTools.Pickaxe);
                    break;
                case StartOp.wood:
                    GameE.OtherSystem.Wood(GameE.Player.PTools.Axe);
                    break;
                case StartOp.StartDun:
                    GameE.Dun.D_Start();
                    break;
                case StartOp.Run:
                    break;
                case StartOp.How_many_coins_go_i_have:
                    Console.WriteLine(GameE.Player.Coins);
                    break;
                case StartOp.Shop:
                    GameE.Shop.ShopStart(true, false);
                    break;
                case StartOp.Inv:
                    GameE.Player.GetPlayerInv();
                    break;
                case StartOp.Craft:
                    GameE.CraftMeun.Craft(true);
                    break;
                case StartOp.WorldMap:
                        Console.WriteLine(GameE.WorldMap);
                    break;
                case StartOp.TownMap:
                        Console.WriteLine(GameE.TownMap);
                    break;
                case StartOp.speed:
                    if(settings.Settings.Dev)
                    {
                    Console.WriteLine("what speed");
                        GameE.Player.SkillsBase.speed = int.Parse(Console.ReadLine());
                    }
                    break;
                case StartOp.help:
                    Console.WriteLine();
                    break;
            }
            GameE.Player.UpdatePlayer();
            Update();
        }
    }
}

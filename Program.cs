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
    /*
                 if(PlayerName == "by engine develop")
            {
                Console.WriteLine("Ok here we go........");
                Console.ReadKey();
                Console.WriteLine("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
                Console.WriteLine("full releas coming in 2022");
                Console.ReadKey();
                Console.WriteLine("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
                Console.ReadKey();
                Console.WriteLine("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
                Console.ReadKey();
                Console.WriteLine("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
                Console.Clear();
                Console.WriteLine("...");
                Console.ReadKey();
                int Time = 1000000000;
                do
                {
                    Time--;
                } while (Time != 0);
                Console.WriteLine("high graphics?");
                Console.ReadKey();
                Time = 1000000000;
                do
                {
                    Time--;
                } while (Time != 0);
                Console.WriteLine("?");
                Console.ReadKey();
                Console.WriteLine("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
                Console.WriteLine("explore dungeons with enemy");
                Console.WriteLine("and find the wild");
                Console.ReadKey();
                Time = 50;
                do
                {
                    Time--;
                    Console.WriteLine("\r\n");
                } while (Time != 0);
                Console.Clear();
                Console.WriteLine("are you up to the challenage");
                Console.WriteLine("download it now on engine.develop.itch.io/game-in-console");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("download it now we need the money :D");
                Console.ReadKey();
                Console.Clear();
            }
     */
    public class Program : GameE
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
            Start();
            if (PlayerName == "devB" || PlayerName == "BEsBB")
                new Dev(Player, Password, PlayerName);
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
            Player.UpdatePlayer();
            string User = Console.ReadLine();
            if (settings.Settings.DunDev)
                User = "StartDun";
            switch (converter.UserToStartOp(User))
            {
                case StartOp.none:
                    break;
                case StartOp.mine:
                    OtherSystem.Mine(Player.PTools.Pickaxe);
                    break;
                case StartOp.wood:
                    OtherSystem.Wood(Player.PTools.Axe);
                    break;
                case StartOp.StartDun:
                    Dun.D_Start();
                    break;
                case StartOp.Run:
                    break;
                case StartOp.How_many_coins_go_i_have:
                    Console.WriteLine(Player.Coins);
                    break;
                case StartOp.Shop:
                    Shop.ShopStart(true, false);
                    break;
                case StartOp.Inv:
                    Player.GetPlayerInv();
                    break;
                case StartOp.Craft:
                    Craft(true);
                    break;
                case StartOp.WorldMap:
                        Console.WriteLine(WorldMap);
                    break;
                case StartOp.TownMap:
                        Console.WriteLine(TownMap);
                    break;
                case StartOp.speed:
                    if(settings.Settings.Dev)
                    {
                    Console.WriteLine("what speed");
                    Player.SkillsBase.speed = int.Parse(Console.ReadLine());
                    }
                    break;
                case StartOp.help:
                    Console.WriteLine();
                    break;
            }
            Player.UpdatePlayer();
            Update();
        }
        bool EnC = false;
        public void Craft(bool Start)
        {
            if (EnC == false)
            {
                Console.WriteLine(@"what to do say ""help"" and get help");
                EnC = true;
            }
            string Help = @"you can say ""what can i craft"" or ""wcic""";
            string UserCraft = Console.ReadLine();
            switch (converter.UserToCraftOp(UserCraft))
            {
                case CraftOp.none:
                    break;
                case CraftOp.GO:
                    Console.WriteLine("exit craft menu");
                    EnC = false;
                    break;
                case CraftOp.craft:
                    Console.WriteLine("what to craft");
                    string HTC = Console.ReadLine();
                    craft.Craft(HTC);
                    break;
                case CraftOp.wcic:
                    Console.WriteLine("HW");
                    break;
                case CraftOp.help:
                    Console.WriteLine(Help);
                    break;
                default:
                    break;
            }
            if (EnC == true)
                Craft(Start);
        }
    }
}

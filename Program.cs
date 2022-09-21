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
    class Program : GameE
    {
        string PlayerName;
        static void Main()
        {
            Console.WriteLine("Hello you there what is your name?");
            Program program = new Program(); 
            program.PStart();
        }
        void PStart()
        {
            PlayerName = Console.ReadLine();
            base.Start();
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
            string User = Console.ReadLine();
            if (settings.Settings.DunDev)
                User = "StartDun";
            switch (converter.UserToStartOp(User))
            {
                case startOp.none:
                    break;
                case startOp.mine:
                    OtherSystem.MineStone(items.StonePickaxe);
                    break;
                case startOp.StartDun:
                    Dun.D_Start();
                    break;
                case startOp.Run:
                    break;
                case startOp.How_many_coins_go_i_have:
                    Console.WriteLine(Player.Coins);
                    break;
                case startOp.Shop:
                    Shop.ShopStart(true, false);
                    break;
                case startOp.Inv:
                    Player.GetPlayerInv();
                    break;
                case startOp.Craft:
                    Craft(true);
                    break;
                case startOp.WorldMap:
                        Console.WriteLine(WorldMap);
                    break;
                case startOp.TownMap:
                        Console.WriteLine(TownMap);
                    break;
                case startOp.speed:
                    if(settings.Settings.Dev)
                    {
                    Console.WriteLine("what speed");
                    Player.SkillsBase.speed = int.Parse(Console.ReadLine());
                    }
                    break;
                case startOp.help:
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

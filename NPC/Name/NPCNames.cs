using System;
using System.Collections.Generic;
using System.Text;

namespace game_in_console.NPC.Name
{
    public class NPCNames : GameEMain.GameE
    {
        public Player player;
        public string _1NPCName = "Bolvar";
        public string ShopKeeperName = "TheShopKeeper";
        public string PlayerHelperName = "elf";
        public string TheWild = "TheWild";
        public string PlayerName;
        public string[] Dia_ShopKeeperIn = { "hello what can i do for you?", "it's it not a good day", "The Shop has all the items you need :D" };
        public string[] Dia_ShopKeeperOut = { "thanks you and bye", "bye", "farewell hero" };
        public string[] sayYes = { "yes", "Yes", "Y", "y" };
        public string[] sayWM = { "WorldMap", "worldmap", "wm", "WM" };
        public void _ShopKeeperDialog()
        { 
        }
        public void _1NPCNameDialog(int Dialog)
        {
            if(Dialog == 0)
            {
                Console.WriteLine("Hello " + PlayerName);
                Console.WriteLine("You: " + "where am i? and who are you?");
                Console.WriteLine("i am " + _1NPCName + " and you are in Strombard");
                Console.WriteLine("You: " + "you said where?");
                Console.WriteLine(_1NPCName + ": do you have a map?");
                Console.WriteLine("say no to lie or say yes to not lie");
                if (Input.GetLine(sayYes))
                {
                    Console.WriteLine("You: " + "yes i have a map");
                    Console.WriteLine(_1NPCName + ": " + "yes yes can you open it");
                }
                else
                {
                    Console.WriteLine("You: " + "no i do not have a map");
                    Console.WriteLine(_1NPCName + ": " + "ok here take this map and open it");
                }
            }
            if(Dialog == 1)
            {
                Console.WriteLine(@"say ""WorldMap"" to open your map");
                if (Input.GetLine(sayWM))
                    Console.WriteLine(WorldMap);
                Console.WriteLine("You: " + "what is Firestormb and IronMake and what is the wild?");
                Console.WriteLine(_1NPCName + ": " + "Firestromb is a friend and the wild is a place where no one has gone to in over 1000 years");
                Console.WriteLine("You: " + "but what is IronMake? ");
                Console.WriteLine(_1NPCName + ": " + "IronMake yes... its an enemy we have try to destory them but there are still here ");
                Console.WriteLine(_1NPCName + ": " + "if you want to go there you need to train for it");
                Console.WriteLine(_1NPCName + ": " + "get your gear/crafting mat at the shop");
                Console.WriteLine(@"say ""shop"" to go to the shop");
            }
        }
        public void TheWildDialog(bool first ,int Dialog)
        {
            string need = "";
            if (Dialog == 0)
            {
                if(first)
                {
                    Console.WriteLine(TheWild + ": welcome to the wild and im The wild you are in. a thing says");
                    Console.WriteLine(TheWild + ": what ever you do, do not go down to a dun level you are not at");
                    Console.WriteLine(TheWild + ": you are on level " + player.Level);
                    settings.Settings.FirstTimeInWild = false;
                    Console.WriteLine(TheWild + ": you can go down " + player.Level + 1 + " duns");
                }
                else
                {
                    Console.WriteLine(TheWild + ": Hello " + PlayerName + " you can go down " + player.Level + 1 + " duns");
                }
            }
            if(Dialog == 1)
            {
                Console.WriteLine(PlayerHelperName + ": you can say what do i need to go down there(needs) or you just go down new (down)");
                string PlayerU = Console.ReadLine();
                if (PlayerU == "need")
                {
                    Console.WriteLine("you: what do i need?");
                    Console.WriteLine(TheWild + ": " + need);
                }
                Console.WriteLine(TheWild + ": ok what level");
            }
        }
    }
}

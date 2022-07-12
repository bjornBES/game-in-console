using System;
using System.Collections.Generic;
using System.Text;

namespace game_in_console.NPC.Name
{
    public class NPCNames
    {
        public string _1NPCName = "Bolvar";
        public string ShopKeeperName = "TheShopKeeper";
        public string PlayerName;
        public string[] Dia_ShopKeeperIn = { "hello what can i do for you?", "it's it not a good day", "The Shop has all the items you need :D" };
        public string[] Dia_ShopKeeperOut = { "thanks you and bye", "bye", "farewell hero" };
        public void _ShopKeeperDialog()
        { 
        }
        public void _1NPCNameDialog(int Dialog, map.Map Map)
        {
            if(Dialog == 0)
            {
                Console.WriteLine("Hello " + PlayerName);
                Console.WriteLine("You: " + "where am i? and who are you?");
                Console.WriteLine("i am" + _1NPCName + "and you are in Strombard");
                Console.WriteLine("You: " + "you said where?");
                Console.WriteLine(_1NPCName + ": do you have a map?");
                Console.WriteLine("say no to lie or say yes to not lie");
                string User = Console.ReadLine();
                if (User == "yes" || User == "Yes" || User == "y" || User == "Y")
                {
                    Console.WriteLine("You: " + "yes i have a map");
                    Console.WriteLine(_1NPCName + ": " + "yes yes can you open it");
                }
                if (User == "no" || User == "No" || User == "n" || User == "N")
                {
                    Console.WriteLine("You: " + "no i do not have a map");
                    Console.WriteLine(_1NPCName + ": " + "ok here take this map and open it");
                }
            }
            if(Dialog == 1)
            {
                Console.WriteLine(@"say ""WorldMap"" to open your map");
                string User = Console.ReadLine();
                if (User == "WorldMap" || User == "worldmap" || User == "wm" || User == "WM")
                {
                    for (int i = 0; i < Map.WorldMap.Length; i++)
                    {
                        Console.WriteLine(Map.WorldMap[i]);
                    }
                }
                Console.WriteLine("You: " + "what is Firestormb and what is the wild?");
                Console.WriteLine(_1NPCName + ": " + "Firestromb is a friend and the wild is a place where no one has gone to in over 1000 years");
                Console.WriteLine("You: " + "what... over 1000 years :O ");
                Console.WriteLine(_1NPCName + ": " + "if you want to go there you need to train for it");
                Console.WriteLine(_1NPCName + ": " + "get your gear at the shop");
                Console.WriteLine(@"say ""shop"" to go to the shop");
            }
        }
    }
}

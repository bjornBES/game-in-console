using System;
using game_in_console.crafting;
using game_in_console.Shoping;
using game_in_console.NPC.Name;
using game_in_console.dun;
using game_in_console.dun.enemys;
using game_in_console.enums;
using GameEMain;

namespace game_in_console.otherSystem
{
    public class OtherSystem
    {
        public Player player;
        public bool HasPickaxe;
        public bool HasAxe;
        public OtherSystem()
        {
        }
        public int WalkingDis;
        public int time;
        public int _time;
        public void MineStone(items Pickaxe)
        {
            Random RNG = new Random();
            //if (HasPickaxe)
            switch (Pickaxe)
            {
                case items.StonePickaxe:
                    WalkingDis = RNG.Next(5, 10);
                    break;
            }
            time = WalkingDis / player.SkillsBase.speed;
            Console.WriteLine("the walkingDis is " + WalkingDis + "km and it will take " + time + "min do you wont to go?");
            string User = Console.ReadLine();
            if (User == "yes")
            {
                _time = DateTime.Now.Minute;
                Console.WriteLine("ok");
                TakeTime();
            }

        }
        bool Done;
        int Timer;
        public void TakeTime()
        {
            Timer = _time + time;
            string User = Console.ReadLine();
            if (User == "done")
                Console.WriteLine("here " + Timer + "Minutes");
            if (Timer <= DateTime.Now.Minute)
            {
                Done = true;
            }
            else
                TakeTime();
            if (Done)
                mine();
        }
        public void mine()
        {
            items Re = items.none;
            Random random = new Random();
            int perCent = random.Next(0, 70);
            if (perCent < 30)
            {
                Re = items.ironore;
            }
            else if (perCent < 30 + 10)
            {
                Re = items.coal;
            }
            else if (perCent < 30 + 20)
            {
                Re = items.stone;
            }
            else if (perCent < 30 + 40)
            {
                Re = items.stone;
            }
            bool Done = false;
            for (int i = 0; i < player.InvIndex; i++)
            {
                if (player.Inv[i] == Re && Done != true)
                {
                    player.Inv[i] = Re;
                    player.InvCon[i] = player.InvCon[i] + 1;
                    Done = true;
                }
                else if (player.Inv[player.InvIndex] == items.none && Done != true && i == player.InvIndex - 1)
                {
                    player.Inv[player.InvIndex] = Re;
                    player.InvCon[player.InvIndex] = player.InvCon[player.InvIndex] + 1;
                    player.InvIndex++;
                    Done = true;
                }
            }
        }
    }
}

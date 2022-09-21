using System;
using System.Linq;
using game_in_console.crafting;
using game_in_console.Shoping;
using game_in_console.NPC.Name;
using game_in_console.dun;
using game_in_console.dun.enemys;
using game_in_console.enums;
using game_in_console.player;
using GameEMain;

namespace game_in_console.otherSystem
{
    public class OtherSystem
    {
        public Player player;
        public bool HasPickaxe;
        public bool HasBukkit;
        public bool HasAxe;
        readonly Random RNG;
        public OtherSystem()
        {
            RNG = new Random();
        }
        //in M
        public int Mine_WalkingDis;
        public int Mine_time;
        public int Mine__time;
        //in m
        public int Lava_WalkingDis;
        public int Lava_time;
        public int Lava__time;
        public void GetLava()
        {
            if(HasBukkit == true)
            {
                Lava_WalkingDis = RNG.Next(10, 15);
                Lava_time = Lava_WalkingDis / (player.Skills.speed + Input.Range(0,1,1));
                Console.WriteLine("the walkingDis is " + Lava_WalkingDis + "km and it will take " + Lava_time + "min do you wont to go?");
                string User = Console.ReadLine();
                if (User == "yes")
                {
                    Mine__time = DateTime.Now.Minute;
                    Console.WriteLine("ok");
                    TakeTime(Lava__time, Lava_time);
                }
            }
        }
        public void MineStone(items Pickaxe)
        {
            //if (HasPickaxe)
            switch (Pickaxe)
            {
                case items.StonePickaxe:
                    Mine_WalkingDis = RNG.Next(5, 10);
                    break;
            }
            Mine_time = Mine_WalkingDis / player.Skills.speed;
            Console.WriteLine("the walkingDis is " + Mine_WalkingDis + "km and it will take " + Mine_time + "min do you wont to go?");
            string User = Console.ReadLine();
            if (User == "yes")
            {
                Mine__time = DateTime.Now.Minute;
                Console.WriteLine("ok");
                TakeTime(Mine__time, Mine_time);
            }

        }
        bool Done;
        int Timer;
        public void TakeTime(int Start_time, int Distime)
        {
            Timer = Start_time + Distime;
            string User = Console.ReadLine();
            if (User == "done")
                Console.WriteLine("here " + Timer + "Minutes");
            if (Timer <= DateTime.Now.Minute)
            {
                Done = true;
            }
            else
                TakeTime(Start_time, Distime);
            if (Done)
                Mine();
        }
        public void Mine()
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

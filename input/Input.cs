using System;
using System.Collections.Generic;
using System.Text;

namespace game_in_console
{
    public static class Input
    {
        static bool E { get; set; }
        public static void SetEesy()
        {
            if (E)
                E = false;
            else
                E = true;
        }
        public static bool GetLine(string[] Line)
        {
            bool Re = false;
            string In = Console.ReadLine();
            for (int i = 0; i < Line.Length; i++)
            {
                if (In == Line[i])
                    Re = true;
            }
            return Re;
        }
        public static bool Chance(int a, int min, int max)
        {
            Random random = new Random();
            if (random.Next(min, max) < a)
                return true;
            else
                return false;
        }
    }
}

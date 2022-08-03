using System;
using System.Collections.Generic;
using System.Text;

namespace game_in_console
{
    public enum Bugs
    {
        shop,
        craft,
        item,
        inv
    }
    public static class Bug
    {
        public static void MessBug(int ErrorCode, Bugs bugs)
        {
            string common = "please message the creator on discord in the " +
                "BjornBEs Server or on twitter at @BjornBEs1 \n " +
                "in the message set the the first line to" + 
                @" ""Bug in Game"" #CG" + ErrorCode + 
                " and he will answer as fast as he can";
            switch (bugs)
            {
                case Bugs.shop:
                    if(ErrorCode == 01920)
                        Console.WriteLine("Error: \n " +
                "Shop data can't find item \n " + common);
                    break;
                case Bugs.craft:
                    if (ErrorCode == 01023)
                        Console.WriteLine("Error: \n " +
                "database can't find item \n " + common);
                    break;
                case Bugs.item:
                    break;
                case Bugs.inv:
                    break;
                default:
                    break;
            }
            //Console.WriteLine(craft.CraftintItems);
            Console.Title = "error... #CG" + ErrorCode;
        }
    }
}

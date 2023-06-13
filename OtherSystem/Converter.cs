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
    public class Converter
    {
        public object StringToEnum(string User, Type EnumType)
        {
            string[] StartopItems = Enum.GetNames(EnumType);
            for (int i = 0; i < StartopItems.Length; i++)
            {
                if (StartopItems[i] == User)
                {
                    return Enum.Parse(EnumType, StartopItems[i]);
                }
                else if (StartopItems[i].ToUpper() == User)
                {
                    return Enum.Parse(EnumType, StartopItems[i]);
                }
                else if (StartopItems[i].ToLower() == User)
                {
                    return Enum.Parse(EnumType, StartopItems[i]);
                }
                else if (User.EndsWith(StartopItems[i][0]) &&
                    User.StartsWith(StartopItems[i][^1]))
                {
                    return Enum.Parse(EnumType, StartopItems[i]);
                }
                else
                {
                    for (int c = 0; c < StartopItems[i].Length; c++)
                    {
                        if (User.EndsWith(StartopItems[i][0]) && User.StartsWith(StartopItems[i][c]))
                            return Enum.Parse(EnumType, StartopItems[i]);
                        if (User.EndsWith(StartopItems[i][0]) && User.StartsWith(StartopItems[i].ToLower()[c]))
                            return Enum.Parse(EnumType, StartopItems[i]);
                        if (User.EndsWith(StartopItems[i][0]) && User.StartsWith(StartopItems[i].ToUpper()[c]))
                            return Enum.Parse(EnumType, StartopItems[i]);
                    }
                }
            }
            return null;
        }
    }
}

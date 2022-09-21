using System;
using System.Collections.Generic;
using System.Text;
using game_in_console.crafting;
using game_in_console.Shoping;
using game_in_console.NPC.Name;
using game_in_console.dun;
using game_in_console.dun.enemys;
using game_in_console.data.items;
using game_in_console;
using game_in_console.otherSystem;
using game_in_console.enums;
using game_in_console.player;
namespace game_in_console.player
{
    public class PlayerData
    {
        public Skills SkillsBase;
        public Skills Skills;
        public PlayerGear Gear;
        public Gear gear;
        public Tools Tools;
        public bool IsDun;
        public items[] Inv;
        public int[] InvCon;
        public int InvIndex = 0;
        public int Coins = 50;
        public int Level = 0;
        public void LevelUp(int level)
        {
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="WhatSkill">0 = HP 1 = armor 2 = DPS 3 = agility 4 = speed 5 = dodgeC</param>
        /// <returns></returns>
        public int UpdateArmor(int WhatSkill, Gear gear)
        {
            int Re = 0;
            switch (WhatSkill)
            {
                case 0:
                    Re = gear.GetGearData(ArmorTypes.helmet).HP +
                gear.GetGearData(ArmorTypes.Shoulders).HP +
                gear.GetGearData(ArmorTypes.Chestplece).HP +
                gear.GetGearData(ArmorTypes.Cloak).HP +
                gear.GetGearData(ArmorTypes.MainHand).HP +
                gear.GetGearData(ArmorTypes.Ofhand).HP +
                gear.GetGearData(ArmorTypes.legs).HP;
                    break;
                case 1:
                    Re = gear.GetGearData(ArmorTypes.helmet).armor +
gear.GetGearData(ArmorTypes.Shoulders).armor +
gear.GetGearData(ArmorTypes.Chestplece).armor +
gear.GetGearData(ArmorTypes.Cloak).armor +
gear.GetGearData(ArmorTypes.legs).armor;
                    break;
                case 2:
                    Re = gear.GetGearData(ArmorTypes.helmet).DPS +
                gear.GetGearData(ArmorTypes.Shoulders).DPS +
                gear.GetGearData(ArmorTypes.Chestplece).DPS +
                gear.GetGearData(ArmorTypes.Cloak).DPS +
                gear.GetGearData(ArmorTypes.MainHand).DPS +
                gear.GetGearData(ArmorTypes.Ofhand).DPS +
                gear.GetGearData(ArmorTypes.legs).DPS;
                    break;
                case 3:
                    Re = gear.GetGearData(ArmorTypes.helmet).Agility +
gear.GetGearData(ArmorTypes.Shoulders).Agility +
gear.GetGearData(ArmorTypes.Chestplece).Agility +
gear.GetGearData(ArmorTypes.Cloak).Agility +
gear.GetGearData(ArmorTypes.MainHand).Agility +
gear.GetGearData(ArmorTypes.Ofhand).Agility +
gear.GetGearData(ArmorTypes.legs).Agility;
                    break;
                case 4:
                    Re = gear.GetGearData(ArmorTypes.helmet).speed +
gear.GetGearData(ArmorTypes.Shoulders).speed +
gear.GetGearData(ArmorTypes.Chestplece).speed +
gear.GetGearData(ArmorTypes.Cloak).speed +
gear.GetGearData(ArmorTypes.MainHand).speed +
gear.GetGearData(ArmorTypes.Ofhand).speed +
gear.GetGearData(ArmorTypes.legs).speed;
                    break;
                case 5:
                    Re = gear.GetGearData(ArmorTypes.helmet).dodgeC +
gear.GetGearData(ArmorTypes.Shoulders).dodgeC +
gear.GetGearData(ArmorTypes.Chestplece).dodgeC +
gear.GetGearData(ArmorTypes.Cloak).dodgeC +
gear.GetGearData(ArmorTypes.MainHand).dodgeC +
gear.GetGearData(ArmorTypes.Ofhand).dodgeC +
gear.GetGearData(ArmorTypes.legs).dodgeC;
                    break;
            }
            return Re;
        }
    }
    public class SwordSkills
    {
        public int Dps;
        public int BlockChance;
        public int HitChance;
    }
    public class Tools
    {
        public items Pickaxe;
        public items Axe;
        public bool torch;
    }
    public class Skills
    {
        public int Hp;
        public int armor;
        public int Strength;
        /// <summary>
        /// for runing form enemys
        /// </summary>
        public int Agility;
        /// <summary>
        /// the speed is for go mining
        /// </summary>
        public int speed;
        public int dodgeC;
    }
    public class PlayerGear
    {
        public helmet_Armor Helm;
        public Shoulders_Armor Shoulders;
        public Chestplece_Armor Chestplece;
        public Cloak_Armor Cloak;
        public items MainHand;
        public items Ofhand;
        public legs_Armor legs;
    }
}

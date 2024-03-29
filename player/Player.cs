﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game_in_console.enums;
using game_in_console.dun.enemys;
using GameEMain;
using game_in_console.data.items;
namespace game_in_console.player
{
    public class Player : PlayerData
    {
        public Player()
        {
            Skills = new Skills();
            SkillsBase = new Skills();
            PTools = new Tools();
            Gear = new PlayerGear();
            int SpaceInInv = 50;
            Inv = new Items[SpaceInInv];
            for (int i = 0; i < Inv.Length; i++)
            {
                Inv[i] = Items.none;
            }
            InvCon = new int[SpaceInInv];
        }
        /// <summary>
        /// for the player's armor/tools
        /// </summary>
        public void UpdatePlayer()
        {
            PTools = GetTools();
            Skills.Hp = UpdateArmor(0, gear) + SkillsBase.Hp;
            Skills.armor = UpdateArmor(1, gear) + SkillsBase.armor;
            Skills.Strength = UpdateArmor(2, gear) + SkillsBase.Strength;
            Skills.Agility = UpdateArmor(3, gear) + SkillsBase.Agility;
            Skills.speed = UpdateArmor(4, gear) + SkillsBase.speed;
            Skills.dodgeC = UpdateArmor(5, gear) + SkillsBase.dodgeC;
            if (BronzeCount == 2)
                alloysS = true;
        }
        public void SetPLayerD()
        {
            Level = 1;
            SkillsBase.Hp = 10;
            SkillsBase.armor = 0;
            SkillsBase.Strength = 0;
            SkillsBase.Agility = 2;
            SkillsBase.speed = 2;
            SkillsBase.dodgeC = 20;
        }

        public void GetPlayerInv()
        {
            Console.WriteLine("you have");
            for (int i = 0; i < InvIndex; i++)
            {
                Console.WriteLine(InvCon[i].ToString() + " " + Inv[i].ToString() + ", ");
            }
        }
        public Tools GetTools()
        {
            Tools re = new Tools();
            for (int i = 0; i < InvIndex; i++)
            {
                switch (Inv[i])
                {
                    case Items.WoodenPickaxe:
                        re.Pickaxe = Inv[i];
                        break;
                    case Items.StonePickaxe:
                        re.Pickaxe = Inv[i];
                        break;
                    case Items.IronPickaxe:
                        re.Pickaxe = Inv[i];
                        break;
                    case Items.an_old_axe_form_Bolvar:
                        re.Axe = Inv[i];
                        break;
                    case Items.WoodenAxe:
                        re.Axe = Inv[i];
                        break;
                    case Items.StoneAxe:
                        re.Axe = Inv[i];
                        break;
                    case Items.IronAxe:
                        re.Axe = Inv[i];
                        break;
                    default:
                        break;
                }
                if (Inv[i] == Items.bukkit)
                    settings.Settings.HasBukkit = true;
                if (Inv[i] == Items.torch)
                    re.torch = true;
            }
            return re;
        }
    }
}

using game_in_console.crafting;
using game_in_console.Shoping;
using game_in_console.NPC.Name;
using game_in_console.dun;
using game_in_console.dun.enemys;
using game_in_console;
using game_in_console.otherSystem;
using game_in_console.player;
using game_in_console.enums;

namespace game_in_console.data.items
{
    public class GearData
    {
        public string name;
        public string discretion;
        public int ItemS;
        public int HP;
        public int armor;
        public int DPS;
        /// <summary>
        /// for runing form enemys
        /// </summary>
        public int Agility;
        /// <summary>
        /// the speed is for go mining
        /// </summary>
        public int speed;
        public int dodgeC;
        //swords
        public int BlockChance;
        public int HitChance;
    }
    public class Gear
    {
        public Player Player;
        readonly DiscretionBase DiscretionBase = new DiscretionBase();
        public GearData GetGearData(ArmorTypes armorType)
        {
            GearData re = new GearData();
            switch (armorType)
            {
                case ArmorTypes.helmet:
                    switch (Player.Gear.Helm)
                    {
                        case helmet_Armor.Crown_of_the_Righteous:
                            re.discretion = "how holy is this? about 16.666666666666666666666666666...   7%";
                            re.ItemS = 32;
                            re.HP = 20;
                            re.armor = 20;
                            re.DPS = 25;
                            re.Agility = 15;
                            re.speed = 15;
                            re.dodgeC = 20;
                            break;
                        case helmet_Armor.Steel_helmet:
                            re.discretion = DiscretionBase.SteelHelmetDis(Player);
                            re.ItemS = 28;
                            re.HP = 18;
                            re.armor = 18;
                            re.DPS = 20;
                            re.Agility = 10;
                            re.speed = 10;
                            re.dodgeC = 15;
                            break;
                        case helmet_Armor.Bronze_helmet:
                            if (settings.Settings.IsMetric == true)
                            {
                                re.discretion = "100% steel how heavy is it... 1.4kg";
                                if (Player.Skills.Strength! > 10)
                                    re.discretion = "100% steel how heavy is it... 1.4kg + you are weak";
                                else
                                    re.discretion = "100% steel how heavy is it... only? 1.48 kg?";
                            }
                            else
                            {
                                re.discretion = "100% steel how heavy is it... 2.5 lbs";
                                if (Player.Skills.Strength! > 10)
                                    re.discretion = "100% steel how heavy is it... 2.5 lbs + you are weak";
                                else
                                    re.discretion = "100% steel how heavy is it... only? 2.5 lbs?";
                            }
                            re.ItemS = 0;
                            re.HP = 0;
                            re.armor = 0;
                            re.DPS = 0;
                            re.Agility = 0;
                            re.speed = 0;
                            re.dodgeC = 0;
                            break;
                        case helmet_Armor.Diamond_helmet:
                            re.discretion = "";
                            re.ItemS = 0;
                            re.HP = 0;
                            re.armor = 0;
                            re.DPS = 0;
                            re.Agility = 0;
                            re.speed = 0;
                            re.dodgeC = 0;
                            break;
                        case helmet_Armor.iron_helmet:
                            re.discretion = "";
                            re.ItemS = 0;
                            re.HP = 0;
                            re.armor = 0;
                            re.DPS = 0;
                            re.Agility = 0;
                            re.speed = 0;
                            re.dodgeC = 0;
                            break;
                        case helmet_Armor.leather_helmet:
                            re.discretion = "";
                            re.ItemS = 0;
                            re.HP = 0;
                            re.armor = 0;
                            re.DPS = 0;
                            re.Agility = 0;
                            re.speed = 0;
                            re.dodgeC = 0;
                            break;
                    }
                    break;
                case ArmorTypes.Shoulders:
                    switch (Player.Gear.Shoulders)
                    {
                        case Shoulders_Armor.Righteous_shoulders:
                            re.discretion = "";
                            re.ItemS = 0;
                            re.HP = 0;
                            re.armor = 0;
                            re.DPS = 0;
                            re.Agility = 0;
                            re.speed = 0;
                            re.dodgeC = 0;
                            break;
                        case Shoulders_Armor.Steel_shoulders:
                            re.discretion = "";
                            re.ItemS = 0;
                            re.HP = 0;
                            re.armor = 0;
                            re.DPS = 0;
                            re.Agility = 0;
                            re.speed = 0;
                            re.dodgeC = 0;
                            break;
                        case Shoulders_Armor.Bronze_shoulders:
                            re.discretion = "";
                            re.ItemS = 0;
                            re.HP = 0;
                            re.armor = 0;
                            re.DPS = 0;
                            re.Agility = 0;
                            re.speed = 0;
                            re.dodgeC = 0;
                            break;
                        case Shoulders_Armor.Diamond_shoulders:
                            re.discretion = "";
                            re.ItemS = 0;
                            re.HP = 0;
                            re.armor = 0;
                            re.DPS = 0;
                            re.Agility = 0;
                            re.speed = 0;
                            re.dodgeC = 0;
                            break;
                        case Shoulders_Armor.iron_shoulders:
                            re.discretion = "";
                            re.ItemS = 0;
                            re.HP = 0;
                            re.armor = 0;
                            re.DPS = 0;
                            re.Agility = 0;
                            re.speed = 0;
                            re.dodgeC = 0;
                            break;
                        case Shoulders_Armor.leather_shoulders:
                            re.discretion = "";
                            re.ItemS = 0;
                            re.HP = 0;
                            re.armor = 0;
                            re.DPS = 0;
                            re.Agility = 0;
                            re.speed = 0;
                            re.dodgeC = 0;
                            break;
                        default:
                            break;
                    }
                    break;
                case ArmorTypes.Chestplece:
                    break;
                case ArmorTypes.Cloak:
                    break;
                case ArmorTypes.Ofhand:
                    break;
                case ArmorTypes.legs:
                    switch (Player.Gear.legs)
                    {
                        case legs_Armor.Righteous_legs:
                            break;
                        default:
                            break;
                    }
                    break;
                case ArmorTypes.MainHand:
                    switch (Player.Gear.MainHand)
                    {
                        case enums.items.none:
                            re.DPS = 5;
                            re.HitChance = 99;
                            re.BlockChance = 0;
                            break;
                        case enums.items.stone:
                            re.DPS = 6;
                            re.HitChance = 50;
                            re.BlockChance = 0;
                            break;
                        case enums.items.stick:
                            re.DPS = 3;
                            re.HitChance = 85;
                            re.BlockChance = 25;
                            break;
                        case enums.items.WoodenPickaxe:
                            re.DPS = 8;
                            re.HitChance = 80;
                            re.BlockChance = 25;
                            break;
                        case enums.items.StonePickaxe:
                            re.DPS = 12;
                            re.HitChance = 75;
                            re.BlockChance = 30;
                            break;
                        case enums.items.IronPickaxe:
                            re.DPS = 15;
                            re.HitChance = 70;
                            re.BlockChance = 30;
                            break;
                        case enums.items.WoodenAxe:
                            re.DPS = 9;
                            re.HitChance = 80;
                            re.BlockChance = 20;
                            break;
                        case enums.items.StoneAxe:
                            re.DPS = 14;
                            re.HitChance = 75;
                            re.BlockChance = 20;
                            break;
                        case enums.items.IronAxe:
                            re.DPS = 18;
                            re.HitChance = 60;
                            re.BlockChance = 25;
                            break;
                        case enums.items.WoodenSword:
                            re.DPS = 10;
                            re.HitChance = 80;
                            re.BlockChance = 40;
                            break;
                        case enums.items.StoneSword:
                            re.DPS = 15;
                            re.HitChance = 75;
                            re.BlockChance = 40;
                            break;
                        case enums.items.IronSword:
                            re.DPS = 20;
                            re.HitChance = 65;
                            re.BlockChance = 50;
                            break;
                        default:
                            break;
                    }
                    break;
            }
            return re;
        }
    }
}

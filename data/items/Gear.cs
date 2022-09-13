using game_in_console.crafting;
using game_in_console.Shoping;
using game_in_console.NPC.Name;
using game_in_console.dun;
using game_in_console.dun.enemys;
using game_in_console;
using game_in_console.otherSystem;
using game_in_console.enums;

namespace game_in_console.data.items
{
    public class GearData
    {
        public string name;
        public string dis;
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
    public class gear
    {
        public Player Player;
        public GearData GetGearData(ArmorTypes armorType)
        {
            GearData re = new GearData();
            switch (armorType)
            {
                case ArmorTypes.helmet:
                    switch (Player.Gear.Helm)
                    {
                        case helmet_Armor.dark_rongers_hood:
                            re.armor = 15;
                            re.dis = "how did you get that? form WOW";
                            re.ItemS = 32;
                            break;
                        case helmet_Armor.Crown_of_the_Righteous:
                            re.armor = 20;
                            re.dis = "how holy is this? about 99%";
                            re.DPS = 10;
                            re.speed = 1;
                            re.ItemS = 32;
                            break;
                        case helmet_Armor.scouts_hood:
                            break;
                        case helmet_Armor.leather:
                            break;
                        case helmet_Armor.iron:
                            break;
                        default:
                            break;
                    }
                    break;
                case ArmorTypes.Shoulders:
                    break;
                case ArmorTypes.Chestplece:
                    break;
                case ArmorTypes.Cloak:
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
                case ArmorTypes.Ofhand:
                    break;
                case ArmorTypes.legs:
                    switch (Player.Gear.legs)
                    {
                        case legs_Armor.leather:
                            break;
                        case legs_Armor.Righteous_legs:
                            break;
                        case legs_Armor.iron:
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            return re;
        }
    }
}

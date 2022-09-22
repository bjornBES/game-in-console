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
                        case Helmet_Armor.Crown_of_the_Righteous:
                            re.discretion = "how holy is this? about 16.666666666666666666666666666...   7%";
                            re.ItemS = 32;
                            re.HP = 20;
                            re.armor = 20;
                            re.DPS = 25;
                            re.Agility = 15;
                            re.speed = 15;
                            re.dodgeC = 20;
                            break;
                        case Helmet_Armor.Steel_helmet:
                            re.discretion = DiscretionBase.SteelarmorDis(armorType, Player);
                            re.ItemS = 28;
                            re.HP = 18;
                            re.armor = 18;
                            re.DPS = 20;
                            re.Agility = 10;
                            re.speed = 10;
                            re.dodgeC = 15;
                            break;
                        case Helmet_Armor.Bronze_helmet:
                            re.discretion = "";
                            re.ItemS = 0;
                            re.HP = 0;
                            re.armor = 0;
                            re.DPS = 0;
                            re.Agility = 0;
                            re.speed = 0;
                            re.dodgeC = 0;
                            break;
                        case Helmet_Armor.Diamond_helmet:
                            re.discretion = "";
                            re.ItemS = 0;
                            re.HP = 0;
                            re.armor = 0;
                            re.DPS = 0;
                            re.Agility = 0;
                            re.speed = 0;
                            re.dodgeC = 0;
                            break;
                        case Helmet_Armor.iron_helmet:
                            re.discretion = "";
                            re.ItemS = 0;
                            re.HP = 0;
                            re.armor = 0;
                            re.DPS = 0;
                            re.Agility = 0;
                            re.speed = 0;
                            re.dodgeC = 0;
                            break;
                        case Helmet_Armor.leather_helmet:
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
                        case Legs_Armor.Righteous_legs:
                            break;
                        default:
                            break;
                    }
                    break;
                case ArmorTypes.MainHand:
                    switch (Player.Gear.MainHand)
                    {
                        case enums.Items.none:
                            re.DPS = 5;
                            re.HitChance = 99;
                            re.BlockChance = 0;
                            break;
                        case enums.Items.stone:
                            re.DPS = 6;
                            re.HitChance = 50;
                            re.BlockChance = 0;
                            break;
                        case enums.Items.stick:
                            re.DPS = 3;
                            re.HitChance = 85;
                            re.BlockChance = 25;
                            break;
                        case enums.Items.WoodenPickaxe:
                            re.DPS = 8;
                            re.HitChance = 80;
                            re.BlockChance = 25;
                            break;
                        case enums.Items.StonePickaxe:
                            re.DPS = 12;
                            re.HitChance = 75;
                            re.BlockChance = 30;
                            break;
                        case enums.Items.IronPickaxe:
                            re.DPS = 15;
                            re.HitChance = 70;
                            re.BlockChance = 30;
                            break;
                        case enums.Items.WoodenAxe:
                            re.DPS = 9;
                            re.HitChance = 80;
                            re.BlockChance = 20;
                            break;
                        case enums.Items.StoneAxe:
                            re.DPS = 14;
                            re.HitChance = 75;
                            re.BlockChance = 20;
                            break;
                        case enums.Items.IronAxe:
                            re.DPS = 18;
                            re.HitChance = 60;
                            re.BlockChance = 25;
                            break;
                        case enums.Items.WoodenSword:
                            re.DPS = 10;
                            re.HitChance = 80;
                            re.BlockChance = 40;
                            break;
                        case enums.Items.StoneSword:
                            re.DPS = 15;
                            re.HitChance = 75;
                            re.BlockChance = 40;
                            break;
                        case enums.Items.IronSword:
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

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
    public class DiscretionBase
    {
        public string SteelarmorDis(ArmorTypes armor, Player Player)
        {
            string SteelArmor = "100% steel how heavy is it... ";
            float SteelHelmetKg = 1.4f;
            string SteelLowStre = " + you are weak";
            string SteelNLowStre = " only?";
            bool IsMetric = settings.Settings.IsMetric;
            float lb;
            string re = "";
            switch (armor)
            {
                case ArmorTypes.helmet:
                    lb = SteelHelmetKg * 2.2046f;
                    if (IsMetric == true)
                    {
                        _ = SteelArmor + SteelHelmetKg.ToString() + "kg";
                        if (Player.Skills.Strength! > 10)
                            re = SteelArmor + SteelHelmetKg.ToString() + "kg" + SteelLowStre;
                        else
                            re = SteelArmor + SteelNLowStre + "?" + SteelHelmetKg.ToString() + "kg";
                    }
                    else
                    {
                        _ = SteelArmor + lb.ToString() + "lb";
                        if (Player.Skills.Strength! > 10)
                            re = SteelArmor + lb.ToString() + "lb" + SteelLowStre;
                        else
                            re = SteelArmor + SteelNLowStre + "?" + lb.ToString() + "lb";
                    }
                    break;
                case ArmorTypes.Shoulders:
                    lb = SteelHelmetKg * 2.2046f;
                    if (IsMetric == true)
                    {
                        _ = SteelArmor + SteelHelmetKg.ToString() + "kg";
                        if (Player.Skills.Strength! > 10)
                            re = SteelArmor + SteelHelmetKg.ToString() + "kg" + SteelLowStre;
                        else
                            re = SteelArmor + SteelNLowStre + "?" + SteelHelmetKg.ToString() + "kg";
                    }
                    else
                    {
                        _ = SteelArmor + lb.ToString() + "lb";
                        if (Player.Skills.Strength! > 10)
                            re = SteelArmor + lb.ToString() + "lb" + SteelLowStre;
                        else
                            re = SteelArmor + SteelNLowStre + "?" + lb.ToString() + "lb";
                    }
                    break;
                case ArmorTypes.Chestplece:
                    break;
                case ArmorTypes.Cloak:
                    break;
                case ArmorTypes.MainHand:
                    break;
                case ArmorTypes.Ofhand:
                    break;
                case ArmorTypes.legs:
                    break;
                default:
                    break;
            }
            return re;
        }
        public string BronzeHelmetDis(Player Player)
        {
            string BronzeHelmet = "100% bronze... what? it can be ";
            float BronzeHelmetKg = 9f;
            string BronzeHelmetLowStre = " so high? its only ";
            string BronzeHelmetNLowStre = " only?";
            float lb = BronzeHelmetKg * 2.2046f;
            string re;
            if (settings.Settings.IsMetric == true)
            {
                _ = BronzeHelmet + BronzeHelmetKg.ToString() + "kg";
                if (Player.Skills.Strength! > 20)
                    re = BronzeHelmet + BronzeHelmetLowStre + BronzeHelmetKg.ToString() + "kg";
                else
                    re = BronzeHelmet + BronzeHelmetNLowStre + BronzeHelmetKg.ToString() + "kg";
            }
            else
            {
                _ = BronzeHelmet + lb.ToString() + "lb";
                if (Player.Skills.Strength! > 20)
                    re = BronzeHelmet + BronzeHelmetLowStre + lb.ToString() + "lb";
                else
                    re = BronzeHelmet + BronzeHelmetNLowStre + lb.ToString() + "lb";
            }
            return re;
        }
    }
}

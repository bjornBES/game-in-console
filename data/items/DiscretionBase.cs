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
        public string SteelHelmet = "100% steel how heavy is it... ";
        public float SteelHelmetKg = 1.4f;
        public string SteelHelmetLowStre = " + you are weak";
        public string SteelHelmetNLowStre = " + only?";
        public string SteelHelmetDis(Player Player)
        {
            float lb = SteelHelmetKg * 2.2046f;
            string re;
            if (settings.Settings.IsMetric == true)
            {
                _ = SteelHelmet + SteelHelmetKg.ToString() + "kg";
                if (Player.Skills.Strength! > 10)
                    re = SteelHelmet + SteelHelmetKg.ToString() + "kg" + SteelHelmetLowStre;
                else
                    re = SteelHelmet + SteelHelmetNLowStre + "?" + SteelHelmetKg.ToString() + "kg";
            }
            else
            {
                re = SteelHelmet + lb.ToString() + "lb";
                if (Player.Skills.Strength! > 10)
                    re = SteelHelmet + lb.ToString() + "lb" + SteelHelmetLowStre;
                else
                    re = SteelHelmet + SteelHelmetNLowStre + "?" + lb.ToString() + "lb";
            }
            return re;
        }
    }
}

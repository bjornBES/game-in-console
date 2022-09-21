using System;
using System.Collections.Generic;
using System.Text;

namespace settings
{
    public class Settings
    {
        public static bool Dev { set; get; }
        public static bool DunDev { set; get; }
        /// <summary>
        /// the dun level that the player is in
        /// </summary>
        public static int DunLevel { set; get; }
        public static bool FirstTimeInWild { set; get; } = true;
        public static bool IsMetric { get; set; } = System.Globalization.RegionInfo.CurrentRegion.IsMetric;
        public static bool HasBukkit { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace game_in_console.dun.enemys
{
    public class Data
    {
        public string name;
        public int Hp;
        public int Dps;
        public int StartLevel;
    }
    public class EnemyData : Data
    {
        public int C;
        public int DunLevel;
    }
    public class BossData : Data
    {
        public int DunLevel;
    }
    public class EnemyCom
    {
        public BossData[] BossData = new BossData[100];
        public EnemyData[] Data = new EnemyData[100];
        int enemyIndex = 0;
        int BossDataIndex = 0;
        public void addenemy(string name, int Hp, int Dps, int Chane, int DunLevel, int Level)
        {
            Data[enemyIndex].name = name;
            Data[enemyIndex].Hp = Hp;
            Data[enemyIndex].Dps = Dps;
            Data[enemyIndex].C = Chane;
            Data[enemyIndex].DunLevel = DunLevel;
            Data[enemyIndex].StartLevel = Level;
        }
        public void addBoss(string name, int Hp, int Dps, int DunLevel)
        {
            BossData[BossDataIndex].name = name;
            BossData[BossDataIndex].Hp = Hp;
            BossData[BossDataIndex].Dps = Dps;
            BossData[BossDataIndex].DunLevel = DunLevel;
        }
    }
    public class enemy
    {
        static EnemyCom data = new EnemyCom();
        enemy()
        {
            data.addenemy("Test", 25, 1, 50, 1, 1);
            data.addenemy("Rat", 10, 1, 25, 1, 1);
            data.addenemy("Skeleton", 25, 2, 50, 2, 1);
        }
        public static Data GetEnemy(string name)
        {
            EnemyData Re = new EnemyData();
            for (int i = 0; i < data.Data.Length; i++)
            {
                if(data.Data[i].name == name)
                {
                    Re.name = data.Data[i].name;
                    Re.Hp = data.Data[i].Hp;
                    Re.Dps = data.Data[i].Dps;
                    Re.C = data.Data[i].C;
                    Re.DunLevel = data.Data[i].DunLevel;
                    Re.StartLevel = data.Data[i].StartLevel;
                }
            }
            return Re;
        }
    }
}

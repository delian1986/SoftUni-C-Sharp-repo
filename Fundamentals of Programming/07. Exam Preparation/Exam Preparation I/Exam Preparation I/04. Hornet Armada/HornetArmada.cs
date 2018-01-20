using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hornet_Armada
{
    class HornetArmada
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            Dictionary<string, int> activityDic = new Dictionary<string, int>();
            Dictionary<string, Dictionary<string, long>> soldDic = new Dictionary<string, Dictionary<string, long>>();
            PopulatingDics(lines, activityDic, soldDic);

            string lastLine = Console.ReadLine();

            if (lastLine.Contains('\\'))
            {
                ActivitySoldierResult(activityDic, soldDic, lastLine);
            }

        }

        private static void ActivitySoldierResult(Dictionary<string, int> activityDic, Dictionary<string, Dictionary<string, long>> soldDic, string lastLine)
        {
            var tokens = lastLine.Split('\\');
            var activity = tokens[0];
            var soldType = tokens[1];

            foreach (var legion in soldDic.Where(legion=>legion.Value.ContainsKey(soldType)).OrderByDescending(x=>x.Value[soldType]))
            {
                //if (activityDic[legion.Key]<activity)
                {

                }
                Console.WriteLine();
            }


        }

        private static void PopulatingDics(int lines, Dictionary<string, int> activityDic, Dictionary<string, Dictionary<string, long>> soldDic)
        {
            for (int i = 0; i < lines; i++)
            {
                string[] tokens = Console.ReadLine().Split(new[] { '=', ' ', '-', '>', ':' }, StringSplitOptions.RemoveEmptyEntries);

                int legActivity = int.Parse(tokens[0]);
                string legName = tokens[1];
                string legType = tokens[2];
                long legCount = long.Parse(tokens[3]);

                if (!activityDic.ContainsKey(legName))
                {
                    activityDic.Add(legName, legActivity);
                }

                else if (activityDic[legName] < legActivity)
                {
                    activityDic[legName] = legActivity;

                }

                if (!soldDic.ContainsKey(legName))
                {
                    soldDic.Add(legName, new Dictionary<string, long>());
                    soldDic[legName].Add(legType, 0);
                }
                if (!soldDic[legName].ContainsKey(legType))
                {
                    soldDic[legName].Add(legType, 0);
                }
                soldDic[legName][legType] += legCount;

            }
        }
    }
}

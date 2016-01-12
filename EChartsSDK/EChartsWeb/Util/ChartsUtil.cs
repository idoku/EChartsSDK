using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EChartsWeb.Util
{
    public class ChartsUtil
    {
        public static IList<string> Weeks()
        {
            IList<string> weeks = new List<string>(){
              "周一",
              "周二",
              "周三",
              "周四",
              "周五",
              "周六",
              "周日",
            };
            return weeks;
        }


        public static IList<string> Ads()
        {
            IList<string> ads = new List<string>()
            {
            "邮件营销","联盟广告","视频广告","直接访问","搜索引擎"
            };
            return ads;
        }

        public static IList<double> DDatas(int len, int min, int max)
        {
            IList<double> datas = new List<double>();
            Random r = new Random();
            for (int i = 0; i < len; i++)
            {
                datas.Add(r.NextDouble() * r.Next(min, max));
            }
            return datas;
        }

        public static IList<int> Exps(int len, int exp)
        {
            IList<int> exps = new List<int>();
            for (int i = 0; i < len; i++)
            {

                exps.Add((int)Math.Pow(exp, i));
            }
            return exps;
        }

        public static IList<int> Sequences(int start,int end)
        {
            IList<int> datas = new List<int>();

            for (int i = start; i <= end; i++)
            {
                datas.Add(i);
            }
            return datas;
        }

        public static IList<int> Datas(int len, int min, int max)
        {
            IList<int> datas = new List<int>();
            Random r = new Random();
            for (int i = 0; i < len; i++)
            {
                datas.Add(r.Next(min, max));
            }
            return datas;
        }

        public static int[,] TowDatas(int row, int col,int min,int max)
        {
            int[,] datas = new int[row,col];
            Random r = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    datas[i,j] = r.Next(min, max);
                }
            }
            return datas;
        }

        public static IList<DateTime> TimeSteps(DateTime startTime, DateTime endTime, TimeSpan step)
        {
            IList<DateTime> times = new List<DateTime>();
            for (DateTime st = startTime; st < endTime; st = st.Add(step))
            {
                times.Add(st);
            }
            return times;
        }

        public static IList<DateTime> TimeSteps(DateTime startTime, DateTime endTime, TimeSpan minStep, TimeSpan maxStep)
        {
            IList<DateTime> times = new List<DateTime>();
            Random r = new Random();
            for (DateTime st = startTime; st < endTime;)
            {
                int step = r.Next(minStep.Hours, maxStep.Hours);
                st = st.AddHours(step);
                times.Add(st);
            }
            return times;
        }

        public static IList<double> Rains()
        {
            IList<double> rains = ChartsData.Rains;
            return rains;
        }

        public static IList<double> Flows()
        {
            IList<double> flows = ChartsData.Flows;
            return flows;
        }

        private static int GetProb(IList<double> prob)
        {
            int result = 0;
            int n = (int)(prob.Sum() * 1000);
            Random r = new Random();
            double x = (float)r.Next(0, n) / 1000;
            for (int i = 0; i < prob.Count(); i++)
            {
                double pre = prob.Take(i).Sum();
                double next = prob.Take(i + 1).Sum();
                if (x >= pre && x < next)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }


        public static IList<int> Steps(int len, int start, int step) {
            IList<int> datas = new List<int>();
            for (int i = 0; i < len; i++)
            {
                datas.Add(start + i * step);
            }
            return datas;
        }

    }
}
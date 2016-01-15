using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class Node
    {
        public string name { get; set; }

        public string label { get; set; }

        public int? value { get; set; }

        public bool? ignore { get; set; }

        public string symbol { get; set; }

        public object symbolSize { get; set; }

        public int? category { get; set; }

        public ItemStyle itemStyle { get; set; }
    }
}

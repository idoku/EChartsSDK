using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities
{
    public class TreeData
    {
        public string name { get; set; }

        public string symbol { get; set; }

        public object symbolSize { get; set; }

        public int? value { get; set; }

        public IList<TreeData> children { get; set; }

        public ItemStyle itemStyle { get; set; }
    }
}

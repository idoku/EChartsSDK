using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities
{
    public class Category
    {
        public string name { get; set; }

        public string symbol { get; set; }

        public object symbolSize { get; set; }

        public ItemStyle itemStyle { get; set; }
    }
}

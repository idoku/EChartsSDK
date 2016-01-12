using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class Link
    {
        public object source { get; set; }

        public object target { get; set; }

        public int? weight { get; set; }

        public ItemStyle itemStyle { get; set; }
    }
}

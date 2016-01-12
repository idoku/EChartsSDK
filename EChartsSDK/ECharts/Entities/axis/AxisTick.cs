using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.axis
{
    public class AxisTick
    {
        public bool? show { get; set; }

        public object interval { get; set; }

        public bool? onGap { get; set; }

        public bool? inside { get; set; }

        public int? length { get; set; }

        public LineStyle lineStyle { get; set; }
    }
}

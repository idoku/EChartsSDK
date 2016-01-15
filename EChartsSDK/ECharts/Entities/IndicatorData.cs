using ECharts.Entities.axis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities
{
    public class IndicatorData
    {
        public string text { get; set; }

        public int? min { get; set; }

        public int? max { get; set; }

        public AxisLabel axisLabel { get; set; }
    }
}

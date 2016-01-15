using ECharts.Entities.axis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities
{
    public class Polar:Basic<Polar>
    {
        public string radius { get; set; }

        public int? startAngle { get; set; }

        public int? splitNumber { get; set; }

        public AxisName name { get; set; }

        public IList<double> boundaryGap { get; set; }

        public AxisLine axisLine { get; set; }
       
        public AxisLabel axisLabel { get; set; }

        public SplitLine splitLine { get; set; }

        public SplitArea splitArea { get; set; }

        public PolarType? type { get; set; }

        public IList<IndicatorData> indicator { get; set; }



    }
}

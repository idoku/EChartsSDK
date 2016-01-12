using ECharts.Entities.axis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class Gauge : Series<Gauge>
    {
        public object center { get; set; }

        public object radius { get; set; }

        public int? startAngle { get; set; }

        public int? endAngle { get; set; }

        public int? min { get; set; }

        public int? max { get; set; }

        public int? splitNumber { get; set; }

        public AxisLine axisLine { get; set; }

        public AxisTick axisTick { get; set; }

        public AxisLabel axisLabel { get; set; }

        public SplitLine splitLine { get; set; }

        public Pointer pointer { get; set; }

        public Title title { get; set; }

        public Detail detail { get; set; }

        public bool? legendHoverLink { get; set; }


        public Gauge() {
            this.type = ChartType.gauge;
        }



    }
}

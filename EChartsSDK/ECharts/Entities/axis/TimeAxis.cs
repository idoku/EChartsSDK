using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.axis
{
    public class TimeAxis : ChartAxis<TimeAxis>
    {
        public IList<double> boundaryGap { get; set; }

        public TimeAxis BoundaryGap(IList<double> boundaryGap)
        {
            this.boundaryGap = boundaryGap;
            return this;
        }

        public TimeAxis BoundaryGap(params double[] values)
        {
            if (boundaryGap == null)
            {
                boundaryGap = new List<double>();
            }
            values.ToList().ForEach(v => boundaryGap.Add(v));
            return this;
        }

        public TimeAxis()
        {
            this.type = AxisType.time;
        }
    }
}

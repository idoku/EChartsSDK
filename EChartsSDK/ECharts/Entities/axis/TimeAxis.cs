using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.axis
{
    public class TimeAxis : ChartAxis<TimeAxis>
    {
        public TimeAxis()
        {
            this.type = AxisType.time;
        }
    }
}

using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.axis
{
    public class ValueAxis: ChartAxis<ValueAxis>
    {
     


        public IList<double> boundaryGap { get; set; }


        public ValueAxis()
        {
            type = AxisType.value;
        }


        public ValueAxis BoundaryGap(IList<double> boundaryGap)
        {
            this.boundaryGap = boundaryGap;
            return this;
        }

     


     


    }
}

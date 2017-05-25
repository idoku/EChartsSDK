using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.axis
{
    public class AxisLink
    {
        public object xAxisIndex { get; set; }

        public object yAxisIndex { get; set; }

        public string xAxisName { get; set; }

        public string yAxisName { get; set; }

        public string angleAxis { get; set; }

        public AxisLink AngleAxis(string angleAxis)
        {
            this.angleAxis = angleAxis;
            return this;
        }


        public AxisLink XAxisIndex(params double[] values)
        {
            this.xAxisIndex = values.ToList();
            return this;
        }

        public AxisLink YAxisIndex(params double[] values)
        {
            this.yAxisIndex = values.ToList();
            return this;
        }


        public AxisLink XAxisIndex(string xAxisName)
        {
            this.xAxisName = xAxisName;
            return this;
        }


        public AxisLink YAxisIndex(string yAxisName)
        {
            this.yAxisName = yAxisName;
            return this;
        }




    }
}

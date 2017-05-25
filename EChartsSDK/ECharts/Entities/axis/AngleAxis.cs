using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.axis
{
    public class AngleAxis : ChartAxis<AngleAxis> 
    {
        public int? polarIndex { get; set; }

        public int? startAngle { get; set; }

        public bool? clockwise { get; set; }

        public bool? boundaryGap { get; set; }

        public AngleAxis()
        {          
        }

        public AngleAxis(AxisType type)
        {
            this.type = type;
        }

        public AngleAxis BoundaryGap(bool boundaryGap)
        {
            this.boundaryGap = boundaryGap;
            return this;
        }

        public AngleAxis Type(AxisType type)
        {
            this.type = type;
            return this ;
        }

        public AngleAxis Clockwise(bool clockwise)
        {
            this.clockwise = clockwise;
            return this;
        }

        public AngleAxis StartAngle(int startAngle)
        {
            this.startAngle = startAngle;
            return  this;
        }

        public AngleAxis PolarIndex(int polarIndex)
        {
            this.polarIndex = polarIndex;
            return this;
        }
    }
}

using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.axis
{
    public class ValueAxis:Axis
    {
        public int? min { get; set; }

        public int? max { get; set; }

        public bool? scale { get; set; }

        public IList<double> boundaryGap { get; set; }

        public TextStyle nameTextStyle { get; set; }

        public PositionType? position { get; set; }

        public ValueAxis Scale(bool scale)
        {
            this.scale = scale;
            return this;
        }

        public ValueAxis BoundaryGap(IList<double> boundaryGap)
        {
            this.boundaryGap = boundaryGap;
            return this;
        }

        public ValueAxis Name(string name)
        {
            this.name = name;
            return this;
        }

        public ValueAxis()
        {
            type = AxisType.value;
        }

        public ValueAxis Max(int max)
        {
            this.max = max;
            return this;
        }

        public ValueAxis Min(int min)
        {
            this.min = min;
            return this;
        }



    }
}

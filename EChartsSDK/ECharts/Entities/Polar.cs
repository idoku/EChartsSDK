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
        public int? radius { get; set; }

        public int? startAngle { get; set; }

        public int? splitNumber { get; set; }

        public IList<string> center { get; set; }

        public AxisName name { get; set; }

        public IList<double> boundaryGap { get; set; }

        public AxisLine axisLine { get; set; }
       
        public AxisLabel axisLabel { get; set; }

        public SplitLine splitLine { get; set; }

        public SplitArea splitArea { get; set; }

        public PolarType? type { get; set; }

        public object indicator { get; set; }

        public Polar Type(PolarType type)
        {
            this.type = type;
            return this;
        }

        public AxisLabel AxisLabel()
        {
            axisLabel = new AxisLabel();
            return axisLabel;
        }

        public AxisLine AxisLine()
        {
            axisLine = new AxisLine();
            return axisLine;
        }
       
        public SplitLine SplitLine()
        {
            splitLine = new SplitLine();
            return splitLine;
        }

        public SplitArea SplitArea()
        {
            splitArea = new SplitArea();
            return splitArea;
        }        

        public AxisName Name()
        {
            if (name == null)
                this.name = new AxisName();
            return this.name;
        }

        public Polar SplitNumber(int splitNumber)
        {
            this.splitNumber = splitNumber;
            return this;
        }

        public Polar Indicator(params IndicatorData[] values)
        {
            if (this.indicator == null)
                indicator = new List<IndicatorData>();
            indicator = values.ToList();
            return this;
        }

        public Polar Indicator(object indicator)
        {
            this.indicator = indicator;
            return this;
        }

        public Polar Center(IList<string> center)
        {
            this.center = center;
            return this;
        }

        public Polar StartAngle(int radius)
        {
            this.startAngle = startAngle;
            return this;
        }

        public Polar Radius(int radius)
        {
            this.radius = radius;
            return this;
        }



    }
}

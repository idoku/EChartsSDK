using ECharts.Entities.axis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class Gauge : ChartSeries<Gauge>
    {
        public IList<string> center { get; set; }

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

        public GaugePointer pointer { get; set; }

        public GaugeTitle title { get; set; }

        public GaugeDetail detail { get; set; }

        public bool? legendHoverLink { get; set; }

        public int? precision { get; set; }

        public Gauge Precision(int precision)
        {
            this.precision = precision;
            return this;
        }

        public Gauge SplitNumber(int splitNumber)
        {
            this.splitNumber = splitNumber;
            return this;
        }

        public Gauge Center(IList<string> center)
        {
            this.center = center;
            return this;
        }

        public Gauge Max(int max)
        {
            this.max = max;
            return this;
        }

        public Gauge Min(int min)
        {
            this.min = min;
            return this;
        }

        public Gauge LegendHoverLink(bool legendHoverLink)
        {
            this.legendHoverLink = legendHoverLink;
            return this;
        }

        public Gauge StartAngle(int startAngle)
        {
            this.startAngle = startAngle;
            return this;
        }

        public Gauge EndAngle(int endAngle)
        {
            this.endAngle = endAngle;
            return this;
        }

        public Gauge Radius(object radius)
        {
            this.radius = radius;
            return this;
        }

        public GaugePointer Pointer()
        {
            if (this.pointer == null)
                pointer = new Entities.GaugePointer();
            return pointer;
        }

        public GaugeTitle Title()
        {
            if (this.title == null)
                title = new GaugeTitle();
            return title;
        }

        public GaugeDetail Detail()
        {
            if (this.detail == null)
                detail = new Entities.GaugeDetail();
            return detail;
        }

        public Gauge()
        {
            this.type = ChartType.gauge;
        }

        public Gauge(string name):this()
        {
            this.name = name;
        }

        public AxisLabel AxisLabel()
        {
            if(axisLabel==null)
            axisLabel = new AxisLabel();
            return axisLabel;
        }

        public AxisLine AxisLine()
        {
            if(axisLine==null)
            axisLine = new AxisLine();
            return axisLine;
        }

        public AxisTick AxisTick()
        {
            if (axisTick == null)
                axisTick = new AxisTick();

            return axisTick;
        }


        public SplitLine SplitLine()
        {
            splitLine = new SplitLine();
            return splitLine;
        }

        


    }
}

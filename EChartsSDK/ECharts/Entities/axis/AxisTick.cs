using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.axis
{
    public class AxisTick
    {
        public bool? show { get; set; }

        public object interval { get; set; }

        public int splitNumber { get; set; }

        public bool? onGap { get; set; }

        public bool? inside { get; set; }

        public int? length { get; set; }
        
        public LineStyle lineStyle { get; set; }

        public AxisTick Length(int length)
        {
            this.length = length;
            return this;
        }


        public AxisTick SplitNumber(int splitNumber)
        {
            this.splitNumber = splitNumber;
            return this;
        }

        public AxisTick Inside(bool inside)
        {
            this.inside = inside;
            return this;
        }

        public AxisTick OnGap(bool onGap)
        {
            this.onGap = onGap;
            return this;
        }

        public LineStyle LineStyle()
        {
            if (this.lineStyle == null)
                this.lineStyle = new style.LineStyle();
            return this.lineStyle;
        }

        public AxisTick Show(bool show)
        {
            this.show = show;
            return this;
        }

        public AxisTick Interval(object interval)
        {
            this.interval = interval;
            return this;
        }


      

    }
}

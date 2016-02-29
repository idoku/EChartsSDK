using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.axis
{
    public class SplitLine
    {
        public bool? show { get; set; }

        public bool? onGap { get; set; }

        public int? length { get; set; }

        public LineStyle lineStyle { get; set; }

        public SplitLine Length(int length)
        {
            this.length = length;
            return this;
        }

        public SplitLine Show(bool show)
        {
            this.show = show;
            return this;
        }

        public SplitLine OnGap(bool onGap)
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
    }
}

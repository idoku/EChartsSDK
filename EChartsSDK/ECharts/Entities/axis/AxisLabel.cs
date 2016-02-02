using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.axis
{
    public class AxisLabel
    {
        public bool? show { get; set; }

        public object interval { get; set; }

        public int? rotate { get; set; }

        public int? margin { get; set; }

        public bool? clickable { get; set; }

        public object formatter { get; set; }

        public TextStyle textStyle { get; set; }

        public TextStyle TextStyle()
        {
            if (textStyle == null)
                textStyle = new style.TextStyle();
            return textStyle;
        }

        public AxisLabel Rotate(int rotate)
        {
            this.rotate = rotate;
            return this;
        }
        public AxisLabel Margin(int margin)
        {
            this.margin = margin;
            return this;
        }
        public AxisLabel Clickable(bool clickable)
        {
            this.clickable = clickable;
            return this;
        }

        public AxisLabel Show(bool show)
        {
            this.show = show;
            return this;
        }

        public AxisLabel Interval(object interval)
        {
            this.interval = interval;
            return this;
        }


        public AxisLabel Formatter(object formatter)
        {
            this.formatter = formatter;
            return this;
        }

    }
}

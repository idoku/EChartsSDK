using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.axis
{
    public class AxisPointer:Basic<AxisPointer>
    {
        public bool? show { get; set; }

        public AxisPointType? type { get; set; }

        public bool? snap { get; set; }

        public AxisLink link { get; set; }

        public AxisLabel label { get; set; }

        public LineStyle lineStyle { get; set; }

        public LineStyle crossStyle { get; set; }

        public AreaStyle shadowStyle { get; set; }

        public AxisPointer Show(bool show)
        {
            this.show = show;
            return this;
        }


        public AxisLink Link()
        {
            if (this.link == null)
                this.link = new AxisLink();
            return this.link;
        }

        public AxisPointer Type(AxisPointType type)
        {
            this.type = type;
            return this;
        }

        public AxisPointer Snap(bool snap)
        {
            this.snap = snap;
            return this;
        }

        public AxisLabel Label()
        {
            if (this.label == null)
            {
                this.label = new AxisLabel();
            }
            return this.label;
        }

        public LineStyle LineStyle()
        {
            if (this.lineStyle==null)
            {
                this.lineStyle = new style.LineStyle();
            }
            return this.lineStyle;
        }

        public LineStyle CrossStyle()
        {
            if (this.crossStyle == null)
            {
                this.crossStyle = new style.LineStyle();
            }
            return this.crossStyle;
        }


        public AreaStyle ShadowStyle()
        {
            if (this.shadowStyle == null)
            {
                this.shadowStyle = new style.AreaStyle();
            }
            return this.shadowStyle;
        }

    }
}

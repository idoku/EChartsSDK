using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.axis
{
    public class AxisLine
    {
        public bool? show { get; set; }

        public bool? onZero { get; set; }

        public LineStyle lineStyle { get; set; }


        public LineStyle LineStyle()
        {
            if (this.lineStyle == null)
                this.lineStyle = new style.LineStyle();
            return this.lineStyle;
        }

        public AxisLine OnZero(bool onZero) {
            this.onZero = onZero;
            return this;
        }

        public AxisLine Show(bool show) {
            this.show = show;
            return this;
        }
    }
}

using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.axis
{
    public class SplitArea
    {
        public bool? show { get; set; }

        public bool? onGap { get; set; }

        public AreaStyle areaStyle { get; set; }


        public SplitArea OnGap(bool onGap)
        {
            this.onGap = onGap;
            return this;
        }

        public AreaStyle AreaStyle()
        {
            if (this.areaStyle == null)
                this.areaStyle = new style.AreaStyle();
            return this.areaStyle;
        }

        public SplitArea Show(bool show)
        {
            this.show = show;
            return this;
        }


    }
}

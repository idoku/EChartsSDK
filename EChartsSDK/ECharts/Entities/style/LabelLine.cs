using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.style
{
    public class LabelLine
    {
        public bool? show { get; set; }

        public int? length { get; set; }

        public LineStyle lineStyle { get; set; }

        public LabelLine Length(int length)
        {
            this.length = length;
            return this;
        }

        public LabelLine Show(bool show)
        {
            this.show = show;
            return this;
        }

        public LineStyle LineStyle()
        {
            if (lineStyle == null)
                lineStyle = new LineStyle();
            return this.lineStyle;
        }

    }
}

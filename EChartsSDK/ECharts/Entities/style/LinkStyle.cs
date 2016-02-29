using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.style
{
    public class LinkStyle
    {
        public LinkStyleType? type { get; set; }

        public double? opacity { get; set; }

        public object color { get; set; }

        public int? width { get; set; }

        public LinkStyle Opacity(double opacity)
        {
            this.opacity = opacity;
            return this;
        }

        public LinkStyle Type(LinkStyleType type)
        {
            this.type = type;
            return this;
        }


        public LinkStyle Width(int width)
        {
            this.width = width;
            return this;
        }

        public LinkStyle Color(object color)
        {
            this.color = color;
            return this;
        }


    }
}

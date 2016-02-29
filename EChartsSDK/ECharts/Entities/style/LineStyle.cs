using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.style
{
    public class LineStyle
    {
        public object color { get; set; }

        public object color0 { get; set; }

        public LineStyleType? type { get; set; }

        public int? width { get; set; }

        public object shadowColor { get; set; }

        public int? shadowBlur { get; set; }

        public int? shadowOffsetX { get; set; }

        public int? shadowOffsetY { get; set; }

        public LineStyle ShadowBlur(int shadowBlur)
        {
            this.shadowBlur = shadowBlur;
            return this;
        }

        public LineStyle ShadowOffsetX(int shadowOffsetX)
        {
            this.shadowOffsetX = shadowOffsetX;
            return this;
        }

        public LineStyle ShadowOffsetY(int shadowOffsetY)
        {
            this.shadowOffsetY = shadowOffsetY;
            return this;
        }



        public LineStyle Color(object color)
        {
            this.color = color;
            return this;
        }

    

        public LineStyle Color0(string color0)
        {
            this.color0 = color0;
            return this;
        }

        public LineStyle ShadowColor(string shadowColor)
        {
            this.shadowColor = shadowColor;
            return this;
        }

        public LineStyle ShadowColor(object shadowColor)
        {
            this.shadowColor = shadowColor;
            return this;
        }

        public LineStyle Width(int width)
        {
            this.width = width;
            return this;
        }

        public LineStyle Type(LineStyleType type)
        {
            this.type = type;
            return this;
        }
    }
}

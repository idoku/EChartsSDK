using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities
{
    public class GaugeDetail
    {
        public bool? show { get; set; }

        public string backgroundColor { get; set; }

        public int? borderWidth { get; set; }

        public string borderColor { get; set; }

        public int? width { get; set; }

        public int? height { get; set; }

        public IList<string> offsetCenter { get; set; }

        public object formatter { get; set; }

        public TextStyle textStyle { get; set; }

        public int? shadowBlur { get; set; }

        public object shadowColor { get; set; }

        public GaugeDetail ShadowColor(object shadowColor)
        {
            this.shadowColor = shadowColor;
            return this;
        }

        public GaugeDetail ShadowBlur(int shadowBlur)
        {
            this.shadowBlur = shadowBlur;
            return this;
        }

        public TextStyle TextStyle()
        {
            if (this.textStyle == null)
                textStyle = new style.TextStyle();
            return textStyle;
        }

        public GaugeDetail Formatter(object formatter)
        {
            this.formatter = formatter;
            return this;
        }

        public GaugeDetail Height(int height)
        {
            this.height = height;
            return this;
        }

        public GaugeDetail Width(int width)
        {
            this.width = width;
            return this;
        }

        public GaugeDetail Show(bool show)
        {
            this.show = show;
            return this;
        }

        public GaugeDetail BackgroundColor(string backgroundColor)
        {
            this.backgroundColor = backgroundColor;
            return this;
        }

        public GaugeDetail BorderWidth(int borderWidth)
        {
            this.borderWidth = borderWidth;
            return this;
        }

        public GaugeDetail BorderColor(string borderColor)
        {
            this.borderColor = borderColor;
            return this;
        }

        public GaugeDetail OffsetCenter(IList<string> offsetCenter)
        {
            this.offsetCenter = offsetCenter;
            return this;
        }

        

    }
}

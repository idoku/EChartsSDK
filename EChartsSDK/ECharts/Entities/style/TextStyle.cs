using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.style
{
    public class TextStyle
    {
        public string color { get; set; }

        public string decoration { get; set; }

        public HorizontalType? align { get; set; }

        public VerticalType? baseline { get; set; }

        public string fontFamily { get; set; }

        public int? fontSize { get; set; }

        public FontStyleType? fontStyle { get; set; }

        public object fontWeight { get; set; }

        public int? shadowBlur { get; set; }

        public object shadowColor { get; set; }

        public TextStyle ShadowColor(object shadowColor)
        {
            this.shadowColor = shadowColor;
            return this;
        }

        public TextStyle ShadowBlur(int shadowBlur)
        {
            this.shadowBlur = shadowBlur;
            return this;
        }

        public TextStyle FontStyle(FontStyleType fontStyle)
        {
            this.fontStyle = fontStyle;
            return this;
        }

        public TextStyle FontWeight(object fontWeight)
        {
            this.fontWeight = fontWeight;
            return this;
        }

        public TextStyle Baseline(VerticalType baseline)
        {
            this.baseline = baseline;
            return this;
        }

        public TextStyle Align(HorizontalType align)
        {
            this.align = align;
            return this;
        }

        public TextStyle Color(string color)
        {
            this.color = color;
            return this;
        }

        public TextStyle Decoration(string decoration)
        {
            this.decoration = decoration;
            return this;
        }
        public TextStyle FontSize(int fontSize)
        {
            this.fontSize = fontSize;
            return this;
        }

        public TextStyle FontFamily(string fontFamily)
        {
            this.fontFamily = fontFamily;
            return this;
        }

        public TextStyle FontWeight(string fontWeight)
        {
            this.fontWeight = fontWeight;
            return this;
        }
    }
}

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

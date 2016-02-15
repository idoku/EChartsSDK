using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.style
{
    public class CheckPointStyle
    {
        public string symbol { get; set; }

        public string symbolSize { get; set; }

        public string color { get; set; }

        public string borderColor { get; set; }

        public string borderWidth { get; set; }

        public StyleLabel label { get; set; }

        public StyleLabel Label()
        {
            if (label == null)
                this.label = new style.StyleLabel();
            return this.label;
        }

        public CheckPointStyle BorderWidth(string borderWidth)
        {
            this.borderWidth = borderWidth;
            return this;
        }

        public CheckPointStyle BorderColor(string borderColor)
        {
            this.borderColor = borderColor;
            return this;
        }

        public CheckPointStyle Color(string color)
        {
            this.color = color;
            return this;
        }

        public CheckPointStyle SymbolSize(string symbolSize)
        {
            this.symbolSize = symbolSize;
            return this;
        }

        public CheckPointStyle Symbol(string symbol)
        {
            this.symbol = symbol;
            return this;
        }


    }
}

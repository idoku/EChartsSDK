using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.style
{
    public class ChordStyle
    {
        public int? width { get; set; }

        public double opacity { get; set; }

        public string color { get; set; }

        public object borderWidth { get; set; }

        public string borderColor { get; set; }

        public ChordStyle Opacity(double opacity)
        {
            this.opacity = opacity;
            return this;
        }

        public ChordStyle Width(int width)
        {
            this.width = width;
            return this;
        }

        public ChordStyle Color(string color)
        {
            this.color = color;
            return this;
        }

        public ChordStyle BorderWidth(int borderWidth)
        {
            this.borderWidth = borderWidth;
            return this;
        }

        public ChordStyle BorderWidth(string borderWidth)
        {
            this.borderWidth = borderWidth;
            return this;
        }

        public ChordStyle BorderColor(string borderColor)
        {
            this.borderColor = borderColor;
            return this;
        }
    }
}

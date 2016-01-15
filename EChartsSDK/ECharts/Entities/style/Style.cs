using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.style
{
    public abstract class Style<T> where T :class
    {
        public object color { get; set; }

        public LineStyle lineStyle { get; set; }

        public AreaStyle areaStyle { get; set; }

        public ChordStyle chordStyle { get; set; }

        public NodeStyle nodeStyle { get; set; }

        public LinkStyle linkStyle { get; set; }

        public object borderColor { get; set; }

        public int? borderWidth { get; set; }

        public string barBorderColor { get; set; }

        public object barBorderRadius { get; set; }

        public int? barBorderWidth { get; set; }

        public StyleLabel label { get; set; }

        public LabelLine labelLine { get; set; }

        public T Color(object color) {
            this.color = color;
            return this as T;
        }

        public T Color(string color)
        {
            this.color = color;
            return this as T;
        }

        public StyleLabel Label()
        {
            if (label == null)
                this.label = new style.StyleLabel();
            return this.label;
        }


        public LineStyle LineStyle()
        {
            if (lineStyle == null)
                this.lineStyle = new LineStyle();
            return this.lineStyle;
        }

        public AreaStyle AreaStyle()
        {
            if (areaStyle == null) 
                this.areaStyle = new AreaStyle();
            return areaStyle;
        }

        public ChordStyle ChordStyle()
        {
            if (chordStyle == null) 
                this.chordStyle = new ChordStyle();
            return chordStyle;
        }

        public LinkStyle LinkStyle()
        {
            if (linkStyle == null)
                this.linkStyle = new LinkStyle();
            return linkStyle;
        }

      
    }
}

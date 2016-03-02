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

        public object color0 { get; set; }

        public LineStyle lineStyle { get; set; }

        public AreaStyle areaStyle { get; set; }

        public ChordStyle chordStyle { get; set; }

        public NodeStyle nodeStyle { get; set; }

        public LinkStyle linkStyle { get; set; }

        public object borderColor { get; set; }      

        public double? borderWidth { get; set; }

        public string barBorderColor { get; set; }

        public object barBorderRadius { get; set; }

        public int? barBorderWidth { get; set; }

        public  string brushType { get; set; }

        public StyleLabel label { get; set; }

        public LabelLine labelLine { get; set; }

        

          public T BrushType(string brushType)
        {
            this.brushType = brushType;
            return this as T;
        }


        public T BarBorderRadius(string barBorderRadius)
        {
            this.barBorderRadius = barBorderRadius;
            return this as T;
        }

        public T BarBorderRadius(int barBorderRadius)
        {
            this.barBorderRadius = barBorderRadius;
            return this as T;
        }

        public T BarBorderColor(string barBorderColor)
        {
            this.barBorderColor = barBorderColor;
            return this as T;
        }

       

        public T BarBorderWidth(int barBorderWidth)
        {
            this.barBorderWidth = barBorderWidth;
            return this as T;
        }

        public T BorderWidth(double borderWidth)
        {
            this.borderWidth = borderWidth;
            return this as T;
        }

        public T BorderColor(string borderColor)
        {
            this.borderColor = borderColor;
            return this as T;
        }


        public T Color(object color) {
            this.color = color;
            return this as T;
        }

        public T Color(string color)
        {
            this.color = color;
            return this as T;
        }

        public T Color0(string color0)
        {
            this.color0 = color0;
            return this as T;
        }

        public StyleLabel Label()
        {
            if (label == null)
                this.label = new style.StyleLabel();
            return this.label;
        }

        public LabelLine LabelLine()
        {
            if (labelLine == null)
                this.labelLine = new style.LabelLine();
            return this.labelLine;
        }

        public NodeStyle NodeStyle()
        {            
            if (nodeStyle == null)
                this.nodeStyle = new style.NodeStyle();
            return this.nodeStyle;
        }

        


        public LineStyle LineStyle()
        {
            if (lineStyle == null)
                this.lineStyle = new LineStyle();
            return this.lineStyle;
        }

        public T SetLineStyle(LineStyle lineStyle)
        {
            this.lineStyle = lineStyle;
            return this as T;
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

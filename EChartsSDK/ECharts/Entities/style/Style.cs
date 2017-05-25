using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.style
{
    public abstract class Style<T>
		where T : class
    {
        public bool? show { get; set; }

        public object color { get; set; }

        public object color0 { get; set; }

        public LineStyle lineStyle { get; set; }

        public AreaStyle areaStyle { get; set; }

        public ChordStyle chordStyle { get; set; }

        public NodeStyle nodeStyle { get; set; }

        public LinkStyle linkStyle { get; set; }

        public TextStyle textStyle { get; set; }

        public object borderColor { get; set; }      

        public double? borderWidth { get; set; }

        public string barBorderColor { get; set; }

        public object barBorderRadius { get; set; }

        public int? barBorderWidth { get; set; }

        public  string brushType { get; set; }

        public object position { get; set; }

        public double[] offset { get; set; }

        public object formatter { get; set; }

        public StyleLabel label { get; set; }

        public LineStyleType? borderType { get; set; }

        public LabelLine labelLine { get; set; }

        public int? shadowBlur { get; set; }

        public string shadowColor { get; set; }

        public int? shadowOffsetX { get; set; }

        public int? shadowOffsetY { get; set; }

        public string areaColor { get; set; }

        public double? width { get; set; }

        public double? opacity { get; set; }

        public double? curveness { get; set; }


        public T Curveness(double curveness)
        {
            this.curveness = curveness;
            return this as T;
        }


        public T AreaColor(string areaColor)
        {
            this.areaColor = areaColor;
            return this as T;
        }

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

        public T BorderType(LineStyleType borderType)
        {
            this.borderType = borderType;
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

        public TextStyle TextStyle()
        {
            if (textStyle == null)
                this.textStyle = new style.TextStyle();
            return this.textStyle;
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

		/// 
		/// <param name="shadowBlur"></param>
		public T ShadowBlur(int shadowBlur){
		     this.shadowBlur=shadowBlur;
		return this as T; 
		}

		/// 
		/// <param name="shadowColor"></param>
		public T ShadowColor(string shadowColor){
		     this.shadowColor=shadowColor;
		return this as T; 
		}

		/// 
		/// <param name="shadowOffsetY"></param>
		public T ShadowOffsetY(int shadowOffsetY){
		     this.shadowOffsetY=shadowOffsetY;
		return this as T; 
		}

        public T ShadowOffsetX(int shadowOffsetX)
        {
            this.shadowOffsetX = shadowOffsetX;
            return this as T;
        }


		/// 
		/// <param name="show"></param>
		public T Show(bool show){
		     this.show=show;
		return this as T; 
		}

		/// 
		/// <param name="position"></param>
		public T Position(StyleLabelTyle position){
		     this.position=position;
		return this as T; 
		}

		/// 
		/// <param name="formatter"></param>
		public T Formatter(object formatter){
		     this.formatter=formatter;
		return this as T; 
		}


        public T Offset(double[] offset)
        {
            this.offset = offset;
            return this as T;
        }

        public T Width(double width)
        {
            this.width = width;
            return this as T;
        }

        public T Opacity(double opacity)
        {
            this.opacity = opacity;
            return this as T;
        }

    }
}

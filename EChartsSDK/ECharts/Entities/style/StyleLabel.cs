using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.style
{
    public class StyleLabel
    {
        public bool? show { get; set; }

        public StyleLabelTyle position { get; set; }

        public bool? rotate { get; set; }

        public int? distance { get; set; }
    

        public object formatter { get; set; }

        public TextStyle textStyle { get; set; }

        public int? x { get; set; }

        public int? y { get; set; }

        public StyleLabel Show(bool show)
        {
            this.show = show;
            return this;
        }

        public TextStyle TextStyle()
        {
            if (this.textStyle == null)
                this.textStyle = new style.TextStyle();
            return this.textStyle;
        }

        public StyleLabel Position(StyleLabelTyle position)
        {
            this.position = position;
            return this;
        }
    }
}

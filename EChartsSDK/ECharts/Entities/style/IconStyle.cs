using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.style
{
    public class IconStyle
    {
        public string name { get; set; }

        public TextStyle textStyle { get; set; }

        public string icon { get; set; }

        public TextStyle TextStyle()
        {
            if (textStyle == null)
                this.textStyle = new TextStyle();
            return this.textStyle;
        }

        public IconStyle Name(string name)
        {
            this.name = name;
            return this;
        }

        public IconStyle Icon(string icon)
        {
            this.icon = icon;
            return this;
        }

    }
}

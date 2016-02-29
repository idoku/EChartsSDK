using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.style
{
    public class NodeStyle
    {
        public object color { get; set; }

        public object brushType { get; set; }

        public object borderColor { get; set; }

        public int? borderWidt { get; set; }

        public NodeStyle Color(object color)
        {
            this.color = color;
            return this;
        }


        public NodeStyle BrushType(object brushType)
        {
            this.brushType = brushType;            
            return this;
        }

        public NodeStyle BorderColor(object borderColor)
        {
            this.borderColor = borderColor;
            return this;
        }

        public NodeStyle BorderWidt(int borderWidt)
        {
            this.borderWidt = borderWidt;
            return this;
        }
    }

}

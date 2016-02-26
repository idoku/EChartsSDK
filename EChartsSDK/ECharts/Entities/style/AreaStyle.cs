using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.style
{
    public class AreaStyle
    {
        public object color { get; set; }

        public AreaStyleType? type { get; set; }

        public AreaStyle Color(object color)
        {
            this.color = color;
            return this;
        }

        public AreaStyle Type(AreaStyleType type)
        {
            this.type = type;
            return this;
        } 
    }
}

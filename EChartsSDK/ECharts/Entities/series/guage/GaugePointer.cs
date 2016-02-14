using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities
{
    public class GaugePointer
    {
        public object length { get; set; }

        public int? width { get; set; }

        public object color { get; set; }

        public GaugePointer Color(object color)
        {
            this.color = color;
            return this;
        }

        public GaugePointer Length(object length)
        {
            this.length = length;
            return this;
        }

        public GaugePointer Width(int width)
        {
            this.width = width;
            return this;
        }




    }
}

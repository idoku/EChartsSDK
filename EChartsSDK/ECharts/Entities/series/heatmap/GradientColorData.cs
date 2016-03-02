using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities
{
    public class GradientColorData
    {
        public double? offset { get; set; }

        public string color { get; set; }

        public GradientColorData(double offset, string color) {
            this.offset = offset;
            this.color = color;
        }
    }
}

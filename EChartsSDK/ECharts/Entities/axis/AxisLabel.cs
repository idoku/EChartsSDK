using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.axis
{
    public class AxisLabel
    {
        public bool? show { get; set; }

        public object interval { get; set; }

        public int? rotate { get; set; }

        public int? margin { get; set; }

        public bool? clickable { get; set; }

        public object formatter { get; set; }

        public TextStyle textStyle { get; set; }



        public AxisLabel Formatter(object formatter)
        {
            this.formatter = formatter;
            return this;
        }

    }
}

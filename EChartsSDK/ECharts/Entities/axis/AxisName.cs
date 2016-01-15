using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.axis
{
    public class AxisName
    {
        public bool? show { get; set; }

        public object formatter { get; set; }

        public TextStyle  textStyle { get; set; }
    }
}

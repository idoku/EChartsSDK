using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.style
{
    public class ControlStyle
    {
        public int? itemSize { get; set; }

        public int? itemGap { get; set; }

        public Normal normal { get; set; }

        public Emphasis empasis { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class Effect
    {
        public bool? show { get; set; }

        public string type { get; set; }

        public bool? loop { get; set; }

        public int? period { get; set; }

        public int? scaleSize { get; set; }

        public int? bounceDistance { get; set; }

        public object color { get; set; }

        public object shadowColor { get; set; }

        public int? shadowBlur { get; set; }

    }
}

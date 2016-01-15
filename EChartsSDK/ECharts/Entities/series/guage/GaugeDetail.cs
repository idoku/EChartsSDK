using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities
{
    public class GaugeDetail
    {
        public bool? show { get; set; }

        public string backgroundColor { get; set; }

        public int? borderWidth { get; set; }

        public string borderColor { get; set; }

        public int? width { get; set; }

        public int? height { get; set; }

        public IList<object> offsetCenter { get; set; }

        public object formatter { get; set; }

        public TextStyle textStyle { get; set; }
    }
}

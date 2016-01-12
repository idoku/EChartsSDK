using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class HeatMap : Series<HeatMap>
    {
        public int? blurSize { get; set; }

        public IList<object> gradientColors { get; set; }

        public int? minAlpha { get; set; }

        public int? valueScale { get; set; }

        public int? opacity { get; set; }


        public HeatMap() {
            this.type = ChartType.heatmap;
        }

        public HeatMap(string name)
            : this()
        {
            this.name = name;
        }
    }
}

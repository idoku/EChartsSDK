using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class K : Rectangular<K>
    {
        public int? barWidth { get; set; }

        public int? barMaxWidth { get; set; }

        public K()
        {
            this.type = ChartType.k;
        }
    }
}

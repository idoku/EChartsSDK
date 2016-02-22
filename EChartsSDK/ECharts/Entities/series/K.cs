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

        public K(string name):this() {
            this.name = name;
        }

        public K BarWidth(int barWidth)
        {
            this.barWidth = barWidth;
            return this;
        }

        public K BarMaxWidth(int barMaxWidth)
        {
            this.barMaxWidth = barMaxWidth;
            return this;
        }
    }
}

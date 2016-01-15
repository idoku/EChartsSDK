using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class TreeMap : ChartSeries<TreeMap>
    {
        public object center { get; set; }

        public object size { get; set; }

        public string root { get; set; }       

        public TreeMap() {
            this.type = ChartType.treemap;
        }

        public TreeMap(string name) : this() {
            this.name = name;
        }

    }
}

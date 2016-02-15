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

        public TreeMap Center(object center)
        {
            this.center = center;
            return this;
        }

        public TreeMap Size(object size)
        {
            this.size = size;
            return this;
        }

        public TreeMap Root(string root)
        {
            this.root = root;
            return this;
        }

        public TreeMap() {
            this.type = ChartType.treemap;
        }

        public TreeMap(string name) : this() {
            this.name = name;
        }

    }
}

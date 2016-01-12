using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class Funnel : Series<Funnel>
    {
        public object x { get; set; }

        public object y { get; set; }

        public object x2 { get; set; }

        public object y2 { get; set; }

        public object width { get; set; }

        public object height { get; set; }

        public HorizontalType funnelAlign { get; set; }

        public int? min { get; set; }

        public int? max { get; set; }

        public string minSize { get; set; }

        public string maxSize { get; set; }

        public SortType? sort { get; set; }

        public int? gap { get; set; }

        public bool? legendHoverLink { get; set; }

        public Funnel()
        {
            this.type = ChartType.funnel;
        }

        public Funnel(string name):this() {
            this.name = name;
        }
    }
}

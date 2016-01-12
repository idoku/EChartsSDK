using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class Radar : Series<Radar>
    {
        public int? polarIndex { get; set; }

        public string symbol { get; set; }

        public object symbolSize { get; set; }

        public int? symbolRotate { get; set; }

        public bool? legendHoverLink { get; set; }

        public Radar() {
            this.type = ChartType.radar;
        }

        public Radar(string name) : this() {
            this.name = name;
        }
    }
}

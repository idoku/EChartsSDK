using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class EventRiver : ChartSeries<EventRiver>
    {
        public int? xAxisIndex { get; set; }

        public int? weight { get; set; }        

        public bool? legendHoverLink { get; set; }       

        public EventRiver() {
            this.type = ChartType.time;
        }

        public EventRiver(string name) : this() {
            this.name = name;
        }
    }
}

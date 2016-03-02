using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class LocationData
    {
        public object x { get; set; }
        public object y { get; set; }

        public LocationData() { }

        public LocationData(object x, object y) {
            this.x = x;
            this.y = y;
        }
    }
}

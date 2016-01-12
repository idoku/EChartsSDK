using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.feature
{
    public class DataZoom
    {
        public bool? show { get; set; }

        public bool? realtime { get; set; }

        public int? start { get; set; }

        public int? end { get; set; }

        public DataZoom Show(bool show)
        {
            this.show = show;
            return this;
        }
        public DataZoom Realtime(bool realtime)
        {
            this.realtime = realtime;
            return this;
        }
        public DataZoom Start(int start)
        {
            this.start = start;
            return this;
        }
        public DataZoom End(int end)
        {
            this.end = end;
            return this;
        }

    }
}

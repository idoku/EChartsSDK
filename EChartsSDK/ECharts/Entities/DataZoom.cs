using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities
{
    public class DataZoom:Basic<DataZoom>
    {
        public OrientType? orient { get; set; }

        public int? width { get; set; }

        public int? height { get; set; }

        public string fillerColor { get; set; }

        public string handleColor { get; set; }

        public int? handleSize { get; set; }

        public object xAxisIndex { get; set; }

        public object yAxisIndex { get; set; }

        public bool? realtime { get; set; }

        public int? start { get; set; }

        public int? end { get; set; }

        public bool? zoomLock { get; set; }


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

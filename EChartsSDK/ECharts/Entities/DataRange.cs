using ECharts.Entities.feature;
using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities
{
    public class DataRange:Basic<DataRange>
    {
        public OrientType? orient { get; set; }

        public int? itemGap { get; set; }

        public int? itemHeight { get; set; }

        public int? min { get; set; }

        public int? max { get; set; }

        public int? precision { get; set; }

        public int? splitNumber { get; set; }

        public IList<Split> splitList { get; set; }

        public Range range { get; set; }

        public object selectedMode { get; set; }

        public bool? calculable { get; set; }

        public bool? hoverLink { get; set; }

        public bool? realtime { get; set; }

        public IList<string> color { get; set; }

        public object formatter { get; set; }

        public IList<string> text { get; set; }

        public TextStyle textStyle { get; set; }

        public DataRange ItemGap(int itemGap)
        {
            this.itemGap = itemGap;
            return this;
        }

    }
}

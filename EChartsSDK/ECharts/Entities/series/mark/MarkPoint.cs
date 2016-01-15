using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{

    public class MarkPoint:AbstractData<MarkPoint>
    {
        public bool? clickable { get; set; }

        public string symbol { get; set; }

        public object symbolSize { get; set; }

        public int? symbolRotate { get; set; }

        public bool? large { get; set; }

        public Effect effect { get; set; }

        public ItemStyle itemStyle { get; set; }
      
    }
 

}

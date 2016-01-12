using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class Bar : Rectangular<Bar>
    {
        public object barGap { get; set; }

        public object barCategoryGap { get; set; }

        public int? barMinHeight { get; set; }

        public int? barWidth { get; set; }

        public int? barMaxWidth { get; set; }

        public Bar() {
            this.type = ChartType.bar;
        }

        public Bar(string name) : this() {
            this.name = name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class Pie : Series<Pie>
    {
        public IList<object> center { get; set; }

        public object radius { get; set; }

        public int? startAngle { get; set; }

        public int? minAngle { get; set; }

        public bool? clockWise { get; set; }

        public NigRoseType? roseType { get; set; }

        public int? selectedOffset { get; set; }

        public SelectedModeType? selectedMode { get; set; }

        public bool? legendHoverLink { get; set; }

        public Pie Radius(string radius)
        {
            this.radius = radius;
            return this;
        }

        public Pie Center(IList<object> center)
        {
            this.center = center;
            return this;
        }

        public Pie() {
            this.type = ChartType.pie;
        }

        public Pie(string name):this() {
            this.name = name;
        }

    }
}

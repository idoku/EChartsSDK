using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.axis
{
    public class CategoryAxis : Axis
    {
        public bool? boundaryGap { get; set; }

        public CategoryAxis Name(string name)
        {
            this.name = name;
            return this;
        }

        public CategoryAxis()
        {
            type = AxisType.category;
        }


        public CategoryAxis BoundaryGap(bool boundaryGap)
        {
            this.boundaryGap = boundaryGap;
            return this;
        }

    }
}

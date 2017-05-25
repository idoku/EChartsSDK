using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.axis
{
    public class RadiusAxis :ChartAxis<RadiusAxis>
    {
         public int? polarIndex { get; set; }

        


        public RadiusAxis(AxisType type)
        {
            this.type = type;
        }

    

        public RadiusAxis PolarIndex(int polarIndex)
        {
            this.polarIndex = polarIndex;
            return this;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.axis
{
    public class LogAxis : ChartAxis<LogAxis>
    {
        public bool? logPositive { get; set; }

        public int? logLabelBase { get; set; }


        public LogAxis()
        {
            this.type = AxisType.log;
        }

     

        public LogAxis LogLabelBase(int logLabelBase)
        {
            this.logLabelBase = logLabelBase;
            return this;
        }

        public LogAxis LogPositive(bool logPositive)
        {
            this.logPositive = logPositive;
            return this;
        }



    }
}

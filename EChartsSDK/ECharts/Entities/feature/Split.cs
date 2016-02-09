using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.feature
{
    public class Split
    {
        public int? start { get; set; }

        public int? end { get; set; }

        public string label { get; set; }

        public string color { get; set; }

        public Split Label(string label)
        {
            this.label = label;
            return this;
        }

        public Split Color(string color)
        {
            this.color = color;
            return this;
        }

        public Split End(int end)
        {
            this.end = end;
            return this;
        }

        public Split Start(int start)
        {
            this.start = start;
            return this;
        }
    }
}

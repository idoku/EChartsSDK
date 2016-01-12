using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class WordCloud : Series<WordCloud>
    {
        public object center { get; set; }

        public object size { get; set; }

        public object textRotation { get; set; }

        public AutoSizeConfig autoSize { get; set; }


        public WordCloud() {
            this.type = ChartType.wordCloud;
        }

        public WordCloud(string name) : this() {
            this.name = name;
        }
    }
}

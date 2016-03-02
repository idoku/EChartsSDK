using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class WordCloud : ChartSeries<WordCloud>
    {
        public object center { get; set; }

        public object size { get; set; }

        public object textPadding { get; set; }

        public object textRotation { get; set; }

        public AutoSizeConfig autoSize { get; set; }

        public AutoSizeConfig AutoSize()
        {
            if (autoSize == null)
                autoSize = new AutoSizeConfig();            
            return autoSize;
        }

        public WordCloud Center(string center)
        {
            this.center = center;
            return this;
        }

        public WordCloud Size(object size)
        {
            this.size = size;
            return this;
        }

        public WordCloud TextPadding(object textPadding)
        {
            this.textPadding = textPadding;
            return this;
        }
        



        public WordCloud TextRotation(object textRotation)
        {
            this.textRotation = textRotation;
            return this;
        }

        public WordCloud() {
            this.type = ChartType.wordCloud;
        }

        public WordCloud(string name) : this() {
            this.name = name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class Funnel : ChartSeries<Funnel>
    {
        public object x { get; set; }

        public object y { get; set; }

        public object x2 { get; set; }

        public object y2 { get; set; }

        public object width { get; set; }

        public object height { get; set; }

        public object center { get; set; }

        public HorizontalType? funnelAlign { get; set; }

        public int? min { get; set; }

        public int? max { get; set; }

        public string minSize { get; set; }

        public string maxSize { get; set; }

        public SortType? sort { get; set; }

        public int? gap { get; set; }

        public bool? legendHoverLink { get; set; }

        public Funnel LegendHoverLink(bool legendHoverLink)
        {
            this.legendHoverLink = legendHoverLink;
            return this;
        }

        public Funnel Gap(int gap)
        {
            this.gap = gap;
            return this;
        }

        public Funnel Sort(SortType sort)
        {
            this.sort = sort;
            return this;
        }

        public Funnel Center(object center)
        {
            this.center = center;
            return this;
        }


        public Funnel MinSize(string minSize)
        {
            this.minSize = minSize;
            return this;
        }

        public Funnel MaxSize(string maxSize)
        {
            this.maxSize = maxSize;
            return this;
        }

        public Funnel Max(int max)
        {
            this.max = max;
            return this;
        }

        public Funnel Min(int min)
        {
            this.min = min;
            return this;
        }

        public Funnel FunnelAlign(HorizontalType funnelAlign)
        {
            this.funnelAlign = funnelAlign;
            return this;
        }

        public Funnel Height(object height)
        {
            this.height = height;
            return this;
        }

        public Funnel Width(object width)
        {
            this.width = width;
            return this;
        }

        public Funnel Y(object y)
        {
            this.y = y;
            return this;
        }

        public Funnel Y2(object y2)
        {
            this.y2 = y2;
            return this;
        }

        public Funnel X(object x)
        {
            this.x = x;
            return this;
        }

        public Funnel X2(object x2)
        {
            this.x2 = x2;
            return this;
        }




        public Funnel()
        {
            this.type = ChartType.funnel;
        }

        public Funnel(string name):this() {
            this.name = name;
        }
    }
}

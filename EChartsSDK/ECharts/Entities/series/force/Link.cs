using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class Link
    {
        public object source { get; set; }

        public object target { get; set; }

        public int? weight { get; set; }

        public ItemStyle itemStyle { get; set; }

        public Link Source(object source)
        {
            this.source = source;
            return this;
        }

        public Link Target(object target)
        {
            this.target = target;
            return this;
        }

        public Link Weight(int weight)
        {
            this.weight = weight;
            return this;
        }

        public ItemStyle ItemStyle()
        {
            if (itemStyle == null)
                this.itemStyle = new style.ItemStyle();
            return this.itemStyle;
        }
    }
}

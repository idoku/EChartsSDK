using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class Tree : ChartSeries<Tree>
    {
        public object rootLocation { get; set; }

        public int? layerPadding { get; set; }

        public int? nodePadding { get; set; }

        public OrientType? orient { get; set; }

        public DirectionType? direction { get; set; }

        public object roam { get; set; }

        public string symbol { get; set; }

        public object symbolSize { get; set; }


        public Tree() {
            this.type = ChartType.tree;
        }

        public Tree(string name)
            : this()
        {
            this.name = name;
        }
    }
}

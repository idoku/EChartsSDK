using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class Chord : ChartSeries<Chord>
    {
        public IList<Category> categories { get; set; }

        public IList<Node> nodes { get; set; }

        public IList<Link> links { get; set; }

        public IList<int> matrix { get; set; }

        public bool? ribbonType { get; set; }

        public string symbol { get; set; }

        public int? symbolSize { get; set; }

        public int? minRadius { get; set; }

        public int? maxRadius { get; set; }

        public bool? showScale { get; set; }

        public bool? showScaleText { get; set; }

        public int? padding { get; set; }

        public SortType? sort { get; set; }

        public SortType? sortSub { get; set; }

        public bool? clockWise { get; set; }

        public Chord() {
            this.type = ChartType.chord;
        }

        public Chord(string name):this() {
            this.name = name;
        }

    }
}

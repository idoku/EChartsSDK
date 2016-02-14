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

        public Chord ClockWise(bool clockWise)
        {
            this.clockWise = clockWise;
            return this;
        }

        public Chord SortSub(SortType sortSub)
        {
            this.sortSub = sortSub;
            return this;
        }

        public Chord Sort(SortType sort)
        {
            this.sort = sort;
            return this;
        }

        public Chord ShowScaleText(bool showScaleText)
        {
            this.showScaleText = showScaleText;
            return this;
        }

        public Chord Padding(int padding)
        {
            this.padding = padding;
            return this;
        }

        public Chord ShowScale(bool showScale)
        {
            this.showScale = showScale;
            return this;
        }

        public Chord MaxRadius(int maxRadius)
        {
            this.maxRadius = maxRadius;
            return this;
        }

        public Chord MinRadius(int minRadius)
        {
            this.minRadius = minRadius;
            return this;
        }

        public Chord SymbolSize(int symbolSize)
        {
            this.symbolSize = symbolSize;
            return this;
        }

        public Chord Symbol(string symbol)
        {
            this.symbol = symbol;
            return this;
        }

        public Chord RibbonType(bool ribbonType)
        {
            this.ribbonType = ribbonType;
            return this;
        }

        public Chord() {
            this.type = ChartType.chord;
        }

        public Chord(string name):this() {
            this.name = name;
        }

    }
}

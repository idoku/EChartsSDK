using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class Radar : ChartSeries<Radar>
    {
        public int? polarIndex { get; set; }

        public string symbol { get; set; }

        public object symbolSize { get; set; }

        public int? symbolRotate { get; set; }

        public bool? legendHoverLink { get; set; }

        public Radar PolarIndex(int polarIndex)
        {
            this.polarIndex = polarIndex;
            return this;
        }

        public Radar LegendHoverLink(bool legendHoverLink)
        {
            this.legendHoverLink = legendHoverLink;
            return this;
        }

        public Radar SymbolRotate(int symbolRotate)
        {
            this.symbolRotate = symbolRotate;
            return this;
        }

        public Radar SymbolSize(int symbolSize)
        {
            this.symbolSize = symbolSize;
            return this;
        }

        public Radar Symbol(string symbol)
        {
            this.symbol = symbol;
            return this;
        }



        public Radar() {
            this.type = ChartType.radar;
        }

        public Radar(string name) : this() {
            this.name = name;
        }
    }
}

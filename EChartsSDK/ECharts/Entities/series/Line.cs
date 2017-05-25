using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class Line : Rectangular<Line>
    {
        public bool? showAllSymbol { get; set; }

        public bool? smooth { get; set; }

        public object dataFilter { get; set; }


        public object step { get; set; }



        public SamplingType sampling { get; set; }

        public Line() {
            this.type = ChartType.line;
        }

        public Line(string name):this() {
            this.name = name;
        }

        public Line ShowAllSymbol(bool showAllSymbol)
        {
            this.showAllSymbol = showAllSymbol;
            return this;
        }

        public Line Sampling(SamplingType sampling)
        {
            this.sampling = sampling;
            return this;
        }

        public Line DataFilter(object dataFilter)
        {
            this.dataFilter = dataFilter;
            return this;
        }

        public Line Step(bool step)
        {
            this.step = step;
            return this;
        }

        public Line Step(LineStepType step)
        {
            this.step = step;
            return this;
        }

        public Line Smooth(bool smooth) {
            this.smooth = smooth;
            return this;
        }

    }
}

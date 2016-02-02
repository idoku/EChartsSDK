using ECharts.Entities.series;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.feature
{
    public class MagicOption
    {
        public Line line { get; set; }

        public Bar bar { get; set; }

        //public Tiled tiled { get; set; }

        public Force force { get; set; }

        public Chord chord { get; set; }

        public Pie pie { get; set; }

        public Funnel funnel { get; set; }

        public Chord Chord()
        {
            if (chord == null)
                chord = new series.Chord();
            return chord;
        }

        public Pie Pie()
        {
            if (pie == null)
                pie = new series.Pie();
            return pie;
        }

        public Funnel Funnel()
        {
            if (funnel == null)
                funnel = new series.Funnel();
            return funnel;
        }


        public Line Line()
        {
            if (line == null)
                line = new series.Line();
            return line;
        }


        public Bar Bar()
        {
            if (bar == null)
                bar = new series.Bar();
            return bar;
        }

        public Force Force()
        {
            if (force == null)
                force = new series.Force();
            return force;
        }

      
    }
}

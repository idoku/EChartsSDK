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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.feature
{
    public class MagicTitle
    {
        public string line { get; set; }

        public string bar { get; set; }

        public string stack { get; set; }

        public string tiled { get; set; }

        public string force { get; set; }

        public string chord { get; set; }

        public string pie { get; set; }

        public string funnel { get; set; }

        public MagicTitle Funnel(string funnel)
        {
            this.funnel = funnel;
            return this;
        }

        public MagicTitle Pie(string pie)
        {
            this.pie = pie;
            return this;
        }

        public MagicTitle Chord(string chord)
        {
            this.chord = chord;
            return this;
        }

        public MagicTitle Force(string force)
        {
            this.force = force;
            return this;
        }

        public MagicTitle Tiled(string tiled)
        {
            this.tiled = tiled;
            return this;
        }


        public MagicTitle Stack(string stack)
        {
            this.stack = stack;
            return this;
        }

        public MagicTitle Bar(string bar)
        {
            this.bar = bar;
            return this;
        }

        public MagicTitle Line(string line)
        {
            this.line = line;
            return this;
        }



    }
}

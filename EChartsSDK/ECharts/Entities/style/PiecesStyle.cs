using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.style
{
    public class PiecesStyle
    {
        public int? min { get; set; }
        public int? max { get; set; }

        public string  label { get; set; }

        public int? value { get; set; }

        public int? gt { get; set; }

        public int? lte { get; set; }

        public int? lt { get; set; }

        public string color { get; set; }

        public PiecesStyle Color(string color)
        {
            this.color = color;
            return this;
        }

        public PiecesStyle Lt(int lt)
        {
            this.lt = lt;
            return this;
        }

        public PiecesStyle Lte(int lte)
        {
            this.lte = lte;
            return this;
        }

        public PiecesStyle Gt(int gt)
        {
            this.gt = gt;
            return this;
        }

        public PiecesStyle Value(int value)
        {
            this.value = value;
            return this;
        }

        public PiecesStyle Label(string label)
        {
            this.label = label;
            return this;
        }

        public PiecesStyle Min(int min)
        {
            this.min = min;
            return this;
        }
        public PiecesStyle Max(int max)
        {
            this.max = max;
            return this;
        }

        
    }
}

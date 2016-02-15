using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.style
{
    public class ControlStyle
    {
        public int? itemSize { get; set; }

        public int? itemGap { get; set; }

        public Normal normal { get; set; }

        public Emphasis empasis { get; set; }

        public Emphasis Emphasis()
        {
            if (empasis == null)
                this.empasis = new Emphasis();
            return this.empasis;
        }

        public Normal Normal()
        {
            if (normal == null)
                this.normal = new Normal();
            return this.normal;
        }

        public ControlStyle ItemGap(int itemGap)
        {
            this.itemGap = itemGap;
            return this;
        }

        public ControlStyle ItemSize(int itemSize)
        {
            this.itemSize = itemSize;
            return this;
        }

        


    }
}

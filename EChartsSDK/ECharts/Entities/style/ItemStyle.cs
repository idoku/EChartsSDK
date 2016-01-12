using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.style
{
    public class ItemStyle
    {
        public Normal normal { get; set; }

        public Emphasis emphasis { get; set; }

        public Normal Normal() {
            if (normal==null)
            {
                this.normal = new Normal();
            }
            return normal;
        }

        public Emphasis Emphasis()
        {
            if (emphasis == null)
            {
                this.emphasis = new Emphasis();
            }
            return this.emphasis;
        }
    }

   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.style
{
    public class LineLabelStyle
    {
        public bool? show { get; set; }

        public LabelPositionType? position { get; set; }

        public object formatter { get; set; }

        public LineLabelStyle Show(bool show)
        {
            this.show = show;
            return this;
        }

        public LineLabelStyle Position(LabelPositionType position)
        {
            this.position = position;
            return this;
        }


        public LineLabelStyle Formatter(object formatter)
        {
            this.formatter = formatter;
            return this;
        }


    }
}

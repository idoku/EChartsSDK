using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class AutoSizeConfig
    {
        public bool? enable { get; set; }

        public int? minSize { get; set; }

        public AutoSizeConfig Enable(bool enable)
        {
            this.enable = enable;
            return this;
        }

        public AutoSizeConfig MinSize(int minSize)
        {
            this.minSize = minSize;
            return this;
        }
    }
}

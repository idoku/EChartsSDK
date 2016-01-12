using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.feature
{
    public class FeatureImage
    {
        public bool? show { get; set; }

        public string title { get; set; }

        public string type { get; set; }

        public IList<string> lang { get; set; }

        public FeatureImage Show(bool show)
        {
            this.show = show;
            return this;
        }
    }
}

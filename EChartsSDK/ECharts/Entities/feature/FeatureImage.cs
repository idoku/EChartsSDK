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

        public FeatureImage Title(string title)
        {
            this.title = title;
            return this;
        }

        public FeatureImage Type(ImageType type)
        {
            this.type = type.ToString();
            return this;
        }

        public FeatureImage Type(string type)
        {
            this.type = type;                
            return this;
        }
    }
}

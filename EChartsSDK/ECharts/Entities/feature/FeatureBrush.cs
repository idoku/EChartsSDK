using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.feature
{
    public class FeatureBrush
    {
        public IList<BrushType> type { get; set; }

        public BrushIcon icon { get; set; }

        public BrushTitle title { get; set; }

        public FeatureBrush Type(params BrushType[] values)
        {
            this.type = values.ToList();
            return this;
        }

        public BrushIcon Icon()
        {
            if(this.icon == null)
                this.icon = new BrushIcon();
            return this.icon;
        }

        public BrushTitle Title()
        {
            if (this.title == null)
                this.title = new BrushTitle();
            return this.title;
        }

    }

    public class BrushIcon
    {
        public string rect { get; set; }

        public string polygon { get; set; }

        public string lineX { get; set; }

        public string lineY { get; set; }

        public string keep { get; set; }

        public string clear { get; set; }


    }

    public class BrushTitle
    {
        public string rect { get; set; }

        public string polygon { get; set; }

        public string lineX { get; set; }

        public string lineY { get; set; }

        public string keep { get; set; }

        public string clear { get; set; }


    }


}

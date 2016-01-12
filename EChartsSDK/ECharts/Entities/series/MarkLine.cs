using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class MarkLine:AbstractData<MarkPoint>
    {
        public bool? clickable { get; set; }

        public object symbol { get; set; }

        public object symbolSize { get; set; }

        public object symbolRotate { get; set; }

        public bool? large { get; set; }

        public bool? smooth { get; set; }

        public double? smoothness { get; set; }

        public int? precision { get; set; }

        public Bound bounding { get; set; }
     

        public Effect effect { get; set; }

        public ItemStyle itemStyle { get; set; }


        public Bound Bound()
        {
            if (bounding == null)
                bounding = new series.Bound();
            return bounding;
        }

        public ItemStyle ItemStyle()
        {
            if (itemStyle == null)
                itemStyle = new ItemStyle();
            return itemStyle;
        }

        public Effect Effect()
        {
            if (effect == null)
                effect = new series.Effect();
            return effect;
        }

    }
}

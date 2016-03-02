using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class HeatMap : ChartSeries<HeatMap>
    {
        public int? blurSize { get; set; }

        public bool? hoverable { get; set; }

        public IList<GradientColorData> gradientColors { get; set; }

        public double? minAlpha { get; set; }

        public int? valueScale { get; set; }

        public double? opacity { get; set; }

        public HeatMap Hoverable(bool hoverable)
        {
            this.hoverable = hoverable;
            return this;
        }

        public HeatMap Opacity(double opacity)
        {
            this.opacity = opacity;
            return this;
        }

        public HeatMap ValueScale(int valueScale)
        {
            this.valueScale = valueScale;
            return this;
        }

        public HeatMap GradientColors(params GradientColorData[] values)
        {
            if (values == null)
                return this;
            gradientColors = values.ToList();
            return this;
        }

        public HeatMap BlurSize(int blurSize)
        {
            this.blurSize = blurSize;
            return this;
        }

        public HeatMap MinAlpha(double minAlpha)
        {
            this.minAlpha = minAlpha;
            return this;
        }

        public HeatMap() {
            this.type = ChartType.heatmap;
        }

        public HeatMap(string name)
            : this()
        {
            this.name = name;
        }
    }
}

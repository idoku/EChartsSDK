using ECharts.Entities.axis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities
{
    public class IndicatorData
    {
        public string text { get; set; }

        public int? min { get; set; }

        public int? max { get; set; }

        public AxisLabel axisLabel { get; set; }

        public IndicatorData()
        {
          
        }

        public IndicatorData(string text) {
            this.text = text;
        }

        public AxisLabel AxisLabel()
        {
            if (axisLabel == null)
                axisLabel = new axis.AxisLabel();
            return this.axisLabel;
        }

        public IndicatorData Text(string text)
        {
            this.text = text;
            return this;
        }

        public IndicatorData Min(int min)
        {
            this.min = min;
            return this;
        }

        public IndicatorData Max(int max)
        {
            this.max = max;
            return this;
        }

    }
}

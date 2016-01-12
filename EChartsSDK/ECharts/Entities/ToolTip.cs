using ECharts.Entities.axis;
using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities
{
    public class ToolTip
    {
        public bool? show { get; set; }

        public int? zlevel { get; set; }

        public int? z { get; set; }

        public bool? showContent{ get; set; }

        public TriggerType? trigger { get; set; }

        public object position { get; set; }

        public object formatter { get; set; }

        public object islandFormatter { get; set; }

        public int? showDelay { get; set; }

        public int? hideDelay { get; set; }

        public double? transitionDuration { get; set; }

        public bool? enterable { get; set; }

        public object backgroundColor { get; set; }

        public string borderColor { get; set; }

        public int? borderRadius { get; set; }

        public int? borderWidth { get; set; }

        public int? padding { get; set; }

        public AxisPointer axisPointer { get; set; }

    

        public TextStyle textStyle { get; set; }

        public ToolTip ShowDelay(int showDelay)
        {
            this.showDelay = showDelay;
            return this;
        }


        public ToolTip Trigger(TriggerType trigger)
        {
            this.trigger = trigger;
            return this;
        }

        public ToolTip Formatter(object formatter) {
            this.formatter = formatter;
            return this;
        }

        public AxisPointer AxisPointer()
        {
            if (this.axisPointer==null)
            {
                this.axisPointer = new AxisPointer();
            }
            return this.axisPointer;
        }

    }
}

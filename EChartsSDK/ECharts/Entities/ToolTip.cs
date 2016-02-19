using ECharts.Entities.axis;
using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities
{
    public class ToolTip:Basic<ToolTip>
    {     
        public bool? showContent{ get; set; }

        public TriggerType? trigger { get; set; }

        public object position { get; set; }

        public object formatter { get; set; }

        public object islandFormatter { get; set; }

        public int? showDelay { get; set; }

        public int? hideDelay { get; set; }

        public double? transitionDuration { get; set; }

        public bool? enterable { get; set; }        

        public int? borderRadius { get; set; }

        

        public AxisPointer axisPointer { get; set; }    

        public TextStyle textStyle { get; set; }

        public TextStyle TextStyle()
        {
            if (this.textStyle == null)
            {
                this.textStyle = new TextStyle();
            }
            return this.textStyle;
        }

        public ToolTip BorderWidth(int borderWidth)
        {
            this.borderWidth = borderWidth;
            return this;
        }

        public ToolTip BorderRadius(int borderRadius)
        {
            this.borderRadius = borderRadius;
            return this;
        }

        public ToolTip Enterable(bool enterable)
        {
            this.enterable = enterable;
            return this;
        }

        public ToolTip TransitionDuration(double transitionDuration)
        {
            this.transitionDuration = transitionDuration;
            return this;
        }

        public ToolTip HideDelay(int hideDelay)
        {
            this.hideDelay = hideDelay;
            return this;
        }

        public ToolTip IslandFormatter(object islandFormatter)
        {
            this.islandFormatter = islandFormatter;
            return this;
        }

        public ToolTip Formatter(object formatter)
        {
            this.formatter = formatter;
            return this;
        }

        public ToolTip Position(object position)
        {
            this.position = position;
            return this;
        }

        public ToolTip ShowContent(bool showContent)
        {
            this.showContent = showContent;
            return this;
        }

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

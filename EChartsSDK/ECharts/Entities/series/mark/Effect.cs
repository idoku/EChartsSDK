using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class Effect
    {
        public bool? show { get; set; }

        public string type { get; set; }

        public bool? loop { get; set; }

        public int? period { get; set; }

        public int? scaleSize { get; set; }

        public int? bounceDistance { get; set; }

        public object color { get; set; }

        public object shadowColor { get; set; }

        public int? shadowBlur { get; set; }

       

        public Effect Loop(bool loop)
        {
            this.loop = loop;
            return this;
        }

        public Effect Type(string type)
        {
            this.type = type;
            return this;
        }

        public Effect Show(bool show)
        {
            this.show = show;
            return this;
        }

        public Effect ShadowBlur(int shadowBlur)
        {
            this.shadowBlur = shadowBlur;
            return this;
        }

        public Effect ShadowColor(object shadowColor)
        {
            this.shadowColor = shadowColor;
            return this;
        }

        public Effect Color(object color)
        {
            this.color = color;
            return this;
        }

        public Effect BounceDistance(int bounceDistance)
        {
            this.bounceDistance = bounceDistance;
            return this;
        }

        public Effect ScaleSize(int scaleSize)
        {
            this.scaleSize = scaleSize;
            return this;
        }

        public Effect Period(int loop)
        {
            this.period = period;
            return this;
        }       


    }
}

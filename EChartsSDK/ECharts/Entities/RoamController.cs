using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities
{
    public class RoamController : Basic<RoamController>
    {
        public int? width { get; set; }

        public int? height { get; set; }

        public string fillerColor { get; set; }

        public string handleColor { get; set; }

        public int? step { get; set; }

        public Dictionary<string,bool> mapTypeControl { get; set; }

        public RoamController Step(int step)
        {
            this.step = step;
            return this;
        }

        public RoamController HandleColor(string handleColor)
        {
            this.handleColor = handleColor;
            return this;
        }

        public RoamController FillerColor(string fillerColor)
        {
            this.fillerColor = fillerColor;
            return this;
        }

        public RoamController Width(int width)
        {
            this.width = width;
            return this;
        }

        public RoamController Hidth(int height)
        {
            this.height = height;
            return this;
        }


    }
}

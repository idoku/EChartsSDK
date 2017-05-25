using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series.graph
{
    public class Force
    {
        public object initLayout { get; set; }

        public int? repulsion { get; set; }

        public double? gravity { get; set; }

        public int? edgeLength { get; set; }

        public bool? layoutAnimation { get; set; }

        public Force LayoutAnimation(bool layoutAnimation)
        {
            this.layoutAnimation = layoutAnimation;
            return this;
        }

        public Force EdgeLength(int edgeLength)
        {
            this.edgeLength = edgeLength;
            return this;
        }

        public Force Gravity(double gravity)
        {
            this.gravity = gravity;
            return this;
        }

        public Force InitLayout(object initLayout)
        {
            this.initLayout = initLayout;
            return this;
        }

        public Force Repulsion(int repulsion)
        {
            this.repulsion = repulsion;
            return this;
        }


    }
}

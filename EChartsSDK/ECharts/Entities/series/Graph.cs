using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class Graph : ChartSeries<Graph>
    {
        public string layout { get; set; }

        public object links { get; set; }

        public object categories { get; set; }

        public Graph Categories(object categories)
        {
            this.categories = categories;
            return this;
        }

        public Graph Links(object links)
        {
            this.links = links;
            return this;
        }

        public Graph Layout(string layout)
        {
            this.layout = layout;
            return this;
        }
         
        public graph.Force force { get; set; }

        public Graph()
        {
            this.type = ChartType.graph;            
        }

        public graph.Force Force()
        {         
            if(this.force==null)
                this.force = new graph.Force();
            return this.force;
        }

    }
}

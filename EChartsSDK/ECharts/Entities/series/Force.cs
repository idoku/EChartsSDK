using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class Force : Series<Force>
    {
        public IList<Category> categories { get; set; }

        public IList<Node> nodes { get; set; }

        public IList<Link> links { get; set; }

        public int[,] matrix { get; set; }

        public object center { get; set; }

        public object size { get; set; }

        public int? minRadius { get; set; }

        public int? maxRadius { get; set; }

        public string symbol { get; set; }

        public object symbolSize { get; set; }

        public object linkSymbol { get; set; }

        public IList<int> linkSymbolSize { get; set; }

        public int? scaling { get; set; }

        public int? gravity { get; set; }

        public bool? draggable { get; set; }

        public bool? large { get; set; }

        public int? steps { get; set; }

        public object roam { get; set; }


        public Force() {
            this.type = ChartType.force;
        }

        public Force(string name):this()
        {
            this.name = name;
        }
     

    }
}

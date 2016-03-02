using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class Tree : ChartSeries<Tree>
    {
        public LocationData rootLocation { get; set; }

        public int? layerPadding { get; set; }

        public int? nodePadding { get; set; }

        public OrientType? orient { get; set; }

        public DirectionType? direction { get; set; }

        public object roam { get; set; }

        public string symbol { get; set; }

        public object symbolSize { get; set; }

      
        public Tree Symbol(string symbol)
        {
            this.symbol = symbol;
            return this;
        }

        public Tree SymbolSize(string symbolSize)
        {
            this.symbolSize = symbolSize;
            return this;
        }



        public Tree Roam(object roam)
        {
            this.roam = roam;
            return this;
        }

        public Tree Direction(DirectionType direction)
        {
            this.direction = direction;
            return this;
        }

        public Tree Orient(OrientType orient)
        {
            this.orient = orient;
            return this;
        }

        public Tree NodePadding(int nodePadding)
        {
            this.nodePadding = nodePadding;
            return this;
        }

        public Tree LayerPadding(int layerPadding)
        {
            this.layerPadding = layerPadding;
            return this;
        }

        public Tree RootLocation(LocationData rootLocation)
        {
            this.rootLocation = rootLocation;
            return this;
        }

        public Tree() {
            this.type = ChartType.tree;
        }

        public Tree(string name)
            : this()
        {
            this.name = name;
        }
    }
}

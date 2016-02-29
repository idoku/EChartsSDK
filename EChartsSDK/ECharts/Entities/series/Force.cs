using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class Force : ChartSeries<Force>
    {
        public IList<Category> categories { get; set; }

        public object nodes { get; set; }

        public object links { get; set; }

        public int[,] matrix { get; set; }

        public object center { get; set; }

        public int? size { get; set; }

        public object minRadius { get; set; }

        public object maxRadius { get; set; }

        public string symbol { get; set; }

        public object symbolSize { get; set; }

        public object linkSymbol { get; set; }

        public double? coolDown { get; set; }

        public IList<int> linkSymbolSize { get; set; }

        public double? scaling { get; set; }

        public double? gravity { get; set; }

        public bool? draggable { get; set; }

        public bool? large { get; set; }

        public bool? useWorker { get; set; }

        public int? steps { get; set; }

        public object roam { get; set; }

        public bool ribbonType { get; set; }

        public Force Roam(object roam)
        {
            this.roam = roam;
            return this;
        }

        public Force Steps(int steps)
        {
            this.steps = steps;
            return this;
        }

        public Force UseWorker(bool useWorker)
        {
            this.large = useWorker;
            return this;
        }

        public Force Large(bool large)
        {
            this.large = large;
            return this;
        }

        public Force Draggable(bool draggable)
        {
            this.draggable = draggable;
            return this;
        }

        public Force Gravity(double gravity)
        {
            this.gravity = gravity;
            return this;
        }

        public Force Scaling(double scaling)
        {
            this.scaling = scaling;
            return this;
        }

        public Force CoolDown(double coolDown)
        {
            this.coolDown = coolDown;
            return this;
        }

        public Force LinkSymbol(object linkSymbol)
        {
            this.linkSymbol = linkSymbol;
            return this;
        }

        public Force Center(object center)
        {
            this.center = center;
            return this;
        }

        public Force Categories(params Category[] values)
        {
            if (this.categories == null)
                this.categories = new List<Category>();
            this.categories = values.ToList();
            return this;
        }

        public Force Nodes(params Node[] values)
        {
            if (this.nodes == null)
            {
                this.nodes = new List<Node>();
            }
            this.nodes = values.ToList();
            return this;
        }

        public Force Links(params Link[] values)
        {
            if (this.links == null)
            {
                this.links = new List<Link>();
            }
            this.links = values.ToList();
            return this;
        }

        public Force Size(int size)
        {
            this.size = size;
            return this;
        }

        public Force MaxRadius(int maxRadius)
        {
            this.maxRadius = maxRadius;
            return this;
        }

        public Force MinRadius(int minRadius)
        {
            this.minRadius = minRadius;
            return this;
        }

        public Force SymbolSize(int symbolSize)
        {
            this.symbolSize = symbolSize;
            return this;
        }

        public Force Symbol(string symbol)
        {
            this.symbol = symbol;
            return this;
        }

        public Force RibbonType(bool ribbonType)
        {
            this.ribbonType = ribbonType;
            return this;
        }


        public Force() {
            this.type = ChartType.force;
        }

        public Force(string name):this()
        {
            this.name = name;
        }
     

    }
}

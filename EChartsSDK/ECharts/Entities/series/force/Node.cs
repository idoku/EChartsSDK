using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class Node
    {
        public string name { get; set; }

        public string label { get; set; }

        public int? value { get; set; }

        public bool? ignore { get; set; }

        public bool? draggable { get; set; }

        public string symbol { get; set; }

        public object symbolSize { get; set; }

        public int? category { get; set; }

        public ItemStyle itemStyle { get; set; }

        public Node() { }

        public Node(string name) {
            this.name = name;
        }

        public Node(string name, int value, int category):this(name)
        {
            this.value = value;
            this.category = category;
        }

        public Node Ignore(bool ignore)
        {
            this.ignore = ignore;
            return this;
        }

        public Node Label(string label)
        {
            this.label = label;
            return this;
        }


        public Node Category(int category)
        {
            this.category = category;
            return this;
        }

        public Node Value(int value)
        {
            this.value = value;
            return this;
        }


        public Node Name(string name)
        {
            this.name = name;
            return this;
        }

        public Node SymbolSize(object symbolSize)
        {
            this.symbolSize = symbolSize;
            return this;
        }

        public Node Symbol(string symbol)
        {
            this.symbol = symbol;
            return this;
        }

        public Node Draggable(bool draggable)
        {
            this.draggable = draggable;
            return this;
        }
    

        public ItemStyle ItemStyle()
        {
            if (itemStyle == null)
                this.itemStyle = new style.ItemStyle();
            return this.itemStyle;
        }

    }
}

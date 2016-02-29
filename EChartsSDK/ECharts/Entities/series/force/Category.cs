using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class Category
    {
        public string name { get; set; }

        public string symbol { get; set; }

        public object symbolSize { get; set; }

        public ItemStyle itemStyle { get; set; }

        public Category(string name) {
            this.name = name;
        }

        public Category SymbolSize(object symbolSize)
        {
            this.symbolSize = symbolSize;
            return this;
        }

        public Category Symbol(string symbol)
        {
            this.symbol = symbol;
            return this;
        }

        public Category Name(string name)
        {
            this.name = name;
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

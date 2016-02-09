using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series.data
{
    public class TreeData
    {
        public string name { get; set; }

        public int? value { get; set; }

        public string symbol { get; set; }

        public object symbolSize { get; set; }

        public IList<TreeData> children { get; set; }

        public ItemStyle itemStyle { get; set; }

        public ItemStyle ItemStyle()
        {
            if (itemStyle == null)
                this.itemStyle = new style.ItemStyle();
            return this.itemStyle;
        }

        public TreeData SymbolSize(object symbolSize)
        {
            this.symbolSize = symbolSize;
            return this;
        }

        public TreeData Symbol(string symbol)
        {
            this.symbol = symbol;
            return this;
        }

        public TreeData Name(string name)
        {
            this.name = name;
            return this;
        }

        public TreeData Value(int value)
        {
            this.value = value;
            return this;
        }


    }
}

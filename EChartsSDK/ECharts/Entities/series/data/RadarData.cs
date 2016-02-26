using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series.data
{
    public class RadarData
    {
        public object value { get; set; }
        public string name { get; set; }

        public object symbol { get; set; }

        public object symbolSize { get; set; }



        public ItemStyle itemStyle { get; set; }

        public ItemStyle ItemStyle()
        {
            if (this.itemStyle == null)
            {
                itemStyle = new style.ItemStyle();
            }
            return itemStyle;
        }

        public RadarData(string name)
        {
            this.name = name;
        }

        public RadarData(object value, string name)
        {
            this.value = value;
            this.name = name;
        }

        public RadarData(object value, string name, ItemStyle itemStyle):this(value,name)
        {
            this.itemStyle = itemStyle;
        }

        public RadarData Value(params object[] values)
        {
            if (values == null)
                return this;
            this.value = values.ToList();
            return this;
        }

        public RadarData Symbol(string symbol)
        {
            this.symbol = symbol;
            return this;
        }

        public RadarData SymbolSize(object symbolSize)
        {
            this.symbolSize = symbolSize;
            return this;
        }
    }
}

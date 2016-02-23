using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series.data
{
    public class PieData<T>
    {
        public T value { get; set; }
        public string name { get; set; }

        public ItemStyle itemStyle { get; set; }

        public ItemStyle ItemStyle() {
            if (this.itemStyle==null)
            {
                itemStyle = new style.ItemStyle();
            }
            return itemStyle;
        }

        public PieData(T value, string name)
        {
            this.value = value;
            this.name = name;
        }

        public PieData(T value, string name,ItemStyle itemStyle):this(value,name)
        {
            this.itemStyle = itemStyle;
        }

    }
}

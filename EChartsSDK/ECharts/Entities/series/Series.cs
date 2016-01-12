using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public abstract class Series<T> : Data<T> where T :class
    {
        public int? zlevel { get; set; }

        public int? z { get; set; }              

        public ChartType type { get; set; }

        public string name { get; set; }

        public ToolTip tooltip { get; set; }

        public bool? clickable { get; set; }

        public ItemStyle itemStyle { get; set; }

        public object data { get; set; }

        public MarkPoint markPoint { get; set; }

        public MarkLine markLine { get; set; }

        public T SetData(object data)
        {
            this.data = data;
            return this as T;
        }

        public T Data(params object[] values)
        {
            if (values == null)
                return default(T);
            this.data = values.ToList();
            return this as T;
        }

        public ItemStyle SetItemStyle(ItemStyle itemStyle)
        {
            this.itemStyle = itemStyle;
            return this.itemStyle;
        }

        public ItemStyle ItemStyle()
        {
            if (this.itemStyle == null)
                this.itemStyle = new style.ItemStyle();
            return itemStyle;
        }

        public MarkLine MarkLine()
        {
            if (this.markLine == null)
                this.markLine = new series.MarkLine();
            return this.markLine;
        }

        public MarkPoint MarkPoint()
        {
            if (this.markPoint == null)
                this.markPoint = new series.MarkPoint();
            return this.markPoint;
        }

     
    }


   


}

using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public abstract class Series 
    {
        public int? zlevel { get; set; }

        public int? z { get; set; }

        public ChartType type { get; set; }

        public string name { get; set; }        

        public ToolTip tooltip { get; set; }

        public ItemStyle itemStyle { get; set; }

        public MarkPoint markPoint { get; set; }

        public MarkLine markLine { get; set; }

        public Series Name(string name)
        {
            this.type = type;
            return this;
        }


        public Series Type(ChartType type)
        {
            this.type = type;
            return this;
        }

        public Series Z(int z)
        {
            this.z = z;
            return this;
        }

        public Series Zlevel(int zlevel)
        {
            this.zlevel = zlevel;
            return this;
        }


        public Series SetItemStyle(ItemStyle itemStyle)
        {
            this.itemStyle = itemStyle;
            return this;
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

        public ToolTip ToolTip()
        {
            if (this.tooltip == null)
                this.tooltip = new ToolTip();
            return this.tooltip;
        }

        public MarkPoint MarkPoint()
        {
            if (this.markPoint == null)
                this.markPoint = new series.MarkPoint();
            return this.markPoint;
        }

     
    }


   


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECharts.Entities.axis;
using ECharts.Entities.style;

namespace ECharts.Entities
{
    public class Calendar : Basic<Calendar>
    {

        public object cellSize { get; set; }

        public object range { get; set; }

        public Calendar Range(object range)
        {
            this.range = range;
            return this;
        }

        public Calendar CellSize(object cellSize)
        {
            this.cellSize = cellSize;
            return this;
        }

        public SplitLine splitLine { get; set; }

        public ItemStyle itemStyle { get; set; }

        public CalendarLabel dayLabel { get; set; }

        public CalendarLabel monthLabel { get; set; }

        public CalendarLabel yearLabel { get; set; }

        public ItemStyle ItemStyle()
        {
            if (itemStyle == null)
                this.itemStyle = new style.ItemStyle();
            return this.itemStyle;
        }

        public CalendarLabel DayLabel()
        {
            if (dayLabel == null)
                this.dayLabel = new style.CalendarLabel();
            return this.dayLabel;
        }

        public CalendarLabel MonthLabel()
        {
            if (monthLabel == null)
                this.monthLabel = new style.CalendarLabel();
            return this.monthLabel;
        }

        public CalendarLabel YearLabel()
        {
            if (yearLabel == null)
                this.yearLabel = new style.CalendarLabel();
            return this.yearLabel;
        }

    }
}

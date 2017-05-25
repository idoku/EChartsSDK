using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.style
{
    public class CalendarLabel:StyleLabel
    {
        public int? firstDay { get; set; }

        public object nameMap { get; set; }


        public CalendarLabel FirstDay(int firstDay)
        {
            this.firstDay = firstDay;
            return this;
        }
        public CalendarLabel NameMap(string nameMap)
        {
            this.nameMap = nameMap;
            return this;
        }

    }
}

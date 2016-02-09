using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series.data
{
    public class MapData
    {
        public string name { get; set; }

        public bool? selected { get; set; }

        public MapData Name(string name)
        {
            this.name = name;
            return this;
        }

        public MapData Selected(bool selected)
        {
            this.selected = selected;
            return this;
        }

    }
}

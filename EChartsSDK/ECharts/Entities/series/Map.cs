using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class Map : Series<Map>
    {
        public SelectedModeType? selectedMode { get; set; }

        public string mapType { get; set; }

        public bool? hoverable { get; set; }

        public bool? dataRangeHoverLink { get; set; }

        public object mapLocation { get; set; }

        public MapValCalType mapValueCalculation { get; set; }

        public int? mapValuePrecision { get; set; }

        public bool? showLegendSymbol { get; set; }

        public object roam { get; set; }

        public object scaleLimit { get; set; }

        public object nameMap { get; set; }

        public object textFixed { get; set; }

        public object geoCoord { get; set; }

        public object heatmap { get; set; }

        public Map() {
            this.type = ChartType.map;
        }

        public Map(string name)
            : this()
        {
            this.name = name;
        }
    }
}

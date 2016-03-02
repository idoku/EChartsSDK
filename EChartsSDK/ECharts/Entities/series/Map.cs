using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class Map : ChartSeries<Map>
    {
        public SelectedModeType? selectedMode { get; set; }

        public string mapType { get; set; }

        public bool? hoverable { get; set; }

        public bool? dataRangeHoverLink { get; set; }

        public object mapLocation { get; set; }

        public MapValCalType? mapValueCalculation { get; set; }

        public int? mapValuePrecision { get; set; }

        public bool? showLegendSymbol { get; set; }

        public object roam { get; set; }

        public object scaleLimit { get; set; }

        public object nameMap { get; set; }

        public object textFixed { get; set; }

        public object geoCoord { get; set; }

        public object heatmap { get; set; }

        public Map SetHeatmap(HeatMap heatmap)
        {
            this.heatmap = heatmap;
            return this;
        }

        public Map GeoCoord(object geoCoord)
        {
            this.geoCoord = geoCoord;
            return this;
        }

        public Map TextFixed(object textFixed)
        {
            this.textFixed = textFixed;
            return this;
        }

        public Map NameMap(bool nameMap)
        {
            this.nameMap = nameMap;
            return this;
        }

        public Map ScaleLimit(bool scaleLimit)
        {
            this.scaleLimit = scaleLimit;
            return this;
        }

        public Map ShowLegendSymbol(bool showLegendSymbol)
        {
            this.showLegendSymbol = showLegendSymbol;
            return this;
        }

        public Map Roam(object roam)
        {
            this.roam = roam;
            return this;
        }

        public Map MapValuePrecision(int mapValuePrecision)
        {
            this.mapValuePrecision = mapValuePrecision;
            return this;
        }

        public Map MapValueCalculation(MapValCalType mapValueCalculation)
        {
            this.mapValueCalculation = mapValueCalculation;
            return this;
        }

        public Map MapLocation(object mapLocation)
        {
            this.mapLocation = mapLocation;
            return this;
        }

        public Map DataRangeHoverLink(bool dataRangeHoverLink)
        {
            this.dataRangeHoverLink = dataRangeHoverLink;
            return this;
        }

        public Map Hoverable(bool hoverable)
        {
            this.hoverable = hoverable;
            return this;
        }

        public Map MapType(string mapType)
        {
            this.mapType = mapType;
            return this;
        }

        public Map SelectedMode(SelectedModeType selectedMode)
        {
            this.selectedMode = selectedMode;
            return this;
        }

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

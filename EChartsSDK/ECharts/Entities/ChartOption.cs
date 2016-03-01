using ECharts.Entities;
using ECharts.Entities.axis;
using ECharts.Entities.feature;
using ECharts.Entities.series;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities
{
    public class ChartOption
    {
        public object backgroundColor { get; set; }

        public object color { get; set; }

        public bool? renderAsImage { get; set; }

        public bool? calculable { get; set; }

        public bool? animation { get; set; }

        public object timeline { get; set; } //timeline

        public Title title { get; set; }

        public ToolBox toolbox { get; set; }

        public ToolTip tooltip { get; set; }

        public Legend legend { get; set; }

        public DataZoom dataZoom { get; set; }

        public Grid grid { get; set; }       
        
        public IList<Polar> polar { get; set; }

        public IList<Axis> xAxis { get; set; }

        public IList<Axis> yAxis { get; set; }

        public object series { get; set; }

        public IList<ChartOption> options { get; set; }

        public string noDataEffect { get; set; }

        public ToolBox ToolBox()
        {
            if (toolbox == null)
                toolbox = new Entities.ToolBox();
            return toolbox;
        }


        public ChartOption BackgroundColor(object backgroundColor)
        {
            this.backgroundColor = backgroundColor;
            return this;
        }

        public ChartOption ToolBox(ToolBox toolbox)
        {
            this.toolbox = toolbox;
            return this;
        }
        
             public ChartOption NoDataEffect(string noDataEffect)
        {
            this.noDataEffect = noDataEffect;
            return this;
        }

        public ChartOption Color(object color)
        {
            this.color = color;
            return this;
        }

        public Title Title()
        {
            if (title == null)
            {
                title = new Title();
            }
            return title;
        }

        public ChartOption Title(Title title)
        {
            this.title = title;
            return this;
        }
        
        
        

        public ChartOption XAxis(params Axis[] values)
        {
            if (values == null || values.Length == 0) {
                return this;
            }

            if (xAxis == null) {
                xAxis = new List<Axis>();
            }

            if (xAxis.Count() == 2) {
                throw new ArgumentOutOfRangeException("xAxis已经存在2个,无法继续添加.");
            }
            if (xAxis.Count() + values.Length > 2) {
                throw new ArgumentOutOfRangeException("添加的xAxis超出最大允许范围:2!");
            }
            values.ToList().ForEach(v => xAxis.Add(v));
            return this;
        }

        public ChartOption YAxis(params Axis[] values)
        {
            if (values == null || values.Length == 0)
            {
                return this;
            }

            if (yAxis == null)
            {
                yAxis = new List<Axis>();
            }

            if (yAxis.Count() == 2)
            {
                throw new ArgumentOutOfRangeException("yAxis已经存在2个,无法继续添加.");
            }
            if (yAxis.Count() + values.Length > 2)
            {
                throw new ArgumentOutOfRangeException("添加的yAxis超出最大允许范围:2!");
            }
            values.ToList().ForEach(v => yAxis.Add(v));
            return this;
        }

        public ChartOption Series<T>(params T[] values)
        {
            if (values == null || values.Length == 0) { 
                return null;
            }

            if (series==null)
            {
                this.series = new List<object>();
            }
            series = values.ToList();
            return this;
        }

        public Legend Legend()
        {
            if (this.legend == null)
                this.legend = new Entities.Legend();
            return this.legend;
        }

        public ChartOption Polar(params Polar[] valuse)
        {
            if (this.polar == null)
                this.polar = new List<Entities.Polar>();
            valuse.ToList().ForEach(v => polar.Add(v));
            return this;
        }

        public ChartOption Legend(Legend legend) {
            this.legend = legend;
            return this;
        }

        public ChartOption Calculable(bool calculable)
        {
            this.calculable = calculable;
            return this;
        }

        public ChartOption Legend(IList<object> values)
        {
            if (legend == null)
            {
                this.legend = new Legend();
            }
            this.legend.data = values;
            return this;
        }

        public ChartOption Legend(params object[] values)
        {
            if (legend == null) {
                this.legend = new Legend();
            }
            this.legend.Data(values);
            return this;
        }

        public ToolTip ToolTip() {
            if (tooltip == null)
                tooltip = new ToolTip();
            return tooltip;
        }


        public DataZoom DataZoom()
        {
            if (this.dataZoom == null)
                this.dataZoom = new DataZoom();
            return this.dataZoom;
        }

        public Grid Grid()
        {
            if (this.grid==null)
            {
                grid = new Grid();
            }
            return this.grid;
        }
    }
}

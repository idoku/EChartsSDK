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
using ECharts.Entities.bmap;

namespace ECharts.Entities
{
    public class ChartOption
    {
        public object backgroundColor { get; set; }

        public object color { get; set; }

        public bool? renderAsImage { get; set; }

        public bool? calculable { get; set; }

        public bool? animation { get; set; }

        public int? animationThreshold { get; set; }

        public int? animationDuration { get; set; }

        public string animationEasing { get; set; }

        public int? animationDelay { get; set; }

        public int? animationDurationUpdate { get; set; }

        public string animationEasingUpdate { get; set; }

        public object animationDelayUpdate { get; set; }


        public TimeLine timeline { get; set; } //timeline

        public IList<Title> title { get; set; }

        public ToolBox toolbox { get; set; }

        public ToolTip tooltip { get; set; }

        public Legend legend { get; set; }

        public AxisPointer axisPointer { get; set; }

        public IList<DataZoom> dataZoom { get; set; }

        public IList<Grid> grid { get; set; }       
        
        public object polar { get; set; }

        public IList<Axis> xAxis { get; set; }

        public IList<Axis> yAxis { get; set; }

        public AngleAxis angleAxis { get; set; }

        public object series { get; set; }

        public ChartOption baseOption { get; set; }

        public IList<ChartOption> options { get; set; }

        public string noDataEffect { get; set; }

        public Radar radar { get; set; }

        public BMap bmap { get; set; }

        public Geo geo { get; set; }

        public Brush brush { get; set; }

        public Parallel parallel { get; set; }

        public IList<axis.ParallelAxis> parallelAxis { get; set; }

        public RadiusAxis radiusAxis { get; set; }

        public object singleAxis { get; set; }

        public object visualMap { get; set; }

        public IList<Calendar> calendar { get; set; }

        public ChartOption Calendar(params Calendar[] values)
        {
            if (values != null)
                this.calendar = values.ToList();
            return this;
        }
       

        public RadiusAxis RadiusAxis(RadiusAxis radiusAxis)
        {
            this.radiusAxis = radiusAxis;
            return this.radiusAxis;
        }

        public AngleAxis AngleAxis()
        {
            if(this.angleAxis==null)
               this.angleAxis = new AngleAxis();
            return this.angleAxis;
        }

        public AngleAxis AngleAxis(AngleAxis angleAxis)
        {
            this.angleAxis = angleAxis;
            return this.angleAxis;
        }

        public SingleAxis SingleAxis(SingleAxis singleAxis)
        {
            this.singleAxis =singleAxis;
            return (SingleAxis)this.singleAxis;
        }

        public ChartOption ParallelAxis(ParallelAxis parallelAxis)
        {
            if (this.parallelAxis == null)
                this.parallelAxis = new List<ParallelAxis>();
            this.parallelAxis.Add(parallelAxis);
            return this;
        }



        public Parallel Parallel()
        {
            if(this.parallel==null)
                this.parallel = new Parallel();
            return this.parallel;
        }

        

        public ToolBox ToolBox()
        {
            if (toolbox == null)
                toolbox = new Entities.ToolBox();
            return toolbox;
        }


        public AxisPointer AxisPointer()
        {
            if(this.axisPointer==null)
                axisPointer = new AxisPointer();
            return axisPointer;
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
                title = new List<Title>();
                title.Add(new Title());
            }
            return title.FirstOrDefault();
        }

        public ChartOption AddTitle(Title title)
        {
            if (this.title == null)
            {
                this.title = new List<Title>();
            }
            this.title.Add(title);
            return this;
        }

        public ChartOption Title(params Title[] values)
        {
            this.title = values.ToList();
            return this;
        }

 
        public ChartOption VisualMap(params VisualMap[] values)
        {
            this.visualMap = values.ToList();
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

            //if (xAxis.Count() == 2) {
            //    throw new ArgumentOutOfRangeException("xAxis已经存在2个,无法继续添加.");
            //}
            //if (xAxis.Count() + values.Length > 2) {
            //    throw new ArgumentOutOfRangeException("添加的xAxis超出最大允许范围:2!");
            //}
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

            //if (yAxis.Count() == 2)
            //{
            //    throw new ArgumentOutOfRangeException("yAxis已经存在2个,无法继续添加.");
            //}
            //if (yAxis.Count() + values.Length > 2)
            //{
            //    throw new ArgumentOutOfRangeException("添加的yAxis超出最大允许范围:2!");
            //}
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

        public ChartOption Series(params Series[] values)
        {
            if (values == null || values.Length == 0)
            {
                return null;
            }

            if (series == null)
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
            polar = valuse.ToList();
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


        public ChartOption DataZoom(params DataZoom[] valuse)
        {
            if (this.dataZoom == null)
                this.dataZoom = new List<DataZoom>();
            valuse.ToList().ForEach(v => dataZoom.Add(v));
            return this;
        }

        public ChartOption Grid(params Grid[] valuse)
        {
            if (this.grid == null)
                this.grid = new List<Entities.Grid>();
            valuse.ToList().ForEach(v => grid.Add(v));
            return this;
        }

        public Grid Grid()
        {
            if (this.grid==null)
            {
                grid = new List<Grid> {new Grid()};
            }            
            return this.grid[0];
        }

        public Radar Radar()
        {
            if(this.radar == null)
                radar = new Radar();
            return this.radar;
        }

        public BMap BMap()
        {
            if(this.bmap==null)
                bmap =new BMap();
            return this.bmap;
        }

        public Geo Geo()
        {
            if (this.geo==null)
            {
                geo = new Geo();
            }
            return this.geo;
        }

        public Brush Brush()
        {
            if(this.brush == null)
                brush = new Brush();
            return this.brush;
        }

        public TimeLine TimeLine()
        {
            if (this.timeline == null)
                this.timeline = new TimeLine();
            return this.timeline;
        }

        public ChartOption BaseOption()
        {
            if(this.baseOption == null)
                this.baseOption = new ChartOption();
            return this.baseOption;
        }

        public ChartOption Animation(bool animation)
        {
            this.animation = animation;
            return this;
        }


        /// 
        /// <param name="animationThreshold"></param>
        public ChartOption AnimationThreshold(int animationThreshold)
        {
            this.animationThreshold = animationThreshold;
            return this;
        }

        /// 
        /// <param name="animationDuration"></param>
        public ChartOption AnimationDuration(int animationDuration)
        {
            this.animationDuration = animationDuration;
            return this;
        }

        /// 
        /// <param name="animationEasing"></param>
        public ChartOption AnimationEasing(string animationEasing)
        {
            this.animationEasing = animationEasing;
            return this;
        }

        /// 
        /// <param name="animationDelay"></param>
        public ChartOption AnimationDelay(int animationDelay)
        {
            this.animationDelay = animationDelay;
            return this;
        }

        /// 
        /// <param name="animationDurationUpdate"></param>
        public ChartOption AnimationDurationUpdate(int animationDurationUpdate)
        {
            this.animationDurationUpdate = animationDurationUpdate;
            return this;
        }

        /// 
        /// <param name="animationEasingUpdate"></param>
        public ChartOption AnimationEasingUpdate(string animationEasingUpdate)
        {
            this.animationEasingUpdate = animationEasingUpdate;
            return this;
        }

        /// 
        /// <param name="animationDelayUpdate"></param>
        public ChartOption AnimationDelayUpdate(int animationDelayUpdate)
        {
            this.animationDelayUpdate = animationDelayUpdate;
            return this;
        }

        public ChartOption AnimationDelayUpdate(object animationDelayUpdate)
        {
            this.animationDelayUpdate = animationDelayUpdate;
            return this;
        }


        
    }
}

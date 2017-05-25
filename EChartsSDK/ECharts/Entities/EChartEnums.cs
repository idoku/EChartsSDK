using System.Runtime.Serialization;

namespace ECharts.Entities
{
    public enum LoadingEffectType
    {
        [EnumMember(Value = "spin")] spin,
        [EnumMember(Value = "bar")] bar,
        [EnumMember(Value = "ring")] ring,
        [EnumMember(Value = "whirling")] whirling,
        [EnumMember(Value = "dynamicLine")] dynamicLine,
        [EnumMember(Value = "bubble")] bubble
    }

    public enum PolarType
    {
        [EnumMember(Value = "polygon")] polygon,
        [EnumMember(Value = "circle")] circle
    }

    public enum TimeType
    {
        [EnumMember(Value = "time")] time,
        [EnumMember(Value = "number")] number,
    }

    public enum NameLocationType
    {
        [EnumMember(Value = "start")] start,
        [EnumMember(Value = "middle")]
        middle,
        [EnumMember(Value = "end")] end,
    }

    public enum LineStepType
    {
        [EnumMember(Value = "start")]
        start,
        [EnumMember(Value = "middle")]
        middle,
        [EnumMember(Value = "end")]
        end,
    }

    public enum LabelPositionType
    {
        [EnumMember(Value = "start")]
        start,
        [EnumMember(Value = "middle")]
        middle,
        [EnumMember(Value = "end")]
        end,
    }

    public enum ImageType
    {
        [EnumMember(Value = "png")] png,
    }

    public enum StyleLabelTyle
    {
        [EnumMember(Value = "center")] center,
        [EnumMember(Value = "outer")] outer,
        [EnumMember(Value = "inner")] inner,
        [EnumMember(Value = "left")] left,
        [EnumMember(Value = "right")] right,
        [EnumMember(Value = "top")] top,
        [EnumMember(Value = "inside")] inside,
        [EnumMember(Value = "bottom")] bottom,
        [EnumMember(Value = "insideLeft")] insideLeft,
        [EnumMember(Value = "insideRight")] insideRight,
        [EnumMember(Value = "insideTop")] insideTop,
        [EnumMember(Value = "insideBottom")] insideBottom,
        [EnumMember(Value = "start")] start,
        [EnumMember(Value = "outside")]
        outside,
    }

    public enum EffectType
    {
        [EnumMember(Value = "scale")] scale,
        [EnumMember(Value = "bounce")] bounce
    }

    public enum DirectionType
    {
        [EnumMember(Value = "inverse")] inverse,
    }

    public enum SortType
    {
        [EnumMember(Value = "none")] none,
        [EnumMember(Value = "ascending")] ascending,
        [EnumMember(Value = "descending")] descending
    }

    public enum MapValCalType
    {
        [EnumMember(Value = "sum")] sum,
        [EnumMember(Value = "average")] average
    }

    public enum SelectedModeType
    {
        [EnumMember(Value = "single")] single,
        [EnumMember(Value = "multiple")] multiple
    }

    public enum NigRoseType
    {
        [EnumMember(Value = "radius")] radius,
        [EnumMember(Value = "area")] area
    }

    public enum LinkStyleType
    {
        [EnumMember(Value = "curve")] curve,
        [EnumMember(Value = "line")] line,
    }

    public enum AreaStyleType
    {
        [EnumMember(Value = "default")] Default,
    }

    public enum LineStyleType
    {
        [EnumMember(Value = "solid")] solid,
        [EnumMember(Value = "dotted")] dotted,
        [EnumMember(Value = "dashed")] dashed,
        [EnumMember(Value = "curve")] curve,
        [EnumMember(Value = "broken")] broken
    }

    public enum AxisPointType
    {
        [EnumMember(Value = "line")] line,
        [EnumMember(Value = "cross")] cross,
        [EnumMember(Value = "shadow")] shadow,
        [EnumMember(Value = "none")] none
    }

    /// <summary>
    /// 布局方向
    /// </summary>
    public enum OrientType
    {
        [EnumMember(Value = "horizontal")] horizontal,
        [EnumMember(Value = "vertical")] vertical,
        [EnumMember(Value = "radial")] radial
    }

    public enum FontStyleType
    {
        [EnumMember(Value = "normal")] normal,
        [EnumMember(Value = "italic")] italic,
        [EnumMember(Value = "oblique")] oblique
    }

    public enum PositionType
    {
        [EnumMember(Value = "bottom")] bottom,
        [EnumMember(Value = "top")] top,
        [EnumMember(Value = "left")] left,
        [EnumMember(Value = "right")] right,
        [EnumMember(Value = "none")] none,
    }

    /// <summary>
    /// 水平方式
    /// </summary>
    public enum HorizontalType
    {
        [EnumMember(Value = "left")] left,
        [EnumMember(Value = "right")] right,
        [EnumMember(Value = "center")] center,
    }

    /// <summary>
    /// 垂直方式
    /// </summary>
    public enum VerticalType
    {
        [EnumMember(Value = "top")] top,
        [EnumMember(Value = "bottom")] bottom,
        [EnumMember(Value = "middle")] middle
    }

    /// <summary>
    /// 新窗口打开类型
    /// </summary>
    public enum TargetType
    {
        [EnumMember(Value = "self")] self,
        [EnumMember(Value = "blank")] blank
    }

    public enum ChartType
    {
        [EnumMember(Value = "line")] line,
        [EnumMember(Value = "bar")] bar,
        [EnumMember(Value = "scatter")] scatter,
        [EnumMember(Value = "effectScatter")] effectScatter,
        [EnumMember(Value = "k")] k,
        [EnumMember(Value = "pie")] pie,
        [EnumMember(Value = "radar")] radar,
        [EnumMember(Value = "chord")] chord,
        [EnumMember(Value = "force")] force,
        [EnumMember(Value = "funnel")] funnel,
        [EnumMember(Value = "gauge")] gauge,
        [EnumMember(Value = "map")] map,
        [EnumMember(Value = "time")] time,
        [EnumMember(Value = "heatmap")] heatmap,
        [EnumMember(Value = "eventRiver")] eventRiver,
        [EnumMember(Value = "tree")] tree,
        [EnumMember(Value = "treemap")] treemap,
        [EnumMember(Value = "venn")] venn,
        [EnumMember(Value = "wordCloud")] wordCloud,
        [EnumMember(Value = "parallel")] parallel,
        [EnumMember(Value = "boxplot")] boxplot,
        [EnumMember(Value = "graph")] graph,
        [EnumMember(Value = "sankey")] sankey,
        [EnumMember(Value = "pictorialBar")] pictorialBar,
        [EnumMember(Value = "themeRiver")]
        themeRiver,
    }

    public enum AxisType
    {
        [EnumMember(Value = "category")] category,
        [EnumMember(Value = "value")] value,
        [EnumMember(Value = "time")] time,
        [EnumMember(Value = "log")] log,
    }

    public enum MarkType
    {
        max,
        min,
        average
    }

    public enum SamplingType
    {
        [EnumMember(Value = "max")] max,
        [EnumMember(Value = "min")] min,
        [EnumMember(Value = "average")] average,
        [EnumMember(Value = "sum")] sum
    }

    public enum TriggerType
    {
        [EnumMember(Value = "axis")] axis,
        [EnumMember(Value = "item")] item,
        [EnumMember(Value = "none")] none,

    }

    public enum TriggerOnType
    {
        [EnumMember(Value = "mousemove")]
        mousemove,
        [EnumMember(Value = "click")]
        click,
        [EnumMember(Value = "none")]
        none,
    }

    public enum SymbolType
    {
        [EnumMember(Value = "none")] none,
        [EnumMember(Value = "auto")] auto,
        [EnumMember(Value = "circle")] circle,
        [EnumMember(Value = "rectangle")] rectangle,
        [EnumMember(Value = "triangle")] triangle,
        [EnumMember(Value = "diamond")] diamond,
        [EnumMember(Value = "emptyCircle")] emptyCircle,
        [EnumMember(Value = "emptyRectangle")] emptyRectangle,
        [EnumMember(Value = "emptyTriangle")] emptyTriangle,
        [EnumMember(Value = "emptyDiamond")] emptyDiamond,
        [EnumMember(Value = "heart")] heart,
        [EnumMember(Value = "droplet")] droplet,
        [EnumMember(Value = "pin")] pin,
        [EnumMember(Value = "arrow")] arrow,
        [EnumMember(Value = "star")] star,
        [EnumMember(Value = "emptyheart")] emptyheart,
        [EnumMember(Value = "emptydroplet")] emptydroplet,
        [EnumMember(Value = "emptypin")] emptypin,
        [EnumMember(Value = "emptyarrow")] emptyarrow,
        [EnumMember(Value = "emptystar")] emptystar,
    }

    public enum DataZoomType
    {

        /// <summary>
        /// 内置型
        /// </summary>
        [EnumMember(Value = "inside")] inside,

        /// <summary>
        /// 滑动条型
        /// </summary>
        [EnumMember(Value = "slider")] slider

    } //end DataZoomType

    public enum ShowEffectType
    {
        /// <summary>
        /// 绘制完成时
        /// </summary>
        [EnumMember(Value = "render")] render,

        /// <summary>
        /// 高亮时
        /// </summary>
        [EnumMember(Value = "emphasis")] emphasis
    }

    public enum BrushType
    {
        [EnumMember(Value = "fill")] fill,
        [EnumMember(Value = "stroke")] stroke,
        [EnumMember(Value = "rect")] rect,
        [EnumMember(Value = "polygon")] polygon,
        [EnumMember(Value = "lineX")] lineX,
        [EnumMember(Value = "lineY")] lineY,
        [EnumMember(Value = "clear")] clear
    }


    public enum BrushMode
    {
        [EnumMember(Value = "single")]
        single,
        [EnumMember(Value = "multiple")]
        multiple
    }

    public enum BrushThrottleType
    {
        [EnumMember(Value = "debounce")]
        debounce,
        [EnumMember(Value = "fixRate")]
        fixRate
        
    }

public enum CoordinateSystemType
    {
        [EnumMember(Value = "cartesian2d")] cartesian2d,
        [EnumMember(Value = "geo")] geo,
        [EnumMember(Value = "bmap")] bmap,
        [EnumMember(Value = "polar")] polar,
        [EnumMember(Value = "parallel")] parallel
    }

    public enum BrushToolBoxType
    {
        [EnumMember(Value = "rect")]
        rect,
        [EnumMember(Value = "polygon")]
        polygon,
         [EnumMember(Value = "lineX")]
         lineX,
         [EnumMember(Value = "lineY")]
         lineY,
         [EnumMember(Value = "keep")]
         keep,
         [EnumMember(Value = "clear")]
         clear
    }

    public enum VisualMapType
    {
        [EnumMember(Value = "continuous")]
        continuous,
        [EnumMember(Value = "piecewise")]
        piecewise
    }
}
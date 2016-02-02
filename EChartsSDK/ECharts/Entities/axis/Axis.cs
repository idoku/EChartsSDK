using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.axis
{

    public abstract class Axis : AbstractData<Axis>
    {
        public TextStyle nameTextStyle { get; set; }

        public AxisLine axisLine { get; set; }

        public AxisTick axisTick { get; set; }

        public AxisLabel axisLabel { get; set; }

        public SplitLine splitLine { get; set; }

        public SplitArea splitArea { get; set; }


        public TextStyle NameTextStyle()
        {
            nameTextStyle = new TextStyle();
            return nameTextStyle;
        }

        public AxisLabel AxisLabel()
        {
            axisLabel = new AxisLabel();
            return axisLabel;
        }

        public AxisLine AxisLine()
        {
            axisLine = new AxisLine();
            return axisLine;
        }

        public AxisTick AxisTick()
        {
            axisTick = new AxisTick();
            return axisTick;
        }

        public SplitLine SplitLine()
        {
            splitLine = new SplitLine();
            return splitLine;
        }

        public SplitArea SplitArea()
        {
            splitArea = new SplitArea();
            return splitArea;
        }

    }
}

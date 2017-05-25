using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities
{
    public class TimeLine  :Basic<TimeLine>,IData<TimeLine>
    {        
        public TimeType? type { get; set; }

        public AxisType? axisType { get; set; }

        public bool? notMerge { get; set; }

        public bool? realtime { get; set; }       

        public object x2 { get; set; }

        public object y2 { get; set; }

         

        public bool? inverse { get; set; }

        public OrientType? orient { get; set; }




        public PositionType? controlPosition { get; set; }

        public bool? autoPlay { get; set; }

        public bool? loop { get; set; }

        public int? playInterval { get; set; }

        public LineStyle  lineStyle { get; set; }

        public EntityStyle<StyleLabel> label { get; set; }

        public CheckPointStyle checkpointStyle { get; set; }

        public ControlStyle controlStyle { get; set; }

        public string symbol { get; set; }

        public int? symbolSize { get; set; }

        public int? currentIndex { get; set; }

        public IList<object> data { get; set; }

        public TimeLine Symbol(string symbol)
        {
            this.symbol = symbol;
            return this;
        }


        public TimeLine Type(TimeType type)
        {
            this.type = type;
            return this;
        }

        public TimeLine AxisType(AxisType axisType)
        {
            this.axisType = axisType;
            return this;
        }


        public TimeLine AutoPlay(bool autoPlay)
        {
            this.autoPlay = autoPlay;
            return this;
        }

        public TimeLine PlayInterval(int playInterval)
        {
            this.playInterval = playInterval;
            return this;
        }

        public TimeLine Inverse(bool inverse)
        {
            this.inverse = inverse;
            return this;
        }

        public TimeLine Orient(OrientType orient)
        {
            this.orient = orient;
            return this;
        }

        public EntityStyle<StyleLabel> Label()
        {
            if (label == null)
                label = new EntityStyle<StyleLabel>();
            return label;
        }

        public TimeLine Data(params object[] values)
        {
            if (data == null)
            {
                data = new List<object>();
            }
            values.ToList().ForEach(v => data.Add(v));
            return this;
        }
    }
}

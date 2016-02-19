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

        public bool? notMerge { get; set; }

        public bool? realtime { get; set; }       

        public object x2 { get; set; }

        public object y2 { get; set; }

        public int? width { get; set; }

        public int? height { get; set; }
     
       

        public PositionType? controlPosition { get; set; }

        public bool? autoPlay { get; set; }

        public bool? loop { get; set; }

        public int? playInterval { get; set; }

        public LineStyle  lineStyle { get; set; }

        public StyleLabel label { get; set; }

        public CheckPointStyle checkpointStyle { get; set; }

        public string symbol { get; set; }

        public int? symbolSize { get; set; }

        public int? currentIndex { get; set; }

        public IList<object> data { get; set; }

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

        public StyleLabel Label()
        {
            if (label == null)
                label = new StyleLabel();
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

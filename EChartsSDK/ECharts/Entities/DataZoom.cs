using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECharts.Entities.style;

namespace ECharts.Entities
{
    public class DataZoom:Basic<DataZoom>
    {
        public DataZoomType? type { get; set; }

        public OrientType? orient { get; set; }

        public int? width { get; set; }

        public int? height { get; set; }

        public string fillerColor { get; set; }

        public string handleIcon { get; set; }

        public string handleColor { get; set; }

        public object handleSize { get; set; }

        public object xAxisIndex { get; set; }

        public Entities.style.Normal hanleStyle { get; set; }


        public Entities.style.Normal dataBackground { get; set; }

        public object yAxisIndex { get; set; }

        public bool? realtime { get; set; }

        public int? start { get; set; }

        public string startValue { get; set; }

        public int? end { get; set; }

        public bool? zoomLock { get; set; }

        public string filterMode { get; set; }

        public DataZoom FilterMode(string filterMode)
        {
            this.filterMode = filterMode;
            return this;
        }

        public DataZoom Type(DataZoomType type)
        {
            this.type = type;
            return this;
        }


        public DataZoom XAxisIndex(int xAxisIndex)
        {
            this.xAxisIndex = xAxisIndex;
            return this;
        }

        public DataZoom StartValue(string startValue)
        {
            this.startValue = startValue;
            return this;
        }

        public DataZoom YAxisIndex(string yAxisIndex)
        {
            this.yAxisIndex = yAxisIndex;
            return this;
        }


        public DataZoom Realtime(bool realtime)
        {
            this.realtime = realtime;
            return this;
        }
        public DataZoom Start(int start)
        {
            this.start = start;
            return this;
        }
        public DataZoom End(int end)
        {
            this.end = end;
            return this;
        }


        public DataZoom HandleIcon(string handleIcon)
        {
            this.handleIcon = handleIcon;
            return this;
        }

        public DataZoom HandleSize(string handleSize)
        {
            this.handleSize = handleSize;
            return this;
        }

        public Normal HandleStyle()
        {
            if (this.hanleStyle == null)
                this.hanleStyle = new Normal();
            return this.hanleStyle;
        }
        public Normal DataBackground()
        {
            if (this.dataBackground == null)
                this.dataBackground = new Normal();
            return this.dataBackground;
        }

                

    }
}

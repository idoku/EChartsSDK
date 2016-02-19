using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class Rectangular<T>: ChartSeries<Rectangular<T>> where T:class
    {
        public string stack { get; set; }

        public int? xAxisIndex { get; set; }

        public int? yAxisIndex { get; set; }

        public object symbol { get; set; }

        public object symbolSize { get; set; }

        public double? symbolRotate { get; set; }        

        public bool? legendHoverLink { get; set; }

        public T Stack(string stack)
        {
            this.stack = stack;
            return this as T;
        }

        public T XAxisIndex(int xAxisIndex)
        {
            this.xAxisIndex = xAxisIndex;
            return this as T;
        }

        public T YAxisIndex(int yAxisIndex)
        {
            this.yAxisIndex = yAxisIndex;
            return this as T;
        }

        public T SymbolRotate(double symbolRotate)
        {
            this.symbolRotate = symbolRotate;
            return this as T;
        }

        public T Symbol(SymbolType symbol)
        {
            this.symbol = symbol;
            return this as T;
        }

        public T Symbol(string icon)
        {
            this.symbol = icon;
            return this as T;
        }
 

        public T SymbolSize(object symbolSize)
        {
            this.symbolSize = symbolSize;
            return this as T;
        }


    }
}

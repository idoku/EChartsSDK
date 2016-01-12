using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities
{
    public class Basic<T> where T :class
    {
        public bool? show { get; set; }

        public object x { get; set; }

        public object y { get; set; }

        public object padding { get; set; }

        public string backgroundColor { get; set; }

        public string borderColor { get; set; }

        public int? zlevel { get; set; }

        public int? z { get; set; }

        public T Show(bool show)
        {
            this.show = show;
            return this as T;
        }

        public T X(int x)
        {
            this.x = x;
            return this as T;
        }

        public T X(HorizontalType x)
        {
            this.x = x;
            return this as T;
        }

        public T Y(int y)
        {
            this.y = y;
            return this as T;
        }

        public T Y(VerticalType y)
        {
            this.y = y;
            return this as T;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series.data
{
    public class PieData<T> where T :class
    {
        public T value { get; set; }
        public string name { get; set; }

        public PieData(T value, string name)
        {
            this.value = value;
            this.name = name;
        }

        public T Value(T value)
        {
            this.value = value;
            return this as T;
        }

        public T Name(string name)
        {
            this.name = name;
            return this as T;
        }


    }
}

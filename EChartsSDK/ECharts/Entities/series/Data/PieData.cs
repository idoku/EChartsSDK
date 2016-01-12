using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series.data
{
    public class PieData<T>
    {
        public T value { get; set; }
        public string name { get; set; }

        public PieData(T value, string name)
        {
            this.value = value;
            this.name = name;
        }
    }
}

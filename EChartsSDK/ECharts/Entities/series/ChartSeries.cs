using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class ChartSeries<T> :Series,  IData<T> where T : class
    {
        public object data { get; set; }

        public T SetData(object data)
        {
            this.data = data;
            return this as T;
        }

        public T Data(params object[] values)
        {
            if (values == null)
                return default(T);
            this.data = values.ToList();
            return this as T;
        }
    }
}

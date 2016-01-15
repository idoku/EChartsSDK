using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities
{
    public abstract class AbstractData<T> : IData<T> where T:class
    {
        public IList<object> data;

        private bool clickable;

        private bool hoverable;

        public T Data()
        {
            if (data == null) {
                data = new List<object>();
            }
            return this as T;
        }
 

        public T SetData(IList<object> data) {
            this.data = data;
            return this as T;
        }

        public T Data(params object[] values)
        {
            if (values == null)
            {
                return default(T);
            }
            if (data == null) {
                data = new List<object>();
            }
            values.ToList().ForEach(v => data.Add(v));
            return this as T;
        }
    }
}

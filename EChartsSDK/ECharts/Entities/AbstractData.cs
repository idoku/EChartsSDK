using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities
{
    public abstract class AbstractData<T> : IData<T> where T:class
    {
        public object data;

        private bool clickable;

        private bool hoverable;

        public T Clickable(bool clickable)
        {
            this.clickable = clickable;
            return this as T;
        }

        public T Hoverable(bool hoverable)
        {
            this.hoverable = hoverable;
            return this as T;
        }


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
            data = values;
            return this as T;
        }
    }
}

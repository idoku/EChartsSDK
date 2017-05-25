using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.style
{
    public class EntityStyle<T> where T : class, new()
    {
        public T normal { get; set; }

        public T emphasis { get; set; }

        public T Normal()
        {
            if (normal == null)
            {
                this.normal = new T();
            }
            return this.normal;
        }

        public T Emphasis()
        {
            if (emphasis == null)
            {
                this.emphasis = new T();
            }
            return this.emphasis;
        }
    }
}

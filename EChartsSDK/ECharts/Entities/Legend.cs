using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities
{
    public class Legend : Basic<Legend>, Data<Legend>
    {
      
        public OrientType? orient { get; set; }
            

        public int? borderWidth { get; set; }

       
        public int? itemGap { get; set; }

        public int? itemWidth { get; set; }

        public TextStyle textStyle { get; set; }

        public object formatter { get; set; }


        public object selectedMode { get; set; }        

        public IList<object> data { get; set; }        

        public Legend SetData(IList<object> data)
        {
            this.data = data;
            return this;
        }

        public Legend Orient(OrientType orient)
        {
            this.orient = orient;
            return this;
        }
        

        public Legend Data(params object[] values)
        {
            if (data == null) {
                data = new List<object>();
            }
            values.ToList().ForEach(v => data.Add(v));
            return this;
        }


        
    }
}

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class EventEvolution
    {
        
        public DateTime? time { get; set; }

        public int? value { get; set; }

        public EventDetail detail { get; set; }

        public EventEvolution Time(DateTime time)
        {
            this.time = time;
            return this;
        }

        public EventEvolution Value(int value)
        {
            this.value = value;
            return this;
        }

        public EventDetail Detail()
        {
            if(this.detail==null)
              this.detail = new EventDetail();
            return this.detail;
        }
    }
}

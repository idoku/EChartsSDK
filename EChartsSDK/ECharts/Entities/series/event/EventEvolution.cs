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


    }
}

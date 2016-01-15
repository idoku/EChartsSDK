using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class Event
    {
        public string name { get; set; }

        public int? weight { get; set; }

        public IList<EventEvolution> evolution { get; set; }

        
    }
}

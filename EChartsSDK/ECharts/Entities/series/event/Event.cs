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

        public Event Name(string name)
        {
            this.name = name;
            return this;
        }

        public Event Weight(int weight)
        {
            this.weight = weight;
            return this;
        }
    }
}

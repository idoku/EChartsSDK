using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class EventData
    {
        public string name { get; set; }

        public int? weight { get; set; }

        public IList<EventEvolution> evolution { get; set; }

        public EventData() { }

        public EventData(string name) {
            this.name = name;
        }

        public EventData Name(string name)
        {
            this.name = name;
            return this;
        }

        public EventData Weight(int weight)
        {
            this.weight = weight;
            return this;
        }

        public EventData Evolution(params EventEvolution[] values)
        {
            if (values == null)
                return this;
            this.evolution = values.ToList();
            return this;
        }
    }
}

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

        public IList<Evolution> evolution { get; set; }

        public class Evolution
        {
            public DateTime? time { get; set; }

            public int? value { get; set; }

            public Detail detail { get; set; }

            public class Detail
            {
                public string link { get; set; }

                public string text { get; set; }

                public string img { get; set; }
            }
        }
    }
}

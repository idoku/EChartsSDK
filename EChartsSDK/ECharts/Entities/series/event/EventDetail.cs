using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class EventDetail
    {
        public string link { get; set; }

        public string text { get; set; }

        public string img { get; set; }

        public EventDetail Link(string link)
        {
            this.link = link;
            return this;
        }


        public EventDetail Text(string text)
        {
            this.text = text;
            return this;
        }


        public EventDetail Img(string img)
        {
            this.img = img;
            return this;
        }

    }
}

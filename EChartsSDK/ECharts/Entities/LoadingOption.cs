using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities
{
    public class LoadingOption
    {
        public string text { get; set; }

        public object x { get; set; }

        public object y { get; set; }

        public TextStyle  textStyle { get; set; }

        public object effect { get; set; }

        public object effectOption { get; set; }

        public double? progress { get; set; }
    }

   
}

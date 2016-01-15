using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities
{
    public class RoamController : Basic<RoamController>
    {
        public int? width { get; set; }

        public int? height { get; set; }

        public string fillerColor { get; set; }

        public string handleColor { get; set; }

        public int? step { get; set; }

        public Dictionary<string,bool> mapTypeControl { get; set; }

    }
}

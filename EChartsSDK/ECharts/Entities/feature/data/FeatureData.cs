using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.feature.data
{
    public class FeatureData<T>
    {
        public bool? show { get; set; }

        public object backgroundColor { get; set; }

        public object title { get; set; }

        public object icon { get; set; }

        public object iconStyle { get; set; }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.feature
{
    public class MagicType
    {
        public bool? show { get; set; }


        public MagicTitle title { get; set; }


        public MagicOption option { get; set; }

        public IList<object> type { get; set; }



    }

}

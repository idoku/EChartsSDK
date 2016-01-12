using ECharts.Entities.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class MarkData:BasicData<MarkData>
    {
        public MarkData() : base()
        {

        }

        public MarkData(string name) : this()
        {
            this.name = name;
        }

    }
}

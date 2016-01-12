using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.feature
{
    public class DataView
    {
        public bool? show { get; set; }

        public string title { get; set; }

        public bool? readOnly { get; set; }

        public IList<string> lang { get; set; }

        public DataView Show(bool show)
        {
            this.show = show;
            return this;
        }

        public DataView Title(string title)
        {
            this.title = title;
            return this;        
        }

        public DataView ReadOnly(bool? readOnly)
        {
            this.readOnly = readOnly;
            return this;
        }


    }
}

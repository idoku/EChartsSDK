using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.feature
{
    public class MarkTitle
    {
        public string mark { get; set; }

        public string markUndo { get; set; }

        public string markClear { get; set; }


        public MarkTitle Mark(string mark)
        {
            this.mark = mark;
            return this;
        }

        public MarkTitle MarkUndo(string markUndo)
        {
            this.markUndo = markUndo;
            return this;
        }

        public MarkTitle MarkClear(string markClear)
        {
            this.markClear = markClear;
            return this;
        }
    }

}

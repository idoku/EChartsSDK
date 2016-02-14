using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class MarkPoint:AbstractData<MarkPoint>
    {
        public bool? clickable { get; set; }

        public string symbol { get; set; }

        public object symbolSize { get; set; }

        public object symbolRotate { get; set; }

        public bool? large { get; set; }

        public Effect effect { get; set; }

        public ItemStyle itemStyle { get; set; }
                        
        public MarkPoint SymbolRotate(object symbolRotate)
        {
            this.symbolRotate = symbolRotate;
            return this;
        }

        public MarkPoint Symbol(string symbol)
        {
            this.symbol = symbol;
            return this;
        }

        public MarkPoint Clickable(bool clickable)
        {
            this.clickable = clickable;
            return this;
        }
   
        public ItemStyle ItemStyle()
        {
            if (itemStyle == null)
                itemStyle = new ItemStyle();
            return itemStyle;
        }

        public Effect Effect()
        {
            if (effect == null)
                effect = new series.Effect();
            return effect;
        }

    }
 

}

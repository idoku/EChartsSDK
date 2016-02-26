using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities
{
    public class Legend : Basic<Legend>, IData<Legend>
    {      
        public OrientType? orient { get; set; }
            
     
       
        public object itemGap { get; set; }

        public int? itemWidth { get; set; }

        public int? itemHeight { get; set; }

        public TextStyle textStyle { get; set; }

        public object formatter { get; set; }

        public object selectedMode { get; set; }

        public Dictionary<string, bool> selected { get; set; }

        public object data { get; set; }

        public Legend SetSelected(Dictionary<string, bool> selected)
        {
            this.selected = selected;
            return this;
        }

        public TextStyle TextStyle()
        {
            if (textStyle == null)
                textStyle = new style.TextStyle();
            return this.textStyle;
        }

        public Legend SelectedMode(object selectedMode)
        {
            this.selectedMode = selectedMode;
            return this;
        }

        public Legend Formatter(object formatter)
        {
            this.formatter = formatter;
            return this;
        }


        public Legend ItemHeight(int itemHeight)
        {
            this.itemHeight = itemHeight;
            return this;
        }

        public Legend ItemWidth(int itemWidth)
        {
            this.itemWidth = itemWidth;
            return this;
        }

        public Legend BorderWidth(int borderWidth)
        {
            this.borderWidth = borderWidth;
            return this;
        }

        public Legend ItemGap(int itemGap)
        {
            this.itemGap = itemGap;
            return this;
        }

        public Legend ItemGap(object itemGap)
        {
            this.itemGap = itemGap;
            return this;
        }

        public Legend SetData(IList<object> data)
        {
            this.data = data;
            return this;
        }

        public Legend Orient(OrientType orient)
        {
            this.orient = orient;
            return this;
        }
        

        public Legend Data(params object[] values)
        {
            if (data == null) {
                data = new List<object>();
            }
            data = values.ToList();
            return this;
        }

        public Legend Data(params IconStyle[] values)
        {
            if (data == null)
            {
                data = new List<object>();
            }
            data = values.ToList();
            return this;
        }

        public Legend Data(object data)
        {
            if (this.data == null)
            {
                this.data = new List<object>();
            }
            this.data = data;
            return this;
        }
    }
}

using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities
{
    public class Title:Basic<Title>
    {
        #region properties       
        public string text { get; set; }

        public string link { get; set; }

        public TargetType? target { get; set; }        

        public string subtext { get; set; }

        public string sublink { get; set; }

        public TargetType? subtarget { get; set; }
       
        public HorizontalType? textAlign { get; set; }
     
        public int? borderWidth { get; set; }

        public int? itemGap { get; set; }

        public TextStyle textStyle { get; set; } 

        public TextStyle subtextStyle { get; set; }
        #endregion

        #region method

        public Title Text(string text) {
            this.text = text;
            return this;
        }

        public Title SubText(string subtext)
        {
            this.subtext = subtext;
            return this;
        }

      
        #endregion
    }
}

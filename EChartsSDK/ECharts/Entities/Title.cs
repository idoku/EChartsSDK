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
     
        

        public int? itemGap { get; set; }

        public TextStyle textStyle { get; set; } 

        public TextStyle subtextStyle { get; set; }
        #endregion

        #region method
        public TextStyle TextStyle()
        {
            if (this.textStyle == null)
                textStyle = new style.TextStyle();
            return textStyle;
        }

        public TextStyle SubtextStyle()
        {
            if (this.subtextStyle == null)
                subtextStyle = new style.TextStyle();
            return subtextStyle;
        }

        public Title ItemGap(int itemGap)
        {
            this.itemGap = itemGap;
            return this;
        }

        public Title BorderWidth(int borderWidth)
        {
            this.borderWidth = borderWidth;
            return this;
        }

        public Title TextAlign(HorizontalType textAlign)
        {
            this.textAlign = textAlign;
            return this;
        }

        public Title Subtarget(TargetType subtarget)
        {
            this.subtarget = subtarget;
            return this;
        }

        public Title Sublink(string sublink)
        {
            this.sublink = sublink;
            return this;
        }

        public Title Subtext(string subtext)
        {
            this.subtext = subtext;
            return this;
        }

        public Title Target(TargetType target)
        {
            this.target = target;
            return this;
        }

        public Title Link(string link)
        {
            this.link = link;
            return this;
        }

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

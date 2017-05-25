using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using ECharts.Entities.series.mark;

namespace ECharts.Entities.series
{
    public abstract class Series 
    {
        public string coordinateSystem { get; set; }

        public string id { get; set; }

        public int? zlevel { get; set; }

        public int? z { get; set; }

        public ChartType type { get; set; }

        public string name { get; set; }        

        public ToolTip tooltip { get; set; }

        public ItemStyle itemStyle { get; set; }

        public EntityStyle<AreaStyle> areaStyle { get; set; }

        public MarkPoint markPoint { get; set; }

        public MarkLine markLine { get; set; }

        public MarkArea markArea { get; set; }

        public ItemStyle label { get; set; }

        public ItemStyle lineStyle { get; set; }

        public bool? silent { get; set; }

        public bool? animation { get; set; }


        public int? animationThreshold { get; set; }

        public int? animationDuration { get; set; }

        public string animationEasing { get; set; }

        public object animationDelay { get; set; }

        public int? animationDurationUpdate { get; set; }

        public string animationEasingUpdate { get; set; }

        public int? animationDelayUpdate { get; set; }

        public string blendMode { get; set; }


        public bool? hoverAnimation { get; set; }

        public Series HoverAnimation(bool hoverAnimation)
        {
            this.hoverAnimation = hoverAnimation;
            return this;
        }


        public Series Id(string id)
        {
            this.id = id;
            return this;
        }

        public EntityStyle<AreaStyle> AreaStyle()
        {
            if(this.areaStyle == null)
                this.areaStyle = new EntityStyle<AreaStyle>();
            return this.areaStyle;
        }

        public Series CoordinateSystem(string coordinateSystem)
        {
            this.coordinateSystem = coordinateSystem;
            return this;
        }

        public Series Name(string name)
        {
            this.type = type;
            return this;
        }


        public Series Type(ChartType type)
        {
            this.type = type;
            return this;
        }

        public Series Z(int z)
        {
            this.z = z;
            return this;
        }

        public Series Zlevel(int zlevel)
        {
            this.zlevel = zlevel;
            return this;
        }


        public Series SetItemStyle(ItemStyle itemStyle)
        {
            this.itemStyle = itemStyle;
            return this;
        }

        public ECharts.Entities.style.ItemStyle ItemStyle()
        {
            if (this.itemStyle == null)
                this.itemStyle = new style.ItemStyle();
            return itemStyle;
        }

        public ItemStyle LineStyle()
        {
            if (this.lineStyle == null)
                this.lineStyle = new style.ItemStyle();
            return lineStyle;
        }

        public Series MarkLine(MarkLine markLine)
        {
            this.markLine = markLine;
            return this;
        }


        public MarkLine MarkLine()
        {
            if (this.markLine == null)
                this.markLine = new series.MarkLine();
            return this.markLine;
        }

        public MarkArea MarkArea()
        {
            if (this.markArea == null)
                this.markArea = new MarkArea();
            return this.markArea;
        }



        public ECharts.Entities.ToolTip ToolTip()
        {
            if (this.tooltip == null)
                this.tooltip = new ToolTip();
            return this.tooltip;
        }

        public MarkPoint MarkPoint()
        {
            if (this.markPoint == null)
                this.markPoint = new series.MarkPoint();
            return this.markPoint;
        }

        public ItemStyle Label()
        {
            if (this.label == null)
                this.label = new ItemStyle();
            return this.label;
        }

		/// 
		/// <param name="slient"></param>
        public Series Silent(bool silent)
        {
            this.silent = silent;
		return this; 
		}

		/// 
		/// <param name="animation"></param>
		public Series Animation(bool animation){
		     this.animation=animation;
		return this; 
		}

		/// 
		/// <param name="animationThreshold"></param>
		public Series AnimationThreshold(int animationThreshold){
		     this.animationThreshold=animationThreshold;
		return this; 
		}

		/// 
		/// <param name="animationDuration"></param>
		public Series AnimationDuration(int animationDuration){
		     this.animationDuration=animationDuration;
		return this; 
		}

		/// 
		/// <param name="animationEasing"></param>
		public Series AnimationEasing(string animationEasing){
		     this.animationEasing=animationEasing;
		return this; 
		}

		/// 
		/// <param name="animationDelay"></param>
		public Series AnimationDelay(int animationDelay){
		     this.animationDelay=animationDelay;
		return this; 
		}

        public Series AnimationDelay(object animationDelay)
        {
            this.animationDelay = animationDelay;
            return this;
        }

		/// 
		/// <param name="animationDurationUpdate"></param>
		public Series AnimationDurationUpdate(int animationDurationUpdate){
		     this.animationDurationUpdate=animationDurationUpdate;
		return this; 
		}

		/// 
		/// <param name="animationEasingUpdate"></param>
		public Series AnimationEasingUpdate(string animationEasingUpdate){
		     this.animationEasingUpdate=animationEasingUpdate;
		return this; 
		}

		/// 
		/// <param name="animationDelayUpdate"></param>
		public Series AnimationDelayUpdate(int animationDelayUpdate){
		     this.animationDelayUpdate=animationDelayUpdate;
		return this; 
		}

        public Series BlendMode(string blendMode)
        {
            this.blendMode = blendMode;
            return this;
        }
    }


   


}

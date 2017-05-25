using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.axis
{

    public abstract class Axis : AbstractData<Axis>
    {
        public TextStyle nameTextStyle { get; set; }

        public AxisLine axisLine { get; set; }

        public AxisTick axisTick { get; set; }

        public AxisLabel axisLabel { get; set; }

        public SplitLine splitLine { get; set; }

        public SplitArea splitArea { get; set; }

        public AxisPointer axisPointer { get; set; }


        public ECharts.Entities.style.TextStyle NameTextStyle()
        {
            nameTextStyle = new TextStyle();
            return nameTextStyle;
        }

        public AxisPointer AxisPointer()
        {
            axisPointer = new AxisPointer();
            return axisPointer;
        }

        public AxisLabel AxisLabel()
        {
            axisLabel = new AxisLabel();
            return axisLabel;
        }

        public AxisLine AxisLine()
        {
            axisLine = new AxisLine();
            return axisLine;
        }

        public AxisTick AxisTick()
        {
            axisTick = new AxisTick();
            return axisTick;
        }

        public SplitLine SplitLine()
        {
            splitLine = new SplitLine();
            return splitLine;
        }

        public SplitArea SplitArea()
        {
            splitArea = new SplitArea();
            return splitArea;
        }

		public string name{
			get;
			set;
		}

		public object position{
			get;
			set;
		}

		public int zlevel{
			get;
			set;
		}

		public int? gridIndex{
			get;
			set;
		}

		public int? nameGap{
			get;
			set;
		}

		public bool? inverse{
			get;
			set;
		}

	 
	 

		public bool scale{
			get;
			set;
		}

		/// 
		/// <param name="name"></param>
		public Axis Name(string name){
		     this.name=name;
		return this; 
		}

		/// 
		/// <param name="zlevel"></param>
		public Axis zLevel(int zlevel){
		     this.zlevel=zlevel;
		return this; 
		}

		/// 
		/// <param name="gridIndex"></param>
		public Axis GridIndex(int gridIndex){
		     this.gridIndex=gridIndex;
		return this; 
		}

		/// 
		/// <param name="nameGap"></param>
		public Axis NameGap(int nameGap){
		     this.nameGap=nameGap;
		return this; 
		}

		/// 
		/// <param name="inverse"></param>
		public Axis Inverse(bool inverse){
		     this.inverse=inverse;
		return this; 
		}

	 

	 

		

		/// 
		/// <param name="scale"></param>
		public Axis Scale(bool scale){
		     this.scale=scale;
		return this; 
		}

		 

    }
}

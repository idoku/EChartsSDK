using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities
{
    public abstract class Basic<T>
        where T : class
    {
        public string name { get; set; }

        public bool? show { get; set; }

        public object x { get; set; }

        public object y { get; set; }

        public object padding { get; set; }

        public object borderWidth { get; set; }

        public string backgroundColor { get; set; }

        public string borderColor { get; set; }

        public object left { get; set; }

        public object right { get; set; }

        public object top { get; set; }

        public object bottom { get; set; }

        public OrientType orient { get; set; }

        public object shadowColor { get; set; }

        public int? shadowOffsetX { get; set; }

        public int? shadowOffsetY { get; set; }

        public object width { get; set; }

        public object height { get; set; }

        public int? zlevel { get; set; }

        public int? z { get; set; }

        public int? itemGap { get; set; }

        public int? shadowBlur { get; set; }

        public int? min { get; set; }

        public object max { get; set; }

        public bool? animation { get; set; }

        public int? animationThreshold { get; set; }

        public int? animationDuration { get; set; }

        public string animationEasing { get; set; }

        public int? animationDelay { get; set; }

        public int? animationDurationUpdate { get; set; }

        public string animationEasingUpdate { get; set; }

        public int? animationDelayUpdate { get; set; }

        public double? zoom { get; set; }

        public bool? inverse { get; set; }

        public int? splitNumber { get; set; }

        public T SplitNumber(int splitNumber)
        {
            this.splitNumber = splitNumber;
            return this as T;
        }

        public T Inverse(bool inverse)
        {
            this.inverse = inverse;
            return this as T;
        }

        public T Zoom(double zoom)
        {
            this.zoom = zoom;
            return this as T;
        }

        public T Name(string name)
        {
            this.name = name;
            return this as T;
        }

        public T Padding(string padding)
        {
            this.padding = padding;
            return this as T;
        }

        public T BorderColor(string borderColor)
        {
            this.borderColor = borderColor;
            return this as T;
        }

        public T BorderWidth(object borderWidth)
        {
            this.borderWidth = borderWidth;
            return this as T;
        }

        public T BackgroundColor(string backgroundColor)
        {
            this.backgroundColor = backgroundColor;
            return this as T;
        }

        public T Show(bool show)
        {
            this.show = show;
            return this as T;
        }

        public T X(int x)
        {
            this.x = x;
            return this as T;
        }

        public T X(string x)
        {
            this.x = x;
            return this as T;
        }

        public T X(HorizontalType x)
        {
            this.x = x;
            return this as T;
        }

        public T Y(int y)
        {
            this.y = y;
            return this as T;
        }

        public T Y(string y)
        {
            this.y = y;
            return this as T;
        }

        public T Y(HorizontalType y)
        {
            this.y = y;
            return this as T;
        }

        public T Y(VerticalType y)
        {
            this.y = y;
            return this as T;
        }

        public T Z(int z)
        {
            this.z = z;
            return this as T;
        }

        /// 
        /// <param name="animation"></param>
        public T Animation(bool animation)
        {
            this.animation = animation;
            return this as T;
        }

        /// 
        /// <param name="animationThreshold"></param>
        public T AnimationThreshold(int animationThreshold)
        {
            this.animationThreshold = animationThreshold;
            return this as T;
        }

        /// 
        /// <param name="animationDuration"></param>
        public T AnimationDuration(int animationDuration)
        {
            this.animationDuration = animationDuration;
            return this as T;
        }

        /// 
        /// <param name="animationEasing"></param>
        public T AnimationEasing(string animationEasing)
        {
            this.animationEasing = animationEasing;
            return this as T;
        }

        /// 
        /// <param name="animationDelay"></param>
        public T AnimationDelay(int animationDelay)
        {
            this.animationDelay = animationDelay;
            return this as T;
        }

        /// 
        /// <param name="animationDurationUpdate"></param>
        public T AnimationDurationUpdate(int animationDurationUpdate)
        {
            this.animationDurationUpdate = animationDurationUpdate;
            return this as T;
        }

        /// 
        /// <param name="animationEasingUpdate"></param>
        public T AnimationEasingUpdate(string animationEasingUpdate)
        {
            this.animationEasingUpdate = animationEasingUpdate;
            return this as T;
        }

        /// 
        /// <param name="animationDelayUpdate"></param>
        public T AnimationDelayUpdate(int animationDelayUpdate)
        {
            this.animationDelayUpdate = animationDelayUpdate;
            return this as T;
        }


        /// 
        /// <param name="width"></param>
        public T Width(int width)
        {
            this.width = width;
            return this as T;
        }

        public T Width(string width)
        {
            this.width = width;
            return this as T;
        }

        /// 
        /// <param name="height"></param>
        public T Height(string height)
        {
            this.height = height;
            return this as T;
        }


        /// 
        /// <param name="padding"></param>
        public T Padding(object padding)
        {
            this.padding = padding;
            return this as T;
        }

        /// 
        /// <param name="itemGap"></param>
        public T ItemGap(int itemGap)
        {
            this.itemGap = itemGap;
            return this as T;
        }

        /// 
        /// <param name="left"></param>
        public T Left(object left)
        {
            this.left = left;
            return this as T;
        }

        /// 
        /// <param name="right"></param>
        public T Right(object right)
        {
            this.right = right;
            return this as T;
        }

        /// 
        /// <param name="bottom"></param>
        public T Bottom(object bottom)
        {
            this.bottom = bottom;
            return this as T;
        }

        public T Orient(OrientType orient)
        {
            this.orient = orient;
            return this as T;
        }

        /// 
        /// <param name="top"></param>
        public T Top(object top)
        {
            this.top = top;
            return this as T;
        }

        public T Min(int min)
        {
            this.min = min;
            return this as T;
        }

        public T Max(int max)
        {
            this.max = max;
            return this as T;
        }

        public T Max(object max)
        {
            this.max = max;
            return this as T;
        }


    }
}

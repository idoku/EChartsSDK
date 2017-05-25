using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities
{
    public abstract class AbstractData<T> : IData<T> where T:class
    {
        public object data;

        private bool clickable;

        private bool hoverable;

        public string blendMode { get; set; }

        public bool? silent { get; set; }

        public bool? animation { get; set; }

        public int? animationThreshold { get; set; }

        public int? animationDuration { get; set; }

        public string animationEasing { get; set; }

        public int? animationDelay { get; set; }

        public int? animationDurationUpdate { get; set; }

        public string animationEasingUpdate { get; set; }

        public int? animationDelayUpdate { get; set; }

        

        /// 
        /// <param name="slient"></param>
        public T Silent(bool silent)
        {
            this.silent = silent;
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

        public T BlendMode(string blendMode)
        {
            this.blendMode = blendMode;
            return this as T;
        }

        public T Clickable(bool clickable)
        {
            this.clickable = clickable;
            return this as T;
        }

        public T Hoverable(bool hoverable)
        {
            this.hoverable = hoverable;
            return this as T;
        }


        public T Data()
        {
            if (data == null) {
                data = new List<object>();
            }
            return this as T;
        }
 

        public T SetData(IList<object> data) {
            this.data = data;
            return this as T;
        }

        public T Data(params object[] values)
        {
            if (values == null)
            {
                return default(T);
            }
            if (data == null) {
                data = new List<object>();
            }
            data = values;
            return this as T;
        }
    }
}

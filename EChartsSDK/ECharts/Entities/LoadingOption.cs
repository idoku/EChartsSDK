using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities
{
    public class LoadingOption
    {
        public string text { get; set; }

        public object x { get; set; }

        public object y { get; set; }

        public TextStyle  textStyle { get; set; }

        public object effect { get; set; }

        public object effectOption { get; set; }

        public double? progress { get; set; }

        public LoadingOption Progress(double progress)
        {
            this.progress = progress;
            return this;
        }

        public LoadingOption EffectOption(object effectOption)
        {
            this.effectOption = effectOption;
            return this;
        }

        public LoadingOption Effect(object effect)
        {
            this.effect = effect;
            return this;
        }

        public LoadingOption Y(object y)
        {
            this.y = y;
            return this;
        }

        public LoadingOption X(object x)
        {
            this.x = x;
            return this;
        }

        public LoadingOption Text(string text)
        {
            this.text = text;
            return this;
        }

    }

   
}

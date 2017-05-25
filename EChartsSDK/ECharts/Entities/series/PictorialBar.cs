using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class PictorialBar : ChartSeries<PictorialBar>
    {

        public object symbol { get; set; }

        public object symbolSize { get; set; }

        public string symbolPosition { get; set; }

        public object symbolOffset { get; set; }

        public int? symbolRotate { get; set; }

        public object symbolRepeat { get; set; }

        public string symbolRepeatDirection { get; set; }

        public object symbolMargin { get; set; }

        public bool? symbolClip { get; set; }

        public object symbolBoundingData { get; set; }

        public int? symbolPatternSize { get; set; }

        public PictorialBar SymbolPatternSize(int symbolPatternSize)
        {
            this.symbolPatternSize = symbolPatternSize;
            return this;
        }

        public PictorialBar SymbolBoundingData(object symbolBoundingData)
        {
            this.symbolBoundingData = symbolBoundingData;
            return this;
        }

        public PictorialBar SymbolMargin(object symbolMargin)
        {
            this.symbolMargin = symbolMargin;
            return this;
        }

        public PictorialBar SymbolClip(bool symbolClip)
        {
            this.symbolClip = symbolClip;
            return this;
        }

        public PictorialBar SymbolRepeatDirection(string symbolRepeatDirection)
        {
            this.symbolRepeatDirection = symbolRepeatDirection;
            return this;
        }

        public PictorialBar SymbolRepeat(string symbolRepeat)
        {
            this.symbolRepeat = symbolRepeat;
            return this;
        }

        public PictorialBar Symbol(object symbol)
        {
            this.symbol = symbol;
            return this;
        }

        public PictorialBar SymbolSize(object symbolSize)
        {
            this.symbolSize = symbolSize;
            return this;
        }

        public PictorialBar SymbolPosition(string symbolPosition)
        {
            this.symbolPosition = symbolPosition;
            return this;
        }

        public PictorialBar SymbolOffset(object symbolOffset)
        {
            this.symbolOffset = symbolOffset;
            return this;
        }

        public PictorialBar SymbolRotate(int symbolRotate)
        {
            this.symbolRotate = symbolRotate;
            return this;
        }

        public PictorialBar()
        {
            this.type = ChartType.pictorialBar;
        }

    }
}

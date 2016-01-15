using ECharts.Entities.series;
using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.feature
{
    public class Feature
    {

        public Mark mark { get; set; }

        public DataZoom dataZoom { get; set; }

        public DataView dataView { get; set; }

        public MagicType magicType { get; set; }

        public Restore restore { get; set; }

        public FeatureImage saveAsImage { get; set; }


        public MagicType MagicType()
        {
            if (magicType == null)
                magicType = new feature.MagicType();
            return magicType;
        }


        public Mark Mark()
        {
            if (mark == null)
                mark = new feature.Mark();
            return mark;
        }

        public DataZoom DataZoom()
        {
            if (dataZoom == null)
                dataZoom = new DataZoom();
            return dataZoom;
        }

        public DataView DataView()
        {
            if (dataView == null)
                dataView = new feature.DataView();
            return dataView;
        }


        public Restore Restore()
        {
            if (restore == null)
                restore = new feature.Restore();
            return restore;
        }

        public FeatureImage SaveAsImage()
        {
            if (saveAsImage == null)
                saveAsImage = new FeatureImage();
            return saveAsImage;
        }
    }
}

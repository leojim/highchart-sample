using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RnD.HighChartSample.ViewModels
{
    public class LineChartViewModel
    {
        public string TitleText { get; set; }
        public string SubTitleText { get; set; }
        public string[] XAxisCategories { get; set; }
        public string YAxisTitleText { get; set; }
        public string TooltipValueSuffix { get; set; }
        public LineChartSerieViewModel[] Series { get; set; }
    }

    public class LineChartSerieViewModel
    {
        public string SeriesName { get; set; }
        public decimal[] SeriesDatas { get; set; }
    }

    public class PieChartViewModel
    {
        public string Name { get; set; }
        public decimal Data { get; set; }
    }
}
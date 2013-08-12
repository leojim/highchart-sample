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
        public ChartSerieViewModel[] Series { get; set; }
    }

    public class ChartSerieViewModel
    {
        public string SeriesName { get; set; }
        public decimal[] SeriesDatas { get; set; }
    }

    public class BarChartViewModel
    {
        public string TitleText { get; set; }
        public string[] XAxisCategories { get; set; }
        public string YAxisTitleText { get; set; }
        public ChartSerieViewModel[] Series { get; set; }
    }

    public class PieChartViewModel
    {
        public string TitleText { get; set; }
        //public PieChartSerieViewModel[] Series { get; set; }
        public PieChartSerieDataViewModel[] SeriesDatas { get; set; }
    }

    public class PieChartSerieViewModel
    {
        public string SeriesName { get; set; }
        public PieChartSerieDataViewModel[] SeriesDatas { get; set; }
    }

    public class PieChartSerieDataViewModel
    {
        public string DataName { get; set; }
        public decimal DataY { get; set; }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RnD.HighChartSample.ViewModels;

namespace RnD.HighChartSample.Controllers
{
    public class ChartsController : Controller
    {
        //
        // GET: /Charts/

        public ActionResult Index()
        {
            return View();
        }

        //public JsonResult GetPieData()
        //{
        //    var chartsViewModels = new List<PieChartViewModel>(){

        //       new PieChartViewModel{Name = "Firefox", Data = 45m},
        //       new PieChartViewModel{Name = "IE", Data = 26.8m},
        //       new PieChartViewModel{Name = "Chrome", Data = 12.8m},
        //       new PieChartViewModel{Name = "Safari", Data = 8.5m},
        //       new PieChartViewModel{Name = "Opera", Data = 6.2m},
        //       new PieChartViewModel{Name = "Others", Data = 0.7m}

        //    };

        //    return Json(chartsViewModels, JsonRequestBehavior.AllowGet);
        //}

        //LineCharts
        public ActionResult LineCharts()
        {
            return View();
        }

        //ServerLineCharts
        public ActionResult ServerLineCharts()
        {
            return View();
        }

        [HttpGet]
        public JsonResult ServerLineChartsData()
        {
            string[] _months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

            List<ChartSerieViewModel> series = new List<ChartSerieViewModel>();

            for (int i = 0; i < 5; i++)
            {
                decimal d = 2 + i;
                decimal[] _datas = { d, 6.90m, 9.50m, 14.50m, 18.20m, 4.56m, d, 26.50m, 23.30m, 18.30m, 13.90m, d };

                ChartSerieViewModel lineChartSerieViewModel = new ChartSerieViewModel();
                lineChartSerieViewModel.SeriesName = "Tokyo : " + i;
                lineChartSerieViewModel.SeriesDatas = _datas;

                series.Add(lineChartSerieViewModel);
            }

            var model = new LineChartViewModel();

            model.TitleText = "Monthly Average Temperature";
            model.SubTitleText = "Source: WorldClimate.com";
            model.XAxisCategories = _months;
            model.YAxisTitleText = "Temperature (°C)";
            model.TooltipValueSuffix = "°C";
            model.Series = series.ToArray();

            return Json(model, JsonRequestBehavior.AllowGet);
        }

        //AreaCharts
        public ActionResult AreaCharts()
        {
            return View();
        }

        //ServerAreaCharts
        public ActionResult ServerAreaCharts()
        {
            return View();
        }

        //BarCharts
        public ActionResult BarCharts()
        {
            return View();
        }

        //ServerBarCharts
        public ActionResult ServerBarCharts()
        {
            return View();
        }

        [HttpGet]
        public JsonResult ServerBarChartsData()
        {
            string[] _categories = { "Apples", "Oranges", "Pears", "Grapes", "Bananas" };

            List<ChartSerieViewModel> series = new List<ChartSerieViewModel>();

            for (int i = 0; i < 3; i++)
            {
                decimal d = 2 + i;
                decimal[] _datas = { d, 3, 4, 7, d };

                ChartSerieViewModel lineChartSerieViewModel = new ChartSerieViewModel();
                lineChartSerieViewModel.SeriesName = "John : " + i;
                lineChartSerieViewModel.SeriesDatas = _datas;

                series.Add(lineChartSerieViewModel);
            }

            var model = new BarChartViewModel();

            model.TitleText = "Stacked column chart";
            model.XAxisCategories = _categories;
            model.YAxisTitleText = "Total fruit consumption";
            model.Series = series.ToArray();

            return Json(model, JsonRequestBehavior.AllowGet);
        }

        //PieCharts
        public ActionResult PieCharts()
        {
            return View();
        }

        //ServerPieCharts
        public ActionResult ServerPieCharts()
        {
            return View();
        }

        [HttpGet]
        public JsonResult ServerPieChartsData()
        {
            List<PieChartSerieDataViewModel> seriesDatas = new List<PieChartSerieDataViewModel>();

            for (int i = 0; i < 5; i++)
            {
                decimal d = 5 * i;

                PieChartSerieDataViewModel pieChartSerieDataViewModel = new PieChartSerieDataViewModel();
                pieChartSerieDataViewModel.DataName = "Tokyo : " + i;
                pieChartSerieDataViewModel.DataY = d;

                seriesDatas.Add(pieChartSerieDataViewModel);
            }

            var model = new PieChartViewModel();

            model.TitleText = "Browser market shares at a specific website, 2010";
            model.SeriesDatas = seriesDatas.ToArray();

            return Json(model, JsonRequestBehavior.AllowGet);
        }

        //ReloadCharts
        public ActionResult ReloadCharts()
        {
            return View();
        }

    }
}

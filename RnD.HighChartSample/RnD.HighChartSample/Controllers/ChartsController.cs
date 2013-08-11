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

        public JsonResult GetPieData()
        {
            var chartsViewModels = new List<PieChartViewModel>(){

               new PieChartViewModel{Name = "Firefox", Data = 45m},
               new PieChartViewModel{Name = "IE", Data = 26.8m},
               new PieChartViewModel{Name = "Chrome", Data = 12.8m},
               new PieChartViewModel{Name = "Safari", Data = 8.5m},
               new PieChartViewModel{Name = "Opera", Data = 6.2m},
               new PieChartViewModel{Name = "Others", Data = 0.7m}

            };

            return Json(chartsViewModels, JsonRequestBehavior.AllowGet);
        }

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

            List<LineChartSerieViewModel> series = new List<LineChartSerieViewModel>();

            for (int i = 0; i < 5; i++)
            {
                decimal d = 2 + i;
                decimal[] _datas = { d, 6.90m, 9.50m, 14.50m, 18.20m, 4.56m, d, 26.50m, 23.30m, 18.30m, 13.90m, d };

                LineChartSerieViewModel lineChartSerieViewModel = new LineChartSerieViewModel();
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
    }
}

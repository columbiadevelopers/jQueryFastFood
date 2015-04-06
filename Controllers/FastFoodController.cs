using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using jQueryFastFood.Models;

namespace jQueryFastFood.Controllers
{
    public class FastFoodController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

       
        public ActionResult SimpleToggle()
        {
            return View();
        }

        public ActionResult DecodeMonthNames()
        {
            return View();
        }

        public ActionResult ControlBreak()
        {
            return View();
        }
        public JsonResult GetPipelineData()
        {
            return Json(InitializeData());
        }

        public JsonResult GetExtendedData()
        {
            var data = InitializeData();
            var regions = data.GroupBy(p => new {p.Region})
                .Select(p => new {p.Key.Region, Count =  p.Count()}).ToList();
            return Json(new {data, regions});
        }

        public string GetSideBar()
        {
            if (this.Request.UrlReferrer.AbsoluteUri.Contains("FastFood"))
            {
                return @"
                <li>
                    <a href='/FastFood/index/'>
                        Basic Binding
                    </a>
                </li>
                <li>
                    <a href='/FastFood/SimpleToggle/'>
                        Simple Toggle
                    </a>

                </li>
                <li>
                    <a href='/FastFood/DecodeMonthNames/'>
                        Decode Month Names
                    </a>

                </li>
                <li>
                    <a href='/FastFood/ControlBreak/'>
                        Control Break
                    </a>
                </li>
                ";
            }
            else
            {
                return string.Empty;
            }
        }

        public IList <ReportDataViewModel> InitializeData()
        {
            var returnData = new List<ReportDataViewModel>
                                 {
                                     new ReportDataViewModel()
                                         {
                                             Region = "North East",
                                             AccountExecutive = "Valarie Mills",
                                             Units1 = 28,
                                             Units2 = 35,
                                             Units3 = 27,
                                             Units4 = 35,
                                             Units5 = 20,
                                             Units6 = 32,
                                             Units7 = 20,
                                             Units8 = 32,
                                             Units9 = 21,
                                             Units10 = 22,
                                             Units11 = 33,
                                             Units12 = 32,
                                             Volume1 = 36124.77,
                                             Volume2 = 48992.66,
                                             Volume3 = 47532.27,
                                             Volume4 = 48744.41,
                                             Volume5 = 45054.68,
                                             Volume6 = 36471.09,
                                             Volume7 = 50290.53,
                                             Volume8 = 47628.06,
                                             Volume9 = 43487.52,
                                             Volume10 = 47698.68,
                                             Volume11 = 51136.51,
                                             Volume12 = 50026.1
                                         },
                                     new ReportDataViewModel()
                                         {
                                             Region = "North East",
                                             AccountExecutive = "Bill Powers",
                                             Units1 = 29,
                                             Units2 = 23,
                                             Units3 = 22,
                                             Units4 = 25,
                                             Units5 = 29,
                                             Units6 = 35,
                                             Units7 = 28,
                                             Units8 = 28,
                                             Units9 = 20,
                                             Units10 = 27,
                                             Units11 = 20,
                                             Units12 = 32,
                                             Volume1 = 37942.03,
                                             Volume2 = 47112.54,
                                             Volume3 = 45244.14,
                                             Volume4 = 32551.71,
                                             Volume5 = 46185.68,
                                             Volume6 = 48524.52,
                                             Volume7 = 46499.67,
                                             Volume8 = 48311.25,
                                             Volume9 = 35554.67,
                                             Volume10 = 42639.49,
                                             Volume11 = 35747,
                                             Volume12 = 45424.85

                                         },
                                     new ReportDataViewModel()
                                         {
                                             Region = "North East",
                                             AccountExecutive = "Jayson Meyers",
                                             Units1 = 35,
                                             Units2 = 26,
                                             Units3 = 20,
                                             Units4 = 31,
                                             Units5 = 25,
                                             Units6 = 33,
                                             Units7 = 20,
                                             Units8 = 21,
                                             Units9 = 34,
                                             Units10 = 24,
                                             Units11 = 29,
                                             Units12 = 23,
                                             Volume1 = 32878.73,
                                             Volume2 = 49419,
                                             Volume3 = 36541.87,
                                             Volume4 = 34310.55,
                                             Volume5 = 36167.2,
                                             Volume6 = 43422.98,
                                             Volume7 = 45244.23,
                                             Volume8 = 45942.94,
                                             Volume9 = 36698.42,
                                             Volume10 = 46581.38,
                                             Volume11 = 42040.12,
                                             Volume12 = 46029.68


                                         },
                                     new ReportDataViewModel
                                         {
                                             Region = "South West",
                                             AccountExecutive = "Kim Trull",
                                             Units1 = 25,
                                             Units2 = 26,
                                             Units3 = 33,
                                             Units4 = 28,
                                             Units5 = 23,
                                             Units6 = 27,
                                             Units7 = 32,
                                             Units8 = 25,
                                             Units9 = 28,
                                             Units10 = 32,
                                             Units11 = 31,
                                             Units12 = 34,
                                             Volume1 = 36994.5,
                                             Volume2 = 51158.2,
                                             Volume3 = 38910.92,
                                             Volume4 = 39055.2,
                                             Volume5 = 50540.04,
                                             Volume6 = 38662.39,
                                             Volume7 = 49302.95,
                                             Volume8 = 32735.9,
                                             Volume9 = 47802.47,
                                             Volume10 = 47298.24,
                                             Volume11 = 50700.58,
                                             Volume12 = 34505.95

                                         },
                                     new ReportDataViewModel()
                                         {
                                             Region = "South West",
                                             AccountExecutive = "Lisa Wall",
                                             Units1 = 20,
                                             Units2 = 26,
                                             Units3 = 20,
                                             Units4 = 31,
                                             Units5 = 27,
                                             Units6 = 30,
                                             Units7 = 30,
                                             Units8 = 25,
                                             Units9 = 32,
                                             Units10 = 22,
                                             Units11 = 30,
                                             Units12 = 25,
                                             Volume1 = 43746.52,
                                             Volume2 = 34928.85,
                                             Volume3 = 38693.05,
                                             Volume4 = 45516.72,
                                             Volume5 = 33464.61,
                                             Volume6 = 44392.63,
                                             Volume7 = 39221.75,
                                             Volume8 = 37606.78,
                                             Volume9 = 49027.98,
                                             Volume10 = 36194.13,
                                             Volume11 = 36861.26,
                                             Volume12 = 45442.14

                                         },
                                     new ReportDataViewModel()
                                         {
                                             Region = "South West",
                                             AccountExecutive = "Vonda Russell",
                                             Units1 = 26,
                                             Units2 = 22,
                                             Units3 = 30,
                                             Units4 = 23,
                                             Units5 = 34,
                                             Units6 = 21,
                                             Units7 = 27,
                                             Units8 = 35,
                                             Units9 = 35,
                                             Units10 = 29,
                                             Units11 = 21,
                                             Units12 = 21,
                                             Volume1 = 32894.03,
                                             Volume2 = 46821.5,
                                             Volume3 = 40778.99,
                                             Volume4 = 40624.1,
                                             Volume5 = 35686.7,
                                             Volume6 = 46605.15,
                                             Volume7 = 49447.92,
                                             Volume8 = 33637.36,
                                             Volume9 = 36681.37,
                                             Volume10 = 38317.16,
                                             Volume11 = 49676.39,
                                             Volume12 = 35969.18

                                         },
                                     new ReportDataViewModel()
                                         {
                                             Region = "Central",
                                             AccountExecutive = "Denise Richards",
                                             Units1 = 29,
                                             Units2 = 29,
                                             Units3 = 30,
                                             Units4 = 31,
                                             Units5 = 26,
                                             Units6 = 35,
                                             Units7 = 20,
                                             Units8 = 32,
                                             Units9 = 31,
                                             Units10 = 25,
                                             Units11 = 33,
                                             Units12 = 33,
                                             Volume1 = 46216.45,
                                             Volume2 = 46310.64,
                                             Volume3 = 43882.6,
                                             Volume4 = 32880.25,
                                             Volume5 = 33904.68,
                                             Volume6 = 47640.6,
                                             Volume7 = 46745.84,
                                             Volume8 = 41941.28,
                                             Volume9 = 48019.37,
                                             Volume10 = 51575.9,
                                             Volume11 = 45407.32,
                                             Volume12 = 48363.12

                                         }
                                 };
            return (returnData);
        }
    }
}

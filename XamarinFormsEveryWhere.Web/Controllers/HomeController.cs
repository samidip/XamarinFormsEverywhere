using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using XamarinFormsEveryWhere.Web.Models;

using Ooui.AspNetCore;
using Xamarin.Forms;
using XamarinFormsEverywhere;

namespace XamarinFormsEveryWhere.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var page = new XamarinFormsEverywherePage();
            //var page = new TelerikUI();
            var element = page.GetOouiElement();
            return new ElementResult(element, "Hello, from XAML!");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using System.Collections.Generic;
using System.Web.Mvc;
using Syncfusion.EJ2.Navigations;

namespace SyncfusionExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<AccordionAccordionItem> accItems = new List<AccordionAccordionItem>();
            accItems.Add(new AccordionAccordionItem { Header = "Click to view Scheduler", Content = "#Current_Enrolments" });
            ViewBag.accordionItems = accItems;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
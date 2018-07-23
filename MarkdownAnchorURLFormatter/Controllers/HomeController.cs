using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Collections.Specialized;
using System.Text.RegularExpressions;

namespace MarkdownAnchorURLFormatter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
                      
            return View();
        }
        
        public ActionResult Result()
        {
            ViewBag.Message = "Your result page.";

            return View();
        }
    }
}
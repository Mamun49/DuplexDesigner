using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DuplexDesigner.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service
        public ActionResult Index()
        {
            ViewBag.ActivePage = "Service";
            return View();
        }public ActionResult Architecture()
        {
            return View();
        }public ActionResult StructureEngineering()
        {
            return View();
        }public ActionResult Electrical()
        {
            return View();
        }public ActionResult Plumbing()
        {
            return View();
        }public ActionResult ProjectManagement()
        {
            return View();
        }public ActionResult Construction()
        {
            return View();
        }
    }
}
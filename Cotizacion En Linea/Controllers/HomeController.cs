using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cotizacion_En_Linea.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Programa para el Control de las Cotizaciones para Licitaciones en línea";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Alexander Goicoechea Ch. - UNED (2021)";

            return View();
        }
    }
}
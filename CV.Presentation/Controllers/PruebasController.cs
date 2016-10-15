using CV.Presentation.Models.Pruebas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CV.Presentation.Controllers
{
    public class PruebasController : Controller
    {
        // GET: Pruebas
        public ActionResult Index()
        {
            return PartialView();
        }
        
        public ActionResult Grid()
        {
            return PartialView();
        }

        public ActionResult Data()
        {
            var rand = new Random();
            var viewModel = new List<GridItemViewModel>();
            for(var i = 0; i < rand.Next(100); i++)
            {
                viewModel.Add(new GridItemViewModel()
                {
                    ID = i,
                    Nombre = "Nombre " + i,
                    Valor = rand.NextDouble()*1000,
                    Fecha = DateTime.Now
                });
            }

            return Json(viewModel, JsonRequestBehavior.AllowGet);
        }

    }
}
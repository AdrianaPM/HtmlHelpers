using HtmlHelpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlHelpers.Controllers
{
    public class FormularioController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

     

        public ActionResult Registro(Formulario f)
        {
            if (ModelState.IsValid)
            {
               
                return View("Datos", f);
            }
            else
            {

                return View("Registro");

            }
           
        }

        public ActionResult Datos(Formulario f)
        {
            return View(f);

        }
    }
}
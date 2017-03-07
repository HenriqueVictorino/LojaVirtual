using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LojaVirtual.Domain;

namespace LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {

        private Produto _produto;

        public ActionResult Index()
        {
            return View();
        }
    }
}
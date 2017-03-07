using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LojaVirtual.Domain.Entities;

namespace LojaVirtual.Web.Controllers
{
    public class ProdutoController : Controller
    {
        private Produto Produtos;
        public ActionResult Index()
        {
            Produtos = new Produto();
            var Itens = Produtos.Produtos;
            return View();
        }
    }
}
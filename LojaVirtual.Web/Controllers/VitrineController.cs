using LojaVirtual.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        private Produto Produtos;
        public int ProdutosPorPagina = 3;
            

        public ActionResult ListaProdutos(int pagina = 1)
        {
            Produtos = new Produto();
            var Itens = Produtos.Produtos.OrderBy(a=>a.Nome).Skip((pagina - 1) * ProdutosPorPagina).Take(ProdutosPorPagina) ;


            return View(Itens);
        }
    }
}
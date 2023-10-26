using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Web.Mvc;
using ActionResult = Microsoft.AspNetCore.Mvc.ActionResult;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace ProductProgram.Controllers
{
    public class ProdutosController : Controller
    {
        private ConexaoDB _context;

        public ProdutosController()
        {
            _context = new ConexaoDB();
        }

        public ActionResult Index()
        {
            var produtos = _context.Produtos.ToList();
            return View(produtos);
        }

        public ActionResult Novo()
        {
            return View();
        }

        public ActionResult Editar(int id)
        {
            var produto = _context.Produtos.SingleOrDefault(p => p.Id == id);
            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        public ActionResult Excluir(int id)
        {
            var produto = _context.Produtos.SingleOrDefault(p => p.Id == id);
            if (produto == null)
            {
                return NotFound();
            }

            _context.Produtos.Remove(produto);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Detalhes(int id)
        {
            var produto = _context.Produtos.SingleOrDefault(p => p.Id == id);
            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }
    }
}

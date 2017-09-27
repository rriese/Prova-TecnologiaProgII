using ArtesMarciais.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArtesMarciais.Controllers
{
    public class TipoDeAssociacaoController : Controller
    {
        // GET: TipoDeAssociacao
        private ApplicationDbContext _context;
        public TipoDeAssociacaoController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Faixa
        public ActionResult Index()
        {
            var tipoAssociacao = _context.TipoDeAssociacao.ToList();

            return View(tipoAssociacao);
        }

        public ActionResult Details(int id)
        {
            var tipoAssociacao = _context.TipoDeAssociacao.SingleOrDefault(c => c.Id == id);
            if (tipoAssociacao != null)
            {
                return View(tipoAssociacao);
            }
            else
            {
                return HttpNotFound();
            }
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    }
}
using ArtesMarciais.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArtesMarciais.Controllers
{
    public class FaixaController : Controller
    {
        private ApplicationDbContext _context;
        public FaixaController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Faixa
        public ActionResult Index()
        {
            var faixas = _context.Faixas.ToList();

            return View(faixas);
        }

        public ActionResult Details(int id)
        {
            var faixa = _context.Faixas.SingleOrDefault(c => c.Id == id);
            if (faixa != null)
            {
                return View(faixa);
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
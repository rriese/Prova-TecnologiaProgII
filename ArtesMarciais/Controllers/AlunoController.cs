using ArtesMarciais.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace ArtesMarciais.Controllers
{
    public class AlunoController : Controller
    {
        // GET: Aluno
        private ApplicationDbContext _context;
        public AlunoController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Faixa
        public ActionResult Index()
        {
            var alunos = _context.Alunos.Include(c => c.Faixa).Include(c => c.TipoDeAssociacao).ToList();

            return View(alunos);
        }

        public ActionResult Details(int id)
        {
            var alunos = _context.Alunos.Include(c => c.Faixa).Include(c => c.TipoDeAssociacao).SingleOrDefault(c => c.Id == id);
            if (alunos != null)
            {
                return View(alunos);
            } else
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
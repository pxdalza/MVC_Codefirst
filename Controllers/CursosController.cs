using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_CodeFirst.Models;
using MVC_CodeFirst.ViewModel;

namespace MVC_CodeFirst.Controllers
{
    public class CursosController : Controller
    {
        private ApplicationContext db = new ApplicationContext();

        // GET: Cursos
        public ActionResult Index()
        {
            var cursos = db.Curso.ToList().Select(c => new CursoViewModel
            {
                CursoId = c.CursoId,
                Nombre = c.Nombre,
                Codigo =
                c.Codigo
            }).ToList();
            return View(cursos);
        }

        // GET: Cursos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            int cursoId = id.Value;
            var curso = db.Curso.Where(c=> c.CursoId.Equals(cursoId)).Select(c => new CursoViewModel { 
                CursoId = c.CursoId,
                Codigo = c.Codigo,
                Nombre = c.Nombre
            }).SingleOrDefault();
            if (curso == null)
            {
                return HttpNotFound();
            }
            return View(curso);
        }

        // GET: Cursos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cursos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CursoViewModel curso)
        {
            if (ModelState.IsValid)
            {
                db.Curso.Add(curso.ConvertToCurso());
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(curso);
        }

        // GET: Cursos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            int cursoId = id.Value;

            var curso = db.Curso.Where(c => c.CursoId.Equals(cursoId)).Select(c => new CursoViewModel
            {
                CursoId = c.CursoId,
                Codigo = c.Codigo,
                Nombre = c.Nombre
            }).SingleOrDefault();
            if (curso == null)
            {
                return HttpNotFound();
            }
            return View(curso);
        }

        // POST: Cursos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CursoViewModel curso)
        {
            if (ModelState.IsValid)
            {
                db.Entry(curso.ConvertToCurso()).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(curso);
        }

        // GET: Cursos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            int cursoId = id.Value;

            var curso = db.Curso.Where(c => c.CursoId.Equals(cursoId)).Select(c => new CursoViewModel
            {
                CursoId = c.CursoId,
                Codigo = c.Codigo,
                Nombre = c.Nombre
            }).SingleOrDefault();
            if (curso == null)
            {
                return HttpNotFound();
            }
            return View(curso);
        }

        // POST: Cursos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var curso = db.Curso.Where(c => c.CursoId.Equals(id)).SingleOrDefault();
            db.Curso.Remove(curso);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

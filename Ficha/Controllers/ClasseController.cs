using Ficha.Context;
using Ficha.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Ficha.Controllers
{
    public class ClasseController : Controller
    {
        private readonly Contexto _contexto = new Contexto();

        public ActionResult Index()
        {
            var classes = _contexto.Classe.ToList();
            return View(classes);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClasseModel classes)
        {
            if (ModelState.IsValid)
            {
                _contexto.Classe.Add(classes);
                _contexto.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(classes);
        }

        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            ClasseModel classes = _contexto.Classe.Where(aa => aa.Id == id).FirstOrDefault();

            if (classes == null)
            {
                return HttpNotFound();
            }

            return View(classes);
        }

        [HttpGet]
        public ActionResult Edit (int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            ClasseModel classes = _contexto.Classe.Where(aa => aa.Id == id).FirstOrDefault();

            if (classes == null)
            {
                return HttpNotFound();
            }
            return View(classes);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClasseModel classes)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _contexto.Entry(classes).State = EntityState.Modified;
                    _contexto.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }

                catch
                {
                    return View(classes);
                }
            }
            return View(classes);
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClasseModel classes = _contexto.Classe.Where(aa => aa.Id == id).FirstOrDefault();

            if (classes == null)
            {
                return HttpNotFound();
            }

            return View(classes);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete (ClasseModel classes)
        {
            try
            {
                _contexto.Entry(classes).State = EntityState.Deleted;
                _contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            catch
            {
                return View(classes);
            }
        }

        
    }
}
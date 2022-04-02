using Ficha.Context;
using Ficha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Ficha.Controllers
{
    public class JogadorController : Controller
    {
        private Contexto _db = new Contexto();

        // GET: Jogador
        public ActionResult Index()
        {
            return View(_db.Jogador.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }
        //Post: Create
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(JogadorModel jogadorModel)
        {
            if (ModelState.IsValid)
            {
                _db.Jogador.Add(jogadorModel);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(jogadorModel);
        }

        //Details
        public ActionResult Details(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JogadorModel jogadorModel = _db.Jogador.Find(id);
            if(jogadorModel == null)
            {
                return HttpNotFound();
            }
            return View(jogadorModel);
        }

        //Edit Get
        public ActionResult Edit(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JogadorModel jogadorModel = _db.Jogador.Find(id);
            if(jogadorModel == null)
            {
                return HttpNotFound();
            }
            return View(jogadorModel);
        }
        
        //Edit Post
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Edit(JogadorModel jogadorModel)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(jogadorModel).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(jogadorModel);
        }

        // Delete Get

        public ActionResult Delete(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JogadorModel jogadorModel = _db.Jogador.Find(id);
            if(jogadorModel == null)
            {
                return HttpNotFound();
            }
            return View(jogadorModel);
        }

        //Delete Post
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public ActionResult DeleteConfirmed(int id)
        {
            JogadorModel jogadorModel = _db.Jogador.Find(id);
            _db.Jogador.Remove(jogadorModel);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
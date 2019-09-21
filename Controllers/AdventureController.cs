using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Nankivell_MIS4200.DAL;
using Nankivell_MIS4200.Models;

namespace Nankivell_MIS4200.Controllers
{
    public class AdventureController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: Adventure
        public ActionResult Index()
        {
            var adventure = db.Adventure.Include(a => a.Character).Include(a => a.Episode);
            return View(adventure.ToList());
        }

        // GET: Adventure/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adventure adventure = db.Adventure.Find(id);
            if (adventure == null)
            {
                return HttpNotFound();
            }
            return View(adventure);
        }

        // GET: Adventure/Create
        public ActionResult Create()
        {
            ViewBag.characterId = new SelectList(db.Character, "characterId", "characterName");
            ViewBag.episodeId = new SelectList(db.Episode, "episodeId", "episodeTitle");
            return View();
        }

        // POST: Adventure/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "adventureId,aPlot,bPlot,characterId,episodeId")] Adventure adventure)
        {
            if (ModelState.IsValid)
            {
                db.Adventure.Add(adventure);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.characterId = new SelectList(db.Character, "characterId", "characterName", adventure.characterId);
            ViewBag.episodeId = new SelectList(db.Episode, "episodeId", "episodeTitle", adventure.episodeId);
            return View(adventure);
        }

        // GET: Adventure/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adventure adventure = db.Adventure.Find(id);
            if (adventure == null)
            {
                return HttpNotFound();
            }
            ViewBag.characterId = new SelectList(db.Character, "characterId", "characterName", adventure.characterId);
            ViewBag.episodeId = new SelectList(db.Episode, "episodeId", "episodeTitle", adventure.episodeId);
            return View(adventure);
        }

        // POST: Adventure/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "adventureId,aPlot,bPlot,characterId,episodeId")] Adventure adventure)
        {
            if (ModelState.IsValid)
            {
                db.Entry(adventure).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.characterId = new SelectList(db.Character, "characterId", "characterName", adventure.characterId);
            ViewBag.episodeId = new SelectList(db.Episode, "episodeId", "episodeTitle", adventure.episodeId);
            return View(adventure);
        }

        // GET: Adventure/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adventure adventure = db.Adventure.Find(id);
            if (adventure == null)
            {
                return HttpNotFound();
            }
            return View(adventure);
        }

        // POST: Adventure/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Adventure adventure = db.Adventure.Find(id);
            db.Adventure.Remove(adventure);
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

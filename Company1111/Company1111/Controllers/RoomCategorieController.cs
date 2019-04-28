using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Company1111.Models;

namespace Company1111.Controllers
{
    [Authorize(Roles ="Admin")]
    public class RoomCategorieController : Controller
    {
        private DataBaseContext db = new DataBaseContext();

        // GET: RoomCategorie
        public ActionResult Index()
        {
            return View(db.RoomCategories.ToList());
        }

        // GET: RoomCategorie/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RoomCategories roomCategories = db.RoomCategories.Find(id);
            if (roomCategories == null)
            {
                return HttpNotFound();
            }
            return View(roomCategories);
        }

        // GET: RoomCategorie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoomCategorie/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CategoryName")] RoomCategories roomCategories)
        {
            if (ModelState.IsValid)
            {
                db.RoomCategories.Add(roomCategories);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(roomCategories);
        }

        // GET: RoomCategorie/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RoomCategories roomCategories = db.RoomCategories.Find(id);
            if (roomCategories == null)
            {
                return HttpNotFound();
            }
            return View(roomCategories);
        }

        // POST: RoomCategorie/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CategoryName")] RoomCategories roomCategories)
        {
            if (ModelState.IsValid)
            {
                db.Entry(roomCategories).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(roomCategories);
        }

        // GET: RoomCategorie/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RoomCategories roomCategories = db.RoomCategories.Find(id);
            if (roomCategories == null)
            {
                return HttpNotFound();
            }
            return View(roomCategories);
        }

        // POST: RoomCategorie/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RoomCategories roomCategories = db.RoomCategories.Find(id);
            db.RoomCategories.Remove(roomCategories);
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

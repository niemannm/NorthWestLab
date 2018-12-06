using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NorthWestOrderSystem.DAL;
using NorthWestOrderSystem.Models;

namespace NorthWestOrderSystem.Controllers
{
    public class AssayTypesController : Controller
    {
        private IntexContext db = new IntexContext();

        // GET: AssayTypes
        public ActionResult Index()
        {
            return View(db.AssayTypes.ToList());
        }

        // GET: AssayTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AssayType assayType = db.AssayTypes.Find(id);
            if (assayType == null)
            {
                return HttpNotFound();
            }
            return View(assayType);
        }

        // GET: AssayTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AssayTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AssayID,AssayTitle,FullDescription,Summary,BasePrice,Procedures")] AssayType assayType)
        {
            if (ModelState.IsValid)
            {
                db.AssayTypes.Add(assayType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(assayType);
        }

        // GET: AssayTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AssayType assayType = db.AssayTypes.Find(id);
            if (assayType == null)
            {
                return HttpNotFound();
            }
            return View(assayType);
        }

        // POST: AssayTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AssayID,AssayTitle,FullDescription,Summary,BasePrice,Procedures")] AssayType assayType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(assayType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(assayType);
        }

        // GET: AssayTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AssayType assayType = db.AssayTypes.Find(id);
            if (assayType == null)
            {
                return HttpNotFound();
            }
            return View(assayType);
        }

        // POST: AssayTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AssayType assayType = db.AssayTypes.Find(id);
            db.AssayTypes.Remove(assayType);
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

        public ActionResult AssayTypesList()
        {
            return View("AssayTypesList");
        }

        public ActionResult Catalog()
        {
            return View("Catalog");
        }

        public ActionResult BiochemicalPharmocology()
        {
            AssayType assayType = db.AssayTypes.Find(1);
            return View(assayType);
        }
    }
}

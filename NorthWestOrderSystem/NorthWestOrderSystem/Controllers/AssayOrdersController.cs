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
    public class AssayOrdersController : Controller
    {
        private IntexContext db = new IntexContext();

        // GET: AssayOrders
        public ActionResult Index()
        {
            var assayOrders = db.AssayOrders.Include(a => a.Customer).Include(a => a.Status);
            return View(assayOrders.ToList());
        }

        // GET: AssayOrders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AssayOrder assayOrder = db.AssayOrders.Find(id);
            if (assayOrder == null)
            {
                return HttpNotFound();
            }
            return View(assayOrder);
        }

        // GET: AssayOrders/Create
        public ActionResult Create()
        {
            ViewBag.CustomerID = new SelectList(db.Customers, "CustomerID", "FirstName");
            ViewBag.StatusID = new SelectList(db.Statuses, "StatusID", "StatusDescription");
            return View();
        }

        // POST: AssayOrders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OrderID,PreliminaryCharge,FinalCharge,DueDate,FirstPayment,SecondPayment,DiscountPercentage,Comments,CustomerID,StatusID")] AssayOrder assayOrder)
        {
            if (ModelState.IsValid)
            {
                db.AssayOrders.Add(assayOrder);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CustomerID = new SelectList(db.Customers, "CustomerID", "FirstName", assayOrder.CustomerID);
            ViewBag.StatusID = new SelectList(db.Statuses, "StatusID", "StatusDescription", assayOrder.StatusID);
            return View(assayOrder);
        }

        // GET: AssayOrders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AssayOrder assayOrder = db.AssayOrders.Find(id);
            if (assayOrder == null)
            {
                return HttpNotFound();
            }
            ViewBag.CustomerID = new SelectList(db.Customers, "CustomerID", "FirstName", assayOrder.CustomerID);
            ViewBag.StatusID = new SelectList(db.Statuses, "StatusID", "StatusDescription", assayOrder.StatusID);
            return View(assayOrder);
        }

        // POST: AssayOrders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OrderID,PreliminaryCharge,FinalCharge,DueDate,FirstPayment,SecondPayment,DiscountPercentage,Comments,CustomerID,StatusID")] AssayOrder assayOrder)
        {
            if (ModelState.IsValid)
            {
                db.Entry(assayOrder).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CustomerID = new SelectList(db.Customers, "CustomerID", "FirstName", assayOrder.CustomerID);
            ViewBag.StatusID = new SelectList(db.Statuses, "StatusID", "StatusDescription", assayOrder.StatusID);
            return View(assayOrder);
        }

        // GET: AssayOrders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AssayOrder assayOrder = db.AssayOrders.Find(id);
            if (assayOrder == null)
            {
                return HttpNotFound();
            }
            return View(assayOrder);
        }

        // POST: AssayOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AssayOrder assayOrder = db.AssayOrders.Find(id);
            db.AssayOrders.Remove(assayOrder);
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

        public ActionResult ViewOrders()
        {
            var assayOrders = db.AssayOrders.Include(a => a.Customer).Include(a => a.Status);
            return View(assayOrders.ToList());
        }
    }
}

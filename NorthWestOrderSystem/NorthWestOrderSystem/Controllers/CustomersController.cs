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
    public class CustomersController : Controller
    {
        private IntexContext db = new IntexContext();

        // GET: Customers
        public ActionResult Index()
        {
            var customers = db.Customers.Include(c => c.PaymentInfo);
            return View(customers.ToList());
        }

        // GET: Customers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            ViewBag.PaymentInfoID = new SelectList(db.PaymentInfos, "PaymentInfoID", "CardHolder");
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CustomerID,FirstName,LastName,StreetAddress,City,State,Zip,Email,Phone,PaymentInfoID")] Customer customer, [Bind(Include = "PaymentInfoID,CardNumber,ExpirationDate,CVV,CardHolder")] PaymentInfo paymentInfo)
        {
            if (ModelState.IsValid)
            {
                db.PaymentInfos.Add(paymentInfo);
                db.SaveChanges();

                customer.PaymentInfoID = paymentInfo.PaymentInfoID;

                db.Customers.Add(customer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PaymentInfoID = new SelectList(db.PaymentInfos, "PaymentInfoID", "CardHolder", customer.PaymentInfoID);
            return View(customer);
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            ViewBag.PaymentInfoID = new SelectList(db.PaymentInfos, "PaymentInfoID", "CardHolder", customer.PaymentInfoID);
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CustomerID,FirstName,LastName,StreetAddress,City,State,Zip,Email,Phone,PaymentInfoID")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Login");
            }
            ViewBag.PaymentInfoID = new SelectList(db.PaymentInfos, "PaymentInfoID", "CardHolder", customer.PaymentInfoID);
            return View(customer);
        }

        // GET: Customers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Customer customer = db.Customers.Find(id);

            db.Database.ExecuteSqlCommand("DELETE FROM PaymentInfo WHERE PaymentInfo.PaymentInfoID = " + customer.PaymentInfoID);

            db.Customers.Remove(customer);
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

        [HttpGet]
        public ActionResult Login()
        {
            return View("Login");
        }

        [HttpPost]
        public ActionResult Login(String Username, String Password)
        {
            //create form that calls the action methd with this information
            if (Username == "byucougar" && Password == "Gocougs")
            {
                return View("CustLandingPage", null, db.Customers.Find(8));
            }
            else
            {
                return View("Login");
            }
        }

        public ActionResult OrderAssay()
        {
            return View();
        }

        [HttpPost]
        public ActionResult OrderAssay(DateTime DueDate, String CompoundName, String AssayType, String Comments)
        {
            return View("ThankYou");
        }

        // GET: Customers/Create
        public ActionResult SignUp()
        {
            ViewBag.PaymentInfoID = new SelectList(db.PaymentInfos, "PaymentInfoID", "CardHolder");
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp([Bind(Include = "CustomerID,FirstName,LastName,StreetAddress,City,State,Zip,Email,Phone,PaymentInfoID")] Customer customer, [Bind(Include = "PaymentInfoID,CardNumber,ExpirationDate,CVV,CardHolder")] PaymentInfo paymentInfo)
        {
            if (ModelState.IsValid)
            {
                db.PaymentInfos.Add(paymentInfo);
                db.SaveChanges();

                customer.PaymentInfoID = paymentInfo.PaymentInfoID;

                db.Customers.Add(customer);
                db.SaveChanges();
                return RedirectToAction("SignedUp");
            }

            ViewBag.PaymentInfoID = new SelectList(db.PaymentInfos, "PaymentInfoID", "CardHolder", customer.PaymentInfoID);
            return View(customer);
        }

        public ActionResult SignedUp()
        {
            return View("SignedUp");
        }

        public ActionResult SingleOrder()
        {
            return View("SingleOrder");
        }

        public ActionResult SingleOrder2()
        {
            return View("SingleOrder2");
        }
    }
}

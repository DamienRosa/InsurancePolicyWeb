using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using InsuranceApolicyWeb.DAL;
using InsuranceApolicyWeb.Models;

namespace InsuranceApolicyWeb.Controllers
{
    public class InsuranceController : Controller
    {
        private InsurancePolicyContext db = new InsurancePolicyContext();

        // GET: Insurance
        public ActionResult Index()
        {
            var policies = db.Policies.Include(p => p.User).Include(p => p.UserVehicles);
            return View(policies.ToList());
        }

        // GET: Insurance/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PolicyModel policyModel = db.Policies.Find(id);
            if (policyModel == null)
            {
                return HttpNotFound();
            }
            return View(policyModel);
        }

        // GET: Insurance/Create
        public ActionResult Create()
        {
            ViewBag.UserViewModelID = new SelectList(db.Users, "ID", "NIF");
            return View();
        }

        // POST: Insurance/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,PolicyType,PolicyNumber,TotalAnnualReward,State,CriationDate,BusinessUnity,Product,ClientNumber,Currency,ExpirationDate,MediatingAgent,Branch,PaymentMethod,Fractionation,LocationWarranty,UserViewModelID")] PolicyModel policyModel)
        {
            if (ModelState.IsValid)
            {
                db.Policies.Add(policyModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UserViewModelID = new SelectList(db.Users, "ID", "NIF", policyModel.UserViewModelID);
            return View(policyModel);
        }

        // GET: Insurance/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PolicyModel policyModel = db.Policies.Find(id);
            if (policyModel == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserViewModelID = new SelectList(db.Users, "ID", "NIF", policyModel.UserViewModelID);
            return View(policyModel);
        }

        // POST: Insurance/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,PolicyType,PolicyNumber,TotalAnnualReward,State,CriationDate,BusinessUnity,Product,ClientNumber,Currency,ExpirationDate,MediatingAgent,Branch,PaymentMethod,Fractionation,LocationWarranty,UserViewModelID")] PolicyModel policyModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(policyModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UserViewModelID = new SelectList(db.Users, "ID", "NIF", policyModel.UserViewModelID);
            return View(policyModel);
        }

        // GET: Insurance/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PolicyModel policyModel = db.Policies.Find(id);
            if (policyModel == null)
            {
                return HttpNotFound();
            }
            return View(policyModel);
        }

        // POST: Insurance/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PolicyModel policyModel = db.Policies.Find(id);
            db.Policies.Remove(policyModel);
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

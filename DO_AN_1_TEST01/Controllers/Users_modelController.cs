using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DO_AN_1_TEST01.DATAContext;
using DO_AN_1_TEST01.Models;

namespace DO_AN_1_TEST01.Controllers
{
    public class Users_modelController : Controller
    {
        private DATAConText db = new DATAConText();

        // GET: Users_model
        public ActionResult Index()
        {
            return View(db.Users_Models.ToList());
        }

        // GET: Users_model/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Users_model users_model = db.Users_Models.Find(id);
            if (users_model == null)
            {
                return HttpNotFound();
            }
            return View(users_model);
        }

        // GET: Users_model/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Users_model/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UsersId,UserName,PassWord,rules,status")] Users_model users_model)
        {
            if (ModelState.IsValid)
            {
                db.Users_Models.Add(users_model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(users_model);
        }

        // GET: Users_model/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Users_model users_model = db.Users_Models.Find(id);
            if (users_model == null)
            {
                return HttpNotFound();
            }
            return View(users_model);
        }

        // POST: Users_model/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UsersId,UserName,PassWord,rules,status")] Users_model users_model)
        {
            if (ModelState.IsValid)
            {
                db.Entry(users_model).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(users_model);
        }

        // GET: Users_model/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Users_model users_model = db.Users_Models.Find(id);
            if (users_model == null)
            {
                return HttpNotFound();
            }
            return View(users_model);
        }

        // POST: Users_model/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Users_model users_model = db.Users_Models.Find(id);
            db.Users_Models.Remove(users_model);
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

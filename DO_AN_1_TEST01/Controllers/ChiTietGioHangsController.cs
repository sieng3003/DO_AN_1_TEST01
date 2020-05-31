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
    public class ChiTietGioHangsController : Controller
    {
        private DATAConText db = new DATAConText();

        // GET: ChiTietGioHangs
        public ActionResult Index()
        {
            var chiTietGioHangs = db.chiTietGioHangs.Include(c => c.GioHang).Include(c => c.SanPham);
            return View(chiTietGioHangs.ToList());
        }

        // GET: ChiTietGioHangs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietGioHang chiTietGioHang = db.chiTietGioHangs.Find(id);
            if (chiTietGioHang == null)
            {
                return HttpNotFound();
            }
            return View(chiTietGioHang);
        }

        // GET: ChiTietGioHangs/Create
        public ActionResult Create()
        {
            ViewBag.GioHangId = new SelectList(db.gioHangs, "GioHangId", "GioHangId");
            ViewBag.SanPhamId = new SelectList(db.sanPhams, "SanPhamId", "TenSanPham");
            return View();
        }

        // POST: ChiTietGioHangs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CTGioHangId,PhiGiaoDich,ThanhTien,GioHangId,SanPhamId")] ChiTietGioHang chiTietGioHang)
        {
            if (ModelState.IsValid)
            {
                db.chiTietGioHangs.Add(chiTietGioHang);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GioHangId = new SelectList(db.gioHangs, "GioHangId", "GioHangId", chiTietGioHang.GioHangId);
            ViewBag.SanPhamId = new SelectList(db.sanPhams, "SanPhamId", "TenSanPham", chiTietGioHang.SanPhamId);
            return View(chiTietGioHang);
        }

        // GET: ChiTietGioHangs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietGioHang chiTietGioHang = db.chiTietGioHangs.Find(id);
            if (chiTietGioHang == null)
            {
                return HttpNotFound();
            }
            ViewBag.GioHangId = new SelectList(db.gioHangs, "GioHangId", "GioHangId", chiTietGioHang.GioHangId);
            ViewBag.SanPhamId = new SelectList(db.sanPhams, "SanPhamId", "TenSanPham", chiTietGioHang.SanPhamId);
            return View(chiTietGioHang);
        }

        // POST: ChiTietGioHangs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CTGioHangId,PhiGiaoDich,ThanhTien,GioHangId,SanPhamId")] ChiTietGioHang chiTietGioHang)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chiTietGioHang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GioHangId = new SelectList(db.gioHangs, "GioHangId", "GioHangId", chiTietGioHang.GioHangId);
            ViewBag.SanPhamId = new SelectList(db.sanPhams, "SanPhamId", "TenSanPham", chiTietGioHang.SanPhamId);
            return View(chiTietGioHang);
        }

        // GET: ChiTietGioHangs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietGioHang chiTietGioHang = db.chiTietGioHangs.Find(id);
            if (chiTietGioHang == null)
            {
                return HttpNotFound();
            }
            return View(chiTietGioHang);
        }

        // POST: ChiTietGioHangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ChiTietGioHang chiTietGioHang = db.chiTietGioHangs.Find(id);
            db.chiTietGioHangs.Remove(chiTietGioHang);
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

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
    public class SanPhamsController : Controller
    {
        private DATAConText db = new DATAConText();

        // GET: SanPhams
        public ActionResult Index()
        {
            var sanPhams = db.sanPhams.Include(s => s.LoaiSanPham).Include(s => s.NhaCungCap);
            return View(sanPhams.ToList());
        }

        // GET: SanPhams/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SanPham sanPham = db.sanPhams.Find(id);
            if (sanPham == null)
            {
                return HttpNotFound();
            }
            return View(sanPham);
        }

        // GET: SanPhams/Create
        public ActionResult Create()
        {
            ViewBag.LoaiId = new SelectList(db.loaiSanPhams, "LoaiId", "TenLoai");
            ViewBag.NhaCungCapId = new SelectList(db.nhaCungCaps, "NhaCungCapId", "TenNhanCungCap");
            return View();
        }

        // POST: SanPhams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SanPhamId,TenSanPham,GiaSanPham,Image,MoTa,NhaCungCapId,LoaiId")] SanPham sanPham)
        {
            if (ModelState.IsValid)
            {
                db.sanPhams.Add(sanPham);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.LoaiId = new SelectList(db.loaiSanPhams, "LoaiId", "TenLoai", sanPham.LoaiId);
            ViewBag.NhaCungCapId = new SelectList(db.nhaCungCaps, "NhaCungCapId", "TenNhanCungCap", sanPham.NhaCungCapId);
            return View(sanPham);
        }

        // GET: SanPhams/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SanPham sanPham = db.sanPhams.Find(id);
            if (sanPham == null)
            {
                return HttpNotFound();
            }
            ViewBag.LoaiId = new SelectList(db.loaiSanPhams, "LoaiId", "TenLoai", sanPham.LoaiId);
            ViewBag.NhaCungCapId = new SelectList(db.nhaCungCaps, "NhaCungCapId", "TenNhanCungCap", sanPham.NhaCungCapId);
            return View(sanPham);
        }

        // POST: SanPhams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SanPhamId,TenSanPham,GiaSanPham,Image,MoTa,NhaCungCapId,LoaiId")] SanPham sanPham)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sanPham).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.LoaiId = new SelectList(db.loaiSanPhams, "LoaiId", "TenLoai", sanPham.LoaiId);
            ViewBag.NhaCungCapId = new SelectList(db.nhaCungCaps, "NhaCungCapId", "TenNhanCungCap", sanPham.NhaCungCapId);
            return View(sanPham);
        }

        // GET: SanPhams/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SanPham sanPham = db.sanPhams.Find(id);
            if (sanPham == null)
            {
                return HttpNotFound();
            }
            return View(sanPham);
        }

        // POST: SanPhams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SanPham sanPham = db.sanPhams.Find(id);
            db.sanPhams.Remove(sanPham);
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

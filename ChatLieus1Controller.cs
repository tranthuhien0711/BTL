using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BTLQLBHHQ1.Models;

namespace BTLQLBHHQ1.Controllers
{
    public class ChatLieus1Controller : Controller
    {
        private HQDbContext db = new HQDbContext();

        // GET: ChatLieus1
        public ActionResult Index()
        {
            return View(db.ChatLieus.ToList());
        }

        // GET: ChatLieus1/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChatLieu chatLieu = db.ChatLieus.Find(id);
            if (chatLieu == null)
            {
                return HttpNotFound();
            }
            return View(chatLieu);
        }

        // GET: ChatLieus1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ChatLieus1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ChatLieuID,TenChatLieu,KieuDang")] ChatLieu chatLieu)
        {
            if (ModelState.IsValid)
            {
                db.ChatLieus.Add(chatLieu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(chatLieu);
        }

        // GET: ChatLieus1/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChatLieu chatLieu = db.ChatLieus.Find(id);
            if (chatLieu == null)
            {
                return HttpNotFound();
            }
            return View(chatLieu);
        }

        // POST: ChatLieus1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ChatLieuID,TenChatLieu,KieuDang")] ChatLieu chatLieu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chatLieu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(chatLieu);
        }

        // GET: ChatLieus1/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChatLieu chatLieu = db.ChatLieus.Find(id);
            if (chatLieu == null)
            {
                return HttpNotFound();
            }
            return View(chatLieu);
        }

        // POST: ChatLieus1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ChatLieu chatLieu = db.ChatLieus.Find(id);
            db.ChatLieus.Remove(chatLieu);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLBH.Models;

namespace QLBH.Controllers
{
    public class KhachHangController : Controller
    {
        //khai báo đói tượng kết nối tới database
        QLBHDbContext db = new QLBHDbContext();
        // GET: KhachHang
        public ActionResult Index()
        {
            //lấy toàn bộ dl trong bảng khách hàng 
            //trả về dạng list ròi hiển thị lên view
            return View(db.KhachHangs.ToList());
        }
        //tạo action create trả về view cho người dùng
        //nhap thông tin khách hàng đê thêm mới vời csdl
        public ActionResult Create()
        {
            return View();
        }
        //tạo action create với tham số để nhận dl từ client
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(KhachHang kh)
        {
            //nếu đk ràng buộc ở class được thỏa mãn
            if (ModelState.IsValid)
            {
                //thêm moi đói tượng kh vào trong csdl
                db.KhachHangs.Add(kh);
                //cập nhật thay đổi vào csdl
                db.SaveChanges();
                return RedirectToAction("Index");
            }    
            //nếu đk ràng buộc ở class k thỏa mãn 
            return View(kh);
        }
    }

}
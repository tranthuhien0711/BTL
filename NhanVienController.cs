using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLBH.Models;

namespace QLBH.Controllers
{
    public class NhanVienController : Controller
    {
        //khai báo đối tượng kết nối tới database
        QLBHDbContext db = new QLBHDbContext();
        // GET: NhanVien
        public ActionResult Index()
        {
            //lấy toàn bộ dữ liệu trong bảng nhanvien
            //trả về dạng list rồi hiển thị len View
            return View(db.NhanViens.ToList());
        }
        //tạo action create trả về view cho người dùng
        //nhập thông tin khách hàng để thêm mới vào CSDL
        public ActionResult Create()
        {
            return View();
        }
        //tạo action create với tham số để nhận dl từ client
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult create(NhanVien nv )
        {
            //nếu đk ràng buộc ở Class được thỏa mãn
            if (ModelState.IsValid)
            {
                //thêm mới đối tượng nv vào CSDl
                db.NhanViens.Add(nv);
                //cập nhật thay đổi vào CSDL
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View();
        }
    }
}
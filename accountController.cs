using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BTLHtml17.Controllers
{
    public class accountController : Controller
    {
        //Mặc điịnh là get
        public ViewResult Login(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Models.account acc , string returnUrl)
        {
            //Nếu vượt qua được Validation ở account
            if (ModelState.IsValid)
            {
                //Kiểm tra thông tin đăng nhập
                if (acc.UserName == "admin" && acc.Password == "123123")
                {
                    FormsAuthentication.SetAuthCookie(acc.UserName, true);
                    return RedirectToLocal(returnUrl);
                }    
            }
            return View(acc);
        }
        //Hàm đăng xuất khỏi chương trình
        public ActionResult Logoff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
        //Kiểm tra xem returnUrl có thuộc hệ thống hay không
        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }    
            else
            {
                return RedirectToAction("Index", "Home");
            }    
        }
    }
}
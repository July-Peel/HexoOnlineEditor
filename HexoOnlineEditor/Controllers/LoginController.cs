using HexoOnlineEditor.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HexoOnlineEditor.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            string pwd = Request.Cookies["pwd"]?.ToString() ?? "";

            if (pwd == HelpData.GetMD5("123Cool"))
            {
                return Redirect("/Home/Index");//已经登录了就跳转
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public JsonResult LoginUser()
        {
            try
            {
                string acc = Request.Form["account"].ToString() ?? "";
                string pwd= Request.Form["password"].ToString() ?? "";

                if (string.IsNullOrEmpty(acc) || string.IsNullOrEmpty(pwd)) throw new Exception("请填写账号密码");
                if (acc != "peel" || pwd != "123Cool") throw new Exception("账号密码不正确");


                string Md5Pwd = HelpData.GetMD5(pwd);

                Response.Cookies.Append("pwd", Md5Pwd, new CookieOptions() { Expires = DateTime.Now.AddDays(3) });//保存cookie
                return Json(new MessAge() { Status = true, Msg = "登录成功" });
            }
            catch (Exception ex)
            {
                return Json(new MessAge() { Status = false, Msg = ex.Message });
            }
        }
    }
}

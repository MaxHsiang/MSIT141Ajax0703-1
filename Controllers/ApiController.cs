using Microsoft.AspNetCore.Mvc;
using MSIT141Ajax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSIT141Ajax.Controllers
{
    public class ApiController : Controller
    {
        private readonly DemoContext _context;
        public ApiController( DemoContext context)
        {
            _context = context;
        }
        public IActionResult Index(User user)
        {

            
            if (string.IsNullOrEmpty(user.name))
                return Content("此處必填，輸入姓名", "text/plain", System.Text.Encoding.UTF8);
            else
            {
                Member member = _context.Members.FirstOrDefault(m => m.Name == user.name);
                if (member != null)
                    return Content("此名稱已有註冊，請重新輸入", "text/plain", System.Text.Encoding.UTF8);
                else
                    return Content("此名稱可使用", "text/plain", System.Text.Encoding.UTF8);
            }
        }
        public IActionResult FirstAjax()
        {
            return View();
        }
    }
}
//return Content("<h1>Hello~~Ajax</h1>","text/html",System.Text.Encoding.UTF8);
            //System.Threading.Thread.Sleep(3000);
            //if (String.IsNullOrEmpty(user.name))
            //{
            //    user.name = "Ajax";
            //}
            //return Content($"{user.name}你好,你的年紀是{user.age}!!", "text/plain", System.Text.Encoding.UTF8);
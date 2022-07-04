using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSIT141Ajax.Controllers
{
    public class ApiController : Controller
    {
        public IActionResult Index()
        {
            return Content("<h1>Hello~~Ajax</h1>","text/html",System.Text.Encoding.UTF8);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    public class TestingController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.user = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return View();
        }
    }
}
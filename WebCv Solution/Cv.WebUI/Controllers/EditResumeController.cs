using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cv.WebUI.Controllers
{
    public class EditResumeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

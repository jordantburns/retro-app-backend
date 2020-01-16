using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using retro_app_backend.Views;

namespace retro_app_backend.Controllers.RetroApp
{
    public class RetroAppController : Controller
    {
        [Route("{*url}")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View("../Index");
        }
    }
}

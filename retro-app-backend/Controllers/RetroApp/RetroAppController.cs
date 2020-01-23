using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using retro_app_backend.Views;
using retro_app_backend.Controllers.RetroApp.Models;

namespace retro_app_backend.Controllers.RetroApp
{
    public class RetroAppController : Controller
    {
        [Route("{*url}")]
        [HttpGet]
        public IActionResult Index()
        {
            return View("../Index");
        }

        [Route("submit")]
        [HttpPost]
        public async Task<IActionResult> Submit([FromBody] RetroAppDataModel model)
        {
            if(string.IsNullOrEmpty(model.FirstName))
            {
                return BadRequest();
            }

            string pin = Guid.NewGuid().ToString();

            pin = pin.Substring(0, 6);

            return Ok(pin);
        }
    }
}
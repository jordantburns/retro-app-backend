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
        private static List<RetroRoom> _rooms = new List<RetroRoom>();

        [Route("{*url}")]
        [HttpGet]
        public IActionResult Index()
        {
            return View("../Index");
        }

        ////TO DO: Room Controller for this where the base route is /room then cut and paste this here
        ////Then create a post with route "board" where the user can post to the board with a post it
        //[Route("submit")]
        //[HttpPost]
        //public async Task<IActionResult> CreateRoom([FromBody] RetroAppDataModel model)
        //{
        //    if(string.IsNullOrEmpty(model.FirstName))
        //    {
        //        return BadRequest();
        //    }

        //    string pin = Guid.NewGuid().ToString();

        //    pin = pin.Substring(0, 6);

        //    RetroRoom room = new RetroRoom
        //    {
        //        Pin = pin,
        //        RoomCreator = model.FirstName
        //    };

        //    _rooms.Add(room);

        //    return Ok(pin);
        //}
    }
}
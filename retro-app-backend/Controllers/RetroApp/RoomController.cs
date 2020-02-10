﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using retro_app_backend.Views;
using retro_app_backend.Controllers.RetroApp.Models;

namespace retro_app_backend.Controllers.RetroApp
{
    [Route("room")]
    public class RoomController : Controller
    {
        private static List<RetroRoom> _rooms = new List<RetroRoom>();

        //Then create a post with route "board" where the user can post to the board with a post it
        [Route("create")]
        [HttpPost]
        public async Task<IActionResult> CreateRoom([FromBody] RetroAppDataModel model)
        {
            if (string.IsNullOrEmpty(model.FirstName))
            {
                return BadRequest();
            }

            string pin = Guid.NewGuid().ToString();

            pin = pin.Substring(0, 6);

            RetroRoom room = new RetroRoom
            {
                Pin = pin,
                RoomCreator = model.FirstName
            };

            _rooms.Add(room);

            return Ok(pin);
        }

        [Route("join")]
        [HttpPost]
        public async Task<IActionResult> JoinRoom([FromBody] RetroAppDataModel model)
        {
            if (string.IsNullOrEmpty(model.FirstName))
            {
                return BadRequest();
            }

            var room = _rooms.Select(x => x).Where(y => y.Pin == model.PinToJoin).FirstOrDefault();

            room.Attendees.Add(model.FirstName);

            return Ok();
        }

        [Route("/board/post")]
        [HttpPost]
        public async Task<IActionResult> PostToBoard([FromBody] RetroAppDataModel model)
        {
            var room = _rooms.Select(x => x).Where(y => y.Pin == model.Pin).FirstOrDefault();

            room.Messages.Add(model.Message);

            return Ok();
        }
    }
}
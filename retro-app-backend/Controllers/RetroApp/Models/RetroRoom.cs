using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace retro_app_backend.Controllers.RetroApp.Models
{
    public class RetroRoom
    {
        public string RoomCreator { get; set; }

        public string Pin { get; set; }

        public Guid id { get; set; } = Guid.NewGuid();
    }
}

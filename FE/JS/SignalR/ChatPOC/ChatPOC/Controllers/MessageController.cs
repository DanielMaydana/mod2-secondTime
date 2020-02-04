using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatPOC.Hubs;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace ChatPOC.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("CorsPostPolicy")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        // GET: api/Message
        IHubContext<ChatHub> _hubContext;
        public MessageController(IHubContext<ChatHub> hubContext)
        {
            _hubContext = hubContext;
        }
        // POST: api/Message
        [HttpPost]
        public IActionResult Post(MessageDTO message)
        {
            _hubContext.Clients.All.SendAsync("getMessage", message.user, message.text);
            return this.StatusCode(StatusCodes.Status200OK, "Message sent");
        }

      
    }
}

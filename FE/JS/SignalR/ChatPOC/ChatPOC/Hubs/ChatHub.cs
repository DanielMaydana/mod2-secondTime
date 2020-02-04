using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatPOC.Hubs
{
    public class ChatHub: Hub
    {
        public Task getMessage(string user, string message)
        {
            return Clients.All.SendAsync("getMessage",user,message);
        }
    }
}

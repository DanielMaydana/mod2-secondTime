using ChatPOC.Hubs;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChat
{
    class ConsoleHub
    {
                   
         private readonly IHubContext<ChatHub> myHubContext;

        public ConsoleHub(IHubContext<ChatHub> myHubContext)
        {
            this.myHubContext = myHubContext;
           
        }

        public async Task SendMessage(string message)
        {
            await myHubContext.Clients.All.SendAsync("getMessage","-Console-", message);///"getMessage",user,message
        }

    }
}

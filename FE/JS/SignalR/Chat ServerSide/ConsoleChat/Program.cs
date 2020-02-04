using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.AspNetCore.SignalR;
using System;
using ChatPOC.Hubs;

namespace ConsoleChat
{
    class Program
    {
       static IHubContext<ChatHub> myHubContext;
        static void Main(string[] args)
        {

            while (true)
            {
                string msj = Console.ReadLine();
               
                Console.WriteLine(msj);
                Send(msj);

            }
        }

        static async void Send(string m)
        {
            await myHubContext.Clients.All.SendAsync("Console", m);
        }
    }
}

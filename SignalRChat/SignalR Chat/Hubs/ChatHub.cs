using Microsoft.AspNetCore.SignalR;
using SignalR_Chat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR_Chat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(MessageModel message) =>
            await Clients.All.SendAsync("receiveMessage", message);
    }
}

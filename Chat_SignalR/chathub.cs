﻿using System;
using System.Web;
using Microsoft.AspNet.SignalR;
namespace SignalRChat
{
    public class ChatHub : Hub
    {
        public void Senden(string name, string message)
        {
            Clients.All.broadcastMessage(name, message);
        }
    }
}
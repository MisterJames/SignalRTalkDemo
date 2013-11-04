using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SimpleSignal
{
    public class HelloHub : Hub
    {
        public void Hello(string message)
        {
            Clients.All.hello(message);
        }
    }
}
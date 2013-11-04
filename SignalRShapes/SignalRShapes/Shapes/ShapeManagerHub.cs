using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRShapes.Shapes
{
    public class ShapeManagerHub : Hub
    {

        public void ShapeMoved(int x, int y)
        {
            Clients.Others.moveShape(x, y);
            
        }

        public void Reset()
        {
            Clients.All.moveShape(0, 0);
        }

    }
}
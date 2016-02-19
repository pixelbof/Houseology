using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService.DAL;
using Microsoft.AspNet.SignalR;
using System.Threading;
using System.Collections;
using System.Threading.Tasks;

namespace signalR_webservice.Hubs
{
    public class ChatHub : Hub
    {
        //signalR_webservice.DAL.Entities _db = new DAL.Entities();

        public override Task OnConnected()
        {
            var identity = Thread.CurrentPrincipal.Identity;
            var request = Context.Request;

            Groups.Add(Context.ConnectionId, identity.Name);

            Clients.Caller.SendMessage("System", "Sys_Admin", "Hello " + identity.Name + " Your connection ID is " + Context.ConnectionId);
            Clients.Caller.SendMessage("System", "Sys_Admin", "Chat has Started sucessfully");

            return base.OnConnected();
        }

        public void Send(string connID, string username, string message)
        {
            var dCon = new UserCon();

            Clients.Group(connID).SendMessage(username, username, message);

            Clients.Caller.SendMessage(connID, username, message);
        }
    }
}
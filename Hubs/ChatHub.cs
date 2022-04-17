using System;
using System.Web;
using System.Threading.Tasks;
using ajima_masterchat.Pages;
using Microsoft.AspNetCore.SignalR;
namespace ajima_masterchat.Server.Hubs
{
    public class ChatHub : Hub
    {
        public void SendMessage(Message message)
        {
            // Call the addNewMessageToPage method to update clients.
            Clients.All.SendAsync("Recieved message", message);
        }
    }
}
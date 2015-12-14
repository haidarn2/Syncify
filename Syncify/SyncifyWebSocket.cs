using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace Syncify
{
    public class SyncifyWebSocket : WebSocketBehavior
    {
        protected override void OnOpen()
        {
            Console.WriteLine("Client as connected.");
            //base.OnOpen();
        }

        protected override void OnClose(CloseEventArgs e)
        {
            Console.WriteLine("Connection to a client closed.");
        }

        protected override void OnMessage(MessageEventArgs e)
        {
            Console.WriteLine("Client says: " + e.Data);
        }
        protected override void OnError(ErrorEventArgs e)
        {
            base.OnError(e);
        }
    }
}

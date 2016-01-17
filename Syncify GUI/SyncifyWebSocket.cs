using WebSocketSharp;
using WebSocketSharp.Server;

namespace Syncify_GUI
{
    public class SyncifyWebSocket : WebSocketBehavior
    {
        protected override void OnOpen()
        {
            //Console.WriteLine("Client as connected.");
            //base.OnOpen();
        }

        protected override void OnClose(CloseEventArgs e)
        {
            //Console.WriteLine("Connection to a client closed.");
        }

        protected override void OnMessage(MessageEventArgs e)
        {
            //Console.WriteLine("Client says: " + e.Data);
        }
        protected override void OnError(ErrorEventArgs e)
        {
            base.OnError(e);
        }
    }
}
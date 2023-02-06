using System.Net.Sockets;

namespace chatroom_server
{
    internal class Usuario
    {
        Socket s;
        string alias;

        public Usuario(Socket s)
        {
            this.s = s;
            this.alias = "anon";
        }
    }
}

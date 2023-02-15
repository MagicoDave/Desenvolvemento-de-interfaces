using System.Net.Sockets;

namespace chatroom_server
{
    internal class Usuario
    {
        private Socket s;
        private string alias;

        public Socket Socket
        {
            set { s = value; }
            get { return s; }
        }

        public string Alias
        {
            set { alias = value; }
            get { return alias;}
        }

        public Usuario(Socket s)
        {
            this.s = s;
            this.alias = "anon";
        }
    }
}

using System.Net;
using System.Net.Sockets;

namespace chatroom_server
{
    internal class Usuario
    {
        private Socket s;
        private string alias;
        private string aliasCompleto;
        private bool registrado;
        private bool conectado;

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

        public string AliasCompleto
        {
            set { aliasCompleto = value; }
            get { return aliasCompleto; }
        }

        public bool EstaRegistrado
        {
            set { registrado = value; }
            get { return registrado;}
        }

        public bool EstaConectado
        {
            set { conectado = value; }
            get { return conectado;}
        }

        public Usuario(Socket s)
        {
            this.s = s;
            this.alias = "anon";
            this.aliasCompleto = alias + "@" + (s.RemoteEndPoint as IPEndPoint).Address.ToString();
            this.registrado = false;
            this.conectado = true;
        }
    }
}

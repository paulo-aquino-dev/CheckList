using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckList.control
{
    public class DadosUsuario
    {
        private static string nome;
        private static string login;
        private static string pa;
        private static string localizacao;
        private static string hostname;
        private static string turno;

        public static string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public static string Login
        {
            get { return login; }
            set { login = value; }
        }
        public static string PA
        {
            get { return pa; }
            set { pa = value; }
        }
        public static string Localizacao
        {
            get { return localizacao; }
            set { localizacao = value; }
        }
        public static string Hostname
        {
            get { return hostname; }
            set { hostname = value; }
        }
        public static string Turno
        {
            get { return turno; }
            set { turno = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckList.control
{
    public class dadosUsuario
    {
        private static string nome;
        private static string matricula;
        private static string pa;
        private static string logon;


        public static string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public static string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        public static string PA
        {
            get { return pa; }
            set { pa = value; }
        }
        public static string Logon
        {
            get { return logon; }
            set { logon = value; }
        }
    }
}

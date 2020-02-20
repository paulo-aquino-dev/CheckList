using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckList.control
{
    public class Usuarios
    {
        private static string nome = "paulo";
        private static int idade = 20;
       
        public static string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public static int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
    }
}

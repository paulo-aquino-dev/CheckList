﻿using System;
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
    }
}

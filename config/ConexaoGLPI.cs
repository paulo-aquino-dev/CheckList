using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckList.config
{
    class ConexaoGLPI
    {
        public static MySqlConnection objCnx = new MySqlConnection();

        public static MySqlCommand objCmd = new MySqlCommand();

        public static MySqlDataReader objFunc;

        public static string conexao = "Server=172.21.0.25;Database=db_facilities;User=ti;Pwd=123;";
    }
}

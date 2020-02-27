using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace CheckList.config
{
    public class Usuarios
    {
        public static MySqlConnection objCnx = new MySqlConnection();

        public static MySqlCommand objCmd = new MySqlCommand();

        public static MySqlDataReader objFunc;

        public static string conexao = "Server=172.21.0.40;Database=winover;User=root;Pwd=winover;";

    }
}

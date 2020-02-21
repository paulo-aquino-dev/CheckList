using CheckList.control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CheckList.config;

namespace CheckList.view
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                //CONEXAO BD LOGIN/LOGOUT
                Conexao.objCnx.ConnectionString = Conexao.conexao;

                //ABRE A CONEXAO COM O BANCO
                Conexao.objCnx.Open();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro ==> " + Erro.Message, "Erro ao Conectar ao Banco de Dados",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string strSql = "SELECT nome FROM funcionarios WHERE matricula = 2191";

            //conexão com o comando
            Conexao.objCmd.Connection = Conexao.objCnx;
            //Atribui o comando
            Conexao.objCmd.CommandText = strSql;
            //Executa a querry
            Conexao.objFunc = Conexao.objCmd.ExecuteReader();

            if (Conexao.objCnx.State == ConnectionState.Open)
            {
                while (Conexao.objFunc.Read())
                {
                    Console.WriteLine(Conexao.objFunc[0]);
                    MessageBox.Show(Conexao.objFunc[0].ToString());
                }
            }
            txtNome.Text = Usuarios.Nome;
            txtIdade.Text = Usuarios.Idade.ToString();
        }
    }
}

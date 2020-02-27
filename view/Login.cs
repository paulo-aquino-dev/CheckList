using CheckList.view.utils;
using System;
using System.Data;
using System.Windows.Forms;
using Message = CheckList.view.utils.Message;

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
                config.Usuarios.objCnx.ConnectionString = config.Usuarios.conexao;


                //ABRE A CONEXAO COM O BANCO
                config.Usuarios.objCnx.Open();
            }
            catch (Exception Erro)
            {
                Msg formMsg2 = new Msg();
                Message.Msg = "ERRO: " + Erro.Message;
                Message.Icone = "ERRO";
                formMsg2.ShowDialog();
            }

            string strSql = "SELECT nome FROM funcionarios WHERE matricula = 2191";

            //conexão com o comando
            config.Usuarios.objCmd.Connection = config.Usuarios.objCnx;
            //Atribui o comando
            config.Usuarios.objCmd.CommandText = strSql;
            //Executa a querry
            config.Usuarios.objFunc = config.Usuarios.objCmd.ExecuteReader();

            if (config.Usuarios.objCnx.State == ConnectionState.Open)
            {
                while (config.Usuarios.objFunc.Read())
                {
                    Console.WriteLine(config.Usuarios.objFunc[0]);
                    //MessageBox.Show(Conexao.objFunc[0].ToString());
                    //MessageBox.Show(winoverDataSet.funcionarios.nomeColumn.);:
                }
                //txtNome.Text = Usuarios.Nome;
                //txtIdade.Text = Usuarios.Idade.ToString();
            }
        }

        private void TxtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.isPassword = true;
        }

        private void BtnVerSenha_MouseHover(object sender, EventArgs e)
        {
            txtSenha.isPassword = false;
        }

        private void BtnLogar_Click(object sender, EventArgs e)
        {
            Msg formMsg = new Msg();
            Message.Msg = "Login Correto: Bem Vindo ";
            Message.Icone = "OK";
            formMsg.ShowDialog();
        }


    }
}
using CheckList.config;
using CheckList.control;
using System;
using System.Data;
using System.Windows.Forms;

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
            // TODO: esta linha de código carrega dados na tabela 'winoverDataSet.funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            //this.funcionariosTableAdapter.Fill(this.winoverDataSet.funcionarios);

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
                    //MessageBox.Show(Conexao.objFunc[0].ToString());
                    //MessageBox.Show(winoverDataSet.funcionarios.nomeColumn.);:
                }
                //txtNome.Text = Usuarios.Nome;
                //txtIdade.Text = Usuarios.Idade.ToString();
            }
        }

        private void PnlLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.isPassword = true;
        }

        private void BtnVerSenha_MouseHover(object sender, EventArgs e)
        {
            txtSenha.isPassword = false;
        }

        
    }
}
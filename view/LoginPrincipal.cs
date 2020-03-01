using CheckList.view.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Message = CheckList.view.utils.Message;

namespace CheckList.view
{
    public partial class LoginPrincipal : Form
    {
        public LoginPrincipal()
        {
            InitializeComponent();
        }
        int i = 0;
        private void LoginPrincipal_Load(object sender, EventArgs e)
        {
            string data = DateTime.Now.ToString("yyyy-MM-dd");

            //PEGA O HOSTNAME
            string hostMaquina = Dns.GetHostName();

            timerPgb.Start();
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

            string strSql = "select distinct hostname from logs  where datetime like '2020-02-29 %' and hostname like '" + hostMaquina+ " %' and acao = 'ip'";

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
                    string hostname = config.Usuarios.objFunc[0].ToString();
                    var teste = hostname.Split(' ');
                    hostname = teste[0];
                    Console.WriteLine(hostname);

                    //string hostname2 = "WOCCOP0001";
                    //if(hostname.Contains("WOCCOP")){
                    //    string teste = hostname.Substring(6);
                    //    string localizacao = "PA" + teste;
                    //    Console.WriteLine(localizacao);
                    //}
                    //MessageBox.Show(Conexao.objFunc[0].ToString());
                    //MessageBox.Show(winoverDataSet.funcionarios.nomeColumn.);:
                }
                //txtNome.Text = Usuarios.Nome;
                //txtIdade.Text = Usuarios.Idade.ToString();
            }
        }

        private void TimerPgb_Tick(object sender, EventArgs e)
        {
            if (i <=100)
            {
                pgbLogin.Value = i;
                i += 2;
                if ((i < 2))
                {
                    lblVerificacao.Text = "Validando Quem Está Logado na P.A.";
                }
                else if (i < 25)
                {
                    lblVerificacao.Text = "Validando Quem Está Logado na P.A..";
                }
                else if (i < 45)
                {
                    lblVerificacao.Text = "Validando Quem Está Logado na P.A...";
                }
                else if (i < 65)
                {
                    lblVerificacao.Text = "Validando Quem Está Logado na P.A.";
                }
                else if (i < 80)
                {
                    lblVerificacao.Text = "Validando Quem Está Logado na P.A..";
                }
                else if (i >= 90)
                {
                    lblVerificacao.Text = "Validando Quem Está Logado na P.A...";
                }
            }
        }
    }
}

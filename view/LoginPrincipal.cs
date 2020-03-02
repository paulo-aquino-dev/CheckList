using CheckList.view.utils;
using System;
using System.Data;
using System.Net;
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
        string nome = "";
        string PA = "";
        private void LoginPrincipal_Load(object sender, EventArgs e)
        {
            string data = DateTime.Now.ToString("yyyy-MM-dd");

            //PEGA O HOSTNAME
            string hostMaquina = Dns.GetHostName();

            string matricula = "";

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

            string strSql = "select distinct hostname, matricula from logs  where datetime like '" + data + " %' and hostname like '" + hostMaquina + " %' and acao = 'ip'";

            //conexão com o comando
            config.Usuarios.objCmd.Connection = config.Usuarios.objCnx;
            //Atribui o comando
            config.Usuarios.objCmd.CommandText = strSql;
            //Executa a querry
            config.Usuarios.objFunc = config.Usuarios.objCmd.ExecuteReader();

            if (config.Usuarios.objCnx.State == ConnectionState.Open)
            {
                config.Usuarios.objFunc.Read();
                if (config.Usuarios.objFunc.HasRows)
                {
                    string hostname = config.Usuarios.objFunc[0].ToString();
                    matricula = config.Usuarios.objFunc[1].ToString();
                    var teste = hostname.Split(' ');
                    hostname = teste[0];
                    Console.WriteLine(hostname + " " + matricula);
                    Console.WriteLine(data);
                    config.Usuarios.objCnx.Close();
                    try
                    {
                        //CONEXAO BD LOGIN/LOGOUT
                        config.Usuarios.objCnx.ConnectionString = config.Usuarios.conexao;
                        //ABRE A CONEXAO COM O BANCO
                        config.Usuarios.objCnx.Open();

                        strSql = "select distinct nome, matricula from funcionarios where matricula = " + matricula + ";";

                        //conexão com o comando
                        config.Usuarios.objCmd.Connection = config.Usuarios.objCnx;
                        //Atribui o comando
                        config.Usuarios.objCmd.CommandText = strSql;
                        //Executa a querry
                        config.Usuarios.objFunc = config.Usuarios.objCmd.ExecuteReader();

                        config.Usuarios.objFunc.Read();

                        nome = config.Usuarios.objFunc[0].ToString();
                        Console.WriteLine(nome);
                    }
                    catch (Exception Erro)
                    {
                        Msg formMsg2 = new Msg();
                        Message.Msg = "ERRO: " + Erro.Message;
                        Message.Icone = "ERRO";
                        formMsg2.ShowDialog();
                    }
                    if (hostname.Contains("WOCCOP"))
                    {
                        PA = "PA" + hostname.Substring(6);
                        Console.WriteLine(PA);
                    }
                    else if (hostname.Contains("WOCCDTI"))
                    {
                        PA = "MAQUINA TI " + hostname.Substring(7);
                        Console.WriteLine(PA);
                    }
                }
                else
                {
                    Msg formMsg2 = new Msg();
                    Message.Msg = "ERRO: USUÁRIO NÃO ENCONTRADO! FAVOR EFETUAR O LOGIN!";
                    Message.Icone = "ERRO";
                    formMsg2.ShowDialog();
                }
            }
        }

        private void TimerPgb_Tick(object sender, EventArgs e)
        {
            if (i <= 100)
            {
                pgbLogin.Value = i;
                i += 3;
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
                else if (i < 95)
                {
                    lblVerificacao.Text = "Validando Quem Está Logado na P.A...";
                }
                else if (i > 99)
                {
                    Msg formMsg = new Msg();
                    Message.Msg = "Bem Vindo: " + nome;
                    Message.Icone = "OK";
                    formMsg.ShowDialog();
                    ChkList formCheck = new ChkList();
                    this.Visible = false;
                    formCheck.ShowDialog();
                }
            }
        }

       
    }
}

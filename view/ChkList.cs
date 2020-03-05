using CheckList.config;
using CheckList.control;
using CheckList.view.utils;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Management;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Message = CheckList.view.utils.Message;

namespace CheckList.view
{
    public partial class ChkList : Form
    {
        public ChkList()
        {
            InitializeComponent();
        }
        private const int WM_APPCOMMAND = 0x319;

        //MICROFONE 
        private const int APPCOMMAND_MICROPHONE_VOLUME_MUTE = 24 * 65536;
        private const int APPCOMMAND_MICROPHONE_VOLUME_DOWN = 25 * 65536;
        private const int APPCOMMAND_MICROPHONE_VOLUME_UP = 26 * 65536;

        //HEAD
        private const int APPCOMMAND_VOLUME_MUTE = 8 * 65536;
        private const int APPCOMMAND_VOLUME_DOWN = 9 * 65536;
        private const int APPCOMMAND_VOLUME_UP = 10 * 65536;

        string headDesc = "OK";
        string monitorDesc = "OK";
        string mouseDesc = "OK";
        string tecladoDesc = "OK";
        string dadosChamado = null;

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg,
            IntPtr wParam, IntPtr lParam);

        private void ajustaAudio()
        {
            for (int i = 0; i < 100; i++)
            {
                SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_VOLUME_UP);

                SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_MICROPHONE_VOLUME_UP);
            }
        }

        private void ChkList_Load(object sender, EventArgs e)
        {
            try
            {
                //CONEXAO BD checklist
                ConexaoChecklist.objCnx.ConnectionString = ConexaoChecklist.conexao;
                //ABRE A CONEXAO COM O BANCO
                ConexaoChecklist.objCnx.Open();
            }
            catch (Exception Erro)
            {
                Msg formMsg2 = new Msg();
                Message.Msg = "ERRO: " + Erro.Message;
                Message.Icone = "ERRO";
                formMsg2.ShowDialog();
            }

            //lblUsuario.Text = dadosUsuario.Nome;
            lblUsuario.Text = "USUARIO: " + DadosUsuario.Nome;
            lblPa.Text = DadosUsuario.PA;

            System.Diagnostics.Process.Start("SndVol.exe");

            ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from Win32_SoundDevice");
            String head = "";
            foreach (ManagementObject soundDevice in mos.Get())
            {
                String sDeviceName = soundDevice.GetPropertyValue("Name").ToString();

                if (sDeviceName.Equals("Dispositivo de áudio USB"))
                {
                    head = sDeviceName;
                }
            }
            if (head.Equals(""))
            {
                Msg formMsg = new Msg();
                Message.Msg = "HEADSET DESCONECTADO, FAVOR INFORMAR O SEU SUPERVISOR!";
                Message.Icone = "ERRO";
                formMsg.ShowDialog();
            }
            else
            {
                ajustaAudio();
                Msg formMsg2 = new Msg();
                Message.Msg = "AUDIO AUTOMATICAMENTE AJUSTADO!!!";
                Message.Icone = "OK";
                formMsg2.ShowDialog();
            }
        }

        string headStatus = "";
        string mouseStatus = "";
        string tecladoStatus = "";
        string monitorStatus = "";

        private void BtnHead_Click(object sender, EventArgs e)
        {
            string backColor = btnHead.BackColor.Name;

            var btn = btnHead;

            var lbl = lblHead;

            var cmb = cmbHead;

            if (backColor.Equals("Green"))
            {
                btn.BackColor = Color.Red;
                lbl.Text = "DANIFICADO";
                cmb.Enabled = true;
                lbl.ForeColor = Color.Red;
                headStatus = "DANIFICADO";
            }
            else
            {
                btn.BackColor = Color.Green;
                lbl.Text = "OK";
                cmb.Text = "INFORME O PROBLEMA...";
                cmb.Enabled = false;
                lbl.ForeColor = Color.Green;
                headStatus = "OK";
            }
        }

        private void BtnTeclado_Click(object sender, EventArgs e)
        {
            string backColor = btnTeclado.BackColor.Name;

            var btn = btnTeclado;

            var lbl = lblTeclado;

            var cmb = cmbTeclado;

            if (backColor.Equals("Green"))
            {
                btn.BackColor = Color.Red;
                lbl.Text = "DANIFICADO";
                cmb.Enabled = true;
                lbl.ForeColor = Color.Red;
                tecladoStatus = "DANIFICADO";
            }
            else
            {
                btn.BackColor = Color.Green;
                lbl.Text = "OK";
                cmb.Text = "INFORME O PROBLEMA...";
                cmb.Enabled = false;
                lbl.ForeColor = Color.Green;
                tecladoStatus = "OK";
            }
        }

        private void BtnMouse_Click(object sender, EventArgs e)
        {
            string backColor = btnMouse.BackColor.Name;

            var btn = btnMouse;

            var lbl = lblMouse;

            var cmb = cmbMouse;

            if (backColor.Equals("Green"))
            {
                btn.BackColor = Color.Red;
                lbl.Text = "DANIFICADO";
                cmb.Enabled = true;
                lbl.ForeColor = Color.Red;
                mouseStatus = "DANIFICADO";
            }
            else
            {
                btn.BackColor = Color.Green;
                lbl.Text = "OK";
                cmb.Text = "INFORME O PROBLEMA...";
                cmb.Enabled = false;
                lbl.ForeColor = Color.Green;
                mouseStatus = "OK";
            }
        }

        private void BtnMonitor_Click(object sender, EventArgs e)
        {
            string backColor = btnMonitor.BackColor.Name;

            var btn = btnMonitor;

            var lbl = lblMonitor;

            var cmb = cmbMonitor;

            if (backColor.Equals("Green"))
            {
                btn.BackColor = Color.Red;
                lbl.Text = "DANIFICADO";
                cmb.Enabled = true;
                lbl.ForeColor = Color.Red;
                monitorStatus = "DANIFICADO";
            }
            else
            {
                btn.BackColor = Color.Green;
                lbl.Text = "OK";
                cmb.Text = "INFORME O PROBLEMA...";
                cmb.Enabled = false;
                lbl.ForeColor = Color.Green;
                monitorStatus = "OK";
            }
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            if (headStatus.Equals("") || monitorStatus.Equals("") || tecladoStatus.Equals("") || monitorStatus.Equals(""))
            {
                Msg formMsg = new Msg();
                Message.Msg = "FAVOR SELECIONAR TODOS OS CAMPOS";
                Message.Icone = "ERRO";
                formMsg.ShowDialog();
            }
            else
            {
                if (ConexaoChecklist.objCnx.State.Equals(ConnectionState.Open))
                {
                    if (headStatus.Equals("DANIFICADO"))
                    {
                        headDesc = cmbHead.SelectedItem.ToString();
                        dadosChamado += " HEADSET: " + cmbHead.SelectedItem.ToString(); ;
                    }
                    if (monitorStatus.Equals("DANIFICADO"))
                    {
                        monitorDesc = cmbMonitor.SelectedItem.ToString();
                        dadosChamado += " MONITOR: " + cmbMonitor.SelectedItem.ToString(); ;
                    }
                    if (mouseStatus.Equals("DANIFICADO"))
                    {
                        mouseDesc = cmbMouse.SelectedItem.ToString();
                        dadosChamado += " MOUSE: " + cmbMouse.SelectedItem.ToString(); ;
                    }
                    if (tecladoStatus.Equals("DANIFICADO"))
                    {
                        tecladoDesc = cmbTeclado.SelectedItem.ToString();
                        dadosChamado += " TECLADO: " + cmbTeclado.SelectedItem.ToString(); ;
                    }
                    try
                    {
                        string strSql = "INSERT INTO db_checklist.tb_checklist (chk_id, chk_usuario, chk_hostname ,chk_data, chk_head_status, chk_monitor_status, chk_mouse_status, chk_teclado_status, chk_head_desc, chk_monitor_desc, chk_mouse_desc, chk_teclado_desc)"
                                      + "VALUES (NULL,'" + DadosUsuario.Login + "','" + DadosUsuario.PA + "',NOW(),'" + headStatus + "','" + monitorStatus + "','" + mouseStatus + "','" + tecladoStatus + "', '" + headDesc + "','" + monitorDesc + "','" + mouseDesc + "','" + tecladoDesc + "');";

                        //conexão com o comando
                        ConexaoChecklist.objCmd.Connection = ConexaoChecklist.objCnx;
                        //Atribui o comando
                        ConexaoChecklist.objCmd.CommandText = strSql;
                        ConexaoChecklist.objCmd.ExecuteNonQuery();
                        ConexaoChecklist.objCnx.Close();

                        if (dadosChamado != null)
                        {
                            try
                            {
                                //CONEXAO BD GLPI
                                ConexaoGLPI.objCnx.ConnectionString = ConexaoGLPI.conexao;
                                //ABRE A CONEXAO COM O BANCO
                                ConexaoGLPI.objCnx.Open();
                            }
                            catch (Exception Erro)
                            {
                                Msg formMsg2 = new Msg();
                                Message.Msg = "ERRO: " + Erro.Message;
                                Message.Icone = "ERRO";
                                formMsg2.ShowDialog();
                            }
                            if (ConexaoGLPI.objCnx.State.Equals(ConnectionState.Open))
                            {
                                try
                                {
                                    strSql = "INSERT INTO glpi_tickets (id, name, content, locations_id, itilcategories_id, users_id_lastupdater, status, users_id_recipient ,date_creation,date, date_mod)"
                                           + "VALUES (null, 'BOT CHECKLIST> " + dadosChamado + "', 'OPERADOR: " + DadosUsuario.Login +" || PROBLEMA>" + dadosChamado + "','"
                                           + DadosUsuario.Localizacao + "','763','129', '1', '129', now(),now(),now());";

                                    //conexão com o comando
                                    ConexaoGLPI.objCmd.Connection = ConexaoGLPI.objCnx;
                                    //Atribui o comando
                                    ConexaoGLPI.objCmd.CommandText = strSql;
                                    ConexaoGLPI.objCmd.ExecuteNonQuery();

                                    Msg formMsg3 = new Msg();
                                    Message.Msg = "CHAMADO ABERTO PARA O SETOR DE T.I!";
                                    Message.Icone = "OK";
                                    formMsg3.ShowDialog();
                                }
                                catch (Exception Erro)
                                {
                                    Console.WriteLine(Erro.Message);
                                    Msg formMsg2 = new Msg();
                                    Message.Msg = "ERRO: " + Erro.Message;
                                    Message.Icone = "ERRO";
                                    formMsg2.ShowDialog();
                                }
                            }
                        }
                    }
                    catch (Exception Erro)
                    {
                        Msg formMsgErro = new Msg();
                        Console.WriteLine(Erro.Message);
                        Message.Msg = "ERRO: " + Erro.Message;
                        Message.Icone = "ERRO";
                        formMsgErro.ShowDialog();
                    }
                }
                Msg formMsg = new Msg();
                Message.Msg = "SEU CHECKLIST FOI ENVIADO!!!";
                Message.Icone = "OK";
                formMsg.ShowDialog();
                System.Diagnostics.Process.Start("http://172.21.0.230/eaglle");
                System.Diagnostics.Process.Start("C:\\Olos\\SoftphoneOlos.exe");
                Process.Start("taskkill", "/F /IM SndVol.exe");
                Application.Exit();
            }
        }
    }
}

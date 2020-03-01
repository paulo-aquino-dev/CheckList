using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckList.view.utils
{
    public partial class Msg : Form
    {
        public Msg()
        {
            InitializeComponent();
        }

        private void Msg_Load(object sender, EventArgs e)
        {

            //ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from Win32_Process");
            
            //foreach (ManagementObject process in mos.Get())
            //{
            //    String nome = process.GetPropertyValue("Name").ToString();
            //    String exec = process.GetPropertyValue("ExecutablePath").ToString();
                
            //    Console.WriteLine("NOME PROCESSO = {0} - exec = {1}", nome, exec);
            //}

            fadeMsg.ShowAsyc(this);

            lblTitulo.Text = Message.Icone;
            lblMsg.Text = Message.Msg;
            if (Message.Icone.Equals("ERRO"))
            {
                pcbMsg.Image = Properties.Resources.icone_error;
                lblTitulo.ForeColor = Color.Red;
            }
            else
            {
                pcbMsg.Image = Properties.Resources.icone_ok;
                lblTitulo.ForeColor = Color.Green;
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

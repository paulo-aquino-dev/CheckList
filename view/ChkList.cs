using Bunifu.Framework.UI;
using CheckList.view.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void ChkList_Load(object sender, EventArgs e)
        {
            
        }

        string headStatus = "";
        string mouseStatus = "";
        string tecladoStatus= "";
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
                monitorStatus = "DANIFICADO";
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
                Message.Msg = "Login Correto: Bem Vindo ";
                Message.Icone = "OK";
                formMsg.ShowDialog();

            }
        }
    }
}

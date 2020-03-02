using System;
using System.Drawing;
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

            //fadeMsg.ShowAsyc(this);

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
            
        }

        private void Msg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Close();
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckList.view
{
    public partial class ChkList : Form
    {
        public ChkList()
        {
            InitializeComponent();
        }

        private void BtnHead_Click(object sender, EventArgs e)
        {
            string backColor = btnHead.BackColor.Name;
            Console.WriteLine(backColor);
            if (backColor.Equals("Green"))
            {
                btnHead.BackColor = Color.Red;
                lblHead.Text = "DANIFICADO";
                lblHead.ForeColor = Color.Red;
            }
            else
            {
                btnHead.BackColor = Color.Green;
                lblHead.Text = "OK";
                lblHead.ForeColor = Color.Green;
            }
        }

        private void DpdHead_onItemSelected(object sender, EventArgs e)
        {

        }
    }
}

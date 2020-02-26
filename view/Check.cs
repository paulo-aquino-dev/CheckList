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
    public partial class Check : Form
    {
        public Check()
        {
            InitializeComponent();
        }

        string btnColor = "";

        private void BtnHead_Click(object sender, EventArgs e)
        {
            string backColor = btnHead.BackColor.Name;
            Console.WriteLine(backColor);
            if (backColor.Equals("Green"))
            {
                btnHead.BackColor = Color.Red;
            }
            else
            {
                btnHead.BackColor = Color.Green;
            }
        }
    }
}

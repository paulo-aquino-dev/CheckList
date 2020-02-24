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
    public partial class ListarDados : Form
    {
        public ListarDados()
        {
            InitializeComponent();
        }

        private void ListarDados_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'winoverDataSet.funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.winoverDataSet.funcionarios);
        }

  
    }
}

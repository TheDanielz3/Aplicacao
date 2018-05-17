using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCC
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        
        private void buttonGerirClientes_Click(object sender, EventArgs e)
        {
            GerirClientes gerirClientes = new GerirClientes();

            gerirClientes.Show();
        }

        private void buttonGerirCasas_Click(object sender, EventArgs e)
        {
            GerirCasas gerirCasas = new GerirCasas();

            gerirCasas.Show();
        }
    }
}

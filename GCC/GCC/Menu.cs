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
        private GCCDMContainer context;

        public Menu()
        {
            InitializeComponent();

            context = new GCCDMContainer();
        }
        
        private void buttonGerirClientes_Click(object sender, EventArgs e)
        {
            GerirClientes gerirClientes = new GerirClientes(context);

            gerirClientes.Show();
        }

        private void buttonGerirCasas_Click(object sender, EventArgs e)
        {
            GerirCasas gerirCasas = new GerirCasas(context);

            gerirCasas.Show();
        }
    }
}

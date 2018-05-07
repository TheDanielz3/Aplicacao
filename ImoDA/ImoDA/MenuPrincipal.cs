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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void buttonGerirClientes_Click_1(object sender, EventArgs e)
        {
            Gerir_Clientes gerirClientes = new Gerir_Clientes();
            gerirClientes.ShowDialog();
        }

        private void buttonGerirCasas_Click(object sender, EventArgs e)
        {
            Gerir_Casas gerirCasas = new Gerir_Casas();
            gerirCasas.ShowDialog();
        }
    }
}

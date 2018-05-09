using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GCC
{
    public partial class Gerir_Clientes : Form
    {

        public string Nome, NIF, Contacto, Morada;

        public Gerir_Clientes(string Nome, string NIF, string Contacto, string Morada)
        {
            InitializeComponent();

            this.Nome = Nome;
            this.NIF = NIF;
            this.Contacto = Contacto;
            this.Morada = Morada;
        }

        private void buttonGuardarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                string Nome = textBoxNome.Text;
                string 
            }
            catch(Exception)
            {
                MessageBox.Show("Erro", "Erro", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}

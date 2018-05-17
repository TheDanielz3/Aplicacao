using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace GCC
{
    public partial class GerirClientes : Form
    {
        private GCCDMContainer context;

        public GerirClientes()
        {
            InitializeComponent();

            comboBoxCliente.Items.Add("Nome");
            comboBoxCliente.Items.Add("NIF");
            comboBoxCliente.Items.Add("Contacto");
        }

        private void GerirClientes_Load(object sender, EventArgs e)
        {

        }

        //Opções da Combobox Cliente
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxFilterCliente.Text.Length > 0)
                {
                    context = new GCCDMContainer();
                    context.Dispose();

                    if(comboBoxCliente.Text == "Nome")
                    {
                        (from cliente in context.ClienteSet
                         where cliente.Nome.ToUpper().Contains(textBoxFilterCliente.Text.ToUpper())
                         orderby cliente.Nome
                         select cliente).ToList();
                    }
                    else if(comboBoxCliente.Text == "NIF")
                    {
                        (from cliente in context.ClienteSet
                         where cliente.NIF.ToUpper().Contains(textBoxFilterCliente.Text.ToUpper())
                         orderby cliente.NIF
                         select cliente).ToList();
                    }
                    else if(comboBoxCliente.Text == "Contacto")
                    {
                        (from cliente in context.ClienteSet
                         where cliente.Contacto.ToUpper().Contains(textBoxFilterCliente.Text.ToUpper())
                         orderby cliente.Contacto
                         select cliente).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Não existe tal campo", "Em falta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    };
                }
            
            }
            catch(Exception)
            {
                MessageBox.Show("Erro", "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}

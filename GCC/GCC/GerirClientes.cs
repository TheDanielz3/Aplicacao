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

            context = new GCCDMContainer();

            clienteDataGridView.DataSource = context.ClienteSet.ToList();
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

        //Botão Guardar Cliente (inserir na datagridview)
        private void button1_Click(object sender, EventArgs e)
        {
            Cliente tempCliente = new Cliente();

            tempCliente.Nome = nomeTextBox.Text;
            tempCliente.NIF = nIFTextBox.Text;
            tempCliente.Morada = moradaTextBox.Text;
            tempCliente.Contacto = contactoTextBox.Text;

            context.ClienteSet.Add(tempCliente);

            context.SaveChanges();

            clienteDataGridView.DataSource = context.ClienteSet.ToList();

            nomeTextBox.ReadOnly = true;
            nIFTextBox.ReadOnly = true;
            moradaTextBox.ReadOnly = true;
            contactoTextBox.ReadOnly = true;
        }

        //Botão Novo (elimina os valores das textboxes para inserir novo cliente)
        private void button2_Click(object sender, EventArgs e)
        {
            //idClienteTextBox.Text = String.Empty;
            nomeTextBox.Text = String.Empty;
            nIFTextBox.Text = String.Empty;
            contactoTextBox.Text = String.Empty;
            moradaTextBox.Text = String.Empty;

            nomeTextBox.ReadOnly = false;
            nIFTextBox.ReadOnly = false;
            moradaTextBox.ReadOnly = false;
            contactoTextBox.ReadOnly = false;
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente) clienteDataGridView.SelectedRows[0].DataBoundItem;


            //Remover
            context.ClienteSet.Remove(clienteSelecionado);
           
            //salvar
            context.SaveChanges();

            //atualizar
            clienteDataGridView.DataSource = context.ClienteSet.ToList();
        }

        private void clienteDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

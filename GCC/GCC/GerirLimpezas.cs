using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCC
{
    public partial class GerirLimpezas : Form
    {
        private Casa casaselecionada;

        private GCCDMContainer context;

        public GerirLimpezas(Casa casaselecionada,GCCDMContainer context)
        {
            InitializeComponent();
            descricaoComboBox.Items.Add("Limpeza rapida 5€");
            descricaoComboBox.Items.Add("Limpeza completa 10€");


            this.casaselecionada = casaselecionada;
            this.context = context;

            labelNomeCasa.Text = casaselecionada.Localidade.ToString();

            limpezaListBox.DataSource = null;
            limpezaListBox.DataSource = context.LimpezaSet.ToList();
            servicosListBox.DataSource = context.ServicoSet.ToList();

        }

        //Don´t Touch 
        private void idClienteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        //Don´t Touch 
        private void GerirLimpezas_Load(object sender, EventArgs e)
        {

        }

        //Don´t Touch 
        private void moradaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        //Don´t Touch 
        private void moradaLabel_Click(object sender, EventArgs e)
        {

        }

        //Don´t Touch 
        private void contactoLabel_Click(object sender, EventArgs e)
        {

        }

        //Don´t Touch 
        private void nomeLabel_Click(object sender, EventArgs e)
        {

        }

        //Don´t Touch 
        private void contactoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        //Don´t Touch 
        private void nIFTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        //Don´t Touch 
        private void limpezaListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Botao Inserir
        private void buttonInserirServico_Click(object sender, EventArgs e)
        {
            Limpeza limpezaselecionada = (Limpeza)limpezaListBox.SelectedItem;

            Servico servicotemp = new Servico();

            servicotemp.Descricao = Convert.ToString(descricaoComboBox.SelectedIndex);

            limpezaselecionada.Servicos.Add(servicotemp);

            

            servicosListBox.DataSource = null;
            
            context.SaveChanges();

            //update listbox
            servicosListBox.DataSource = null;
            servicosListBox.DataSource = limpezaselecionada.Servicos.ToList();
            
        }
        //Emitir Fatura(need to do)
        private void buttonEmitirFatura_Click(object sender, EventArgs e)
        {
            StreamWriter exportar = new StreamWriter("fatura.txt",true);
            exportar.WriteLine("ola");



            exportar.Close();
        }
        //Criar Fatura
        private void buttonCriar_Click(object sender, EventArgs e)
        {
            Limpeza novaLimpeza = new Limpeza();
            novaLimpeza.Data = dataDateTimePicker.Value.ToString();
            novaLimpeza.Casa = casaselecionada;

            casaselecionada.Limpezas.Add(novaLimpeza);

            context.LimpezaSet.Add(novaLimpeza);
            context.SaveChanges();

            limpezaListBox.DataSource = null;
            limpezaListBox.DataSource = casaselecionada.Limpezas.ToList();
        }
        // Dont touch this
        private void descricaoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

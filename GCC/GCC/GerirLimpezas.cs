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
    public partial class GerirLimpezas : Form
    {
        private GCCDMContainer context;
        private Casa casa;

        public GerirLimpezas(GCCDMContainer context, Casa casa)
        {
            InitializeComponent();
            descricaoComboBox.Items.Add("Limpeza rápida 5€");
            descricaoComboBox.Items.Add("Limpeza completa 10 €");

            this.context = context;
            this.casa = casa;

            labelNomeCasa.Text = casa.Localidade.ToString();
        }

        private void idClienteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GerirLimpezas_Load(object sender, EventArgs e)
        {

        }

        private void moradaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void moradaLabel_Click(object sender, EventArgs e)
        {

        }

        private void contactoLabel_Click(object sender, EventArgs e)
        {

        }

        private void nomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void contactoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nIFTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void limpezaListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Inserir serviço
        private void buttonInserirServico_Click(object sender, EventArgs e)
        {
            Limpeza limpezaSelecionada = (Limpeza)limpezaListBox.SelectedItem;

            Servico tempServico = new Servico();

            tempServico.Descricao = descricaoComboBox.SelectedItem.ToString();

            servicosListBox.DataSource = null;
            servicosListBox.DataSource = limpezaSelecionada.Servicos.ToList();
        }

        //Criar fatura
        private void buttonCriar_Click(object sender, EventArgs e)
        {
            Limpeza novaLimpeza = new Limpeza();

            novaLimpeza.Data = dataDateTimePicker.Value.ToString();

            casa.Limpezas.Add(novaLimpeza);

            limpezaListBox.DataSource = null;
            limpezaListBox.DataSource = casa.Limpezas.ToList();
        }

        //Emitir fatura
        private void buttonEmitirFatura_Click(object sender, EventArgs e)
        {

        }
    }
}

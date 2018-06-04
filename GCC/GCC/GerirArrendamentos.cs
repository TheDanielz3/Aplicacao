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
    public partial class GerirArrendamentos : Form
    {
        private GCCDMContainer context;
        private CasaArrendavel casa;

        public GerirArrendamentos(GCCDMContainer context, CasaArrendavel casa)
        {
            InitializeComponent();

            this.context = context;
            this.casa = casa;

            arrendatarioComboBox.DataSource = context.ClienteSet.ToList();

            labelIdCasa.Text = casa.IdCasa.ToString();
            labelLocalidade.Text = casa.Localidade.ToString();
            labelProprietario.Text = casa.Proprietario.ToString();

            casaArrendavelListBox.DataSource = context.ArrendamentoSet.ToList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void renovavelLabel_Click(object sender, EventArgs e)
        {

        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void GerirArrendamentos_Load(object sender, EventArgs e)
        {

        }

        private void inicioContratoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void duracaoMesesNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void duracaoMesesLabel_Click(object sender, EventArgs e)
        {

        }

        //Inserir arrendamentos
        private void buttonInserirArrendamento_Click(object sender, EventArgs e)
        {
            Arrendamento novoArrendamento = new Arrendamento();
            novoArrendamento.InicioContrato = inicioContratoDateTimePicker.Value.ToString();
            novoArrendamento.DuracaoMeses = duracaoMesesNumericUpDown.Value.ToString();

            if (renovavelCheckBox.Checked)
            {
                novoArrendamento.Renovavel = " Sim ";
            }
            else
            {
                novoArrendamento.Renovavel = " Não ";
            }
            
            novoArrendamento.Arrendatario = ((Cliente)arrendatarioComboBox.SelectedItem);

            context.ArrendamentoSet.Add(novoArrendamento);
            context.SaveChanges();

            casaArrendavelListBox.DataSource = context.ArrendamentoSet.ToList();

            return;
        }

        //Don't touch
        private void renovavelCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        //Don't touch
        private void arrendatarioComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Don't touch
        private void arrendatarioLabel_Click(object sender, EventArgs e)
        {

        }

        //Don't touch
        private void inicioContratoLabel_Click(object sender, EventArgs e)
        {

        }

        //Remover arrendamento
        private void buttonRemoverArrendamento_Click(object sender, EventArgs e)
        {
            Arrendamento casaSelecionada = (Arrendamento)casaArrendavelListBox.SelectedItem;

            context.ArrendamentoSet.Remove(casaSelecionada);
            context.SaveChanges();

            casaArrendavelListBox.DataSource = context.ArrendamentoSet.ToList();
        }
    }
}

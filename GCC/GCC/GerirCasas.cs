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
    public partial class GerirCasas : Form
    {
        private GCCDMContainer context;
        
        public GerirCasas()
        {
            InitializeComponent();
            tipoComboBox.Items.Add("Apatamento");
            tipoComboBox.Items.Add("Casota de cão");
                            

            context = new GCCDMContainer();

            foreach (Cliente cliente in context.ClienteSet)
            {
                proprietarioComboBox.Items.Add(cliente);
            }
        }

        private void numeroLabel_Click(object sender, EventArgs e)
        {

        }

        private void numeroTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void valorComissaoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonNovaCasa_Click(object sender, EventArgs e)
        {
            //limpeza de campos
            localidadeTextBox.Text = String.Empty;
            ruaTextBox.Text = String.Empty;
            numeroNumericUpDown.Value = 0;
            areaNumericUpDown.Value = 0;
            numeroAssoalhadasNumericUpDown.Value = 0;
            numeroWCNumericUpDown.Value = 0;
            numeroPisosNumericUpDown.Value = 0;
            tipoComboBox.Text = String.Empty;
            proprietarioComboBox.Text = String.Empty;
        }

        private void numeroAssoalhadasNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxArrendavel_CheckedChanged(object sender, EventArgs e)
        {
            valorBaseVendaTextBox.ReadOnly = true;
            valorComissaoTextBox.ReadOnly = true;
        }

        private void checkBoxVendavel_CheckedChanged(object sender, EventArgs e)
        {
            valorBaseMesTextBox.ReadOnly = true;
            comissaoTextBox.ReadOnly = true;
        }

        private void buttonGuardarCasa_Click(object sender, EventArgs e)
        {
            Casa tempCasa = new Casa();

            tempCasa.Localidade = localidadeTextBox.Text;
            tempCasa.Rua = ruaTextBox.Text;
            tempCasa.Numero = Convert.ToString(numeroNumericUpDown);
            tempCasa.Area = Convert.ToString(areaNumericUpDown);
            tempCasa.NumeroAssoalhadas = Convert.ToString(numeroAssoalhadasNumericUpDown);
            tempCasa.NumeroWC = Convert.ToString(numeroWCNumericUpDown);
            tempCasa.NumeroPisos = Convert.ToString(numeroPisosNumericUpDown);
            tempCasa.Tipo = tipoComboBox.SelectedIndex.ToString();
            //tempCasa.Proprietario = ;
        }
    }
}

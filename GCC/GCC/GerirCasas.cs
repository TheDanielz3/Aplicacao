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
        
        public GerirCasas(GCCDMContainer context)
        {
            InitializeComponent();
            tipoComboBox.Items.Add("Vivenda");
            tipoComboBox.Items.Add("Vivenda Geminada");
            tipoComboBox.Items.Add("Apartamento");
            tipoComboBox.Items.Add("Mansão");

            this.context = context;
            
            proprietarioComboBox.DataSource = context.ClienteSet.ToList();
            casaDataGridView.DataSource = context.CasaSet.ToList();

            //Fecha as groupboxes
            groupBoxDadosArrendamento.Enabled = false;
            groupBoxDadosVenda.Enabled = false;
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

        //Limpa os campos
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

        //Ao carregar no checkbox arrendavel
        private void checkBoxArrendavel_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxDadosArrendamento.Enabled = false;

            if(checkBoxArrendavel.Checked == true)
            {
                checkBoxVendavel.Checked = false;
                groupBoxDadosArrendamento.Enabled = true;
            }
        }
        
        //Ao carregar no checkbox vendavel
        private void checkBoxVendavel_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxDadosVenda.Enabled = false;

            if(checkBoxVendavel.Checked == true)
            {
                checkBoxArrendavel.Checked = false;
                groupBoxDadosVenda.Enabled = true;
            }
        }

        private void buttonGuardarCasa_Click(object sender, EventArgs e)
        {         
            if(numeroNumericUpDown.Value == 0)
            {
                MessageBox.Show("Indique um valor superior a 0", "Numero", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if(areaNumericUpDown.Value == 0)
            {
                MessageBox.Show("Indique um valor superior a 0", "Area", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(numeroAssoalhadasNumericUpDown.Value == 0)
            {
                MessageBox.Show("Indique um valor superior a 0", "Assoalhadas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(numeroWCNumericUpDown.Value == 0)
            {
                MessageBox.Show("Indique um valor superior a 0", "WC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Caso tipo de casa for apartamento, bloqueia numero de pisos
            if(tipoComboBox.SelectedIndex.ToString() == "Apartamento")
            {
                numeroPisosNumericUpDown.Visible = false;
            }

            
            if(!checkBoxVendavel.Checked && !checkBoxArrendavel.Checked)
            {
                Casa tempCasa = new Casa();

                tempCasa.Localidade = localidadeTextBox.Text;
                tempCasa.Rua = ruaTextBox.Text;
                tempCasa.Numero = Convert.ToString(numeroNumericUpDown.Value);
                tempCasa.Area = Convert.ToString(areaNumericUpDown.Value);
                tempCasa.NumeroAssoalhadas = Convert.ToString(numeroAssoalhadasNumericUpDown.Value);
                tempCasa.NumeroWC = Convert.ToString(numeroWCNumericUpDown.Value);
                tempCasa.NumeroPisos = Convert.ToString(numeroPisosNumericUpDown.Value);
                tempCasa.Tipo = Convert.ToString(tipoComboBox.SelectedIndex);
                tempCasa.Proprietario = ((Cliente)proprietarioComboBox.SelectedItem);

                context.CasaSet.Add(tempCasa);
                context.SaveChanges();

                casaDataGridView.ReadOnly = true;
                casaDataGridView.DataSource = context.CasaSet.ToList();

                return;
            }

           
            if(checkBoxArrendavel.Checked)
            {
                CasaArrendavel tempCasaArrendavel = new CasaArrendavel();

                tempCasaArrendavel.Localidade = localidadeTextBox.Text;
                tempCasaArrendavel.Rua = ruaTextBox.Text;
                tempCasaArrendavel.Numero = Convert.ToString(numeroNumericUpDown.Value);
                tempCasaArrendavel.Area = Convert.ToString(areaNumericUpDown.Value);
                tempCasaArrendavel.NumeroAssoalhadas = Convert.ToString(numeroAssoalhadasNumericUpDown.Value);
                tempCasaArrendavel.NumeroWC = Convert.ToString(numeroWCNumericUpDown.Value);
                tempCasaArrendavel.NumeroPisos = Convert.ToString(numeroPisosNumericUpDown.Value);
                tempCasaArrendavel.Tipo = Convert.ToString(tipoComboBox.SelectedIndex);
                tempCasaArrendavel.Proprietario = ((Cliente)proprietarioComboBox.SelectedItem);
                tempCasaArrendavel.ValorBaseMes = valorBaseMesTextBox.Text;
                tempCasaArrendavel.Comissao = comissaoTextBox.Text;

                context.CasaSet.Add(tempCasaArrendavel);
                context.SaveChanges();

                casaDataGridView.ReadOnly = true;
                casaDataGridView.DataSource = context.CasaSet.ToList();

                return;
            }

            if(checkBoxVendavel.Checked)
            {
                CasaVendavel tempCasaVendavel = new CasaVendavel();

                tempCasaVendavel.Localidade = localidadeTextBox.Text;
                tempCasaVendavel.Rua = ruaTextBox.Text;
                tempCasaVendavel.Numero = Convert.ToString(numeroNumericUpDown.Value);
                tempCasaVendavel.Area = Convert.ToString(areaNumericUpDown.Value);
                tempCasaVendavel.NumeroAssoalhadas = Convert.ToString(numeroAssoalhadasNumericUpDown.Value);
                tempCasaVendavel.NumeroWC = Convert.ToString(numeroWCNumericUpDown.Value);
                tempCasaVendavel.NumeroPisos = Convert.ToString(numeroPisosNumericUpDown.Value);
                tempCasaVendavel.Tipo = Convert.ToString(tipoComboBox.SelectedIndex);
                tempCasaVendavel.Proprietario = ((Cliente)proprietarioComboBox.SelectedItem);
                tempCasaVendavel.ValorBaseVenda = valorBaseVendaTextBox.Text;
                tempCasaVendavel.ValorComissao = valorComissaoTextBox.Text;

                context.CasaSet.Add(tempCasaVendavel);
                context.SaveChanges();

                casaDataGridView.ReadOnly = true;
                casaDataGridView.DataSource = context.CasaSet.ToList();

                return;
            }
        }

        //Botão Gerir_limpezas
        private void button1_Click(object sender, EventArgs e)
        {
            Casa casaSelecionada = (Casa)casaDataGridView.CurrentRow.DataBoundItem;

            GerirLimpezas gerirLimpezas = new GerirLimpezas(context, casaSelecionada);

            gerirLimpezas.Show();
        }

        private void buttonApagarCasa_Click(object sender, EventArgs e)
        {
            Casa casaSelecionada = (Casa) casaDataGridView.CurrentRow.DataBoundItem;

            //Remove
            context.CasaSet.Remove(casaSelecionada);

            context.SaveChanges();

            //Atualiza a datagridview
            casaDataGridView.DataSource = context.CasaSet.ToList();
        }

        private void buttonVerCriarArrendamento_Click(object sender, EventArgs e)
        {
            CasaArrendavel casaSelecionada = (CasaArrendavel) casaDataGridView.CurrentRow.DataBoundItem;

            GerirArrendamentos gerirArrendamentos = new GerirArrendamentos(context, casaSelecionada);

            gerirArrendamentos.Show();
        }

        //Don't touch
        private void groupBoxDadosArrendamento_Enter(object sender, EventArgs e)
        {
        }

        //Don't touch
        private void groupBoxDadosVenda_Enter(object sender, EventArgs e)
        {
        }

        //Abrir form vendas
        private void buttonVerVenda_Click(object sender, EventArgs e)
        {
            CasaVendavel casaSelecionada = (CasaVendavel)casaDataGridView.CurrentRow.DataBoundItem;

            GerirVendas gerirVendas = new GerirVendas(context, casaSelecionada);

            gerirVendas.Show();
        }
    }
}

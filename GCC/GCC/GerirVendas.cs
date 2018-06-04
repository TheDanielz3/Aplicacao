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
    public partial class GerirVendas : Form
    {
        private GCCDMContainer context;
        private CasaVendavel casaSelecionada;
        
        public GerirVendas(GCCDMContainer context, CasaVendavel casaSelecionada)
        {
            InitializeComponent();

            this.context = context;
            this.casaSelecionada = casaSelecionada;
            
            labelProprietarioInfo.Text = casaSelecionada.Proprietario.ToString();
            labelBaseInfo.Text = casaSelecionada.ValorBaseVenda.ToString();
            labelComissaoBaseInfo.Text = casaSelecionada.ValorComissao.ToString();

            compradorComboBox.DataSource = context.ClienteSet.ToList();
            //Passa para lista
            context.VendaSet.ToList();
        }

        private void GerirVendas_Load(object sender, EventArgs e)
        {
            
        }

        //Efetiva a venda da casa
        private void buttonEfetivarVenda_Click(object sender, EventArgs e)
        {
            
            Venda novaVenda = new Venda();

            novaVenda.DataVenda = dataVendaDateTimePicker.Value.ToString();
            novaVenda.ValorNegociado = valorNegociadoTextBox.Text;
            novaVenda.ComissaoNegocio = comissaoNegocioTextBox.Text;
            novaVenda.Comprador = ((Cliente)compradorComboBox.SelectedItem);


            // casaSelecionada.Venda.DataVenda = dataVendaDateTimePicker.Value.ToString();


           casaSelecionada.Venda = novaVenda;
       
            context.SaveChanges();
        }
    }
}

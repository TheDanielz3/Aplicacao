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

            this.context.CasaSet.ToList();
        }
    }
}

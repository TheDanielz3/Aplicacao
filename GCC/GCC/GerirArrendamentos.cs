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

            labelIdCasa.Text = casa.IdCasa.ToString();
            labelLocalidade.Text = casa.Localidade.ToString();
            labelProprietario.Text = casa.Proprietario.ToString();
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
    }
}

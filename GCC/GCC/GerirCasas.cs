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
    }
}

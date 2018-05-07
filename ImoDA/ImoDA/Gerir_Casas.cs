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
    public partial class Gerir_Casas : Form
    {
        public Gerir_Casas()
        {
            InitializeComponent();
        }

        private void buttonGerirLimpezas_Click(object sender, EventArgs e)
        {
            Limpeza formLimpeza = new Limpeza();
            formLimpeza.ShowDialog();
        }
    }
}

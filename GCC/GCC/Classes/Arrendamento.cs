using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCC
{
    public partial class Arrendamento
    {
        public override string ToString()
        {
            return "Início: " + InicioContrato + " " + DuracaoMeses + " meses" + " Renovável: " + Renovavel + "a " + Arrendatario;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCC
{
    public partial class Limpeza
    {
        public override string ToString()
        {
            return "Data" + Data;
        }
        public Decimal Total
        {
            get
            {
                Decimal internoTotal = 0;
                foreach(Servico item in Servicos)
                {
                    internoTotal += Convert.ToDecimal(item.Valor) * Convert.ToDecimal(item.Unidades);
                }
                return internoTotal;
            }
        }
    }
}

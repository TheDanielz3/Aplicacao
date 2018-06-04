using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCC
{
     public partial class Cliente
    {
        public override string ToString()
        {
            return this.Nome + ' ' + '(' + NIF + ')';
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GCC
{
    using System;
    using System.Collections.Generic;
    
    public partial class Servico
    {
        public int IdServico { get; set; }
        public string Descricao { get; set; }
        public string Valor { get; set; }
        public string Unidades { get; set; }
    
        public virtual Limpeza Limpeza { get; set; }
    }
}

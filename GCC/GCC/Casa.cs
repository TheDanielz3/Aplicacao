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
    
    public partial class Casa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Casa()
        {
            this.Limpezas = new HashSet<Limpeza>();
        }
    
        public int IdCasa { get; set; }
        public string Localidade { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Area { get; set; }
        public string NumeroAssoalhadas { get; set; }
        public string NumeroWC { get; set; }
        public string NumeroPisos { get; set; }
        public string Tipo { get; set; }
    
        public virtual Cliente Proprietario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Limpeza> Limpezas { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoSilverLight.Web
{
    using System;
    using System.Collections.Generic;
    
    public partial class PAIS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PAIS()
        {
            this.PROVINCIA = new HashSet<PROVINCIA>();
        }
    
        public decimal CODIGOPAIS { get; set; }
        public string NOMBRE { get; set; }
        public decimal CODIGOPROVINCIA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROVINCIA> PROVINCIA { get; set; }
    }
}

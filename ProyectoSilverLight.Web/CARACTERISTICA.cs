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
    
    public partial class CARACTERISTICA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CARACTERISTICA()
        {
            this.SUBCARACTERISTICAS = new HashSet<SUBCARACTERISTICAS>();
        }
    
        public decimal CODIGOCARAC { get; set; }
        public Nullable<decimal> CODIGOLINEA { get; set; }
        public string NOMBRE { get; set; }
        public decimal CODIGOSUBCARAC { get; set; }
        public decimal CODIGOLINEAPRODUCTO { get; set; }
    
        public virtual LINEAPRODUCTO LINEAPRODUCTO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUBCARACTERISTICAS> SUBCARACTERISTICAS { get; set; }
    }
}

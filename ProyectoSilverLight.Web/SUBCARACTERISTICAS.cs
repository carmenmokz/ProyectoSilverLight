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
    
    public partial class SUBCARACTERISTICAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SUBCARACTERISTICAS()
        {
            this.CARACTERISTICAPRODUCTO = new HashSet<CARACTERISTICAPRODUCTO>();
            this.NAVEGACION = new HashSet<NAVEGACION>();
        }
    
        public decimal CODIGOSUBCARAC { get; set; }
        public Nullable<decimal> CODIGOCARAC { get; set; }
        public string DESCRIPCION { get; set; }
        public decimal CODIGOCARACTPROD { get; set; }
    
        public virtual CARACTERISTICA CARACTERISTICA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CARACTERISTICAPRODUCTO> CARACTERISTICAPRODUCTO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NAVEGACION> NAVEGACION { get; set; }
    }
}

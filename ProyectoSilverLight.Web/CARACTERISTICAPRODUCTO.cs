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
    
    public partial class CARACTERISTICAPRODUCTO
    {
        public decimal CODIGOCARACTPROD { get; set; }
        public Nullable<decimal> CODIGOCARA { get; set; }
        public Nullable<decimal> CODIGOPRODUCTO { get; set; }
        public decimal CODIGOSUBCARAC { get; set; }
    
        public virtual SUBCARACTERISTICAS SUBCARACTERISTICAS { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
    }
}

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
    
    public partial class CIUDAD
    {
        public decimal CODIGOCIUDAD { get; set; }
        public Nullable<decimal> CODIGODISTRITO { get; set; }
        public string NOMBRE { get; set; }
        public string OTRASSEÑAS { get; set; }
        public decimal CODIGODIRECCION { get; set; }
    
        public virtual DISTRITO DISTRITO { get; set; }
    }
}

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
    
    public partial class TARJETA
    {
        public decimal NUMEROTARJETA { get; set; }
        public string IDCLIENTE { get; set; }
        public Nullable<System.DateTime> FCHVENCIMIENTO { get; set; }
    
        public virtual CLIENTE CLIENTE { get; set; }
    }
}

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
    
    public partial class LINEA
    {
        public decimal CODIGOPRODUCTO { get; set; }
        public string DESCRIPCION { get; set; }
        public Nullable<decimal> CANTIDAD { get; set; }
        public decimal CODIGOLINEA { get; set; }
        public string PRECIOXUNIDAD { get; set; }
        public decimal NUMFACTURA { get; set; }
        public Nullable<System.DateTime> FCHPROG { get; set; }
        public Nullable<System.DateTime> FCHREAL { get; set; }
        public Nullable<decimal> ESTADO { get; set; }
        public string IDCLIENTE { get; set; }
        public decimal CODDIRECCION { get; set; }
        public decimal CODCOMPRA { get; set; }
        public decimal CODIGORESPUESTAPERMITIDA { get; set; }
    
        public virtual FACTURA FACTURA { get; set; }
        public virtual RESPUESTACUESTIONARIO RESPUESTACUESTIONARIO { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
    }
}

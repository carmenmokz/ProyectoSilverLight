using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;

namespace ProyectoSilverLight.Web
{
    [DataContract]
    public class clLineaPrecio
    {
        [DataMember]
        public int CODIGOLISTAPRECIO { get; set; } 
        [DataMember]
        public int IDPRODUCTO { get; set; }
        [DataMember]
        public String PRECIO { get; set; }
        [DataMember]
        public int CODIGOPRODUCTO { get; set; }
        [DataMember]
        public String IDCLIENTE { get; set; }

        public clLineaPrecio(int codigolistaprecio, int idproducto, String precio, int codigoproducto, String idcliente)
        {
            this.CODIGOLISTAPRECIO = codigolistaprecio;
            this.IDPRODUCTO = idproducto;
            this.PRECIO = precio;
            this.CODIGOPRODUCTO = codigoproducto;
            this.IDCLIENTE = idcliente;
        }
    }
}
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
    public class clInvProducto
    {
        [DataMember]
        public int IDPRODUCTO { get; set; }
        [DataMember]
        public int IDPROVEEDOR { get; set; }
        [DataMember]
        public String SERIE { get; set; }
        [DataMember]
        public int FACTURA { get; set; }
        [DataMember]
        public int CODIGOPROVEEDOR { get; set; }

        public clInvProducto(int idproducto, int idproveedor, string serie, int factura, int codigoproveedor)
        {
            this.IDPRODUCTO = idproducto;
            this.IDPROVEEDOR = idproveedor;
            this.SERIE = serie;
            this.FACTURA = factura;
            this.CODIGOPROVEEDOR = codigoproveedor;
        }
    }
}
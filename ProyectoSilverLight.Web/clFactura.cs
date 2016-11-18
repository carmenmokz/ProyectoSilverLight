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
    public class clFactura
    {
        [DataMember]
        public int NUMFACTURA { get; set; }
        [DataMember]
        public int CODIGOMONEDA { get; set; }
        [DataMember]
        public DateTime FECHA { get; set; }
        [DataMember]
        public String IDCLIENTE { get; set; }
        [DataMember]
        public int ESTADO { get; set; }
        [DataMember]
        public int CODCOMPRA { get; set; }
        [DataMember]
        public int CODDIRECCION { get; set; }
        [DataMember]
        public int CODIGOPRODUCTO { get; set; }
        [DataMember]
        public int CODIGODIRECCION { get; set; }


        public clFactura(int numfactura, int codmoneda, DateTime fecha, String idcliente, int estado, int codcompra,
                        int coddireccion, int codproducto, int codigodireccion)
        {
            this.NUMFACTURA = numfactura;
            this.CODIGOMONEDA = codmoneda;
            this.FECHA = fecha;
            this.IDCLIENTE = idcliente;
            this.ESTADO = estado;
            this.CODCOMPRA = codcompra;
            this.CODDIRECCION = coddireccion;
            this.CODIGOPRODUCTO = codproducto;
            this.CODIGODIRECCION = codigodireccion;

        }
    }
}
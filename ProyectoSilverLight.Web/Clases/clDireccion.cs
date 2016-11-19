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
    public class clDireccion
    {
        [DataMember]
        public int CODIGODIRECCION { get; set; }
        [DataMember]
        public int CODIGOCIUDAD { get; set;}
        [DataMember]
        public int NUMFACTURA { get; set; } 
        [DataMember]
        public String IDCLIENTE { get; set; }
        [DataMember]
        public int CODCOMPRA { get; set; }

        public clDireccion(int codigodireccion, int codciudad, int numfactura, String idcliente, int codcompra)
        {
            this.CODIGODIRECCION = codigodireccion;
            this.CODIGODIRECCION = codciudad;
            this.NUMFACTURA = numfactura;
            this.IDCLIENTE = idcliente;
            this.CODCOMPRA = codcompra;

        }
    }
}
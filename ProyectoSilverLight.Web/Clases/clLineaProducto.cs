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
    public class clLineaProducto
    {
        [DataMember]
        public int CODIGOLINEAPRODUCTO { get; set; }
        [DataMember]
        public String DESCRIPCION { get; set; }
        [DataMember]
        public int CODIGOCARAC { get; set; }

        public clLineaProducto(int codlineaproducto, String descripcion, int codigocarac)
        {
            this.CODIGOLINEAPRODUCTO = codlineaproducto;
            this.DESCRIPCION = descripcion;
            this.CODIGOCARAC = codigocarac;
        }
    }
}
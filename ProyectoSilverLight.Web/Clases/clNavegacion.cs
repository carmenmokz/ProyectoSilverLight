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
    public class clNavegacion
    {
        [DataMember]
        public int CODIGOCLIENTE { get; set; }
        [DataMember]
        public int CODIGOSUBCARACTERISTICA { get; set; }
        [DataMember]
        public String SITIOVISITADO { get; set; }
        [DataMember]
        public String IDCLIENTE { get; set; }


        public clNavegacion(int codigocliente, int codsubcarac, String sitiovisitado, String idcliente)
        {
            this.CODIGOCLIENTE = codigocliente;
            this.CODIGOSUBCARACTERISTICA = codsubcarac;
            this.SITIOVISITADO = sitiovisitado;
            this.IDCLIENTE = idcliente;
        }
    }
}
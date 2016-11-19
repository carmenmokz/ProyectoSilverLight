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
    public class clMoneda
    {
        [DataMember]
        public int CODIGOMONEDA { get; set; }
        [DataMember]
        public String TIPO { get; set; }

        public clMoneda(int codigomoneda, String tipo)
        {
            this.CODIGOMONEDA = codigomoneda;
            this.TIPO = tipo;
        }
    }
}
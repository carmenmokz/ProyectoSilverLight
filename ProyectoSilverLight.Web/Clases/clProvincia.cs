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
    public class clProvincia
    {
        [DataMember]
        public int CODIGOPROVINCIA { get; set; }
        [DataMember]
        public int CODIGOPAIS { get; set; }
        [DataMember]
        public String NOMBRE { get; set; }
        [DataMember]
        public int CODIGODISTRITO { get; set; }


        public clProvincia(int codigoprovincia, int codigopais, String nombre, int codigodistrito)
        {
            this.CODIGOPROVINCIA = codigoprovincia;
            this.CODIGOPAIS = codigopais;
            this.NOMBRE = nombre;
            this.CODIGODISTRITO = codigodistrito;
        }
    }
}

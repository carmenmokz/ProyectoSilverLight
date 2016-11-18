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
    public class clDistrito {
        [DataMember]
        public int CODIGODISTRITO { get; set; }
        [DataMember]
        public int CODIGOPROVINCIA { get; set; }
        [DataMember]
        public String NOMBRE { get; set; }
        [DataMember]
        public int CODIGOCIUDAD { get; set; }

        public clDistrito(int coddistrito, int codprovincia, String nombre, int codigociudad)
        {
            this.CODIGODISTRITO = coddistrito;
            this.CODIGOPROVINCIA = codprovincia;
            this.NOMBRE = nombre;
            this.CODIGOCIUDAD = codigociudad;

        }
    }
}
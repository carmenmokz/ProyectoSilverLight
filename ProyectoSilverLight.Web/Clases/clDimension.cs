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
    public class clDimension
    {
        [DataMember]
        public int CODIGODIMENSION { get; set; }
        [DataMember]
        public String ANCHO { get; set; }
        [DataMember]
        public String LARGO { get; set; }
        [DataMember]
        public String VOLUMEN { get; set; }
        [DataMember]
        public String PROFUNDIDAD { get; set; }
        [DataMember]
        public int CODIGOPRODUCTO { get; set; }

        public clDimension(int coddimension, String ancho, String largo, String volumen, String profundidad, int codproducto)
        {
            this.CODIGODIMENSION = coddimension;
            this.ANCHO = ancho;
            this.LARGO = largo;
            this.VOLUMEN = volumen;
            this.PROFUNDIDAD = profundidad;
            this.CODIGOPRODUCTO = codproducto;

        }
    }
}
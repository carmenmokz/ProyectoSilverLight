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
    public class Ciudad
    {
        [DataMember]
        public int CODIGOCIUDAD { get; set; }
        [DataMember]
        public int CODIGODISTRITO { get; set; }
        [DataMember]
        public String NOMBRE { get; set; }
        [DataMember]
        public String OTRASSEÑAS { get; set; }
        [DataMember]
        public int CODIGODIRECCION { get; set; }

        public Ciudad(int codciudad, int coddistrito, String nombre, String otrasseñas, int coddireccion)
        {
            this.CODIGOCIUDAD = codciudad;
            this.CODIGODISTRITO = coddistrito;
            this.NOMBRE = nombre;
            this.OTRASSEÑAS = otrasseñas;
            this.CODIGODIRECCION = coddireccion;
            
        }
    }
}
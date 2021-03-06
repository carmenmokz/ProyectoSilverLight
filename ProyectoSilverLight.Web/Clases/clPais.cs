﻿using System;
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
    public class clPais
    {
        [DataMember]
        public int CODIGOPAIS { get; set; }
        [DataMember]
        public String NOMBRE { get; set; }
        [DataMember]
        public int CODIGOPROVINCIA { get; set; }

        public clPais(int codpais, String nombre, int codprovincia)
        {
            this.CODIGOPAIS = codpais;
            this.NOMBRE = nombre;
            this.CODIGOPROVINCIA = codprovincia;
        }
    }
}
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
    public class clSubcaracteristica
    {
        [DataMember]
        public int CODIGOSUBCARAC { get; set; }
        [DataMember] 
        public int CODIGOCARAC { get; set; }
        [DataMember]
        public String DESCRIPCION { get; set; }
        [DataMember] 
        public int CODIGOCARACTPROD { get; set; } 


        public clSubcaracteristica(int codigosubcarac, int codigocarac, String descripcion, int codigocaractprod)
        {
            this.CODIGOSUBCARAC = codigosubcarac;
            this.CODIGOCARAC = codigocarac;
            this.DESCRIPCION = descripcion;
            this.CODIGOCARACTPROD = codigocaractprod;
        }
    }
}
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
    public class clPregunta
    {
        [DataMember]
        public int IDCUESTIOARIO { get; set; } 
        [DataMember]
        public int IDPREGUNTA { get; set; } 
        [DataMember]
        public String PREGUNTA { get; set; }

        public clPregunta(int idcuestionario, int idpregunta, String pregunta)
        {
            this.IDCUESTIOARIO = idcuestionario;
            this.IDPREGUNTA = idpregunta;
            this.PREGUNTA = pregunta;
        }
    }
}
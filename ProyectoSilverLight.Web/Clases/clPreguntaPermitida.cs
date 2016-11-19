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
    public class clPreguntaPermitida
    {
        [DataMember]
        public int IDCUESTIONARIO { get; set; }
        [DataMember]
        public int IDPREGUNTA { get; set; }
        [DataMember]
        public String PREGUNTA { get; set; }
        [DataMember]
        public int IDRESPUESTACUESTIONARIO { get; set; }
        [DataMember]
        public int CODIGOLINEA { get; set; }
        [DataMember]
        public int CODIGORESPUESTAPERMITIDA { get; set; }


        public clPreguntaPermitida(int idcuestionario, int idpregunta, String pregunta, int idrespuestacuestionario,
                                    int codigolinea, int codigorespuestapermitida)
        {
            this.IDCUESTIONARIO = idcuestionario;
            this.IDPREGUNTA = idpregunta;
            this.PREGUNTA = pregunta;
            this.IDRESPUESTACUESTIONARIO = idrespuestacuestionario;
            this.CODIGOLINEA = codigolinea;
            this.CODIGORESPUESTAPERMITIDA = codigorespuestapermitida;
        }
    }
}
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
    public class clRespuestaCuestionario
    {
        [DataMember]
        public int CODIGOLINEA { get; set; }
        [DataMember]
        public int CODIGORESPUESTAPERMITIDA { get; set; }
        [DataMember]
        public String RESPUESTA { get; set; }
        [DataMember]
        public int IDCUESTIONARIO { get; set; }
        [DataMember]
        public int IDPREGUNTA { get; set; }
        [DataMember]
        public String PREGUNTA { get; set; }
        [DataMember]
        public int CODIGOPRODUCTO { get; set; }
        [DataMember]
        public int NUMFACTURA { get; set; }


        public clRespuestaCuestionario(int codigolinea, int codigorespuestapermitida, String respuesta, int idcuestionario,
                                        int idpregunta, String pregunta, int codigoproducto, int numfactura)
        {
            this.CODIGOLINEA = codigolinea;
            this.CODIGORESPUESTAPERMITIDA = codigorespuestapermitida;
            this.RESPUESTA = respuesta;
            this.IDCUESTIONARIO = idcuestionario;
            this.IDPREGUNTA = idpregunta;
            this.PREGUNTA = pregunta;
            this.CODIGOPRODUCTO = codigoproducto;
            this.NUMFACTURA = numfactura;
        }
    }
}

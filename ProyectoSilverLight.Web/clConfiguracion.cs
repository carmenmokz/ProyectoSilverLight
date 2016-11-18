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
    public class clConfiguracion
    {
        [DataMember]
        public int CODIGOVALORESPERMITIDOS { get; set; }
        [DataMember]
        public int CODIGOLINEA { get; set; }
        [DataMember]
        public String CONFIGURACION { get; set; }
        [DataMember]
        public int CODIGOATRIBUTO { get; set; }
        [DataMember]
        public String DESCRIPCION { get; set; }
        [DataMember]
        public int CODIGOPRODUCTO { get; set; }
        [DataMember] 
        public int NUMFACTURA { get; set; } 
);

        public clConfiguracion(int codvalorespermitidos, int codlinea, String configuracion, int codatributo, String descripcion,
                            int codproducto, int numfactura)
        {
            this.CODIGOVALORESPERMITIDOS = codvalorespermitidos;
            this.CODIGOLINEA = codlinea;
            this.CONFIGURACION = configuracion;
            this.CODIGOATRIBUTO = codatributo;
            this.DESCRIPCION = descripcion;
            this.CODIGOPRODUCTO = codproducto;
            this.NUMFACTURA = numfactura;

        }
    }
}
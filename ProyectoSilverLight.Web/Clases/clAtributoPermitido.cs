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
    public class clAtributoPermitido
    {
        [DataMember]
        public int CODIGOATRIBUTO { get; set; }
        [DataMember]
        public String DESCRIPCION { get; set; }

        public clAtributoPermitido(int codatributo, String descripcion)
        {
            this.CODIGOATRIBUTO = codatributo;
            this.DESCRIPCION = descripcion;
        }
    }
}
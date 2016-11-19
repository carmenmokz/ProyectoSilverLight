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
    public class clAtributo
    {
        [DataMember]
        public int CODIGOATRIBUTO { get; set; }
        [DataMember]
        public int CODIGOPRODUCTO { get; set; }

        public clAtributo(int codatributo, int codproducto)
        {
            this.CODIGOATRIBUTO = codatributo;
            this.CODIGOPRODUCTO = codproducto;
        }
    }
}
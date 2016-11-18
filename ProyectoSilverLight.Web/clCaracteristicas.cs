using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;

namespace ProyectoSilverLight.Web
{
    [DataContract]
    public class clCaracteristica
    {
        [DataMember]
        public int CODIGOCARAC { get; set; }
        [DataMember]
        public int CODIGOLINEA { get; set; }
        [DataMember]
        public string NOMBRE { get; set; }
        [DataMember]
        public int CODIGOSUBCARAC { get; set; }
        [DataMember]
        public int CODIGOLINEAPRODUCTO { get; set; }

        public clCaracteristica(int codcarac, int codlinea, string nombre, int codsubcarac, int codLineaProd)
        {
            this.CODIGOCARAC = codcarac;
            this.CODIGOLINEA = codlinea;
            this.NOMBRE = nombre;
            this.CODIGOSUBCARAC = codsubcarac;
            this.CODIGOLINEAPRODUCTO = codLineaProd;
        }
    }
}
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;

namespace ProyectoSilverLight.Web
{
    [DataContract]
    public class CaracteristicaProducto
    {
        [DataMember]
        public int CODIGOCARACTPROD { get; set; }
        [DataMember]
        public int CODIGOCARA { get; set; }
        [DataMember]
        public int CODIGOPRODUCTO { get; set; }
        [DataMember]
        public int CODIGOSUBCARAC { get; set; }
        

        public CaracteristicaProducto(int codcaracprod, int codcara, int codproducto, int codsubcarac)
        {
            this.CODIGOCARACTPROD = codcaracprod; 
            this.CODIGOCARA = codcara;
            this.CODIGOPRODUCTO = codproducto;
            this.CODIGOSUBCARAC = codsubcarac;
            
        }
    }
}
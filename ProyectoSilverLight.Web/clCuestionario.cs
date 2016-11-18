using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;

namespace ProyectoSilverLight.Web
{
    [DataContract]
    public class clCuestionario
    {
        [DataMember]
        public int IDCUESTIONARIO { get; set; }
        [DataMember]
        public string DESCRIPCION { get; set; }
        [DataMember]
        public int IDPREGUNTA { get; set; }

        public clCuestionario(int idcuestionario, string descripcion, int idpregunta)
        {
            this.IDCUESTIONARIO = idcuestionario;
            this.DESCRIPCION = descripcion;
            this.IDPREGUNTA = idpregunta;

        }
    }
}
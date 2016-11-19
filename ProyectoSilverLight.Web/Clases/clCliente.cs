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
    public class clCliente
    {
        [DataMember]
        public String IDCLIENTE { get; set; }
        [DataMember]
        public String NOMBRE { get; set; }
        [DataMember]
        public String APELLIDO1 { get; set; } 
        [DataMember]
        public String APELLIDO2 { get; set; }
        [DataMember]
        public String CORREO { get; set; }
        [DataMember]
        public String IDCLIENTE1 { get; set; } 
        [DataMember]
        public int NUMFACTURA { get; set; }
        [DataMember]
        public int CODDIRECCION { get; set; }
        [DataMember]
        public int CODCOMPRA { get; set; }

        public clCliente(String idcliente, String nombre, String apellido1, String apellido2, String correo, String idcliente1,
                        int numfactura, int coddireccion, int codcompra)
        {
            this.IDCLIENTE = idcliente;
            this.NOMBRE = nombre;
            this.APELLIDO1 = apellido1;
            this.APELLIDO2 = apellido2;
            this.CORREO = correo;
            this.IDCLIENTE1 = idcliente;
            this.NUMFACTURA = numfactura;
            this.CODDIRECCION = coddireccion;
            this.CODCOMPRA = codcompra;

        }
    }
}
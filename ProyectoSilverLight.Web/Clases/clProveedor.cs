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
    public class clProveedor
    {
        [DataMember]
        public int CODIGOPROVEEDOR { get; set; } 
        public String NOMBRE { get; set; }


        public clProveedor(int codigoproveedor, String nombre)
        {
            this.CODIGOPROVEEDOR = codigoproveedor;
            this.NOMBRE = nombre;
        }
    }
}
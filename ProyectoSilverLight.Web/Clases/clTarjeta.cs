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
    public class clTarjeta
    {
        [DataMember]
        public int NUMEROTARJETA { get; set; }
        public String IDCLIENTE { get; set; } 
        public DateTime FCHVENCIMIENTO { get; set; }


        public clTarjeta(int numerotarjeta, String idcliente, DateTime fchvencimiento)
        {
            this.NUMEROTARJETA = numerotarjeta;
            this.IDCLIENTE = idcliente;
            this.FCHVENCIMIENTO = fchvencimiento;
        }
    }
}
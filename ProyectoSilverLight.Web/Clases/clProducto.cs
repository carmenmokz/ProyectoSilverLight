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
    public class clProducto
    {
        [DataMember]
        public int CODIGOPRODUCTO { get; set; }
        [DataMember]
        public int CODIGODIMENSION { get; set; }
        [DataMember]
        public int IDVERSION { get; set; }
        [DataMember]
        public String DESCRIPCION { get; set; }
        [DataMember]
        public String IMAGENHD { get; set; }
        [DataMember]
        public String IMAGEN { get; set; }
        [DataMember]
        public String PESO { get; set; }
        [DataMember]
        public int NUMFACTURA { get; set; }
        [DataMember]
        public int CODIGOCARACTPROD { get; set; }
        [DataMember]
        public int CODIGOLISTAPRECIO { get; set; } 

        public clProducto(int codigoproducto, int codigodimension, int idversion, String descripcion, String imagenhd, 
                            String imagen, String peso, int numfactura, int codigocaractprod, int codigolistaprecio)
        {
            this.CODIGOPRODUCTO = codigoproducto;
            this.CODIGODIMENSION = codigodimension;
            this.IDVERSION = idversion;
            this.DESCRIPCION = descripcion;
            this.IMAGENHD = imagenhd;
            this.IMAGEN = imagen;
            this.PESO = peso;
            this.NUMFACTURA = numfactura;
            this.CODIGOCARACTPROD = codigocaractprod;
            this.CODIGOLISTAPRECIO = codigolistaprecio;
        }
    }
}
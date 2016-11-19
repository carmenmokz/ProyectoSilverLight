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
    public class clLinea
    {
        [DataMember]
        public int CODIGOPRODUCTO { get; set; }
        [DataMember]
        public string DESCRIPCION { get; set; }
        [DataMember]
        public int CANTIDAD { get; set; }
        [DataMember]
        public int CODIGOLINEA {get; set; }
        [DataMember]
        public string PRECIOXUNIDAD { get; set; }
        [DataMember]
        public int NUMFACTURA { get; set; }
        [DataMember]
        public DateTime FCHPROG { get; set; }
        [DataMember]
        public DateTime FCHREAL { get; set; }
        [DataMember]
        public int ESTADO { get; set; } 
        [DataMember]
        public string IDCLIENTE { get; set; }
        [DataMember]
        public int CODDIRECCION { get; set; }
        [DataMember]
        public int CODCOMPRA { get; set; }
        [DataMember]
        public int CODIGORESPUESTAPERMITIDA { get; set; } 

        public clLinea(int codigoproducto, string descripcion, int cantidad, int codigolinea, string precioxunidad,
                        int numfactura, DateTime fchprog, DateTime fchreal, int estado, String idcliente,
                        int coddireccion, int codcompra, int codigorespuestapermitida)
        {
            this.CODIGOPRODUCTO = codigoproducto;
            this.DESCRIPCION = descripcion;
            this.CANTIDAD = cantidad;
            this.CODIGOLINEA = codigolinea;
            this.PRECIOXUNIDAD = precioxunidad;
            this.NUMFACTURA = numfactura;
            this.FCHPROG = fchprog;
            this.FCHREAL = fchreal;
            this.ESTADO = estado;
            this.IDCLIENTE = idcliente;
            this.CODDIRECCION = coddireccion;
            this.CODCOMPRA = codcompra;
            this.CODIGORESPUESTAPERMITIDA = codigorespuestapermitida;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Week4.EsercitazioneFinale.CoreLib.Models
{
    [DataContract]
    public class Ordine
    {
        [DataMember]
        public int OrdineID { get; set; }      

        [DataMember]
        public DateTime DataOrd { get; set; }

        [DataMember]
        public string CodiceOrdine { get; set; }

        [DataMember]
        public string CodiceProd { get; set; }

        [DataMember]
        public Decimal Importo { get; set; }


        [DataMember]
        public int ClienteID { get; set; }

        public Cliente Cliente { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Week4.EsercitazioneFinale.Core.Model
{
    [DataContract]
    class Ordine
    {
        [DataMember]
        public int IDOrdine { get; set; }      

        [DataMember]
        public DateTime DataOrd { get; set; }

        [DataMember]
        public string CodiceOrdine { get; set; }

        [DataMember]
        public string CodiceProd { get; set; }

        [DataMember]
        public Decimal Importo { get; set; }


     //   [DataMember]
    //   public int IDCliente { get; set; }
    }
}

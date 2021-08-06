using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Week4.EsercitazioneFinale.CoreLib.Models
{ 
    [DataContract]
   public class Cliente
    {
        [DataMember]
         public int ClienteID { get;  set; }

        [DataMember]
        public string  CodiceCliente { get; set; }


        [DataMember]
        public string NomeCl { get; set; }


        [DataMember]
        public string CognomeCl { get; set; }


        public IList<Ordine>ListaOrdini { get; set; }
    }
}

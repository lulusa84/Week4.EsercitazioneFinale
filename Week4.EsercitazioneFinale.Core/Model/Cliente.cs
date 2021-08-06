using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Week4.EsercitazioneFinale.Core.Model
{ 
    [DataContract]
   public class Cliente
    {
        [DataMember]
         public int IDCliente { get;  set; }

        [DataMember]
        public string  CodiceCliente { get; set; }


        [DataMember]
        public string NomeCl { get; set; }


        [DataMember]
        public string CognomeCl { get; set; }
    }
}

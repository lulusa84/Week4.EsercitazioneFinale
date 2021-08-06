using Week4.EsercitazioneFinale.CoreLib.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Week4.EsercitazioneFinale.CoreLib.Interfaces
{
    interface IOrdineBL
    {

        #region Ordine

        IEnumerable<Ordine> FetchOrdini(Func<Ordine, bool> filter = null);
        bool AddOrdineByCliente(int ClienteID, Ordine newOrder);

        bool UpdateOrdine(int OrdineID);
        bool AnnullamentoOrdineByUser(int ClienteID, int OrdineID);

        #endregion
    }
}

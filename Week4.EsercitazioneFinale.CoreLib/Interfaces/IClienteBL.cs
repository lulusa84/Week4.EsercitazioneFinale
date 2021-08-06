using Week4.EsercitazioneFinale.CoreLib.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Week4.EsercitazioneFinale.CoreLib.Interfaces
{
    interface IClienteBL
    {
        #region Cliente

        IEnumerable<Cliente> FetchClienti(Func<Cliente, bool> filter = null);
        bool CreateCliente(Cliente newCliente);
        bool EditCliente(Cliente editedCliente);
        bool DeleteClienteByID(int ClienteID);

        #endregion
    }
}

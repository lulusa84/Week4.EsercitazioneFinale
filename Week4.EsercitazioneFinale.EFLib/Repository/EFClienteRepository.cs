using Week4.EsercitazioneFinale.CoreLib.Interfaces;
using Week4.EsercitazioneFinale.CoreLib.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4.EsercitazioneFinale.EFLib.Repository
{
    class EFClienteRepository : IClienteRepository
    {
        private readonly OrdiniContext ctx;

        public EFClienteRepository() : this(new OrdiniContext()) { }

        public EFClienteRepository(OrdiniContext ctx)
        {
            this.ctx = ctx;
        }


        public bool Add(Cliente newCliente)
        {
            if (newCliente == null)
                return false;

            try
            {
                ctx.Clienti.Add(newCliente);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteById(int ClientiID)
        {
            if (ClientiID <= 0)
                return false;

            try
            {
                var order = ctx.Clienti.Find(ClientiID);

                if (order != null)
                    ctx.Clienti.Remove(order);

                ctx.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



        public List<Cliente> Fetch()
        {
            try
            {
                return ctx.Clienti.ToList();
            }
            catch (Exception)
            {
                return new List<Cliente>();
            }
        }

        public Cliente GetByID(int ClienteID)
        {
            if (ClienteID <= 0)
                return null;

            return ctx.Clienti.Find(ClienteID);
        }


        public bool Update(Cliente updatedCliente)
        {
            if (updatedCliente == null)
                return false;

            try
            {
                ctx.Clienti.Update(updatedCliente);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


    } 
}

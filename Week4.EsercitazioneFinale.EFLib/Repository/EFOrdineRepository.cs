using Week4.EsercitazioneFinale.CoreLib.Interfaces;
using Week4.EsercitazioneFinale.CoreLib.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Week4.EsercitazioneFinale.EFLib.Repository
{
    public class EFOrdineRepository : IOrdineRepository
    {
        private readonly OrdiniContext ctx;

        public EFOrdineRepository() : this(new OrdiniContext()) { }

        public EFOrdineRepository(OrdiniContext ctx)
        {
            this.ctx = ctx;
        }



        public bool Add(Ordine newOrder)
        {
            if (newOrder == null)
                return false;

            try
            {
                ctx.Ordini.Add(newOrder);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteById(int OrdineID)
        {
            if (OrdineID <= 0)
                return false;

            try
            {
                var order = ctx.Ordini.Find(OrdineID);

                if (order != null)
                    ctx.Ordini.Remove(order);

                ctx.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



        public List<Ordine> Fetch()
        {
            try
            {
                return ctx.Ordini.ToList();
            }
            catch (Exception)
            {
                return new List<Ordine>();
            }
        }

        public Ordine GetByID(int OrdineID)
        {
            if (OrdineID <= 0)
                return null;

            return ctx.Ordini.Find(OrdineID);
        }





        public bool Update(Ordine updatedOrder)
        {
            if (updatedOrder == null)
                return false;

            try
            {
                ctx.Ordini.Update(updatedOrder);
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

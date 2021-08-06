using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Week4.EsercitazioneFinale.CoreLib.Models;

namespace Week4.EsercitazioneFinale.EFLib.Configuration
{
    class ClienteConfig : IEntityTypeConfiguration<Cliente>, IEntityTypeConfiguration<Ordine>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder
                .HasKey(b => b.ClienteID);
               
            builder
                .Property(b => b.CodiceCliente)
                .HasMaxLength(20)
                .IsRequired();

            builder
                .Property(b => b.NomeCl)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(b => b.CognomeCl)
                .HasMaxLength(50)
                .IsRequired();

            builder
                 .HasMany<Ordine>(x => x.ListaOrdini)
                 .WithOne(b => b.Cliente);
        }

        public void Configure(EntityTypeBuilder<Ordine> builder)
        {
            builder
                .HasKey(b => b.OrdineID);

            builder
                .Property(b => b.CodiceOrdine)
                .HasMaxLength(20)
                .IsRequired();

            builder
                .Property(b => b.DataOrd)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(b => b.CodiceProd)
                .HasMaxLength(50)
                .IsRequired();

            builder
               .Property(b => b.Importo)
               .HasMaxLength(50)
               .IsRequired();

            
        }

        
    }
    }


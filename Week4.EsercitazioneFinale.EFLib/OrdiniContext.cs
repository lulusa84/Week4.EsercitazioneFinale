using Week4.EsercitazioneFinale.EFLib.Configuration;
using Week4.EsercitazioneFinale.CoreLib.Models;
using Microsoft.EntityFrameworkCore;
using System;


namespace Week4.EsercitazioneFinale.EFLib
{
    public class OrdiniContext : DbContext
    {
    
            public DbSet<Cliente> Clienti { get; set; }
            public DbSet<Ordine> Ordini { get; set; }
            public OrdiniContext() : base()
            {

            }

            public OrdiniContext(DbContextOptions<OrdiniContext> options)
                : base(options)
            {

            }
            protected override void OnConfiguring(DbContextOptionsBuilder options)
            {
                if (!options.IsConfigured)
                {
                    string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=OrdiniDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    options.UseSqlServer(connectionString);
                }
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.ApplyConfiguration<Cliente>(new ClienteConfig());
                modelBuilder.ApplyConfiguration<Ordine>(new ClienteConfig());
        }
        }
}

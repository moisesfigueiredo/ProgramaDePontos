using Domain.EnderecosEntrega;
using Domain.Produtos;
using Domain.Resgates;
using Domain.SaldosPontos;
using Domain.Usuarios;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra
{
    public class ProjetoDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<EnderecoEntrega> EnderecoEntregas { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Resgate> Resgates { get; set; }
        public DbSet<SaldoPonto> SaldosPontos { get; set; }

        public ProjetoDbContext(DbContextOptions options) : base(options)
        {

        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Usuario>().HasOne(x => x.EnderecoEntrega);
        //}
    }
}
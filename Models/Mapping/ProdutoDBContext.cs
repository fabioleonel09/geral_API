using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using geralAPI.Configuracoes;

namespace geralAPI.Models.Mapping
{
    public class ProdutoDBContext : DbContext
    {
        public ProdutoDBContext() : base(GetConnectionStringFromConfig())
        {
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapeamento_1_N.Domain;

namespace Mapeamento_1_N.Data
{
    public class LojaDbContext:DbContext
    {
        public LojaDbContext() : base("Name=LojaDB")
        {
            Database.SetInitializer<LojaDbContext>(new CreateDatabaseIfNotExists<LojaDbContext>());
            Database.Initialize(false);
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
    }
}

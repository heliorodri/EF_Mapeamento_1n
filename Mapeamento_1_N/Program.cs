using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapeamento_1_N.Data;
using Mapeamento_1_N.Domain;

namespace Mapeamento_1_N
{
    class Program
    {
        static void Main(string[] args)
        {
            LojaDbContext lDB = new LojaDbContext();
            Produto p = new Produto
            {
                Nome = "Tenis",
                idMarca = 1,
                Preco = 250.00M
            };

            lDB.Produtos.Add(p);
            lDB.SaveChanges();

        }
    }
}

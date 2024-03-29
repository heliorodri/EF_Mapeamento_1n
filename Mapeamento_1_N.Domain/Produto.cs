﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mapeamento_1_N.Domain
{
    [Table("Produtos")]
    public class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        [ForeignKey("Marca")]
        public int idMarca { get; set; }

        public virtual Marca Marca { get; set; }
    }
}

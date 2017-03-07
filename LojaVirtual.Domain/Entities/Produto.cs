using LojaVirtualDB;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtual.Domain.Entities
{
    [Table("TbProduto")]
    public class Produto
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(50)]
        public string Nome { get; set; }

        [MaxLength(300)]
        public string Descricao { get; set; }

        public decimal Preco { get; set; }

        [MaxLength(30)]
        public string Categoria { get; set; }

        public IEnumerable<Produto> Produtos
        {
            get
            {
                using (LojaVirtualContext conn = new LojaVirtualContext())
                {
                    return conn.Produtos.ToList();
                }
            }
        }


    }
}

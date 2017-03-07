using LojaVirtual.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtualDB
{
    public class LojaVirtualContext:DbContext
    {
        public LojaVirtualContext() : base("LojaVirtualDB")
        { }

        public DbSet<Produto> Produtos { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }
    }
}

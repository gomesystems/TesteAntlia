using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using DDDProject.Domain.Entities;

namespace DDDProject.Infra.Data.EntityConfig
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            ToTable("Produto");
            HasKey(c => c.COD_PRODUTO);
            Property(c => c.COD_PRODUTO).HasMaxLength(4).IsRequired();
            Property(c => c.DES_PRODUTO).HasMaxLength(30);
            Property(c => c.STA_STATUS).HasMaxLength(1);
        }
    }
}

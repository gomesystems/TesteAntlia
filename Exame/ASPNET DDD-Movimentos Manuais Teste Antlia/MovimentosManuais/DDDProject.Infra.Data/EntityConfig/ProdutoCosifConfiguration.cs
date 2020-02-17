using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using DDDProject.Domain.Entities;

namespace DDDProject.Infra.Data.EntityConfig
{
    public class ProdutoCosifConfiguration : EntityTypeConfiguration<ProdutoCosif>
    {
        public ProdutoCosifConfiguration()
        {
            ToTable("PRODUTO_COSIF");
            HasKey(c => new { c.COD_PRODUTO, c.COD_COSIF });
            Property(c => c.COD_PRODUTO).HasMaxLength(4).IsRequired();
            Property(c => c.COD_COSIF).HasMaxLength(30).IsRequired();
            Property(c => c.COD_CLASSIFICACAO).HasMaxLength(6);
            Property(c => c.STA_STATUS).HasMaxLength(1);
        }
    }
}

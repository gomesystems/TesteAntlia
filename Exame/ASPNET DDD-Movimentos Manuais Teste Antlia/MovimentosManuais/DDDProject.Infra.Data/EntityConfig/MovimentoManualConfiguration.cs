using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using DDDProject.Domain.Entities;

namespace DDDProject.Infra.Data.EntityConfig
{
    public class MovimentoManualConfiguration : EntityTypeConfiguration<MovimentoManual>
    {
        public MovimentoManualConfiguration()
        {
            ToTable("MOVIMENTO_MANUAL");
            HasKey(c => new { c.COD_PRODUTO, c.COD_COSIF, c.DAT_ANO, c.DAT_MES, c.NUM_LANCAMENTO });
            Property(c => c.DAT_MES).IsRequired();
            Property(c => c.DAT_ANO).IsRequired();
            Property(c => c.NUM_LANCAMENTO).IsRequired();
            Property(c => c.COD_PRODUTO).HasMaxLength(4).IsRequired();
            Property(c => c.COD_COSIF).HasMaxLength(11).IsRequired();
            Property(c => c.DES_DESCRICAO).HasMaxLength(8000);
            Property(c => c.COD_USUARIO).HasMaxLength(100);
        }
    }
}

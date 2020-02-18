using System;
using System.Collections.Generic;

namespace DDDProject.Domain.Entities
{
    public class Produto
    {
        public string COD_PRODUTO { get; set; }
        public string DES_PRODUTO { get; set; }
        public string STA_STATUS { get; set; }
        public ICollection<ProdutoCosif> ProdutoCosifs { get; set; }

    }
}

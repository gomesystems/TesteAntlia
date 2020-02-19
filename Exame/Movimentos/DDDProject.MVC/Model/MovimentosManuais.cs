using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DDDProject.MVC.Model
{
    public class MovimentosManuais
    {
        [Key]
        public string COD_COSIF { get; set; }
        public string DAT_MES { get; set; }
        public string DAT_ANO { get; set; }
        public string COD_PRODUTO { get; set; }
        public int NUM_LANCAMENTO { get; set; }
        public string DES_DESCRICAO { get; set; }
        public double VAL_VALOR { get; set; }
        public System.DateTime DAT_MOVIMENTO { get; set; }
        public string COD_USUARIO { get; set; }
    }
}
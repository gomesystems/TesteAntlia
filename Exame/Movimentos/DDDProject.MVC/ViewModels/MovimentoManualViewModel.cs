using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovimentosManuais.MVC.ViewModels
{
    public class MovimentoManualViewModel
    {
        [Key]
        public string NUM_LANCAMENTO { get; set; }
        [MaxLength(250, ErrorMessage = "Maximum {0} characters")]
        [MinLength(3, ErrorMessage = "Minimum {0} characters")]
        public string DAT_MES { get; set; }
        public string DAT_ANO { get; set; }

        public string DES_DESCRICAO { get; set; }

        public virtual MovimentoManualViewModel MovimentoManual { get; set; }
    }
}
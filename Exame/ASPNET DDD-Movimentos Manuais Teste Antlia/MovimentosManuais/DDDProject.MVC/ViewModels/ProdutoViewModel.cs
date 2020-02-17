using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DDDProject.MVC.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int COD_PRODUTO { get; set; }

        [Required(ErrorMessage = "COD_PRODUTO is required")]
        [MaxLength(250, ErrorMessage = "Maximum {4} characters")]
        [MinLength(3, ErrorMessage = "Minimum {1} characters")]
       // public string COD_PRODUTO { get; set; }

       
        public string DES_PRODUTO { get; set; }

        public string STA_STATUS { get; set; }

        public virtual ProdutoViewModel Produto { get; set; }
    }
}
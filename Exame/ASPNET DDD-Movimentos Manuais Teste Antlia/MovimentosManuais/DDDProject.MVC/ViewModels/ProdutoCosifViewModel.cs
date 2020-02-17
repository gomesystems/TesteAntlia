using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DDDProject.MVC.ViewModels
{
    public class ProdutoCosifViewModel
    {
        [Key]
        public string COD_PRODUTO { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [MaxLength(250, ErrorMessage = "Maximum {4} characters")]
        [MinLength(3, ErrorMessage = "Minimum {1} characters")]
        public string COD_COSIF { get; set; }
       
        public string COD_CLASSIFICACAO { get; set; }

        public virtual ProdutoCosifViewModel ProdutoCosif { get; set; }
    }
}
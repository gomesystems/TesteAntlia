//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovimentosManuaisTeste.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class prSelecionaMOVIMENTO_MANUAL_Result
    { [Key]
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
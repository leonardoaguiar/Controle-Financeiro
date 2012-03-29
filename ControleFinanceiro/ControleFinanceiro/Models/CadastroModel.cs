using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ControleFinanceiro.Models
{
    public class CadastroModel
    {
        [Required]
        [StringLength(50)]
        public string Nome {get; set;}

        [Required]
        [StringLength(50)]
        public string Sobrenome {get; set;}

        [Required]
        [StringLength(50)]
        [Display(Name="Código")]
        public int Codigo {get; set;}

        [StringLength(150)]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Data { get; set; }
    }
}
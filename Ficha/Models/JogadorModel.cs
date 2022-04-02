using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ficha.Models
{
    public class JogadorModel
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }
        public string Celular { get; set; }
        
        [Required(ErrorMessage = "E-mail inválido")]
        public string Emai { get; set; }
        public string Personagem { get; set; }
    }
}
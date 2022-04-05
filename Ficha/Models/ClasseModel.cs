using System.ComponentModel.DataAnnotations;

namespace Ficha.Models
{
    public class ClasseModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe o nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe a raça")]
        public string Raca { get; set; }
        [Required(ErrorMessage = "Informe a classe")]
        public string Classe { get; set; }
        [Required(ErrorMessage = "Informe o level")]
        public int Level { get; set; }

    }
}
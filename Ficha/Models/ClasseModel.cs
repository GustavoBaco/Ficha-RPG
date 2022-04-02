using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ficha.Models
{
    public class ClasseModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Raca { get; set; }
        public string Classe { get; set; }
        public int Level { get; set; }

    }
}
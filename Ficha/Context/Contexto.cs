using Ficha.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ficha.Context
{
    public class Contexto : DbContext
    {
        public Contexto() : base("DBficha")
        {

        }

        public DbSet<JogadorModel> Jogador { get; set; }
        public DbSet<ClasseModel> Classe { get; set; }
    }
}
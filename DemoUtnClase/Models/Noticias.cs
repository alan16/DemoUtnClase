using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DemoUtnClase.Models
{
    public class Noticias
    {
        public int Id { get; set; }
        public string Titulo { get; set; }

        public string Subtitulo { get; set; }

        public string descripcion { get; set; }
    }

    public class NoticiasContex : DbContext
    {
        public DbSet<Noticias> noticias { get; set; }
    }
}


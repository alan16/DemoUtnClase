using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DemoUtnClase.Models;

namespace DemoUtnClase.ViewModels
{
    public class Noticiasfacutad
    {
        public List<Noticias> noticias { get; set; }
        public List<Facultad> facultades { get; set; }

        public Noticiasfacutad()
        {            
        }

        public void iniciar() {

            noticias = new List<Noticias>()
            {
                new Noticias() 
                { 
                  Id = 1,
                  Titulo = "Algun Titulo",
                  Subtitulo = "Otro subtitulo",
                  descripcion = "Alguna descripcion" 
                },
                new Noticias()
                {
                  Id = 2,
                  Titulo = "Algun Titulo2",
                  Subtitulo = "Otro subtitulo2",
                  descripcion = "Alguna descripcion2"   
                }
            };

            facultades = new List<Facultad>()
           {
               new Facultad() 
               {
                   Id = 1,
                   Cuidad = "Tucumna",
                   Nombre = "Tucuman",
                   CodigoPostal = 4000 
               },
               new Facultad()
               {    
                   Id = 2,
                   Cuidad = "Tucumna",
                   Nombre = "Tucuman",
                   CodigoPostal = 4000 
               }
           };            
        }
    }
}
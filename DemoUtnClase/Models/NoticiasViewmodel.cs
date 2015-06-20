using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoUtnClase.Models
{
    public class NoticiasViewmodel
    {
        [Required]    
        public int Id { get; set; }
        [Required]
        [StringLength (200,ErrorMessage ="El titulo debe tener menos de 200 palabras",MinimumLength=1) ]    
        public string Titulo { get; set; }
        [StringLength(400, ErrorMessage = "El titulo debe tener menos de 400 palabras", MinimumLength = 1)]    
        public string Subtitulo { get; set; }
        [StringLength(8000, ErrorMessage = "El titulo debe tener menos de 8000 palabras", MinimumLength = 1)]    
        public string Cuerpo { get; set; }
        [DisplayName("Direccion Imagen")]    
        public string DireccionImagen { get; set; }
        [EmailAddressAttribute]
        [DisplayName("Direccion Mail")]    
        public string DireccionMail { get; set; }
        
    }
}
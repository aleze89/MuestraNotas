using System.Collections.Generic;
namespace Notes.Models
{
    public class Usuario
    {
        [key]
        public string Mail {get; set;}   
        [Required]
        public string Nombre {get; set;}   
       
        public List<Nota> Notas {get; set;}   
    }
    
}
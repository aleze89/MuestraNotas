using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotasG5.Models
{
    public class Nota
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Titulo { get; set; }
        public string Cuerpo { get; set; }
        public string Color { get; set; }
        public Usuario Creador { get; set; }
    }
}
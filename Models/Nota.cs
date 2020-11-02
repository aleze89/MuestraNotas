namespace Notes.Models
{
    public class Nota
    {
     [Key]
     [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
     public long ID {get; set;}
     [Required]
     public string Titulo {get; set;}
     
     public string Cuerpo {get; set;}
     
     public Usuario Duenio {get; set;}

    }
    
}
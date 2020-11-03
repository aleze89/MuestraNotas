namespace NotasG5.Models
{
    public class Nota
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public string Cuerpo { get; set; }
        public string Color { get; set; }
        public Usuario Creador { get; set; }
    }
}
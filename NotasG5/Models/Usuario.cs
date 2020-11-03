using System.Collections.Generic;

namespace NotasG5.Models
{
    public class Usuario
    {
        public string Mail { get; set; }
        public string Nombre { get; set; }

        public List<Nota> Notas { get; set; }
    }
}

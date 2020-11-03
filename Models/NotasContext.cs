using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Notes.Models
{
    public class NotasContext : DbContext
    {
        public NotasContext(DbContextOptions<NotasContext> options)
            : base (options)
            { }

            public DbSet<Nota> Notas { get; set; } //toma datos y hace consultas
            public DbSet<Usuario> Usuarios { get; set; }
    }
}
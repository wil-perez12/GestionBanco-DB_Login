using Entidad;
using Microsoft.EntityFrameworkCore;


namespace Data
{
    public class UsuarioContext : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder option) 
        {

            option.UseSqlServer("server= WILNELP12\\SQLEXPRESS; initial catalo= Usuario; " +
                                "integrated securit= true; TrustServerCertificate= tru;");

        }

        public DbSet<Entidad> Usuario { get; set; }
    }
}

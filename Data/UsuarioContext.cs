
using Microsoft.EntityFrameworkCore;
using Entidad;

namespace Data
{
    public class UsuarioContext : DbContext
    {
       
        public DbSet<usuario> usuario { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder option) 
        {

            option.UseSqlServer("Server=WILNELP12\\SQLEXPRESS; Initial Catalog=Login; " +
                    "Integrated Security=True; TrustServerCertificate=True;");

        }

        
        
    }
}

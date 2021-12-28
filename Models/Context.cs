using Microsoft.EntityFrameworkCore;

namespace credita_nelas.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-PFHLVPM;Initial Catalog=CreditaNelas;Integrated Security=True"); // Mude aqui sua conexão (em Data Source)
        }
    }
}

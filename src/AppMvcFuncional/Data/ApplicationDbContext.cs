using Microsoft.EntityFrameworkCore;
using AppMvcFuncional.Models; // Importando o namespace onde a classe Aluno está definida

namespace AppMvcFuncional.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Defina as entidades que você quer mapear
        public DbSet<Aluno> Alunos { get; set; }
    }
}

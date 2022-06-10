using Microsoft.EntityFrameworkCore;
using ProjectSchool_API.Models;

namespace ProjectSchool_API.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
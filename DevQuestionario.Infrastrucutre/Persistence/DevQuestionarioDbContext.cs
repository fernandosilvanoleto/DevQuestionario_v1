using DevQuestionario.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DevQuestionario.Infrastrucutre.Persistence
{
    public class DevQuestionarioDbContext : DbContext
    {
        public DevQuestionarioDbContext(DbContextOptions<DevQuestionarioDbContext> options) : base(options)
        {

        }

        public DbSet<Area> Areas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Questionario> Questionarios { get; set; }
        public DbSet<Pergunta> Perguntas { get; set; }
        public DbSet<QuestionarioPergunta> QuestionarioPerguntas { get; set; }
        public DbSet<Entrevista> Entrevistas { get; set; }
        public DbSet<RespostaUsuario> RespostaUsuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}

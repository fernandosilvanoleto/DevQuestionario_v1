using DevQuestionario.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevQuestionario.Infrastrucutre.Persistence.Configurations
{
    public class PerguntaConfigurations : IEntityTypeConfiguration<Pergunta>
    {
        public void Configure(EntityTypeBuilder<Pergunta> builder)
        {
            builder
                .HasKey(p => p.Id); // PK
        }
    }
}

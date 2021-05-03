using DevQuestionario.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevQuestionario.Infrastrucutre.Persistence.Configurations
{
    public class ClienteConfigurations : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder
                .HasKey(c => c.Id); // DEFININDO CHAVE PRIMÁRIA

        }
    }
}

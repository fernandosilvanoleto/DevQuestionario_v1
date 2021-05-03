using DevQuestionario.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevQuestionario.Infrastrucutre.Persistence.Configurations
{
    public class AreaConfigurations : IEntityTypeConfiguration<Area>
    {
        public void Configure(EntityTypeBuilder<Area> builder)
        {
            builder
                .HasKey(a => a.Id); // PK
        }
    }
}

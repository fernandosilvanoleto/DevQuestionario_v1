using DevQuestionario.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevQuestionario.Infrastrucutre.Persistence.Configurations
{
    public class EntrevistaConfigurations : IEntityTypeConfiguration<Entrevista>
    {
        public void Configure(EntityTypeBuilder<Entrevista> builder)
        {
            builder
                .HasKey(ent => ent.Id); // DEFININDO CHAVE PRIMÁRIA

            builder
                .HasOne(entrevista => entrevista.Entrevistado) // UMA Entrevista É FEITA SOMENTE COM UM CLIENTE POR VEZ
                .WithMany(cliente => cliente.Entrevistas) // UM CLIENTE PODE ESTÁ EM VÁRIAS Entrevistas
                .HasForeignKey(entrevista => entrevista.IdCliente) // FK
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(entrevista => entrevista.Questionario) // UMA Entrevista É FEITA SOMENTE COM UM Questionario POR VEZ
                .WithMany(questionario => questionario.Entrevistas) // UM Questionario PODE ESTÁ EM VÁRIAS Entrevistas
                .HasForeignKey(entrevista => entrevista.IdQuestionario) // FK
                .OnDelete(DeleteBehavior.Restrict);

            //builder
            //    .HasOne(entrevista => entrevista.Area)
            //    .WithMany(area => area.Entrevistas)
            //    .HasForeignKey(entrevista => entrevista.IdArea)
            //    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

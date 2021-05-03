using DevQuestionario.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevQuestionario.Infrastrucutre.Persistence.Configurations
{
    public class RespostaUsuarioConfigurations : IEntityTypeConfiguration<RespostaUsuario>
    {
        public void Configure(EntityTypeBuilder<RespostaUsuario> builder)
        {
            builder
               .HasKey(respuser => respuser.Id); // PK

            builder
                 .HasOne(respuser => respuser.Entrevista)
                .WithMany(entrevista => entrevista.RespostaUsuarios)
                .HasForeignKey(respuser => respuser.IdEntrevista)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                 .HasOne(respuser => respuser.Perguntas)
                .WithMany(pergunta => pergunta.RespostaUsuarios)
                .HasForeignKey(respuser => respuser.IdPergunta)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                 .HasOne(respuser => respuser.Area)
                .WithMany(area => area.RespostaUsuarios)
                .HasForeignKey(respuser => respuser.IdArea)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

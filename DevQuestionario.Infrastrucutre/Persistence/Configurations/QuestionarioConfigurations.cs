using DevQuestionario.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevQuestionario.Infrastrucutre.Persistence.Configurations
{
    public class QuestionarioConfigurations : IEntityTypeConfiguration<Questionario>
    {
        public void Configure(EntityTypeBuilder<Questionario> builder)
        {
            builder
                .HasKey(ques => ques.Id); // DEFININDO CHAVE PRIMÁRIA

            builder
                .HasOne(questionario => questionario.CriadorUsuario) // UM Questionario SOMENTE TEM UM CLIENTE COMO CRIADOR
                .WithMany(cliente => cliente.Questionarios) // UM CLIENTE PODE ESTÁ EM VÁRIOS QUESTIONARIOS
                .HasForeignKey(questionario => questionario.IdCriadorUsuario) // FK
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

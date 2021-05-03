using DevQuestionario.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevQuestionario.Infrastrucutre.Persistence.Configurations
{
    public class QuestionarioPerguntaConfigurations : IEntityTypeConfiguration<QuestionarioPergunta>
    {
        public void Configure(EntityTypeBuilder<QuestionarioPergunta> builder)
        {
            builder
                .HasKey(qp => qp.Id); // PK

            builder
                .HasOne(qp => qp.Perguntas)
                .WithMany(pergunta => pergunta.QuestionarioPerguntas)
                .HasForeignKey(qp => qp.IdPergunta)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(qp => qp.Questionario)
                .WithMany(ques => ques.QuestionarioPerguntas)
                .HasForeignKey(qp => qp.IdQuestionario)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

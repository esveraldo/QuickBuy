using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.Entities.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repository.Config
{
    class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.HasKey(f => f.Id);

            builder.Property(f => f.Nome).IsRequired();
            builder.Property(f => f.Descricao).IsRequired();

            builder.ToTable("FormaPagamento").HasData(
                new FormaPagamento()
                {
                    Id = 1,
                    Nome = "Boleto",
                    Descricao = "Forma de pagamento boleto"
                },

                new FormaPagamento()
                {
                    Id = 2,
                    Nome = "Cartão de credito",
                    Descricao = "Forma de pagamento Cartão de credito"
                },

                new FormaPagamento()
                {
                    Id = 3,
                    Nome = "Depósito",
                    Descricao = "Forma de pagamento Depósito bancário"
                }
            );
        }
    }
}

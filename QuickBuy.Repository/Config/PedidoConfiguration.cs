using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repository.Config
{
    class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.ItensPedido).IsRequired();
            builder.Property(p => p.UsuarioId).IsRequired();

            builder.HasOne(u => u.Usuario);

            builder.HasMany(i => i.ItensPedido).WithOne(p => p.Pedido);

            builder.HasOne(f => f.FormaPagamento);

            builder.HasOne(e => e.Endereco);
        }
    }
}

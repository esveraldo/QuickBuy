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

            builder.Property(p => p.DataPedido).IsRequired();
            builder.Property(p => p.DataPrivisaoEntrega).IsRequired();
            builder.Property(p => p.UsuarioId).IsRequired();
            builder.HasOne(u => u.Usuario);
            builder.HasOne(f => f.FormaPagamento);
            builder.HasOne(e => e.Endereco);
            builder.HasOne(p => p.FormaPagamento);

            builder.HasMany(p => p.ItensPedido).WithOne(i =>i.Pedido);
        }
    }
}

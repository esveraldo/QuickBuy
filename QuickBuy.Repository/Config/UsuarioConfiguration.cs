using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repository.Config
{
    class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Nome).IsRequired();
            builder.Property(u => u.Sobrenome).IsRequired();
            builder.Property(u => u.Senha).IsRequired();

            builder.HasMany(u => u.Pedidos).WithOne(p => p.Usuario);
        }
    }
}

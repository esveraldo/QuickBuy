﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuickBuy.Repository.Data;

namespace QuickBuy.Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200801231216_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QuickBuy.Domain.Entities.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .IsRequired();

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Cidade")
                        .IsRequired();

                    b.Property<string>("EnderecoCompleto")
                        .IsRequired();

                    b.Property<string>("Estado")
                        .IsRequired();

                    b.Property<string>("NumeroEndereco")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("QuickBuy.Domain.Entities.Helpers.FormaPagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("FormaPagamento");

                    b.HasData(
                        new { Id = 1, Descricao = "Forma de pagamento boleto", Nome = "Boleto" },
                        new { Id = 2, Descricao = "Forma de pagamento Cartão de credito", Nome = "Cartão de credito" },
                        new { Id = 3, Descricao = "Forma de pagamento Depósito bancário", Nome = "Depósito" }
                    );
                });

            modelBuilder.Entity("QuickBuy.Domain.Entities.ItemPedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PedidoId");

                    b.Property<int>("ProdutoId");

                    b.Property<int>("Quantidade");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.ToTable("ItemPedidos");
                });

            modelBuilder.Entity("QuickBuy.Domain.Entities.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataPedido");

                    b.Property<DateTime>("DataPrivisaoEntrega");

                    b.Property<int>("EnderecoId");

                    b.Property<int>("FormaPagamentoId");

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.HasIndex("FormaPagamentoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("QuickBuy.Domain.Entities.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("QuickBuy.Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("Senha")
                        .IsRequired();

                    b.Property<string>("Sobrenome")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("QuickBuy.Domain.Entities.ItemPedido", b =>
                {
                    b.HasOne("QuickBuy.Domain.Entities.Pedido", "Pedido")
                        .WithMany("ItensPedido")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("QuickBuy.Domain.Entities.Pedido", b =>
                {
                    b.HasOne("QuickBuy.Domain.Entities.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("QuickBuy.Domain.Entities.Helpers.FormaPagamento", "FormaPagamento")
                        .WithMany()
                        .HasForeignKey("FormaPagamentoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("QuickBuy.Domain.Entities.Usuario", "Usuario")
                        .WithMany("Pedidos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

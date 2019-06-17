using System;
using System.Collections.Generic;
using System.Text;
using ExemploProdutos.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExemploProdutos.Dados
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.Property(p => p.Nome)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(d => d.Valor)
                .HasColumnType("varchar(10)")
                .IsRequired();

            builder.ToTable("Produtos");
        }
    }
}

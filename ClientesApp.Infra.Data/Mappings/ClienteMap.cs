using ClientesApp.Infra.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientesApp.Infra.Data.Mappings
{
    /// <summary>
    /// Classe de mapeamento para a entidade Cliente
    /// </summary>
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            //nome da tabela do banco de dados
            builder.ToTable("CLIENTE");

            //chave primária
            builder.HasKey(c => c.Id);

            //mapeamento dos demais campos
            builder.Property(c => c.Id).HasColumnName("ID");
            builder.Property(c => c.Nome).HasColumnName("NOME").HasMaxLength(100).IsRequired();
            builder.Property(c => c.Email).HasColumnName("EMAIL").HasMaxLength(100).IsRequired();
            builder.Property(c => c.Cpf).HasColumnName("CPF").HasMaxLength(11).IsRequired();
            builder.Property(c => c.DataHoraCadastro).HasColumnName("DATA_HORA_CADASTRO").IsRequired();

            //criando um índice para tornar o campo de CPF único
            builder.HasIndex(c => c.Cpf).IsUnique();
        }
    }
}

using CondominiumsManager.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominiumsManager.DAL.MapeamentoAp
{
    public class VeiculoMap : IEntityTypeConfiguration<Veiculo>
    {
        public void Configure(EntityTypeBuilder<Veiculo> builder)
        {   //Definir a chave Primaria
            builder.HasKey(v => v.VeiculoId);
            //
            builder.Property(v => v.Nome).IsRequired().HasMaxLength(40);
            builder.Property(v => v.Cor).IsRequired().HasMaxLength(20);
            builder.Property(v => v.Marca).IsRequired().HasMaxLength(40);
            builder.Property(v => v.Placa).IsRequired().HasMaxLength(9);
            //A placa é Unica
            builder.HasIndex(v => v.Placa).IsUnique();
            //Chave estrangeira
            builder.Property(v => v.UsuarioId).IsRequired();
            //Cada Veiculo esta relacionado a um usuario mas cada usuario pode ter mais de um veiculo
            builder.HasOne(v => v.Usuario).WithMany(v => v.Veiculos).HasForeignKey(v => v.UsuarioId);
            // Nome da tabela
            builder.ToTable("Veiculos");
        }
    }
}

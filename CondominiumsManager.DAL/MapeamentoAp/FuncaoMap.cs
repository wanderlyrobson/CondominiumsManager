using CondominiumsManager.BLL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CondominiumsManager.DAL.Map
{
    public class FuncaoMap : IEntityTypeConfiguration<Funcao>
    {
        public void Configure(EntityTypeBuilder<Funcao> builder)
        {
            builder.Property(f => f.Id).ValueGeneratedOnAdd();
            builder.Property(f =>f.Descricao).IsRequired().HasMaxLength(30);

            builder.HasData(
            new Funcao
            {
                Id = Guid.NewGuid().ToString(),
                Nome = "Morador",
                NormalizedName = "MORADOR",
                Descricao = "Morador do Prédio"

            },

            new Funcao
            {
                Id = Guid.NewGuid().ToString(),
                Nome = "Sindico",
                NormalizedName = "SINDICO",
                Descricao = "Sindico do Prédio"
            },

            new Funcao
            {
                Id = Guid.NewGuid().ToString(),
                Nome = "Administrador",
                NormalizedName = "ADMINISTRADOR",
                Descricao = "Administrador do Prédio"
            });
            builder.ToTable("Funções");
        }
    }
}

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
    public class ApartamentoMap : IEntityTypeConfiguration<Apartamento>
    {
        public void Configure(EntityTypeBuilder<Apartamento> builder)
        {   //Chave Primaria
            builder.HasKey(a => a.ApartamentoId);
            //Todos atributos Orbigatorio
            builder.Property(a => a.Numero).IsRequired();
            builder.Property(a => a.Andar).IsRequired();
            builder.Property(a => a.Foto).IsRequired();
            builder.Property(a => a.Proprietario).IsRequired();
            builder.Property(a => a.Morador).IsRequired();
            //Mapeamento de relacionamento da classe
            //Um ap pode estar relacionado apenas um proprietario mas o proprietario pode ter varios ap 
            builder.HasOne(a => a.Proprietario).WithMany(a => a.ProprietarioApartamentos).HasForeignKey(a => a.ProprietarioId);
            //O morador pode ter varios ap associado a ele mas cada ap deve estar relacionado apenas a um morador
            builder.HasOne(a => a.Morador).WithMany(a => a.MoradoresApartamentos).HasForeignKey(a => a.MoradorId);
            //Nome da tabela
            builder.ToTable("Apartamentos"); 
        }
    }
}

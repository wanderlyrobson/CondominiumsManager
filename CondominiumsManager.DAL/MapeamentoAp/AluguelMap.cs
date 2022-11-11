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
    public class AluguelMap : IEntityTypeConfiguration<Aluguel>
    {
        public void Configure(EntityTypeBuilder<Aluguel> builder)
        {   //Chave Primaria
            builder.HasKey(a => a.AluguelId);
            //Atributos valor obrigatoiro
            builder.Property(a => a.Valor).IsRequired();
            //Mes e ano Obrigatorio 
            builder.Property(a => a.MesId).IsRequired();
            builder.Property(a => a.Ano).IsRequired();
            //Configuração Relacionamento
            //O aluguel pode esta relacionado a um mês mas o mês pode estar relacionado a varios alugueis
            builder.HasOne(a => a.Mes).WithMany(a => a.Alugueis).HasForeignKey(a => a.MesId);
            builder.HasMany(a => a.Pagamentos).WithOne(a => a.Aluguel);
            //Nome da tabela
            builder.ToTable("Alugueis");
        }
    }
}

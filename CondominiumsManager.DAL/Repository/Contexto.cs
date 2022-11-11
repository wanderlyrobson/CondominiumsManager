using CondominiumsManager.BLL.Models;
using CondominiumsManager.BLL.Models.GerenciadorCondominios.BLL.Models;
using CondominiumsManager.DAL.Map;
using CondominiumsManager.DAL.MapeamentoAp;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CondominiumsManager.DAL
{
    public class Contexto : IdentityDbContext<Usuario, Funcao, string>
    {
        public DbSet<Aluguel> Alugueis { get; set; }
        public DbSet<Apartamento> Apartmento { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Funcao> Funcoes { get; set; }
        public DbSet<HistoricoRecursos> HistoricoRecursos { get; set; }
        public DbSet<Mes> Meses { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<Servico> ServicoPredio { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new AluguelMap());
            builder.ApplyConfiguration(new ApartamentoMap());
            builder.ApplyConfiguration(new EventoMap());
            builder.ApplyConfiguration(new FuncaoMap());
            builder.ApplyConfiguration(new HistoricoRecursosMap());
            builder.ApplyConfiguration(new MesMap());
            builder.ApplyConfiguration(new ServicoMap());
            builder.ApplyConfiguration(new ServicoPrediosMap());
            builder.ApplyConfiguration(new VeiculoMap());

        }

    }
}

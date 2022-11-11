using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominiumsManager.BLL.Models
{
   public class Pagamento
    {
        public int PagamentoId { get; set; }
        public string UsuarioId { get; set; }
        public virtual Users Usuario { get; set; }
        public int AluguelId { get; set; }
        public virtual Aluguel Aluguel { get; set; }
        public DateTime? DataPagamento { get; set; }
        public StatusPagamento Status { get; set; }
    }

    public enum StatusPagamento
    {
        Pago, Pendente, Atrasado
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominiumsManager.BLL.Models
{
    public class HistoricoRecursos
    {
        public int HistoricoRecursoId { get; set; }
        public int Valor { get; set; }
        public Tipos Tipo { get; set; }
        public int Dia { get; set; }
        public int MesId { get; set; }
        public virtual Mes Mes { get; set; }
        public int Ano { get; set; }

    }
    public enum Tipos
    {
        Entrada, Saida
    }
    

    
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominiumsManager.BLL.Models
{
    public class Veiculo
    {
        public int VeiculoId { get; set; }
        [Required(ErrorMessage = "O campo {0}é Obrigatório")]
        [StringLength(20,ErrorMessage ="Use menos caracteres")]

        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo {0}é Obrigatório")]
        [StringLength(20, ErrorMessage = "Use menos caracteres")]
        public string Marca { get; set; }
        [Required(ErrorMessage = "O campo {0}é Obrigatório")]
        [StringLength(20, ErrorMessage = "Use menos caracteres")]
        public string Cor { get; set; }
        [Required(ErrorMessage = "O campo {0}é Obrigatório")]
        public string Placa { get; set; }
        public string UsuarioId { get; set; }
        public Users Usuario { get; set; }
    }
}

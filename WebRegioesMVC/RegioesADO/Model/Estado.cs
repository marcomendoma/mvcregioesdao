
using System.ComponentModel.DataAnnotations;

namespace RegioesADO.Model
{
    public class Estado
    {
        public long idEstado { get; set; }

        [Required(ErrorMessage = "Descrição do estado é campo obrigatório.")]
        public string UF { get; set; }
    }
}

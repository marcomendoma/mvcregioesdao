using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace RegioesADO.Model
{
    public class Regiao
    {
        public long idRegiao { get; set; }
        public Estado Estado { get; set; }

        [Required(ErrorMessage = "Descrição da região é campo obrigatório.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Ativo da região é campo obrigatório.")]
        public bool Ativo { get; set; }

        public IEnumerable<Regiao> regioes { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace RegioesADO.Model
{
    public class Fornecedor
    {
        public long idFornecedor { get; set; }

        [Required(ErrorMessage = "Cnpj do fornecedor é campo obrigatório.")]
        public string Cnpj { get; set; }

        [Required(ErrorMessage = "Nome do fornecedor é campo obrigatório.")]
        public string Nome { get; set; }
    }
}

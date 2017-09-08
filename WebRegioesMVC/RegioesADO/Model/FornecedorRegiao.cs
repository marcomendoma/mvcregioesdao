using System.Collections.Generic;

namespace RegioesADO.Model
{
    public class FornecedorRegiao
    {
        public long idFornecedorRegiao { get; set; }
        public List<Fornecedor> fornecedores { get; set; }
        public List<Regiao> regioes { get; set; }
    }
}

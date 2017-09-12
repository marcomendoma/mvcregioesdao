using System.Collections.Generic;

using RegioesADO.Model;

namespace WebRegioesMVC.Models
{
    public class RegiaoModel
    {
        public int PageNumber { get; set; }

        public IEnumerable<Regiao> Regioes { get; set; }

        public int TotalRows { get; set; }

        public int PageSize { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.Base
{
    public class EntidadeBase 
    {

        public EntidadeBase()
        {
            Status = true;
        }
        public int Id { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public bool Status { get; set; }
    }
}

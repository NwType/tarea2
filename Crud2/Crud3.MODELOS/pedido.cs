using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud3.MODELOS
{
    public class pedido
    {
        public int idpedido { get; set; }
        public int idcliente { get; set; }
        public DateTime fecha { get; set; }
        public decimal total { get; set; }
        public string estado { get; set; }
    }
}

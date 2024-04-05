using Crud3.DAL;
using Crud3.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Crud33.BSS
{
    public class PedidoBss
    {
        PedidosDal dal = new PedidosDal();
        public void InsertarPedidoBss(pedido p)
        {
            dal.InserarPedidoDal (p);
        }
        public DataTable ListarPedidosBss()
        {
            return dal.ListarPedidosDal();
        }
        public pedido ObtenerPedidoBss(int id)
        {
            return dal.ObtenerPedidoId(id);
        }
        public void EditarPedidoBss(pedido p)
        {
            dal.EditarPedidoDal(p);
        }
        public void EliminarPedidoBss(int id)
        {
            dal.EliminarpedidoDal(id);
        }
    }
}

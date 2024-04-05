using Crud3.DAL;
using Crud3.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud33.BSS
{
    public class ClienteBss
    {
        ClienteDal dal= new ClienteDal();
        public DataTable ListarClienteBss()
        {
            return dal.ListarClienetesDal();
        }
        public cliente ObtenerIdBss(int id)
        {
            return dal.ObtenerClienteId(id);
        }
        public DataTable ListarClienteTotalBss()
        {
            return dal.ListarClienetesTotalDal();
        }
        public void InsertarClienteBss(cliente c)
        {
            dal.InsertarCliente(c);
        }
        public void EliminarClienteBss(int id)
        {
            dal.EliminarCliente(id);
        }
        public void EditarClienteBss(cliente p)
        {
            dal.ActualizarCliente(p);
        }
    }
}

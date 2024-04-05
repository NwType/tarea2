using Crud3.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud3.DAL
{
    public class PedidosDal
    {
        public void InserarPedidoDal(pedido p)
        {
            string consulta = "insert into pedido values (" + p.idcliente + ",'" +
                p.fecha + "','" + p.total + "','Proceso')";
            conexion.Ejecutar(consulta);
        }
        public DataTable ListarPedidosDal()
        {
            string consulta = "SELECT Pedido.*, Cliente.Nombre AS NombreCliente " +
                              "FROM Pedido " +
                              "INNER JOIN Cliente ON Pedido.IDCliente = Cliente.IDCliente";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public pedido ObtenerPedidoId(int id)
        {
            string consulta = "select * from pedido where idpedido=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "ya");
            pedido p = new pedido();
            if (tabla.Rows.Count > 0)
            {
                p.idcliente = Convert.ToInt32(tabla.Rows[0]["idcliente"]);
                p.fecha = Convert.ToDateTime(tabla.Rows[0]["fecha"]);
                p.total =Convert.ToDecimal(tabla.Rows[0]["total"].ToString());
                p.estado = tabla.Rows[0]["estado"].ToString();
            }
            return p;
        }
        public void EditarPedidoDal(pedido p)
        {
            string consulta = "UPDATE pedido SET idcliente= '" + p.idcliente + "', fecha = '" + p.fecha + "', total = '" + p.total + "', estado = '" + p.estado + "' WHERE idpedido = " + p.idpedido;

            conexion.Ejecutar(consulta);
        }
        public void EliminarpedidoDal(int id)
        {
            string consulta = "DELETE FROM pedido WHERE idpedido = " + id;

            conexion.Ejecutar(consulta);
        }
    }
}

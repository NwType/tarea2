using Crud3.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud3.DAL
{
    public class ClienteDal
    {
        public DataTable ListarClienetesDal()
        {
            string consulta = "select * from cliente";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public cliente ObtenerClienteId(int id)
        {
            string consulta = "select * from cliente where idcliente=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "ya");
            cliente c = new cliente();
            if (tabla.Rows.Count > 0)
            {
                c.idcliente = Convert.ToInt32(tabla.Rows[0]["idcliente"]);
                c.nombre = tabla.Rows[0]["nombre"].ToString();
                c.apellido = tabla.Rows[0]["apellido"].ToString();
                c.email = tabla.Rows[0]["email"].ToString();
                c.telefono = tabla.Rows[0]["telefono"].ToString();
            }
            return c;
        }
        public DataTable ListarClienetesTotalDal()
        {
            string consulta = @"
                SELECT Cliente.Nombre AS NombreCliente, SUM(Pedido.Total) AS TotalPedidos
                FROM Cliente
                INNER JOIN Pedido ON Cliente.IDCliente = Pedido.IDCliente
                GROUP BY Cliente.Nombre;
                    ";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarCliente(cliente c)
        {
            string consulta = string.Format("INSERT INTO Cliente (Nombre, Apellido, Email, Telefono) " +
                                     "VALUES ('{0}', '{1}', '{2}', '{3}')",
                                     c.nombre, c.apellido, c.email, c.telefono);
            conexion.Ejecutar(consulta);
        }
        public void EliminarCliente(int id)
        {
            string consulta = "DELETE FROM Cliente WHERE IDCliente ="+id;
            conexion.Ejecutar(consulta);
        }
        public void ActualizarCliente(cliente c)
        {
            string consulta = "INSERT INTO Cliente (Nombre, Apellido, Email, Telefono) VALUES ('" + c.nombre + "', '" + c.apellido + "', '" + c.email + "', '" + c.telefono + "')";
            conexion.Ejecutar(consulta);

        }


    }
}

using Crud3.MODELOS;
using Crud3.VISTA.ClienteVista;
using Crud33.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud3.VISTA.PedidoVista
{
    public partial class PedidoInsertarVista : Form
    {
        public PedidoInsertarVista()
        {
            InitializeComponent();
        }
        public static int IdClienteSeleccionada = 0;
        ClienteBss bss = new ClienteBss();
        private void button3_Click(object sender, EventArgs e)
        {
            ClienteListarVista fr = new ClienteListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                cliente C = bss.ObtenerIdBss(IdClienteSeleccionada);
                textBox1.Text = C.nombre + " " + C.apellido;
            }
        }
        PedidoBss bsspedido = new PedidoBss();
        private void button1_Click(object sender, EventArgs e)
        {
            pedido p = new pedido();
            p.idcliente = IdClienteSeleccionada;
            p.fecha = dateTimePicker1.Value;
            p.total = Convert.ToDecimal (textBox2.Text);
            p.estado= textBox3.Text;
            bsspedido.InsertarPedidoBss(p);
            MessageBox.Show("Pedido registrado");
        }
    }
}

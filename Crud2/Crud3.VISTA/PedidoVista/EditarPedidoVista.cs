using Crud3.MODELOS;
using Crud33.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud3.VISTA.PedidoVista
{
    public partial class EditarPedidoVista : Form
    {
        int idx = 0;
        pedido p = new pedido();
        public EditarPedidoVista(int id)
        {
            idx = id;
            InitializeComponent();
       

        }
        public static int IdPedidoSeleccionada = 0;
        PedidoBss bss = new PedidoBss();
        private void button3_Click(object sender, EventArgs e)
        {
        }
        PedidoBss bsspedido = new PedidoBss();
        private void button1_Click(object sender, EventArgs e)
        {
            pedido p = new pedido();
            p.idcliente = Convert.ToInt32(textBox1.Text);
            p.fecha = dateTimePicker1.Value;
            p.total = Convert.ToDecimal(textBox2.Text);
            p.estado = textBox3.Text;
            bsspedido.EditarPedidoBss(p);
            MessageBox.Show("Pedido Actualizado");
        }

        private void EditarPedidoVista_Load(object sender, EventArgs e)
        {
                 p = bss.ObtenerPedidoBss(idx);
                textBox1.Text = Convert.ToString(p.idcliente);
                dateTimePicker1.MinDate = p.fecha;
                textBox2.Text = Convert.ToString(p.total);
                textBox3.Text = p.estado;
        }

        private void EditarPedidoVista_Load_1(object sender, EventArgs e)
        {
            p = bss.ObtenerPedidoBss(idx);
            textBox1.Text = Convert.ToString(p.idcliente);
            dateTimePicker1.MinDate = p.fecha;
            textBox2.Text = Convert.ToString(p.total);
            textBox3.Text = p.estado;
        }
    }
}

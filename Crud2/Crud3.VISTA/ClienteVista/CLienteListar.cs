using Crud3.VISTA.PedidoVista;
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

namespace Crud2.VISTA.ClienteVista
{
    public partial class CLienteListar : Form
    {
        public CLienteListar()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();
        private void CLienteListar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarClienteBss();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdPedidoSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("esta seguro de eliminar este pedido", "eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarClienteBss(IdPedidoSeleccionada);
                dataGridView1.DataSource = bss.ListarClienteBss();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int IdPedidoSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            EditarCliente fr = new EditarCliente(IdPedidoSeleccionada);
            if(fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarClienteBss();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AgregarCLiente fr = new AgregarCLiente();
            fr.ShowDialog();
            {
                dataGridView1.DataSource = bss.ListarClienteBss();
            }
        }
    }
}

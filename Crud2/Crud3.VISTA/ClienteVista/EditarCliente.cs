using Crud3.MODELOS;
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
    public partial class EditarCliente : Form
    {
        int idx = 0;
        cliente c = new cliente();
        public EditarCliente(int id)
        {
            InitializeComponent();
            idx = id;
        }
        ClienteBss bss = new ClienteBss();
        private void EditarCliente_Load(object sender, EventArgs e)
        {
            c = bss.ObtenerIdBss(idx);
            textBox1.Text = Convert.ToString(c.nombre);
            textBox2.Text = Convert.ToString(c.apellido);
            textBox3.Text = Convert.ToString(c.email);
            textBox4.Text = Convert.ToString(c.telefono);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cliente p = new cliente();
            p.nombre = textBox1.Text;
            p.apellido = textBox2.Text;
            p.email = textBox3.Text;
            p.telefono = textBox4.Text;
            bss.EditarClienteBss(p);
            MessageBox.Show("Cliente Actualizado");
        }
    }
}

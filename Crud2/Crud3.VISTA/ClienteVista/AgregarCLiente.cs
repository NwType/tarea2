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
    public partial class AgregarCLiente : Form
    {
        public AgregarCLiente()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();

        private void button1_Click(object sender, EventArgs e)
        {
            cliente p = new cliente();
            p.nombre = textBox1.Text;   
            p.apellido = textBox2.Text;
            p.email = textBox3.Text;
            p.telefono = textBox4.Text;
            bss.InsertarClienteBss(p);
            MessageBox.Show("Cliente registrado");
        }
    }
}

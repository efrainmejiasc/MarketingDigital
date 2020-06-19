using MarketingDigitalDesktop.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MarketingDigitalDesktop.Forms
{
    public partial class NuevoRemitente : Form
    {
        private Procesador procesador = new Procesador();
        public NuevoRemitente()
        {
            InitializeComponent();
        }

        private void NuevoRemitente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("TODOS LOS CAMPOS SON NESESARIOS", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!procesador.EmailValido(textBox2.Text))
            {
                MessageBox.Show("EMAIL NO VALIDO", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CreateNewRemitenteAsync(textBox1.Text, textBox2.Text);
        }

        private async Task CreateNewRemitenteAsync(string nombre,string email)
        {
            bool result = await procesador.CrearNuevoRemitenteAsync(nombre, email);

            if (!result)
                MessageBox.Show("REMITENTE CREADO CORRECTAMENTE", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("CREACION DE REMITENTE FALLIDA", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }
    }
}

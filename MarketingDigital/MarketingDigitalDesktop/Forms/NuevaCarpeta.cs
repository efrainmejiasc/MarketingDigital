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
    public partial class NuevaCarpeta : Form
    {
        public NuevaCarpeta()
        {
            InitializeComponent();
        }

        private void NuevaCarpeta_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("TODOS LOS CAMPOS SON NESESARIOS", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _ = CreateNewCarpetaAsync(textBox1.Text);
        }

        private async Task CreateNewCarpetaAsync(string nombreCarpeta)
        {
            Procesador procesador = new Procesador();
            bool result = await procesador.CrearNuevaCarpetaAsync(nombreCarpeta);

            if (!result)
                MessageBox.Show("CARPETA CREADA CORRECTAMENTE", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("CREACION DE CARPETA FALLIDA", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            textBox1.Text = string.Empty;
        }
    }
}

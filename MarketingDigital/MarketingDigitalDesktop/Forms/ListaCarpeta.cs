using MarketingDigitalDesktop.Engine;
using MarketingDigitalDesktop.Engine.Interfaces;
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
    public partial class ListaCarpeta : Form
    {
        private readonly ITool tool;
        public ListaCarpeta()
        {
            InitializeComponent();
        }
        public ListaCarpeta(ITool _tool)
        {
            InitializeComponent();
            tool = _tool;
        }

        private void ListaCarpeta_Load(object sender, EventArgs e)
        {
            SetTableCarpetaAsync();
        }
        public async Task SetTableCarpetaAsync()
        {
            var procesador = new Procesador();
            var listaCarpetas = await procesador.ObtenerListaCarpetasAsync();
            dgv.DataSource = tool.SetTableFolder(listaCarpetas);
            dgv = tool.ColorFila(dgv, Color.WhiteSmoke, Color.AliceBlue);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0 || string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("DEBE SELECCIONAR UNA CARPETA E INGRESAR UN NOMBRE DE LISTA", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgv.CurrentRow;
            var id = Convert.ToInt32(row.Cells["ID"].Value);
            NuevaListaContactos(textBox1.Text,id);
        }
  
        public async Task NuevaListaContactos(string nombreLista , int idCarpeta)
        {
            var procesador = new Procesador();
            bool result = await procesador.CrearNuevaListaContactoAsync(nombreLista, idCarpeta);
            if (!result)
                MessageBox.Show("LISTA DE CONTACTOS CREADA CORRECTAMENTE", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("CREACION DE LISTA DE CONTACTOS FALLIDA", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            textBox1.Text = string.Empty;
        }
    }
}

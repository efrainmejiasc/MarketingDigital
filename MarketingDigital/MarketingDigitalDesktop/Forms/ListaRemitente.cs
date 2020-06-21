using MarketingDigitalBCS.Response;
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
    public partial class ListaRemitente : Form
    {
        private readonly ITool tool;
        public ListaRemitente()
        {
            InitializeComponent();
        }

        public ListaRemitente(ITool _tool)
        {
            InitializeComponent();
            tool = _tool;
        }

        private void ListaRemitente_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetTableRemitenteAsync();
        }

        public async Task SetTableRemitenteAsync()
        {
            var procesador = new Procesador();
            var listaRemitentes = await procesador.ObtenerListaRemitentesAsync();
            dgv.DataSource = tool.SetTableRemitente(listaRemitentes);
            dgv = tool.ColorFila(dgv, Color.WhiteSmoke, Color.AliceBlue);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.ClearSelection();
        }

        private void dgv_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgv = tool.ColorFila(dgv, Color.WhiteSmoke, Color.AliceBlue);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.ClearSelection();
        }
    }
}

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

        private void button1_Click(object sender, EventArgs e)
        {
          
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
    }
}

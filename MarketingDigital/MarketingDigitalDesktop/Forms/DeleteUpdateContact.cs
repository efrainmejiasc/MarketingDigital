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
    public partial class DeleteUpdateContact : Form
    {
        private readonly ITool tool;
        public DeleteUpdateContact()
        {
            InitializeComponent();
        }
        public DeleteUpdateContact(ITool _tool)
        {
            tool = _tool;
            InitializeComponent();
        }

        private void DeleteUpdateContact_Load(object sender, EventArgs e)
        {
            _= GetAllContactAsync();
        }

        private async Task GetAllContactAsync()
        {
            var procesador = new Procesador();
            var listaContactos = await procesador.ObtenerAllContacts();
            dgv.DataSource = tool.SetTableAllContactos(listaContactos);
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

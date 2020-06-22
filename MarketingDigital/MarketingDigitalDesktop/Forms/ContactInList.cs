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
    public partial class ContactInList : Form
    {
        private readonly ITool tool;
        private string idLista = string.Empty;
        public ContactInList()
        {
            InitializeComponent();
        }

        public ContactInList(ITool _tool , string _idLista)
        {
            InitializeComponent();
            tool = _tool;
            idLista = _idLista;
        }

        private void ContactInList_Load(object sender, EventArgs e)
        {
            _= GetContactInListAsync();
        }

        private async Task GetContactInListAsync()
        {
            var procesador = new Procesador();
            var listaContactos = await procesador.ObtenerContactoEnLista(idLista);
            dgv.DataSource = tool.SetTableContactos(listaContactos);
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

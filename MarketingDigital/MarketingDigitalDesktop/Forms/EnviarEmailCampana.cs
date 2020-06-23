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
    public partial class EnviarEmailCampana : Form
    {
        private readonly ITool tool;

        public EnviarEmailCampana()
        {
            InitializeComponent();
        }

        public EnviarEmailCampana(ITool _tool)
        {
            InitializeComponent();
            tool = _tool;
        }

        private void EnviarEmailCampana_Load(object sender, EventArgs e)
        {
            _ = ObtenerTodasCampanasEmailAsync();
            _ = ObtenerTodasListasEmailAsync();
        }

        private async Task ObtenerTodasCampanasEmailAsync()
        {
            var procesador = new Procesador();
            var listaCampanas = await procesador.ObtenerTodasCampanasEmailAsync();
            dgv1.DataSource = tool.SetTableCampanasEmail(listaCampanas);
            dgv1 = tool.ColorFila(dgv1, Color.WhiteSmoke, Color.AliceBlue);
            dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv1.ClearSelection();
        }

        private async Task ObtenerTodasListasEmailAsync()
        {
            var procesador = new Procesador();
            var listaEmails = await procesador.ObtenerTodasListaContactoAsync();
            dgv2.DataSource = tool.SetTableListEmail(listaEmails);
            dgv2 = tool.ColorFila(dgv2, Color.WhiteSmoke, Color.AliceBlue);
            dgv2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv2.ClearSelection();
        }

        private void dgv1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgv1 = tool.ColorFila(dgv1, Color.WhiteSmoke, Color.AliceBlue);
            dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv1.ClearSelection();
        }

        private void dgv2_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgv2 = tool.ColorFila(dgv2, Color.WhiteSmoke, Color.AliceBlue);
            dgv2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv2.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _ = EnviarCampanaEmailAsync();
        }

        private async Task EnviarCampanaEmailAsync()
        {
            if (dgv1.SelectedRows.Count == 0 || dgv2.SelectedRows.Count == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA CAMAPAÑA DE EMAIL Y UNA LISTA DE CONTACTOS", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row1 = dgv1.CurrentRow;
            var idCampaing  = row1.Cells["ID"].Value.ToString();
            DataGridViewRow row2 = dgv2.CurrentRow;
            var idLista =row2.Cells["ID"].Value.ToString();

            var procesador = new Procesador();
            var listaContacto = await procesador.ObtenerContactoEnLista(idLista);
            List<string> emailTo = listaContacto.contacts.Select(x => x.email).ToList();
            bool result = await  procesador.SendEmailCampanaAsync(emailTo,idCampaing);
            if (!result)
                MessageBox.Show("CAMPAÑA ENVIADA CORRECTAMENTE", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("ENVIO FALLIDO", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

    }
}

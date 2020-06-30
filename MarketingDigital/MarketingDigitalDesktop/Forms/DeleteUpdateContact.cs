using MarketingDigitalBCS.Models;
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
    public partial class DeleteUpdateContact : Form
    {
        private readonly ITool tool;
        private string email = string.Empty;
        private SBResponseAllContacts listaContactos = new SBResponseAllContacts();
        private SBResponseAllContacts.Contacts dataContact = new SBResponseAllContacts.Contacts();

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
            txtEmail.Enabled = false;
           _ = GetAllContactAsync();
        }

        private async Task GetAllContactAsync()
        {
            var procesador = new Procesador();
            listaContactos = new SBResponseAllContacts();
            listaContactos = await procesador.ObtenerAllContacts();
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

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv.CurrentRow;
            email = row.Cells["EMAIL"].Value.ToString();
            dataContact = new SBResponseAllContacts.Contacts();
            dataContact = listaContactos.contacts.Where(x => x.email == email).FirstOrDefault();
            txtNombre.Text = dataContact.attributes.NOMBRE;
            txtApellido.Text = dataContact.attributes.SURNAME;
            txtEmail.Text = dataContact.email;
            txttelefono.Text = dataContact.attributes.SMS;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            _ = DeleteContact();
        }

        public async Task DeleteContact ()
        {
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("SELECCIONE UN CONTACTO", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
                

            var procesador = new Procesador();
            bool result = await procesador.DeleteContactAsync(email);
            if (!result)
                MessageBox.Show("CONTACTO ELIMINADO CORRECTAMENTE", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("ELIMINACION FALLIDA", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Update_Click(object sender, EventArgs e)
        {
            _ = UpdateContact();
        }

        public async Task UpdateContact()
        {
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("SELECCIONE UN CONTACTO", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var procesador = new Procesador();
            if (!string.IsNullOrEmpty(nuevoemail.Text))
            {
                if (!procesador.EmailValido(nuevoemail.Text.ToLower()))
                {
                    MessageBox.Show("EMAIL NO VALIDO", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                dataContact.email = nuevoemail.Text.ToLower();
            }
            else
            {
                dataContact.email = txtEmail.Text;
            }
                

            bool result = await procesador.UpdateContactAsync(email,dataContact);
            if (!result)
                MessageBox.Show("CONTACTO ACTUALIZADO CORRECTAMENTE", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("ACTUALIZACION FALLIDA", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}

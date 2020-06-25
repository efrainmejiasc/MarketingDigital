using MarketingDigitalBCS.EngineClass;
using MarketingDigitalBCS.Response;
using MarketingDigitalDesktop.Engine;
using MarketingDigitalDesktop.Engine.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketingDigitalDesktop.Forms
{
    public partial class NuevoCampaña : Form
    {
        private readonly ITool tool;
        private SBRecoverSender listaRemitentes = new SBRecoverSender();
        private SBRecoverSender.Sender remitente = new SBRecoverSender.Sender();
        private string tipo = string.Empty;
        public NuevoCampaña()
        {
            InitializeComponent();
        }

        public NuevoCampaña(ITool _tool)
        {
            InitializeComponent();
            tool = _tool;
        }

        private void NuevoCampaña_Load(object sender, EventArgs e)
        {
            _ = SetTableRemitenteAsync();
        }

        public async Task SetTableRemitenteAsync()
        {
            var procesador = new Procesador();
            listaRemitentes = await procesador.ObtenerListaRemitentesAsync();
            comboBox1 = tool.SetListaRemitente(comboBox1, listaRemitentes);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if (comboBox1.SelectedIndex == -1)
                return;

            var email = comboBox1.SelectedItem.ToString();
            remitente = listaRemitentes.senders.Where(x => x.email == email).FirstOrDefault();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipo = string.Empty;
            if (comboBox2.SelectedIndex == -1)
                return;


            tipo = comboBox2.SelectedItem.ToString();
            if (tipo == "Texto")
            {
               
            }
            else if (tipo == "Plantilla HTML")
            {
                this.openFileDialog1.FileName = string.Empty;
                this.openFileDialog1.Multiselect = false;
                this.openFileDialog1.Filter = "Archivo HTML (*.html)|*.html";
                this.openFileDialog1.Title = "Buscar lista";
                this.openFileDialog1.ShowDialog();
                string pathArchivo = openFileDialog1.FileName;
                if (!string.IsNullOrEmpty(pathArchivo))
                {
                    richTextBox1.Text = pathArchivo;
                }
            }
            else if (tipo == "Id Plantilla")
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string contenido = string.Empty;
            if (tipo == "Texto")
            {
                contenido = "<div style='text-aling:justify;' ><p> " + richTextBox1.Text + "</p></div>";
            }
            else if (tipo == "Plantilla HTML")
            {
                if (!File.Exists(richTextBox1.Text))
                {
                    MessageBox.Show("EL ARCHIVO .html NO EXISTE ", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                contenido = File.ReadAllText(richTextBox1.Text);
            }
            else if (tipo == "Id Plantilla")
            {

            }
            _ = CrearNuevaCampanaAsync(contenido);
        }

        private async Task CrearNuevaCampanaAsync(string contenido)
        {
            var procesador = new Procesador();
            bool result = await procesador.CrearNuevaCampanaEmailAsync(tag.Text, remitente.name, remitente.email, campana.Text, contenido, subject.Text);
            if (!result)
                MessageBox.Show("CAMPAÑA CREADA CORRECTAMENTE", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("CREACION DE CAMPAÑA FALLIDA", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            campana.Text = string.Empty;
            tag.Text = string.Empty;
            subject.Text = string.Empty;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            listaRemitentes = new SBRecoverSender();
            remitente = new SBRecoverSender.Sender();
            tipo = string.Empty;
         }
    }
}

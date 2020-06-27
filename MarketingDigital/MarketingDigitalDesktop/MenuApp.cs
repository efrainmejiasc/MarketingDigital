using MarketingDigitalDesktop.Engine;
using MarketingDigitalDesktop.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketingDigitalDesktop
{
    public partial class MenuApp : Form
    {
        public MenuApp()
        {
            InitializeComponent();
        }

        private void nuevoRemitente_Click(object sender, EventArgs e)
        {
            NuevoRemitente remitente = new NuevoRemitente();
            remitente.ShowDialog();
        }

        private void remitentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tool = new Tool();
            ListaRemitente listaRemitente = new ListaRemitente(tool);
            listaRemitente.ShowDialog();
        }

        private void nuevaCarpetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaCarpeta carpeta = new NuevaCarpeta();
            carpeta.ShowDialog();
        }

        private void carpetasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var tool = new Tool();
            ListaCarpeta listaCarpeta = new ListaCarpeta(tool);
            listaCarpeta.ShowDialog();
        }

        private void nuevaListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tool = new Tool();
            ListaCarpeta listaCarpeta = new ListaCarpeta(tool);
            listaCarpeta.ShowDialog();
        }

        private void nuevoContactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tool = new Tool();
            NuevoContacto nuevoContacto = new NuevoContacto(tool);
            nuevoContacto.ShowDialog();
        }

        private void verContactosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tool = new Tool();
            NuevoContacto nuevoContacto = new NuevoContacto(tool);
            nuevoContacto.ShowDialog();
        }

        private void nuevaCampañaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tool = new Tool();
            NuevoCampaña nuevoCampaña = new NuevoCampaña(tool);
            nuevoCampaña.ShowDialog();
        }

        private void enviarCampañaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tool = new Tool();
            EnviarEmailCampana enviarEmailCampana = new EnviarEmailCampana(tool);
            enviarEmailCampana.ShowDialog();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AyudaImagen ayuda = new AyudaImagen();
            ayuda.ShowDialog();
        }
    }
}

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
    }
}

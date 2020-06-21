namespace MarketingDigitalDesktop
{
    partial class MenuApp
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.remitenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoRemitente = new System.Windows.Forms.ToolStripMenuItem();
            this.remitentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carpetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaCarpetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carpetasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoContactoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.remitenteToolStripMenuItem,
            this.carpetasToolStripMenuItem,
            this.contactosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // remitenteToolStripMenuItem
            // 
            this.remitenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoRemitente,
            this.remitentesToolStripMenuItem});
            this.remitenteToolStripMenuItem.Name = "remitenteToolStripMenuItem";
            this.remitenteToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.remitenteToolStripMenuItem.Text = "Remitente";
            // 
            // nuevoRemitente
            // 
            this.nuevoRemitente.Name = "nuevoRemitente";
            this.nuevoRemitente.Size = new System.Drawing.Size(166, 22);
            this.nuevoRemitente.Text = "Nuevo Remitente";
            this.nuevoRemitente.Click += new System.EventHandler(this.nuevoRemitente_Click);
            // 
            // remitentesToolStripMenuItem
            // 
            this.remitentesToolStripMenuItem.Name = "remitentesToolStripMenuItem";
            this.remitentesToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.remitentesToolStripMenuItem.Text = "Remitentes";
            this.remitentesToolStripMenuItem.Click += new System.EventHandler(this.remitentesToolStripMenuItem_Click);
            // 
            // carpetasToolStripMenuItem
            // 
            this.carpetasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaCarpetaToolStripMenuItem,
            this.carpetasToolStripMenuItem1,
            this.nuevaListaToolStripMenuItem});
            this.carpetasToolStripMenuItem.Name = "carpetasToolStripMenuItem";
            this.carpetasToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.carpetasToolStripMenuItem.Text = "Carpetas y Listas";
            // 
            // nuevaCarpetaToolStripMenuItem
            // 
            this.nuevaCarpetaToolStripMenuItem.Name = "nuevaCarpetaToolStripMenuItem";
            this.nuevaCarpetaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevaCarpetaToolStripMenuItem.Text = "Nueva Carpeta";
            this.nuevaCarpetaToolStripMenuItem.Click += new System.EventHandler(this.nuevaCarpetaToolStripMenuItem_Click);
            // 
            // carpetasToolStripMenuItem1
            // 
            this.carpetasToolStripMenuItem1.Name = "carpetasToolStripMenuItem1";
            this.carpetasToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.carpetasToolStripMenuItem1.Text = "Carpetas";
            this.carpetasToolStripMenuItem1.Click += new System.EventHandler(this.carpetasToolStripMenuItem1_Click);
            // 
            // nuevaListaToolStripMenuItem
            // 
            this.nuevaListaToolStripMenuItem.Name = "nuevaListaToolStripMenuItem";
            this.nuevaListaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevaListaToolStripMenuItem.Text = "Nueva Lista";
            this.nuevaListaToolStripMenuItem.Click += new System.EventHandler(this.nuevaListaToolStripMenuItem_Click);
            // 
            // contactosToolStripMenuItem
            // 
            this.contactosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoContactoToolStripMenuItem});
            this.contactosToolStripMenuItem.Name = "contactosToolStripMenuItem";
            this.contactosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.contactosToolStripMenuItem.Text = "Contactos";
            // 
            // nuevoContactoToolStripMenuItem
            // 
            this.nuevoContactoToolStripMenuItem.Name = "nuevoContactoToolStripMenuItem";
            this.nuevoContactoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoContactoToolStripMenuItem.Text = "Nuevo Contacto";
            this.nuevoContactoToolStripMenuItem.Click += new System.EventHandler(this.nuevoContactoToolStripMenuItem_Click);
            // 
            // MenuApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marketin Digital";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem remitenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoRemitente;
        private System.Windows.Forms.ToolStripMenuItem remitentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carpetasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaCarpetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carpetasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nuevaListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoContactoToolStripMenuItem;
    }
}


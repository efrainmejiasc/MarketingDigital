namespace MarketingDigitalDesktop.Forms
{
    partial class DeleteUpdateContact
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtListId = new System.Windows.Forms.TextBox();
            this.namelbl = new System.Windows.Forms.Label();
            this.lastNamelbl = new System.Windows.Forms.Label();
            this.maillbl = new System.Windows.Forms.Label();
            this.phonelbl = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nuevoemail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(-1, -1);
            this.dgv.Name = "dgv";
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(572, 404);
            this.dgv.TabIndex = 2;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_ColumnHeaderMouseClick);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(590, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(590, 79);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(250, 20);
            this.txtApellido.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(590, 131);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(590, 238);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(250, 20);
            this.txttelefono.TabIndex = 6;
            // 
            // txtListId
            // 
            this.txtListId.Location = new System.Drawing.Point(577, 374);
            this.txtListId.Name = "txtListId";
            this.txtListId.Size = new System.Drawing.Size(229, 20);
            this.txtListId.TabIndex = 7;
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(587, 9);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(44, 13);
            this.namelbl.TabIndex = 8;
            this.namelbl.Text = "Nombre";
            // 
            // lastNamelbl
            // 
            this.lastNamelbl.AutoSize = true;
            this.lastNamelbl.Location = new System.Drawing.Point(587, 63);
            this.lastNamelbl.Name = "lastNamelbl";
            this.lastNamelbl.Size = new System.Drawing.Size(44, 13);
            this.lastNamelbl.TabIndex = 9;
            this.lastNamelbl.Text = "Apellido";
            // 
            // maillbl
            // 
            this.maillbl.AutoSize = true;
            this.maillbl.Location = new System.Drawing.Point(587, 115);
            this.maillbl.Name = "maillbl";
            this.maillbl.Size = new System.Drawing.Size(32, 13);
            this.maillbl.TabIndex = 10;
            this.maillbl.Text = "Email";
            // 
            // phonelbl
            // 
            this.phonelbl.AutoSize = true;
            this.phonelbl.Location = new System.Drawing.Point(587, 222);
            this.phonelbl.Name = "phonelbl";
            this.phonelbl.Size = new System.Drawing.Size(187, 13);
            this.phonelbl.TabIndex = 11;
            this.phonelbl.Text = "Telefono  ( ejemplo +5804247895623)";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(590, 285);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(90, 23);
            this.Delete.TabIndex = 12;
            this.Delete.Text = "ELIMINAR";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(750, 285);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(90, 23);
            this.Update.TabIndex = 13;
            this.Update.Text = "ACTUALIZAR";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(587, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nuevo Email  ( Ingrese si quiere actualizar)";
            // 
            // nuevoemail
            // 
            this.nuevoemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoemail.Location = new System.Drawing.Point(590, 182);
            this.nuevoemail.Name = "nuevoemail";
            this.nuevoemail.Size = new System.Drawing.Size(250, 20);
            this.nuevoemail.TabIndex = 14;
            // 
            // DeleteUpdateContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 406);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nuevoemail);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.phonelbl);
            this.Controls.Add(this.maillbl);
            this.Controls.Add(this.lastNamelbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.txtListId);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dgv);
            this.Name = "DeleteUpdateContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar - Actualizar  Contactos";
            this.Load += new System.EventHandler(this.DeleteUpdateContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtListId;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label lastNamelbl;
        private System.Windows.Forms.Label maillbl;
        private System.Windows.Forms.Label phonelbl;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nuevoemail;
    }
}
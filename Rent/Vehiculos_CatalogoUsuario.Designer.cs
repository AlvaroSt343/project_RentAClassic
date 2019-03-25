namespace Rent
{
    partial class Vehiculos_CatalogoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vehiculos_CatalogoUsuario));
            this.Listado = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Nuevo = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.Editar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Listado)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // Listado
            // 
            this.Listado.AllowUserToAddRows = false;
            this.Listado.AllowUserToDeleteRows = false;
            this.Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Listado.Location = new System.Drawing.Point(8, 46);
            this.Listado.Name = "Listado";
            this.Listado.ReadOnly = true;
            this.Listado.Size = new System.Drawing.Size(1145, 535);
            this.Listado.TabIndex = 0;
            this.Listado.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Listado_MouseDoubleClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(95)))), ((int)(((byte)(142)))));
            this.panel4.Controls.Add(this.Editar);
            this.panel4.Controls.Add(this.Nuevo);
            this.panel4.Controls.Add(this.cerrar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1161, 36);
            this.panel4.TabIndex = 11;
            // 
            // Nuevo
            // 
            this.Nuevo.BackColor = System.Drawing.Color.Transparent;
            this.Nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nuevo.FlatAppearance.BorderSize = 0;
            this.Nuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.Nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nuevo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nuevo.ForeColor = System.Drawing.Color.White;
            this.Nuevo.Location = new System.Drawing.Point(3, 1);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(142, 32);
            this.Nuevo.TabIndex = 13;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.UseVisualStyleBackColor = false;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(1132, 5);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(25, 25);
            this.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrar.TabIndex = 12;
            this.cerrar.TabStop = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // Editar
            // 
            this.Editar.BackColor = System.Drawing.Color.Transparent;
            this.Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Editar.FlatAppearance.BorderSize = 0;
            this.Editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.Editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editar.ForeColor = System.Drawing.Color.White;
            this.Editar.Location = new System.Drawing.Point(148, 1);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(142, 32);
            this.Editar.TabIndex = 14;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = false;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Vehiculos_CatalogoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 593);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Listado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vehiculos_CatalogoUsuario";
            this.Text = "Vehiculos_CatalogoUsuario";
            this.Load += new System.EventHandler(this.Vehiculos_CatalogoUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Listado)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Listado;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.PictureBox cerrar;
    }
}
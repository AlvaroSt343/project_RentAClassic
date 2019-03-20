namespace Rent
{
    partial class Usuario_Catalogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario_Catalogo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Borrar = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.nuevaRenta = new System.Windows.Forms.Button();
            this.Listado = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Listado)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(95)))), ((int)(((byte)(142)))));
            this.panel1.Controls.Add(this.Borrar);
            this.panel1.Controls.Add(this.Editar);
            this.panel1.Controls.Add(this.cerrar);
            this.panel1.Controls.Add(this.nuevaRenta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 36);
            this.panel1.TabIndex = 6;
            // 
            // Borrar
            // 
            this.Borrar.BackColor = System.Drawing.Color.Transparent;
            this.Borrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Borrar.FlatAppearance.BorderSize = 0;
            this.Borrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.Borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Borrar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Borrar.ForeColor = System.Drawing.Color.White;
            this.Borrar.Location = new System.Drawing.Point(299, 1);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(142, 32);
            this.Borrar.TabIndex = 15;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseVisualStyleBackColor = false;
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
            this.Editar.Location = new System.Drawing.Point(151, 1);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(142, 32);
            this.Editar.TabIndex = 13;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = false;
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(704, 5);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(25, 25);
            this.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrar.TabIndex = 12;
            this.cerrar.TabStop = false;
            // 
            // nuevaRenta
            // 
            this.nuevaRenta.BackColor = System.Drawing.Color.Transparent;
            this.nuevaRenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nuevaRenta.FlatAppearance.BorderSize = 0;
            this.nuevaRenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.nuevaRenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.nuevaRenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevaRenta.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevaRenta.ForeColor = System.Drawing.Color.White;
            this.nuevaRenta.Location = new System.Drawing.Point(3, 1);
            this.nuevaRenta.Name = "nuevaRenta";
            this.nuevaRenta.Size = new System.Drawing.Size(142, 32);
            this.nuevaRenta.TabIndex = 11;
            this.nuevaRenta.Text = "Nuevo Usuario";
            this.nuevaRenta.UseVisualStyleBackColor = false;
            this.nuevaRenta.Click += new System.EventHandler(this.nuevaRenta_Click);
            // 
            // Listado
            // 
            this.Listado.AllowUserToAddRows = false;
            this.Listado.AllowUserToDeleteRows = false;
            this.Listado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Listado.BackgroundColor = System.Drawing.Color.DarkGray;
            this.Listado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Listado.Location = new System.Drawing.Point(12, 42);
            this.Listado.Name = "Listado";
            this.Listado.ReadOnly = true;
            this.Listado.Size = new System.Drawing.Size(709, 350);
            this.Listado.TabIndex = 5;
            // 
            // Usuario_Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 404);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Listado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usuario_Catalogo";
            this.Opacity = 0.1D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario_Catalogo";
            this.Load += new System.EventHandler(this.Usuario_Catalogo_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Listado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.Button nuevaRenta;
        private System.Windows.Forms.DataGridView Listado;
    }
}
namespace Rent
{
    partial class Renta_Catalogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Renta_Catalogo));
            this.Listado = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Listado)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // Listado
            // 
            this.Listado.AllowUserToAddRows = false;
            this.Listado.AllowUserToDeleteRows = false;
            this.Listado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Listado.BackgroundColor = System.Drawing.Color.White;
            this.Listado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Listado.Location = new System.Drawing.Point(12, 58);
            this.Listado.Name = "Listado";
            this.Listado.ReadOnly = true;
            this.Listado.Size = new System.Drawing.Size(1004, 564);
            this.Listado.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(95)))), ((int)(((byte)(142)))));
            this.panel1.Controls.Add(this.cerrar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1252, 36);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "Nueva Renta";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(1223, 5);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(25, 25);
            this.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrar.TabIndex = 12;
            this.cerrar.TabStop = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // Renta_Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1252, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Listado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Renta_Catalogo";
            this.Text = "Renta_Catalogo";
            this.Load += new System.EventHandler(this.Renta_Catalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Listado)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Listado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox cerrar;
    }
}
namespace Rent
{
    partial class Clientes_Catalogo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes_Catalogo));
            this.Listado = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.visualizar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.nuevaRenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Listado)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // Listado
            // 
            this.Listado.AllowUserToAddRows = false;
            this.Listado.AllowUserToDeleteRows = false;
            this.Listado.BackgroundColor = System.Drawing.Color.Silver;
            this.Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Listado.Location = new System.Drawing.Point(6, 38);
            this.Listado.Name = "Listado";
            this.Listado.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Listado.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Listado.RowHeadersVisible = false;
            this.Listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Listado.Size = new System.Drawing.Size(1103, 471);
            this.Listado.TabIndex = 82;
            this.Listado.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Listado_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(95)))), ((int)(((byte)(142)))));
            this.panel1.Controls.Add(this.visualizar);
            this.panel1.Controls.Add(this.cancelar);
            this.panel1.Controls.Add(this.editar);
            this.panel1.Controls.Add(this.nuevaRenta);
            this.panel1.Controls.Add(this.cerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 32);
            this.panel1.TabIndex = 83;
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(1081, 4);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(25, 25);
            this.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrar.TabIndex = 12;
            this.cerrar.TabStop = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // visualizar
            // 
            this.visualizar.BackColor = System.Drawing.Color.Transparent;
            this.visualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.visualizar.FlatAppearance.BorderSize = 0;
            this.visualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.visualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.visualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visualizar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.visualizar.ForeColor = System.Drawing.Color.White;
            this.visualizar.Location = new System.Drawing.Point(288, 0);
            this.visualizar.Name = "visualizar";
            this.visualizar.Size = new System.Drawing.Size(142, 32);
            this.visualizar.TabIndex = 58;
            this.visualizar.Text = "Imprimir";
            this.visualizar.UseVisualStyleBackColor = false;
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.Color.Transparent;
            this.cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelar.FlatAppearance.BorderSize = 0;
            this.cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelar.ForeColor = System.Drawing.Color.White;
            this.cancelar.Location = new System.Drawing.Point(432, 0);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(142, 32);
            this.cancelar.TabIndex = 57;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = false;
            // 
            // editar
            // 
            this.editar.BackColor = System.Drawing.Color.Transparent;
            this.editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editar.FlatAppearance.BorderSize = 0;
            this.editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editar.ForeColor = System.Drawing.Color.White;
            this.editar.Location = new System.Drawing.Point(143, 0);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(142, 32);
            this.editar.TabIndex = 56;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = false;
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
            this.nuevaRenta.Location = new System.Drawing.Point(0, 0);
            this.nuevaRenta.Name = "nuevaRenta";
            this.nuevaRenta.Size = new System.Drawing.Size(142, 32);
            this.nuevaRenta.TabIndex = 55;
            this.nuevaRenta.Text = "Nuevo Cliente";
            this.nuevaRenta.UseVisualStyleBackColor = false;
            // 
            // Clientes_Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 518);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Listado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientes_Catalogo";
            this.Text = "Clientes_Info";
            this.Load += new System.EventHandler(this.Clientes_Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Listado)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Listado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.Button visualizar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button nuevaRenta;
    }
}
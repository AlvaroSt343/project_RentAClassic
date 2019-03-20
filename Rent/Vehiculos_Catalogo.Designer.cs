namespace Rent
{
    partial class Vehiculos_Catalogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vehiculos_Catalogo));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.Motorcycle = new System.Windows.Forms.Button();
            this.PickUp = new System.Windows.Forms.Button();
            this.Muscle = new System.Windows.Forms.Button();
            this.Classic = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.botonMenu = new System.Windows.Forms.PictureBox();
            this.panelVehiculos = new System.Windows.Forms.Panel();
            this.panelContVehiculos = new System.Windows.Forms.Panel();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTitulo.Controls.Add(this.Motorcycle);
            this.panelTitulo.Controls.Add(this.PickUp);
            this.panelTitulo.Controls.Add(this.Muscle);
            this.panelTitulo.Controls.Add(this.Classic);
            this.panelTitulo.Controls.Add(this.cerrar);
            this.panelTitulo.Controls.Add(this.botonMenu);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1386, 33);
            this.panelTitulo.TabIndex = 1;
            // 
            // Motorcycle
            // 
            this.Motorcycle.BackColor = System.Drawing.Color.CadetBlue;
            this.Motorcycle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Motorcycle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Motorcycle.ForeColor = System.Drawing.Color.White;
            this.Motorcycle.Location = new System.Drawing.Point(192, 0);
            this.Motorcycle.Name = "Motorcycle";
            this.Motorcycle.Size = new System.Drawing.Size(90, 33);
            this.Motorcycle.TabIndex = 17;
            this.Motorcycle.Text = "Motorcycle";
            this.Motorcycle.UseVisualStyleBackColor = false;
            this.Motorcycle.Click += new System.EventHandler(this.Motorcycle_Click);
            // 
            // PickUp
            // 
            this.PickUp.BackColor = System.Drawing.Color.CadetBlue;
            this.PickUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PickUp.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickUp.ForeColor = System.Drawing.Color.White;
            this.PickUp.Location = new System.Drawing.Point(122, 0);
            this.PickUp.Name = "PickUp";
            this.PickUp.Size = new System.Drawing.Size(72, 33);
            this.PickUp.TabIndex = 18;
            this.PickUp.Text = "Pick-Up";
            this.PickUp.UseVisualStyleBackColor = false;
            this.PickUp.Click += new System.EventHandler(this.PickUp_Click);
            // 
            // Muscle
            // 
            this.Muscle.BackColor = System.Drawing.Color.CadetBlue;
            this.Muscle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Muscle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Muscle.ForeColor = System.Drawing.Color.White;
            this.Muscle.Location = new System.Drawing.Point(64, 0);
            this.Muscle.Name = "Muscle";
            this.Muscle.Size = new System.Drawing.Size(59, 33);
            this.Muscle.TabIndex = 19;
            this.Muscle.Text = "Muscle";
            this.Muscle.UseVisualStyleBackColor = false;
            this.Muscle.Click += new System.EventHandler(this.Muscle_Click);
            // 
            // Classic
            // 
            this.Classic.BackColor = System.Drawing.Color.CadetBlue;
            this.Classic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Classic.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Classic.ForeColor = System.Drawing.Color.White;
            this.Classic.Location = new System.Drawing.Point(0, 0);
            this.Classic.Name = "Classic";
            this.Classic.Size = new System.Drawing.Size(65, 33);
            this.Classic.TabIndex = 20;
            this.Classic.Text = "Classic";
            this.Classic.UseVisualStyleBackColor = false;
            this.Classic.Click += new System.EventHandler(this.Classic_Click);
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(1354, 1);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(30, 30);
            this.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrar.TabIndex = 3;
            this.cerrar.TabStop = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // botonMenu
            // 
            this.botonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonMenu.Image = ((System.Drawing.Image)(resources.GetObject("botonMenu.Image")));
            this.botonMenu.Location = new System.Drawing.Point(280, 0);
            this.botonMenu.Name = "botonMenu";
            this.botonMenu.Size = new System.Drawing.Size(35, 35);
            this.botonMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonMenu.TabIndex = 2;
            this.botonMenu.TabStop = false;
            this.botonMenu.Click += new System.EventHandler(this.botonMenu_Click);
            // 
            // panelVehiculos
            // 
            this.panelVehiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panelVehiculos.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelVehiculos.Location = new System.Drawing.Point(0, 33);
            this.panelVehiculos.Name = "panelVehiculos";
            this.panelVehiculos.Size = new System.Drawing.Size(282, 755);
            this.panelVehiculos.TabIndex = 3;
            // 
            // panelContVehiculos
            // 
            this.panelContVehiculos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContVehiculos.Location = new System.Drawing.Point(282, 33);
            this.panelContVehiculos.Name = "panelContVehiculos";
            this.panelContVehiculos.Size = new System.Drawing.Size(1104, 755);
            this.panelContVehiculos.TabIndex = 4;
            // 
            // Vehiculos_Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.panelContVehiculos);
            this.Controls.Add(this.panelVehiculos);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vehiculos_Catalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehiculos_Catalogo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.PictureBox botonMenu;
        private System.Windows.Forms.Button Motorcycle;
        private System.Windows.Forms.Button PickUp;
        private System.Windows.Forms.Button Muscle;
        private System.Windows.Forms.Button Classic;
        private System.Windows.Forms.Panel panelVehiculos;
        private System.Windows.Forms.Panel panelContVehiculos;
    }
}
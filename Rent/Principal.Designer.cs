namespace Rent
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.CerrarSesion = new System.Windows.Forms.Button();
            this.Config = new System.Windows.Forms.Button();
            this.Reportes = new System.Windows.Forms.Button();
            this.Usuarios = new System.Windows.Forms.Button();
            this.Clientes = new System.Windows.Forms.Button();
            this.Rentas = new System.Windows.Forms.Button();
            this.Vehiculos = new System.Windows.Forms.Button();
            this.logo2 = new System.Windows.Forms.PictureBox();
            this.logo1 = new System.Windows.Forms.PictureBox();
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.maximizar = new System.Windows.Forms.PictureBox();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.botonMenu = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo1)).BeginInit();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.MenuVertical.Controls.Add(this.CerrarSesion);
            this.MenuVertical.Controls.Add(this.Config);
            this.MenuVertical.Controls.Add(this.Reportes);
            this.MenuVertical.Controls.Add(this.Usuarios);
            this.MenuVertical.Controls.Add(this.Clientes);
            this.MenuVertical.Controls.Add(this.Rentas);
            this.MenuVertical.Controls.Add(this.Vehiculos);
            this.MenuVertical.Controls.Add(this.logo2);
            this.MenuVertical.Controls.Add(this.logo1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(53, 788);
            this.MenuVertical.TabIndex = 0;
            this.MenuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuVertical_Paint);
            // 
            // CerrarSesion
            // 
            this.CerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CerrarSesion.FlatAppearance.BorderSize = 0;
            this.CerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(115)))), ((int)(((byte)(159)))));
            this.CerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(77)))), ((int)(((byte)(116)))));
            this.CerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CerrarSesion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CerrarSesion.ForeColor = System.Drawing.Color.White;
            this.CerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("CerrarSesion.Image")));
            this.CerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CerrarSesion.Location = new System.Drawing.Point(3, 686);
            this.CerrarSesion.Name = "CerrarSesion";
            this.CerrarSesion.Size = new System.Drawing.Size(250, 45);
            this.CerrarSesion.TabIndex = 8;
            this.CerrarSesion.Text = "Cerrar Sesion";
            this.CerrarSesion.UseVisualStyleBackColor = true;
            this.CerrarSesion.Click += new System.EventHandler(this.CerrarSesion_Click);
            // 
            // Config
            // 
            this.Config.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Config.FlatAppearance.BorderSize = 0;
            this.Config.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(115)))), ((int)(((byte)(159)))));
            this.Config.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(77)))), ((int)(((byte)(116)))));
            this.Config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Config.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Config.ForeColor = System.Drawing.Color.White;
            this.Config.Image = ((System.Drawing.Image)(resources.GetObject("Config.Image")));
            this.Config.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Config.Location = new System.Drawing.Point(3, 613);
            this.Config.Name = "Config";
            this.Config.Size = new System.Drawing.Size(250, 45);
            this.Config.TabIndex = 7;
            this.Config.Text = "Configuracion";
            this.Config.UseVisualStyleBackColor = true;
            this.Config.Click += new System.EventHandler(this.Config_Click);
            // 
            // Reportes
            // 
            this.Reportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reportes.FlatAppearance.BorderSize = 0;
            this.Reportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(115)))), ((int)(((byte)(159)))));
            this.Reportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(77)))), ((int)(((byte)(116)))));
            this.Reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reportes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reportes.ForeColor = System.Drawing.Color.White;
            this.Reportes.Image = ((System.Drawing.Image)(resources.GetObject("Reportes.Image")));
            this.Reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reportes.Location = new System.Drawing.Point(3, 535);
            this.Reportes.Name = "Reportes";
            this.Reportes.Size = new System.Drawing.Size(250, 45);
            this.Reportes.TabIndex = 6;
            this.Reportes.Text = "Reportes";
            this.Reportes.UseVisualStyleBackColor = true;
            this.Reportes.Click += new System.EventHandler(this.Reportes_Click);
            // 
            // Usuarios
            // 
            this.Usuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Usuarios.FlatAppearance.BorderSize = 0;
            this.Usuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(115)))), ((int)(((byte)(159)))));
            this.Usuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(77)))), ((int)(((byte)(116)))));
            this.Usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Usuarios.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuarios.ForeColor = System.Drawing.Color.White;
            this.Usuarios.Image = ((System.Drawing.Image)(resources.GetObject("Usuarios.Image")));
            this.Usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Usuarios.Location = new System.Drawing.Point(3, 452);
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Size = new System.Drawing.Size(250, 45);
            this.Usuarios.TabIndex = 5;
            this.Usuarios.Text = "Usuarios";
            this.Usuarios.UseVisualStyleBackColor = true;
            this.Usuarios.Click += new System.EventHandler(this.Usuarios_Click);
            // 
            // Clientes
            // 
            this.Clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clientes.FlatAppearance.BorderSize = 0;
            this.Clientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(115)))), ((int)(((byte)(159)))));
            this.Clientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(77)))), ((int)(((byte)(116)))));
            this.Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clientes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clientes.ForeColor = System.Drawing.Color.White;
            this.Clientes.Image = ((System.Drawing.Image)(resources.GetObject("Clientes.Image")));
            this.Clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clientes.Location = new System.Drawing.Point(3, 374);
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(250, 45);
            this.Clientes.TabIndex = 4;
            this.Clientes.Text = "Clientes";
            this.Clientes.UseVisualStyleBackColor = true;
            this.Clientes.Click += new System.EventHandler(this.Clientes_Click);
            // 
            // Rentas
            // 
            this.Rentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rentas.FlatAppearance.BorderSize = 0;
            this.Rentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(115)))), ((int)(((byte)(159)))));
            this.Rentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(77)))), ((int)(((byte)(116)))));
            this.Rentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rentas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rentas.ForeColor = System.Drawing.Color.White;
            this.Rentas.Image = ((System.Drawing.Image)(resources.GetObject("Rentas.Image")));
            this.Rentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Rentas.Location = new System.Drawing.Point(3, 293);
            this.Rentas.Name = "Rentas";
            this.Rentas.Size = new System.Drawing.Size(250, 45);
            this.Rentas.TabIndex = 3;
            this.Rentas.Text = "Rentas";
            this.Rentas.UseVisualStyleBackColor = true;
            this.Rentas.Click += new System.EventHandler(this.Rentas_Click);
            // 
            // Vehiculos
            // 
            this.Vehiculos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Vehiculos.FlatAppearance.BorderSize = 0;
            this.Vehiculos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(115)))), ((int)(((byte)(159)))));
            this.Vehiculos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(77)))), ((int)(((byte)(116)))));
            this.Vehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vehiculos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vehiculos.ForeColor = System.Drawing.Color.White;
            this.Vehiculos.Image = ((System.Drawing.Image)(resources.GetObject("Vehiculos.Image")));
            this.Vehiculos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Vehiculos.Location = new System.Drawing.Point(3, 223);
            this.Vehiculos.Name = "Vehiculos";
            this.Vehiculos.Size = new System.Drawing.Size(250, 45);
            this.Vehiculos.TabIndex = 2;
            this.Vehiculos.Text = "Vehiculos";
            this.Vehiculos.UseVisualStyleBackColor = true;
            this.Vehiculos.Click += new System.EventHandler(this.Vehiculos_Click);
            // 
            // logo2
            // 
            this.logo2.Image = ((System.Drawing.Image)(resources.GetObject("logo2.Image")));
            this.logo2.Location = new System.Drawing.Point(5, 8);
            this.logo2.Name = "logo2";
            this.logo2.Size = new System.Drawing.Size(45, 45);
            this.logo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo2.TabIndex = 1;
            this.logo2.TabStop = false;
            // 
            // logo1
            // 
            this.logo1.Image = ((System.Drawing.Image)(resources.GetObject("logo1.Image")));
            this.logo1.Location = new System.Drawing.Point(12, 9);
            this.logo1.Name = "logo1";
            this.logo1.Size = new System.Drawing.Size(228, 143);
            this.logo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo1.TabIndex = 0;
            this.logo1.TabStop = false;
            this.logo1.Visible = false;
            // 
            // barraTitulo
            // 
            this.barraTitulo.Controls.Add(this.minimizar);
            this.barraTitulo.Controls.Add(this.maximizar);
            this.barraTitulo.Controls.Add(this.cerrar);
            this.barraTitulo.Controls.Add(this.botonMenu);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(53, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(1247, 50);
            this.barraTitulo.TabIndex = 1;
            this.barraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.barraTitulo_Paint);
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown);
            // 
            // minimizar
            // 
            this.minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.Location = new System.Drawing.Point(1118, 9);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(35, 35);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizar.TabIndex = 3;
            this.minimizar.TabStop = false;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // maximizar
            // 
            this.maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizar.Image = ((System.Drawing.Image)(resources.GetObject("maximizar.Image")));
            this.maximizar.Location = new System.Drawing.Point(1159, 9);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(35, 35);
            this.maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximizar.TabIndex = 2;
            this.maximizar.TabStop = false;
            this.maximizar.Click += new System.EventHandler(this.maximizar_Click);
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(1200, 9);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(35, 35);
            this.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrar.TabIndex = 1;
            this.cerrar.TabStop = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // botonMenu
            // 
            this.botonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonMenu.Image = ((System.Drawing.Image)(resources.GetObject("botonMenu.Image")));
            this.botonMenu.Location = new System.Drawing.Point(6, 9);
            this.botonMenu.Name = "botonMenu";
            this.botonMenu.Size = new System.Drawing.Size(35, 35);
            this.botonMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonMenu.TabIndex = 0;
            this.botonMenu.TabStop = false;
            this.botonMenu.Click += new System.EventHandler(this.botonMenu_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(53, 50);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1247, 738);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 788);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.barraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo1)).EndInit();
            this.barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox botonMenu;
        private System.Windows.Forms.PictureBox logo1;
        private System.Windows.Forms.PictureBox logo2;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.PictureBox maximizar;
        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.Button Vehiculos;
        private System.Windows.Forms.Button Clientes;
        private System.Windows.Forms.Button Rentas;
        private System.Windows.Forms.Button CerrarSesion;
        private System.Windows.Forms.Button Config;
        private System.Windows.Forms.Button Reportes;
        private System.Windows.Forms.Button Usuarios;
    }
}


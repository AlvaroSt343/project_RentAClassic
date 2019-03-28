namespace Rent
{
    partial class ApartadoPregunta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApartadoPregunta));
            this.titulo = new System.Windows.Forms.Label();
            this.panel3Cliente = new System.Windows.Forms.Panel();
            this.NO = new System.Windows.Forms.PictureBox();
            this.SI = new System.Windows.Forms.PictureBox();
            this.panelDesea = new System.Windows.Forms.Panel();
            this.noCliente = new System.Windows.Forms.PictureBox();
            this.siCliente = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3Cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SI)).BeginInit();
            this.panelDesea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.BackColor = System.Drawing.Color.DarkCyan;
            this.titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.titulo.Font = new System.Drawing.Font("Century Gothic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.White;
            this.titulo.Location = new System.Drawing.Point(0, 0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(743, 69);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "¿YA ES USTED CLIENTE?";
            this.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3Cliente
            // 
            this.panel3Cliente.Controls.Add(this.NO);
            this.panel3Cliente.Controls.Add(this.SI);
            this.panel3Cliente.Location = new System.Drawing.Point(103, 82);
            this.panel3Cliente.Name = "panel3Cliente";
            this.panel3Cliente.Size = new System.Drawing.Size(540, 281);
            this.panel3Cliente.TabIndex = 1;
            this.panel3Cliente.Visible = false;
            // 
            // NO
            // 
            this.NO.Image = ((System.Drawing.Image)(resources.GetObject("NO.Image")));
            this.NO.Location = new System.Drawing.Point(331, 72);
            this.NO.Name = "NO";
            this.NO.Size = new System.Drawing.Size(150, 150);
            this.NO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NO.TabIndex = 1;
            this.NO.TabStop = false;
            this.NO.Click += new System.EventHandler(this.NO_Click);
            this.NO.MouseLeave += new System.EventHandler(this.NO_MouseLeave);
            this.NO.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NO_MouseMove);
            // 
            // SI
            // 
            this.SI.Image = ((System.Drawing.Image)(resources.GetObject("SI.Image")));
            this.SI.Location = new System.Drawing.Point(50, 72);
            this.SI.Name = "SI";
            this.SI.Size = new System.Drawing.Size(150, 150);
            this.SI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SI.TabIndex = 0;
            this.SI.TabStop = false;
            this.SI.Click += new System.EventHandler(this.SI_Click);
            this.SI.MouseLeave += new System.EventHandler(this.SI_MouseLeave);
            this.SI.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SI_MouseMove);
            // 
            // panelDesea
            // 
            this.panelDesea.Controls.Add(this.noCliente);
            this.panelDesea.Controls.Add(this.siCliente);
            this.panelDesea.Location = new System.Drawing.Point(58, 119);
            this.panelDesea.Name = "panelDesea";
            this.panelDesea.Size = new System.Drawing.Size(629, 241);
            this.panelDesea.TabIndex = 2;
            this.panelDesea.Visible = false;
            // 
            // noCliente
            // 
            this.noCliente.Image = ((System.Drawing.Image)(resources.GetObject("noCliente.Image")));
            this.noCliente.Location = new System.Drawing.Point(377, 39);
            this.noCliente.Name = "noCliente";
            this.noCliente.Size = new System.Drawing.Size(150, 150);
            this.noCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.noCliente.TabIndex = 3;
            this.noCliente.TabStop = false;
            this.noCliente.Click += new System.EventHandler(this.noCliente_Click);
            this.noCliente.MouseLeave += new System.EventHandler(this.noCliente_MouseLeave);
            this.noCliente.MouseMove += new System.Windows.Forms.MouseEventHandler(this.noCliente_MouseMove);
            // 
            // siCliente
            // 
            this.siCliente.Image = ((System.Drawing.Image)(resources.GetObject("siCliente.Image")));
            this.siCliente.Location = new System.Drawing.Point(96, 39);
            this.siCliente.Name = "siCliente";
            this.siCliente.Size = new System.Drawing.Size(150, 150);
            this.siCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siCliente.TabIndex = 2;
            this.siCliente.TabStop = false;
            this.siCliente.Click += new System.EventHandler(this.siCliente_Click);
            this.siCliente.MouseLeave += new System.EventHandler(this.siCliente_MouseLeave);
            this.siCliente.MouseMove += new System.Windows.Forms.MouseEventHandler(this.siCliente_MouseMove);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(743, 26);
            this.label1.TabIndex = 5;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ApartadoPregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(743, 410);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3Cliente);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.panelDesea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ApartadoPregunta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApartadoPregunta";
            this.panel3Cliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SI)).EndInit();
            this.panelDesea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.noCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox SI;
        private System.Windows.Forms.PictureBox NO;
        public System.Windows.Forms.Label titulo;
        private System.Windows.Forms.PictureBox noCliente;
        private System.Windows.Forms.PictureBox siCliente;
        public System.Windows.Forms.Panel panel3Cliente;
        public System.Windows.Forms.Panel panelDesea;
        public System.Windows.Forms.Label label1;
    }
}
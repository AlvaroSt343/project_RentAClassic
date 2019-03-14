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
            this.label1 = new System.Windows.Forms.Label();
            this.alta = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.PictureBox();
            this.catalogo = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 62);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(260, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catalogo de Usuarios";
            // 
            // alta
            // 
            this.alta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.alta.FlatAppearance.BorderSize = 0;
            this.alta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alta.ForeColor = System.Drawing.SystemColors.Control;
            this.alta.Location = new System.Drawing.Point(610, 352);
            this.alta.Name = "alta";
            this.alta.Size = new System.Drawing.Size(144, 44);
            this.alta.TabIndex = 5;
            this.alta.Text = "Dar de alta Usuario";
            this.alta.UseVisualStyleBackColor = false;
            // 
            // borrar
            // 
            this.borrar.Image = ((System.Drawing.Image)(resources.GetObject("borrar.Image")));
            this.borrar.Location = new System.Drawing.Point(610, 120);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(72, 79);
            this.borrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.borrar.TabIndex = 4;
            this.borrar.TabStop = false;
            // 
            // catalogo
            // 
            this.catalogo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catalogo.FormattingEnabled = true;
            this.catalogo.ItemHeight = 17;
            this.catalogo.Location = new System.Drawing.Point(51, 120);
            this.catalogo.Name = "catalogo";
            this.catalogo.Size = new System.Drawing.Size(542, 276);
            this.catalogo.TabIndex = 3;
            // 
            // Usuario_Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 481);
            this.Controls.Add(this.alta);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.catalogo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usuario_Catalogo";
            this.Opacity = 0.1D;
            this.Text = "Usuario_Catalogo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button alta;
        private System.Windows.Forms.PictureBox borrar;
        private System.Windows.Forms.ListBox catalogo;
    }
}
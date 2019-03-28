namespace Rent
{
    partial class Clientes_Alta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes_Alta));
            this.panel1 = new System.Windows.Forms.Panel();
            this.nuevo = new System.Windows.Forms.Button();
            this.guarda = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.correo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.telefono1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.apellido2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.apellido1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clave = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cuenta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.domicilio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nombre2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.telefono2 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.estatus = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(95)))), ((int)(((byte)(142)))));
            this.panel1.Controls.Add(this.nuevo);
            this.panel1.Controls.Add(this.guarda);
            this.panel1.Controls.Add(this.cerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 32);
            this.panel1.TabIndex = 84;
            // 
            // nuevo
            // 
            this.nuevo.BackColor = System.Drawing.Color.Transparent;
            this.nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nuevo.FlatAppearance.BorderSize = 0;
            this.nuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevo.ForeColor = System.Drawing.Color.White;
            this.nuevo.Location = new System.Drawing.Point(143, 0);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(142, 32);
            this.nuevo.TabIndex = 11;
            this.nuevo.Text = "Nuevo";
            this.nuevo.UseVisualStyleBackColor = false;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // guarda
            // 
            this.guarda.BackColor = System.Drawing.Color.Transparent;
            this.guarda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guarda.FlatAppearance.BorderSize = 0;
            this.guarda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.guarda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.guarda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guarda.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guarda.ForeColor = System.Drawing.Color.White;
            this.guarda.Location = new System.Drawing.Point(0, 0);
            this.guarda.Name = "guarda";
            this.guarda.Size = new System.Drawing.Size(142, 32);
            this.guarda.TabIndex = 10;
            this.guarda.Text = "Guardar";
            this.guarda.UseVisualStyleBackColor = false;
            this.guarda.Click += new System.EventHandler(this.guarda_Click);
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(727, 4);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(25, 25);
            this.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrar.TabIndex = 12;
            this.cerrar.TabStop = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.estatus);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.domicilio);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cuenta);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.correo);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.telefono1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.apellido2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.apellido1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.nombre);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.clave);
            this.panel2.Location = new System.Drawing.Point(12, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(733, 202);
            this.panel2.TabIndex = 85;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(435, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "Correo:";
            // 
            // correo
            // 
            this.correo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correo.Location = new System.Drawing.Point(518, 23);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(202, 25);
            this.correo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "Telefono:";
            // 
            // telefono1
            // 
            this.telefono1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono1.Location = new System.Drawing.Point(116, 151);
            this.telefono1.Name = "telefono1";
            this.telefono1.Size = new System.Drawing.Size(142, 25);
            this.telefono1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Apellido M:";
            // 
            // apellido2
            // 
            this.apellido2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido2.Location = new System.Drawing.Point(116, 120);
            this.apellido2.Name = "apellido2";
            this.apellido2.Size = new System.Drawing.Size(229, 25);
            this.apellido2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Apellido P:";
            // 
            // apellido1
            // 
            this.apellido1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido1.Location = new System.Drawing.Point(116, 89);
            this.apellido1.Name = "apellido1";
            this.apellido1.Size = new System.Drawing.Size(229, 25);
            this.apellido1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre(s):";
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(116, 58);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(229, 25);
            this.nombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Clave:";
            // 
            // clave
            // 
            this.clave.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clave.Location = new System.Drawing.Point(116, 27);
            this.clave.Name = "clave";
            this.clave.ReadOnly = true;
            this.clave.Size = new System.Drawing.Size(60, 25);
            this.clave.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(435, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 19);
            this.label7.TabIndex = 25;
            this.label7.Text = "Domicilio:";
            // 
            // cuenta
            // 
            this.cuenta.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuenta.Location = new System.Drawing.Point(518, 151);
            this.cuenta.Name = "cuenta";
            this.cuenta.Size = new System.Drawing.Size(202, 25);
            this.cuenta.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(435, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 36);
            this.label8.TabIndex = 27;
            this.label8.Text = "Cuenta Bancaria:";
            // 
            // domicilio
            // 
            this.domicilio.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domicilio.Location = new System.Drawing.Point(518, 58);
            this.domicilio.Multiline = true;
            this.domicilio.Name = "domicilio";
            this.domicilio.Size = new System.Drawing.Size(202, 81);
            this.domicilio.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 19);
            this.label9.TabIndex = 29;
            this.label9.Text = "Nombre Completo:";
            // 
            // nombre2
            // 
            this.nombre2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre2.Location = new System.Drawing.Point(152, 20);
            this.nombre2.Name = "nombre2";
            this.nombre2.Size = new System.Drawing.Size(311, 25);
            this.nombre2.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(488, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 19);
            this.label10.TabIndex = 31;
            this.label10.Text = "Celular:";
            // 
            // telefono2
            // 
            this.telefono2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono2.Location = new System.Drawing.Point(556, 20);
            this.telefono2.Name = "telefono2";
            this.telefono2.Size = new System.Drawing.Size(165, 25);
            this.telefono2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.nombre2);
            this.panel3.Controls.Add(this.telefono2);
            this.panel3.Location = new System.Drawing.Point(12, 262);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(733, 65);
            this.panel3.TabIndex = 86;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(175, 18);
            this.label11.TabIndex = 87;
            this.label11.Text = "En caso de accidente:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(16, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 18);
            this.label12.TabIndex = 89;
            this.label12.Text = "Datos generales:";
            // 
            // estatus
            // 
            this.estatus.AutoSize = true;
            this.estatus.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.estatus.Checked = true;
            this.estatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.estatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estatus.Location = new System.Drawing.Point(282, 29);
            this.estatus.Name = "estatus";
            this.estatus.Size = new System.Drawing.Size(63, 19);
            this.estatus.TabIndex = 51;
            this.estatus.Text = "Activo";
            this.estatus.UseVisualStyleBackColor = true;
            // 
            // Clientes_Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 344);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientes_Alta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes_Alta";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button nuevo;
        private System.Windows.Forms.Button guarda;
        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox estatus;
        public System.Windows.Forms.TextBox cuenta;
        public System.Windows.Forms.TextBox correo;
        public System.Windows.Forms.TextBox telefono1;
        public System.Windows.Forms.TextBox apellido2;
        public System.Windows.Forms.TextBox apellido1;
        public System.Windows.Forms.TextBox nombre;
        public System.Windows.Forms.TextBox clave;
        public System.Windows.Forms.TextBox telefono2;
        public System.Windows.Forms.TextBox nombre2;
        public System.Windows.Forms.TextBox domicilio;
    }
}
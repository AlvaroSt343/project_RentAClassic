namespace Rent
{
    partial class Renta_Alta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Renta_Alta));
            this.cliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.telefono = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.correo = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Clientes = new System.Windows.Forms.Button();
            this.Clave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TotalDias = new System.Windows.Forms.TextBox();
            this.CalcularTotales = new System.Windows.Forms.Button();
            this.TotalHoras = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.descuentos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.devolucion = new System.Windows.Forms.DateTimePicker();
            this.entrega = new System.Windows.Forms.DateTimePicker();
            this.total = new System.Windows.Forms.TextBox();
            this.impuestos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.subtotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.GuardayConfirma = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.transmision = new System.Windows.Forms.ComboBox();
            this.tipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.placa = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.fabricacion = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.modelo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.color = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.marca = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.estatus = new System.Windows.Forms.Label();
            this.precioXdia = new System.Windows.Forms.Label();
            this.precioXhora = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cliente
            // 
            this.cliente.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente.Location = new System.Drawing.Point(207, 13);
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            this.cliente.Size = new System.Drawing.Size(325, 25);
            this.cliente.TabIndex = 3;
            this.cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.telefono);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.correo);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.Clientes);
            this.panel1.Controls.Add(this.Clave);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cliente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 87);
            this.panel1.TabIndex = 6;
            // 
            // telefono
            // 
            this.telefono.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono.Location = new System.Drawing.Point(345, 48);
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Size = new System.Drawing.Size(187, 25);
            this.telefono.TabIndex = 10;
            this.telefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(284, 48);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 13);
            this.label19.TabIndex = 9;
            this.label19.Text = "Telefono:";
            // 
            // correo
            // 
            this.correo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correo.Location = new System.Drawing.Point(58, 50);
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            this.correo.Size = new System.Drawing.Size(222, 25);
            this.correo.TabIndex = 8;
            this.correo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(5, 50);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "Correo:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Silver;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(592, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Clientes
            // 
            this.Clientes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clientes.FlatAppearance.BorderSize = 0;
            this.Clientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(115)))), ((int)(((byte)(159)))));
            this.Clientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(77)))), ((int)(((byte)(116)))));
            this.Clientes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Clientes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clientes.ForeColor = System.Drawing.Color.White;
            this.Clientes.Location = new System.Drawing.Point(550, 31);
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(27, 27);
            this.Clientes.TabIndex = 5;
            this.Clientes.UseVisualStyleBackColor = false;
            this.Clientes.Click += new System.EventHandler(this.Clientes_Click);
            // 
            // Clave
            // 
            this.Clave.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clave.Location = new System.Drawing.Point(58, 13);
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            this.Clave.Size = new System.Drawing.Size(74, 25);
            this.Clave.TabIndex = 3;
            this.Clave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clave:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.precioXhora);
            this.panel3.Controls.Add(this.precioXdia);
            this.panel3.Controls.Add(this.label24);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.TotalDias);
            this.panel3.Controls.Add(this.CalcularTotales);
            this.panel3.Controls.Add(this.TotalHoras);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.descuentos);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Controls.Add(this.devolucion);
            this.panel3.Controls.Add(this.entrega);
            this.panel3.Controls.Add(this.total);
            this.panel3.Controls.Add(this.impuestos);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.subtotal);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(696, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(432, 316);
            this.panel3.TabIndex = 8;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(126, 120);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(54, 13);
            this.label24.TabIndex = 22;
            this.label24.Text = "Horas:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(352, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Dias:";
            // 
            // TotalDias
            // 
            this.TotalDias.Enabled = false;
            this.TotalDias.Location = new System.Drawing.Point(353, 53);
            this.TotalDias.Name = "TotalDias";
            this.TotalDias.Size = new System.Drawing.Size(61, 20);
            this.TotalDias.TabIndex = 20;
            this.TotalDias.Text = "0";
            this.TotalDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CalcularTotales
            // 
            this.CalcularTotales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(95)))), ((int)(((byte)(142)))));
            this.CalcularTotales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalcularTotales.FlatAppearance.BorderSize = 0;
            this.CalcularTotales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.CalcularTotales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.CalcularTotales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalcularTotales.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcularTotales.ForeColor = System.Drawing.Color.White;
            this.CalcularTotales.Location = new System.Drawing.Point(305, 117);
            this.CalcularTotales.Name = "CalcularTotales";
            this.CalcularTotales.Size = new System.Drawing.Size(88, 22);
            this.CalcularTotales.TabIndex = 19;
            this.CalcularTotales.Text = "Calcular";
            this.CalcularTotales.UseVisualStyleBackColor = false;
            this.CalcularTotales.Click += new System.EventHandler(this.CalcularTotales_Click);
            // 
            // TotalHoras
            // 
            this.TotalHoras.Enabled = false;
            this.TotalHoras.Location = new System.Drawing.Point(186, 116);
            this.TotalHoras.Name = "TotalHoras";
            this.TotalHoras.Size = new System.Drawing.Size(74, 20);
            this.TotalHoras.TabIndex = 18;
            this.TotalHoras.Text = "0";
            this.TotalHoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(183, 39);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(130, 13);
            this.label21.TabIndex = 17;
            this.label21.Text = "Fecha de devolucion:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(22, 37);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(111, 13);
            this.label20.TabIndex = 16;
            this.label20.Text = "Fecha de entrega:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(205, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Descuentos:";
            // 
            // descuentos
            // 
            this.descuentos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descuentos.Location = new System.Drawing.Point(284, 247);
            this.descuentos.Name = "descuentos";
            this.descuentos.Size = new System.Drawing.Size(130, 25);
            this.descuentos.TabIndex = 14;
            this.descuentos.Text = "0.00";
            this.descuentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(206, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Subtotal:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(206, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Impuestos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(206, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Total:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(25, 119);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(75, 17);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.Text = "Por Hora";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(24, 11);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Por Dia";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // devolucion
            // 
            this.devolucion.Location = new System.Drawing.Point(185, 53);
            this.devolucion.Name = "devolucion";
            this.devolucion.Size = new System.Drawing.Size(140, 20);
            this.devolucion.TabIndex = 8;
            this.devolucion.ValueChanged += new System.EventHandler(this.devolucion_ValueChanged);
            // 
            // entrega
            // 
            this.entrega.Location = new System.Drawing.Point(24, 53);
            this.entrega.Name = "entrega";
            this.entrega.Size = new System.Drawing.Size(144, 20);
            this.entrega.TabIndex = 7;
            this.entrega.ValueChanged += new System.EventHandler(this.entrega_ValueChanged);
            // 
            // total
            // 
            this.total.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(284, 278);
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Size = new System.Drawing.Size(130, 25);
            this.total.TabIndex = 5;
            this.total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // impuestos
            // 
            this.impuestos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impuestos.Location = new System.Drawing.Point(284, 216);
            this.impuestos.Name = "impuestos";
            this.impuestos.ReadOnly = true;
            this.impuestos.Size = new System.Drawing.Size(130, 25);
            this.impuestos.TabIndex = 4;
            this.impuestos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Precio por Dia:";
            // 
            // subtotal
            // 
            this.subtotal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotal.Location = new System.Drawing.Point(284, 185);
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            this.subtotal.Size = new System.Drawing.Size(130, 25);
            this.subtotal.TabIndex = 3;
            this.subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Precio por hora:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(95)))), ((int)(((byte)(142)))));
            this.panel4.Controls.Add(this.cerrar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1140, 36);
            this.panel4.TabIndex = 9;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(1111, 5);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(25, 25);
            this.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrar.TabIndex = 12;
            this.cerrar.TabStop = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.editar);
            this.panel5.Controls.Add(this.GuardayConfirma);
            this.panel5.Location = new System.Drawing.Point(696, 369);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(432, 79);
            this.panel5.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(95)))), ((int)(((byte)(142)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(284, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 32);
            this.button2.TabIndex = 18;
            this.button2.Text = "Enviar por Correo";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // editar
            // 
            this.editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(95)))), ((int)(((byte)(142)))));
            this.editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editar.FlatAppearance.BorderSize = 0;
            this.editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editar.ForeColor = System.Drawing.Color.White;
            this.editar.Location = new System.Drawing.Point(284, 3);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(143, 32);
            this.editar.TabIndex = 17;
            this.editar.Text = "Imprimir";
            this.editar.UseVisualStyleBackColor = false;
            // 
            // GuardayConfirma
            // 
            this.GuardayConfirma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(95)))), ((int)(((byte)(142)))));
            this.GuardayConfirma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuardayConfirma.FlatAppearance.BorderSize = 0;
            this.GuardayConfirma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.GuardayConfirma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.GuardayConfirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardayConfirma.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardayConfirma.ForeColor = System.Drawing.Color.White;
            this.GuardayConfirma.Location = new System.Drawing.Point(3, 3);
            this.GuardayConfirma.Name = "GuardayConfirma";
            this.GuardayConfirma.Size = new System.Drawing.Size(242, 70);
            this.GuardayConfirma.TabIndex = 16;
            this.GuardayConfirma.Text = "Guardar y Confirmar";
            this.GuardayConfirma.UseVisualStyleBackColor = false;
            this.GuardayConfirma.Click += new System.EventHandler(this.GuardayConfirma_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.estatus);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Controls.Add(this.codigo);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.transmision);
            this.panel2.Controls.Add(this.tipo);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.descripcion);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.placa);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.fabricacion);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.modelo);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.color);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.marca);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Location = new System.Drawing.Point(12, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 308);
            this.panel2.TabIndex = 11;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(278, 182);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(53, 13);
            this.label25.TabIndex = 28;
            this.label25.Text = "Estatus:";
            // 
            // codigo
            // 
            this.codigo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo.Location = new System.Drawing.Point(88, 13);
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Size = new System.Drawing.Size(91, 25);
            this.codigo.TabIndex = 3;
            this.codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(475, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(115)))), ((int)(((byte)(159)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(77)))), ((int)(((byte)(116)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(231, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 27);
            this.button1.TabIndex = 26;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // transmision
            // 
            this.transmision.FormattingEnabled = true;
            this.transmision.Items.AddRange(new object[] {
            "STANDARD",
            "AUTOMATIC"});
            this.transmision.Location = new System.Drawing.Point(88, 94);
            this.transmision.Name = "transmision";
            this.transmision.Size = new System.Drawing.Size(155, 21);
            this.transmision.TabIndex = 25;
            // 
            // tipo
            // 
            this.tipo.FormattingEnabled = true;
            this.tipo.Items.AddRange(new object[] {
            "Classic",
            "Muscle",
            "PickUp",
            "Motorcycle"});
            this.tipo.Location = new System.Drawing.Point(329, 97);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(130, 21);
            this.tipo.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(278, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tipo:";
            // 
            // descripcion
            // 
            this.descripcion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion.Location = new System.Drawing.Point(14, 228);
            this.descripcion.Multiline = true;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Size = new System.Drawing.Size(444, 57);
            this.descripcion.TabIndex = 19;
            this.descripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(11, 212);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 13);
            this.label17.TabIndex = 18;
            this.label17.Text = "Descripcion:";
            // 
            // placa
            // 
            this.placa.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placa.Location = new System.Drawing.Point(329, 136);
            this.placa.Name = "placa";
            this.placa.ReadOnly = true;
            this.placa.Size = new System.Drawing.Size(129, 25);
            this.placa.TabIndex = 17;
            this.placa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(278, 136);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Placa:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(11, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Marca:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(10, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Trasmision:";
            // 
            // fabricacion
            // 
            this.fabricacion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fabricacion.Location = new System.Drawing.Point(88, 179);
            this.fabricacion.Name = "fabricacion";
            this.fabricacion.ReadOnly = true;
            this.fabricacion.Size = new System.Drawing.Size(155, 25);
            this.fabricacion.TabIndex = 12;
            this.fabricacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(11, 182);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Año:";
            // 
            // modelo
            // 
            this.modelo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelo.Location = new System.Drawing.Point(345, 50);
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            this.modelo.Size = new System.Drawing.Size(318, 25);
            this.modelo.TabIndex = 10;
            this.modelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(278, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Modelo:";
            // 
            // color
            // 
            this.color.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color.Location = new System.Drawing.Point(88, 135);
            this.color.Name = "color";
            this.color.ReadOnly = true;
            this.color.Size = new System.Drawing.Size(155, 25);
            this.color.TabIndex = 8;
            this.color.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Color:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(11, 13);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(50, 13);
            this.label22.TabIndex = 2;
            this.label22.Text = "Codigo:";
            // 
            // marca
            // 
            this.marca.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marca.Location = new System.Drawing.Point(88, 50);
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            this.marca.Size = new System.Drawing.Size(170, 25);
            this.marca.TabIndex = 3;
            this.marca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(11, 50);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(41, 20);
            this.label23.TabIndex = 2;
            // 
            // estatus
            // 
            this.estatus.BackColor = System.Drawing.Color.White;
            this.estatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.estatus.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estatus.ForeColor = System.Drawing.Color.LimeGreen;
            this.estatus.Location = new System.Drawing.Point(329, 177);
            this.estatus.Name = "estatus";
            this.estatus.Size = new System.Drawing.Size(129, 26);
            this.estatus.TabIndex = 29;
            this.estatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // precioXdia
            // 
            this.precioXdia.BackColor = System.Drawing.Color.White;
            this.precioXdia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.precioXdia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.precioXdia.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioXdia.ForeColor = System.Drawing.Color.LimeGreen;
            this.precioXdia.Location = new System.Drawing.Point(37, 204);
            this.precioXdia.Name = "precioXdia";
            this.precioXdia.Size = new System.Drawing.Size(123, 26);
            this.precioXdia.TabIndex = 30;
            this.precioXdia.Text = "$ 0.00";
            this.precioXdia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // precioXhora
            // 
            this.precioXhora.BackColor = System.Drawing.Color.White;
            this.precioXhora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.precioXhora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.precioXhora.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioXhora.ForeColor = System.Drawing.Color.LimeGreen;
            this.precioXhora.Location = new System.Drawing.Point(37, 262);
            this.precioXhora.Name = "precioXhora";
            this.precioXhora.Size = new System.Drawing.Size(123, 26);
            this.precioXhora.TabIndex = 31;
            this.precioXhora.Text = "$ 0.00";
            this.precioXhora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Renta_Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 460);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Renta_Alta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renta_Alta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Clientes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox subtotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DateTimePicker devolucion;
        private System.Windows.Forms.DateTimePicker entrega;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.TextBox impuestos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox descuentos;
        public System.Windows.Forms.TextBox cliente;
        public System.Windows.Forms.TextBox Clave;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.TextBox correo;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button GuardayConfirma;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ComboBox transmision;
        public System.Windows.Forms.ComboBox tipo;
        public System.Windows.Forms.TextBox descripcion;
        public System.Windows.Forms.TextBox placa;
        public System.Windows.Forms.TextBox fabricacion;
        public System.Windows.Forms.TextBox modelo;
        public System.Windows.Forms.TextBox color;
        public System.Windows.Forms.TextBox codigo;
        public System.Windows.Forms.TextBox marca;
        private System.Windows.Forms.TextBox TotalHoras;
        private System.Windows.Forms.Button CalcularTotales;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TotalDias;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label estatus;
        private System.Windows.Forms.Label precioXhora;
        private System.Windows.Forms.Label precioXdia;
    }
}
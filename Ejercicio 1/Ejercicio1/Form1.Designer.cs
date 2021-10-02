namespace Ejercicio1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtnumerocuenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtnit = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtdui = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvlistado = new System.Windows.Forms.DataGridView();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.sucursal = new System.Windows.Forms.GroupBox();
            this.rdbsansalvador = new System.Windows.Forms.RadioButton();
            this.rdbsantaana = new System.Windows.Forms.RadioButton();
            this.rdbsanmiguel = new System.Windows.Forms.RadioButton();
            this.rdblalibertad = new System.Windows.Forms.RadioButton();
            this.rdbmorazan = new System.Windows.Forms.RadioButton();
            this.tipodecuenta = new System.Windows.Forms.GroupBox();
            this.rdbcorriente = new System.Windows.Forms.RadioButton();
            this.rdbplazos = new System.Windows.Forms.RadioButton();
            this.rdbahorro = new System.Windows.Forms.RadioButton();
            this.btnsalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistado)).BeginInit();
            this.sucursal.SuspendLayout();
            this.tipodecuenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Banco El Salvador";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtnumerocuenta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtmonto);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtnit);
            this.groupBox1.Controls.Add(this.txtapellido);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.txtdui);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 356);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos:";
            // 
            // txtnumerocuenta
            // 
            this.txtnumerocuenta.Location = new System.Drawing.Point(254, 296);
            this.txtnumerocuenta.Name = "txtnumerocuenta";
            this.txtnumerocuenta.Size = new System.Drawing.Size(119, 27);
            this.txtnumerocuenta.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Numero de cuenta:";
            // 
            // txtmonto
            // 
            this.txtmonto.Location = new System.Drawing.Point(254, 238);
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(119, 27);
            this.txtmonto.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(221, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "Monto discponible en la cuenta:";
            // 
            // txtnit
            // 
            this.txtnit.Location = new System.Drawing.Point(254, 189);
            this.txtnit.Name = "txtnit";
            this.txtnit.Size = new System.Drawing.Size(118, 27);
            this.txtnit.TabIndex = 10;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(254, 133);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(118, 27);
            this.txtapellido.TabIndex = 8;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(254, 90);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(117, 27);
            this.txtnombre.TabIndex = 7;
            // 
            // txtdui
            // 
            this.txtdui.Location = new System.Drawing.Point(253, 40);
            this.txtdui.Name = "txtdui";
            this.txtdui.Size = new System.Drawing.Size(118, 27);
            this.txtdui.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "NIT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dui:";
            // 
            // dgvlistado
            // 
            this.dgvlistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistado.Location = new System.Drawing.Point(380, 220);
            this.dgvlistado.Name = "dgvlistado";
            this.dgvlistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvlistado.Size = new System.Drawing.Size(438, 208);
            this.dgvlistado.TabIndex = 2;
            this.dgvlistado.DoubleClick += new System.EventHandler(this.dgvlistado_DoubleClick);
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Location = new System.Drawing.Point(36, 434);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(157, 44);
            this.btnguardar.TabIndex = 16;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(331, 434);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(157, 44);
            this.btneliminar.TabIndex = 17;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // sucursal
            // 
            this.sucursal.Controls.Add(this.rdbsansalvador);
            this.sucursal.Controls.Add(this.rdbsantaana);
            this.sucursal.Controls.Add(this.rdbsanmiguel);
            this.sucursal.Controls.Add(this.rdblalibertad);
            this.sucursal.Controls.Add(this.rdbmorazan);
            this.sucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sucursal.Location = new System.Drawing.Point(576, 84);
            this.sucursal.Name = "sucursal";
            this.sucursal.Size = new System.Drawing.Size(249, 130);
            this.sucursal.TabIndex = 19;
            this.sucursal.TabStop = false;
            this.sucursal.Text = "Sucursal";
            // 
            // rdbsansalvador
            // 
            this.rdbsansalvador.AutoSize = true;
            this.rdbsansalvador.Location = new System.Drawing.Point(6, 29);
            this.rdbsansalvador.Name = "rdbsansalvador";
            this.rdbsansalvador.Size = new System.Drawing.Size(114, 22);
            this.rdbsansalvador.TabIndex = 20;
            this.rdbsansalvador.TabStop = true;
            this.rdbsansalvador.Text = "San Salvador";
            this.rdbsansalvador.UseVisualStyleBackColor = true;
            // 
            // rdbsantaana
            // 
            this.rdbsantaana.AutoSize = true;
            this.rdbsantaana.Location = new System.Drawing.Point(6, 102);
            this.rdbsantaana.Name = "rdbsantaana";
            this.rdbsantaana.Size = new System.Drawing.Size(93, 22);
            this.rdbsantaana.TabIndex = 24;
            this.rdbsantaana.TabStop = true;
            this.rdbsantaana.Text = "Santa Ana";
            this.rdbsantaana.UseVisualStyleBackColor = true;
            // 
            // rdbsanmiguel
            // 
            this.rdbsanmiguel.AutoSize = true;
            this.rdbsanmiguel.Location = new System.Drawing.Point(6, 65);
            this.rdbsanmiguel.Name = "rdbsanmiguel";
            this.rdbsanmiguel.Size = new System.Drawing.Size(99, 22);
            this.rdbsanmiguel.TabIndex = 23;
            this.rdbsanmiguel.TabStop = true;
            this.rdbsanmiguel.Text = "San Miguel";
            this.rdbsanmiguel.UseVisualStyleBackColor = true;
            // 
            // rdblalibertad
            // 
            this.rdblalibertad.AutoSize = true;
            this.rdblalibertad.Location = new System.Drawing.Point(144, 29);
            this.rdblalibertad.Name = "rdblalibertad";
            this.rdblalibertad.Size = new System.Drawing.Size(98, 22);
            this.rdblalibertad.TabIndex = 22;
            this.rdblalibertad.TabStop = true;
            this.rdblalibertad.Text = "La Libertad";
            this.rdblalibertad.UseVisualStyleBackColor = true;
            // 
            // rdbmorazan
            // 
            this.rdbmorazan.AutoSize = true;
            this.rdbmorazan.Location = new System.Drawing.Point(144, 65);
            this.rdbmorazan.Name = "rdbmorazan";
            this.rdbmorazan.Size = new System.Drawing.Size(85, 22);
            this.rdbmorazan.TabIndex = 21;
            this.rdbmorazan.TabStop = true;
            this.rdbmorazan.Text = "Morazan";
            this.rdbmorazan.UseVisualStyleBackColor = true;
            // 
            // tipodecuenta
            // 
            this.tipodecuenta.Controls.Add(this.rdbcorriente);
            this.tipodecuenta.Controls.Add(this.rdbplazos);
            this.tipodecuenta.Controls.Add(this.rdbahorro);
            this.tipodecuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipodecuenta.Location = new System.Drawing.Point(402, 84);
            this.tipodecuenta.Name = "tipodecuenta";
            this.tipodecuenta.Size = new System.Drawing.Size(144, 130);
            this.tipodecuenta.TabIndex = 20;
            this.tipodecuenta.TabStop = false;
            this.tipodecuenta.Text = "Tipo de cuenta";
            // 
            // rdbcorriente
            // 
            this.rdbcorriente.AutoSize = true;
            this.rdbcorriente.Location = new System.Drawing.Point(15, 65);
            this.rdbcorriente.Name = "rdbcorriente";
            this.rdbcorriente.Size = new System.Drawing.Size(87, 22);
            this.rdbcorriente.TabIndex = 23;
            this.rdbcorriente.TabStop = true;
            this.rdbcorriente.Text = "Corriente";
            this.rdbcorriente.UseVisualStyleBackColor = true;
            // 
            // rdbplazos
            // 
            this.rdbplazos.AutoSize = true;
            this.rdbplazos.Location = new System.Drawing.Point(15, 95);
            this.rdbplazos.Name = "rdbplazos";
            this.rdbplazos.Size = new System.Drawing.Size(72, 22);
            this.rdbplazos.TabIndex = 22;
            this.rdbplazos.TabStop = true;
            this.rdbplazos.Text = "Plazos";
            this.rdbplazos.UseVisualStyleBackColor = true;
            // 
            // rdbahorro
            // 
            this.rdbahorro.AutoSize = true;
            this.rdbahorro.Location = new System.Drawing.Point(15, 37);
            this.rdbahorro.Name = "rdbahorro";
            this.rdbahorro.Size = new System.Drawing.Size(71, 22);
            this.rdbahorro.TabIndex = 21;
            this.rdbahorro.TabStop = true;
            this.rdbahorro.Text = "Ahorro";
            this.rdbahorro.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(635, 434);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(157, 44);
            this.btnsalir.TabIndex = 21;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 490);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.tipodecuenta);
            this.Controls.Add(this.sucursal);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.dgvlistado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Banco El Salvador";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistado)).EndInit();
            this.sucursal.ResumeLayout(false);
            this.sucursal.PerformLayout();
            this.tipodecuenta.ResumeLayout(false);
            this.tipodecuenta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtmonto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtnit;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtdui;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvlistado;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.GroupBox sucursal;
        private System.Windows.Forms.RadioButton rdbsansalvador;
        private System.Windows.Forms.RadioButton rdbsantaana;
        private System.Windows.Forms.RadioButton rdbsanmiguel;
        private System.Windows.Forms.RadioButton rdblalibertad;
        private System.Windows.Forms.RadioButton rdbmorazan;
        private System.Windows.Forms.TextBox txtnumerocuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox tipodecuenta;
        private System.Windows.Forms.RadioButton rdbcorriente;
        private System.Windows.Forms.RadioButton rdbplazos;
        private System.Windows.Forms.RadioButton rdbahorro;
        private System.Windows.Forms.Button btnsalir;
    }
}


namespace Ejercicio_2
{
    partial class Form3
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
            this.dgvlistadoestudiantes = new System.Windows.Forms.DataGridView();
            this.btnllenar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistadoestudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvlistadoestudiantes
            // 
            this.dgvlistadoestudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistadoestudiantes.Location = new System.Drawing.Point(25, 64);
            this.dgvlistadoestudiantes.Name = "dgvlistadoestudiantes";
            this.dgvlistadoestudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvlistadoestudiantes.Size = new System.Drawing.Size(568, 271);
            this.dgvlistadoestudiantes.TabIndex = 0;
            // 
            // btnllenar
            // 
            this.btnllenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnllenar.Location = new System.Drawing.Point(139, 341);
            this.btnllenar.Name = "btnllenar";
            this.btnllenar.Size = new System.Drawing.Size(111, 47);
            this.btnllenar.TabIndex = 1;
            this.btnllenar.Text = "Llenar";
            this.btnllenar.UseVisualStyleBackColor = true;
            this.btnllenar.Click += new System.EventHandler(this.btnllenar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(346, 341);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(111, 47);
            this.btnsalir.TabIndex = 2;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Listado de estudiantes inscritos";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 389);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnllenar);
            this.Controls.Add(this.dgvlistadoestudiantes);
            this.Name = "Form3";
            this.Text = "Listadoestudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistadoestudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvlistadoestudiantes;
        private System.Windows.Forms.Button btnllenar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label label1;
    }
}
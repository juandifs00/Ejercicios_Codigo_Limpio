namespace Banco_ABC
{
    partial class Banco_ABC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Banco_ABC));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCrear_nueva_cuenta = new System.Windows.Forms.Button();
            this.btmRealizarConsginación = new System.Windows.Forms.Button();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.btnTansferir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido al Banco ABC";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(613, 374);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(79, 25);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCrear_nueva_cuenta
            // 
            this.btnCrear_nueva_cuenta.BackColor = System.Drawing.Color.Honeydew;
            this.btnCrear_nueva_cuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear_nueva_cuenta.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnCrear_nueva_cuenta.Location = new System.Drawing.Point(300, 166);
            this.btnCrear_nueva_cuenta.Name = "btnCrear_nueva_cuenta";
            this.btnCrear_nueva_cuenta.Size = new System.Drawing.Size(133, 70);
            this.btnCrear_nueva_cuenta.TabIndex = 3;
            this.btnCrear_nueva_cuenta.Text = "Crear nueva cuenta";
            this.btnCrear_nueva_cuenta.UseVisualStyleBackColor = false;
            this.btnCrear_nueva_cuenta.Click += new System.EventHandler(this.btnCrear_nueva_cuenta_Click);
            // 
            // btmRealizarConsginación
            // 
            this.btmRealizarConsginación.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmRealizarConsginación.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btmRealizarConsginación.Location = new System.Drawing.Point(12, 334);
            this.btmRealizarConsginación.Name = "btmRealizarConsginación";
            this.btmRealizarConsginación.Size = new System.Drawing.Size(126, 65);
            this.btmRealizarConsginación.TabIndex = 13;
            this.btmRealizarConsginación.Text = "Realizar Consignación";
            this.btmRealizarConsginación.UseVisualStyleBackColor = true;
            this.btmRealizarConsginación.Click += new System.EventHandler(this.btmRealizarConsginación_Click);
            // 
            // btnRetirar
            // 
            this.btnRetirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetirar.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnRetirar.Location = new System.Drawing.Point(170, 334);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(111, 65);
            this.btnRetirar.TabIndex = 14;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // btnTansferir
            // 
            this.btnTansferir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTansferir.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnTansferir.Location = new System.Drawing.Point(309, 334);
            this.btnTansferir.Name = "btnTansferir";
            this.btnTansferir.Size = new System.Drawing.Size(111, 65);
            this.btnTansferir.TabIndex = 15;
            this.btnTansferir.Text = "Tansferir";
            this.btnTansferir.UseVisualStyleBackColor = true;
            this.btnTansferir.Click += new System.EventHandler(this.btnTansferir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Banco_ABC.Properties.Resources.BancoLogo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadisticas.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnEstadisticas.Location = new System.Drawing.Point(458, 334);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(117, 65);
            this.btnEstadisticas.TabIndex = 16;
            this.btnEstadisticas.Text = "Estadísticas";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // Banco_ABC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(704, 411);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.btnTansferir);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.btmRealizarConsginación);
            this.Controls.Add(this.btnCrear_nueva_cuenta);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Banco_ABC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco ABC";
            this.Load += new System.EventHandler(this.Banco_ABC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCrear_nueva_cuenta;
        private System.Windows.Forms.Button btmRealizarConsginación;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Button btnTansferir;
        private System.Windows.Forms.Button btnEstadisticas;
    }
}


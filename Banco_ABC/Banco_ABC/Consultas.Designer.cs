namespace Banco_ABC
{
    partial class Consultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultas));
            this.Texto_Consigna = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCliente_mayor_Consigna = new System.Windows.Forms.Button();
            this.btnTotal_Operaciones = new System.Windows.Forms.Button();
            this.btnTotal_Retiros = new System.Windows.Forms.Button();
            this.btnValor_total_consignas = new System.Windows.Forms.Button();
            this.txtbxTotal_Consignas = new System.Windows.Forms.TextBox();
            this.txtbxCliente_Mayor_Consigna = new System.Windows.Forms.TextBox();
            this.txtbxTotal_Operaciones = new System.Windows.Forms.TextBox();
            this.txtbxTotal_Retiros = new System.Windows.Forms.TextBox();
            this.btnRegresar3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Texto_Consigna
            // 
            this.Texto_Consigna.AutoSize = true;
            this.Texto_Consigna.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Texto_Consigna.Location = new System.Drawing.Point(12, 9);
            this.Texto_Consigna.Name = "Texto_Consigna";
            this.Texto_Consigna.Size = new System.Drawing.Size(484, 43);
            this.Texto_Consigna.TabIndex = 2;
            this.Texto_Consigna.Text = "Aquí puedes mirar las estadísticas: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Banco_ABC.Properties.Resources.Libro_Consulta_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(541, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnCliente_mayor_Consigna
            // 
            this.btnCliente_mayor_Consigna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente_mayor_Consigna.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnCliente_mayor_Consigna.Location = new System.Drawing.Point(20, 318);
            this.btnCliente_mayor_Consigna.Name = "btnCliente_mayor_Consigna";
            this.btnCliente_mayor_Consigna.Size = new System.Drawing.Size(151, 70);
            this.btnCliente_mayor_Consigna.TabIndex = 17;
            this.btnCliente_mayor_Consigna.Text = "Cliente con la mayor consignación:";
            this.btnCliente_mayor_Consigna.UseVisualStyleBackColor = true;
            this.btnCliente_mayor_Consigna.Click += new System.EventHandler(this.btnCliente_mayor_Consigna_Click);
            // 
            // btnTotal_Operaciones
            // 
            this.btnTotal_Operaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal_Operaciones.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnTotal_Operaciones.Location = new System.Drawing.Point(20, 226);
            this.btnTotal_Operaciones.Name = "btnTotal_Operaciones";
            this.btnTotal_Operaciones.Size = new System.Drawing.Size(151, 69);
            this.btnTotal_Operaciones.TabIndex = 18;
            this.btnTotal_Operaciones.Text = "Total operaciones realizadas:";
            this.btnTotal_Operaciones.UseVisualStyleBackColor = true;
            this.btnTotal_Operaciones.Click += new System.EventHandler(this.btnTotal_Operaciones_Click);
            // 
            // btnTotal_Retiros
            // 
            this.btnTotal_Retiros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal_Retiros.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnTotal_Retiros.Location = new System.Drawing.Point(20, 148);
            this.btnTotal_Retiros.Name = "btnTotal_Retiros";
            this.btnTotal_Retiros.Size = new System.Drawing.Size(151, 58);
            this.btnTotal_Retiros.TabIndex = 19;
            this.btnTotal_Retiros.Text = "Total retiros realizados:";
            this.btnTotal_Retiros.UseVisualStyleBackColor = true;
            this.btnTotal_Retiros.Click += new System.EventHandler(this.btnTotal_Retiros_Click);
            // 
            // btnValor_total_consignas
            // 
            this.btnValor_total_consignas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValor_total_consignas.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnValor_total_consignas.Location = new System.Drawing.Point(20, 74);
            this.btnValor_total_consignas.Name = "btnValor_total_consignas";
            this.btnValor_total_consignas.Size = new System.Drawing.Size(151, 58);
            this.btnValor_total_consignas.TabIndex = 20;
            this.btnValor_total_consignas.Text = "Valor total de consignaciones:";
            this.btnValor_total_consignas.UseVisualStyleBackColor = true;
            this.btnValor_total_consignas.Click += new System.EventHandler(this.btnValor_total_consignas_Click);
            // 
            // txtbxTotal_Consignas
            // 
            this.txtbxTotal_Consignas.Location = new System.Drawing.Point(178, 96);
            this.txtbxTotal_Consignas.Name = "txtbxTotal_Consignas";
            this.txtbxTotal_Consignas.Size = new System.Drawing.Size(152, 20);
            this.txtbxTotal_Consignas.TabIndex = 21;
            // 
            // txtbxCliente_Mayor_Consigna
            // 
            this.txtbxCliente_Mayor_Consigna.Location = new System.Drawing.Point(178, 345);
            this.txtbxCliente_Mayor_Consigna.Name = "txtbxCliente_Mayor_Consigna";
            this.txtbxCliente_Mayor_Consigna.Size = new System.Drawing.Size(152, 20);
            this.txtbxCliente_Mayor_Consigna.TabIndex = 22;
            // 
            // txtbxTotal_Operaciones
            // 
            this.txtbxTotal_Operaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxTotal_Operaciones.Location = new System.Drawing.Point(178, 252);
            this.txtbxTotal_Operaciones.Name = "txtbxTotal_Operaciones";
            this.txtbxTotal_Operaciones.Size = new System.Drawing.Size(152, 20);
            this.txtbxTotal_Operaciones.TabIndex = 23;
            // 
            // txtbxTotal_Retiros
            // 
            this.txtbxTotal_Retiros.Location = new System.Drawing.Point(178, 169);
            this.txtbxTotal_Retiros.Name = "txtbxTotal_Retiros";
            this.txtbxTotal_Retiros.Size = new System.Drawing.Size(152, 20);
            this.txtbxTotal_Retiros.TabIndex = 24;
            // 
            // btnRegresar3
            // 
            this.btnRegresar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar3.ForeColor = System.Drawing.Color.Red;
            this.btnRegresar3.Location = new System.Drawing.Point(607, 374);
            this.btnRegresar3.Name = "btnRegresar3";
            this.btnRegresar3.Size = new System.Drawing.Size(85, 25);
            this.btnRegresar3.TabIndex = 25;
            this.btnRegresar3.Text = "Regresar";
            this.btnRegresar3.UseVisualStyleBackColor = true;
            this.btnRegresar3.Click += new System.EventHandler(this.btnRegresar3_Click);
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(704, 411);
            this.Controls.Add(this.btnRegresar3);
            this.Controls.Add(this.txtbxTotal_Retiros);
            this.Controls.Add(this.txtbxTotal_Operaciones);
            this.Controls.Add(this.txtbxCliente_Mayor_Consigna);
            this.Controls.Add(this.txtbxTotal_Consignas);
            this.Controls.Add(this.btnValor_total_consignas);
            this.Controls.Add(this.btnTotal_Retiros);
            this.Controls.Add(this.btnTotal_Operaciones);
            this.Controls.Add(this.btnCliente_mayor_Consigna);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Texto_Consigna);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Consultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Texto_Consigna;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCliente_mayor_Consigna;
        private System.Windows.Forms.Button btnTotal_Operaciones;
        private System.Windows.Forms.Button btnTotal_Retiros;
        private System.Windows.Forms.Button btnValor_total_consignas;
        private System.Windows.Forms.TextBox txtbxTotal_Consignas;
        private System.Windows.Forms.TextBox txtbxCliente_Mayor_Consigna;
        private System.Windows.Forms.TextBox txtbxTotal_Operaciones;
        private System.Windows.Forms.TextBox txtbxTotal_Retiros;
        private System.Windows.Forms.Button btnRegresar3;
    }
}
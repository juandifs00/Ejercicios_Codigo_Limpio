namespace Banco_ABC
{
    partial class Consignas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consignas));
            this.Texto_Consigna = new System.Windows.Forms.Label();
            this.lblNumCuenta2 = new System.Windows.Forms.Label();
            this.txtbxNumCuenta2 = new System.Windows.Forms.TextBox();
            this.lblCantidadDinero = new System.Windows.Forms.Label();
            this.txtbxCantidad_Consignar = new System.Windows.Forms.TextBox();
            this.btnRealizar_Consignacion = new System.Windows.Forms.Button();
            this.btnRegresar2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // Texto_Consigna
            // 
            this.Texto_Consigna.AutoSize = true;
            this.Texto_Consigna.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Texto_Consigna.Location = new System.Drawing.Point(13, 13);
            this.Texto_Consigna.Name = "Texto_Consigna";
            this.Texto_Consigna.Size = new System.Drawing.Size(551, 43);
            this.Texto_Consigna.TabIndex = 0;
            this.Texto_Consigna.Text = "Aquí puedes realizar tus consignaciones:";
            // 
            // lblNumCuenta2
            // 
            this.lblNumCuenta2.AutoSize = true;
            this.lblNumCuenta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCuenta2.Location = new System.Drawing.Point(18, 83);
            this.lblNumCuenta2.Name = "lblNumCuenta2";
            this.lblNumCuenta2.Size = new System.Drawing.Size(180, 16);
            this.lblNumCuenta2.TabIndex = 5;
            this.lblNumCuenta2.Text = "Ingrese el número de cuenta:";
            // 
            // txtbxNumCuenta2
            // 
            this.txtbxNumCuenta2.Location = new System.Drawing.Point(219, 83);
            this.txtbxNumCuenta2.Name = "txtbxNumCuenta2";
            this.txtbxNumCuenta2.Size = new System.Drawing.Size(213, 20);
            this.txtbxNumCuenta2.TabIndex = 9;
            this.txtbxNumCuenta2.TextChanged += new System.EventHandler(this.txtbxNumCuenta2_TextChanged);
            // 
            // lblCantidadDinero
            // 
            this.lblCantidadDinero.AutoSize = true;
            this.lblCantidadDinero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadDinero.Location = new System.Drawing.Point(18, 135);
            this.lblCantidadDinero.Name = "lblCantidadDinero";
            this.lblCantidadDinero.Size = new System.Drawing.Size(195, 16);
            this.lblCantidadDinero.TabIndex = 10;
            this.lblCantidadDinero.Text = "Cantidad que desea consignar:";
            // 
            // txtbxCantidad_Consignar
            // 
            this.txtbxCantidad_Consignar.Location = new System.Drawing.Point(219, 134);
            this.txtbxCantidad_Consignar.Name = "txtbxCantidad_Consignar";
            this.txtbxCantidad_Consignar.Size = new System.Drawing.Size(213, 20);
            this.txtbxCantidad_Consignar.TabIndex = 11;
            this.txtbxCantidad_Consignar.TextChanged += new System.EventHandler(this.txtbxCantidad_Consignar_TextChanged);
            // 
            // btnRealizar_Consignacion
            // 
            this.btnRealizar_Consignacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizar_Consignacion.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnRealizar_Consignacion.Location = new System.Drawing.Point(282, 293);
            this.btnRealizar_Consignacion.Name = "btnRealizar_Consignacion";
            this.btnRealizar_Consignacion.Size = new System.Drawing.Size(133, 71);
            this.btnRealizar_Consignacion.TabIndex = 15;
            this.btnRealizar_Consignacion.Text = "Realizar Consignación";
            this.btnRealizar_Consignacion.UseVisualStyleBackColor = true;
            this.btnRealizar_Consignacion.Click += new System.EventHandler(this.btnRealizar_Consigna_Click);
            // 
            // btnRegresar2
            // 
            this.btnRegresar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar2.ForeColor = System.Drawing.Color.Red;
            this.btnRegresar2.Location = new System.Drawing.Point(607, 374);
            this.btnRegresar2.Name = "btnRegresar2";
            this.btnRegresar2.Size = new System.Drawing.Size(85, 25);
            this.btnRegresar2.TabIndex = 16;
            this.btnRegresar2.Text = "Regresar";
            this.btnRegresar2.UseVisualStyleBackColor = true;
            this.btnRegresar2.Click += new System.EventHandler(this.btnRegresar2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Banco_ABC.Properties.Resources.ConsignacionLogo;
            this.pictureBox1.Location = new System.Drawing.Point(551, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Consignas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(704, 411);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegresar2);
            this.Controls.Add(this.btnRealizar_Consignacion);
            this.Controls.Add(this.txtbxCantidad_Consignar);
            this.Controls.Add(this.lblCantidadDinero);
            this.Controls.Add(this.txtbxNumCuenta2);
            this.Controls.Add(this.lblNumCuenta2);
            this.Controls.Add(this.Texto_Consigna);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Consignas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consignaciones";
            this.Load += new System.EventHandler(this.Consignas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Texto_Consigna;
        private System.Windows.Forms.Label lblNumCuenta2;
        private System.Windows.Forms.TextBox txtbxNumCuenta2;
        private System.Windows.Forms.Label lblCantidadDinero;
        private System.Windows.Forms.TextBox txtbxCantidad_Consignar;
        private System.Windows.Forms.Button btnRealizar_Consignacion;
        private System.Windows.Forms.Button btnRegresar2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}
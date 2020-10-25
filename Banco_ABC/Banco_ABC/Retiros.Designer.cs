namespace Banco_ABC
{
    partial class Retiros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Retiros));
            this.Texto_Consigna = new System.Windows.Forms.Label();
            this.lblNumCuenta2 = new System.Windows.Forms.Label();
            this.txtbxNumCuenta3 = new System.Windows.Forms.TextBox();
            this.lblCantidadDinero = new System.Windows.Forms.Label();
            this.txtbxCantidad_Retirar = new System.Windows.Forms.TextBox();
            this.btnRealizar_Retiro = new System.Windows.Forms.Button();
            this.btnRegresar3 = new System.Windows.Forms.Button();
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
            this.Texto_Consigna.Location = new System.Drawing.Point(12, 9);
            this.Texto_Consigna.Name = "Texto_Consigna";
            this.Texto_Consigna.Size = new System.Drawing.Size(441, 43);
            this.Texto_Consigna.TabIndex = 1;
            this.Texto_Consigna.Text = "Aquí puedes realizar tus retiros:";
            // 
            // lblNumCuenta2
            // 
            this.lblNumCuenta2.AutoSize = true;
            this.lblNumCuenta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCuenta2.Location = new System.Drawing.Point(12, 79);
            this.lblNumCuenta2.Name = "lblNumCuenta2";
            this.lblNumCuenta2.Size = new System.Drawing.Size(180, 16);
            this.lblNumCuenta2.TabIndex = 6;
            this.lblNumCuenta2.Text = "Ingrese el número de cuenta:";
            // 
            // txtbxNumCuenta3
            // 
            this.txtbxNumCuenta3.Location = new System.Drawing.Point(193, 79);
            this.txtbxNumCuenta3.Name = "txtbxNumCuenta3";
            this.txtbxNumCuenta3.Size = new System.Drawing.Size(213, 20);
            this.txtbxNumCuenta3.TabIndex = 10;
            this.txtbxNumCuenta3.TextChanged += new System.EventHandler(this.txtbxNumCuenta3_TextChanged);
            // 
            // lblCantidadDinero
            // 
            this.lblCantidadDinero.AutoSize = true;
            this.lblCantidadDinero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadDinero.Location = new System.Drawing.Point(17, 132);
            this.lblCantidadDinero.Name = "lblCantidadDinero";
            this.lblCantidadDinero.Size = new System.Drawing.Size(170, 16);
            this.lblCantidadDinero.TabIndex = 11;
            this.lblCantidadDinero.Text = "Cantidad que desea retirar:";
            // 
            // txtbxCantidad_Retirar
            // 
            this.txtbxCantidad_Retirar.Location = new System.Drawing.Point(193, 131);
            this.txtbxCantidad_Retirar.Name = "txtbxCantidad_Retirar";
            this.txtbxCantidad_Retirar.Size = new System.Drawing.Size(213, 20);
            this.txtbxCantidad_Retirar.TabIndex = 12;
            this.txtbxCantidad_Retirar.TextChanged += new System.EventHandler(this.txtbxCantidad_Retirar_TextChanged);
            // 
            // btnRealizar_Retiro
            // 
            this.btnRealizar_Retiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizar_Retiro.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnRealizar_Retiro.Location = new System.Drawing.Point(287, 287);
            this.btnRealizar_Retiro.Name = "btnRealizar_Retiro";
            this.btnRealizar_Retiro.Size = new System.Drawing.Size(133, 71);
            this.btnRealizar_Retiro.TabIndex = 16;
            this.btnRealizar_Retiro.Text = "Realizar Retiro";
            this.btnRealizar_Retiro.UseVisualStyleBackColor = true;
            this.btnRealizar_Retiro.Click += new System.EventHandler(this.btnRealizar_Retiro_Click);
            // 
            // btnRegresar3
            // 
            this.btnRegresar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar3.ForeColor = System.Drawing.Color.Red;
            this.btnRegresar3.Location = new System.Drawing.Point(607, 374);
            this.btnRegresar3.Name = "btnRegresar3";
            this.btnRegresar3.Size = new System.Drawing.Size(85, 25);
            this.btnRegresar3.TabIndex = 17;
            this.btnRegresar3.Text = "Regresar";
            this.btnRegresar3.UseVisualStyleBackColor = true;
            this.btnRegresar3.Click += new System.EventHandler(this.btnRegresar3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Banco_ABC.Properties.Resources.RetirosLogo;
            this.pictureBox1.Location = new System.Drawing.Point(548, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
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
            // Retiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(704, 411);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegresar3);
            this.Controls.Add(this.btnRealizar_Retiro);
            this.Controls.Add(this.txtbxCantidad_Retirar);
            this.Controls.Add(this.lblCantidadDinero);
            this.Controls.Add(this.txtbxNumCuenta3);
            this.Controls.Add(this.lblNumCuenta2);
            this.Controls.Add(this.Texto_Consigna);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Retiros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retiros";
            this.Load += new System.EventHandler(this.Retiros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Texto_Consigna;
        private System.Windows.Forms.Label lblNumCuenta2;
        private System.Windows.Forms.TextBox txtbxNumCuenta3;
        private System.Windows.Forms.Label lblCantidadDinero;
        private System.Windows.Forms.TextBox txtbxCantidad_Retirar;
        private System.Windows.Forms.Button btnRealizar_Retiro;
        private System.Windows.Forms.Button btnRegresar3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}
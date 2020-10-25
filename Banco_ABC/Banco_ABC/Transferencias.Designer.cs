namespace Banco_ABC
{
    partial class Transferencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transferencias));
            this.Texto_Consigna = new System.Windows.Forms.Label();
            this.lblNumCuenta3 = new System.Windows.Forms.Label();
            this.lblCuenta_Destino = new System.Windows.Forms.Label();
            this.lblCantidad_Trasnferir = new System.Windows.Forms.Label();
            this.txtbxNumCuenta3 = new System.Windows.Forms.TextBox();
            this.txtbxCuenta_Destino = new System.Windows.Forms.TextBox();
            this.txtbxCuenta_Origen = new System.Windows.Forms.TextBox();
            this.btnRegresar3 = new System.Windows.Forms.Button();
            this.btnRealizar_Transferencia = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // Texto_Consigna
            // 
            this.Texto_Consigna.AutoSize = true;
            this.Texto_Consigna.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Texto_Consigna.Location = new System.Drawing.Point(12, 9);
            this.Texto_Consigna.Name = "Texto_Consigna";
            this.Texto_Consigna.Size = new System.Drawing.Size(542, 43);
            this.Texto_Consigna.TabIndex = 2;
            this.Texto_Consigna.Text = "Aquí puedes realizar tus transferencias:";
            // 
            // lblNumCuenta3
            // 
            this.lblNumCuenta3.AutoSize = true;
            this.lblNumCuenta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCuenta3.Location = new System.Drawing.Point(17, 78);
            this.lblNumCuenta3.Name = "lblNumCuenta3";
            this.lblNumCuenta3.Size = new System.Drawing.Size(221, 16);
            this.lblNumCuenta3.TabIndex = 7;
            this.lblNumCuenta3.Text = "Ingrese el número de cuenta origen:";
            // 
            // lblCuenta_Destino
            // 
            this.lblCuenta_Destino.AutoSize = true;
            this.lblCuenta_Destino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuenta_Destino.Location = new System.Drawing.Point(17, 125);
            this.lblCuenta_Destino.Name = "lblCuenta_Destino";
            this.lblCuenta_Destino.Size = new System.Drawing.Size(227, 16);
            this.lblCuenta_Destino.TabIndex = 8;
            this.lblCuenta_Destino.Text = "Ingrese el número de cuenta destino:";
            // 
            // lblCantidad_Trasnferir
            // 
            this.lblCantidad_Trasnferir.AutoSize = true;
            this.lblCantidad_Trasnferir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad_Trasnferir.Location = new System.Drawing.Point(17, 172);
            this.lblCantidad_Trasnferir.Name = "lblCantidad_Trasnferir";
            this.lblCantidad_Trasnferir.Size = new System.Drawing.Size(247, 16);
            this.lblCantidad_Trasnferir.TabIndex = 9;
            this.lblCantidad_Trasnferir.Text = "Ingrese la cantidad que desea transferir:";
            // 
            // txtbxNumCuenta3
            // 
            this.txtbxNumCuenta3.Location = new System.Drawing.Point(270, 172);
            this.txtbxNumCuenta3.Name = "txtbxNumCuenta3";
            this.txtbxNumCuenta3.Size = new System.Drawing.Size(213, 20);
            this.txtbxNumCuenta3.TabIndex = 11;
            this.txtbxNumCuenta3.TextChanged += new System.EventHandler(this.txtbxNumCuenta3_TextChanged);
            // 
            // txtbxCuenta_Destino
            // 
            this.txtbxCuenta_Destino.Location = new System.Drawing.Point(270, 125);
            this.txtbxCuenta_Destino.Name = "txtbxCuenta_Destino";
            this.txtbxCuenta_Destino.Size = new System.Drawing.Size(213, 20);
            this.txtbxCuenta_Destino.TabIndex = 12;
            this.txtbxCuenta_Destino.TextChanged += new System.EventHandler(this.txtbxCuenta_Destino_TextChanged);
            // 
            // txtbxCuenta_Origen
            // 
            this.txtbxCuenta_Origen.Location = new System.Drawing.Point(270, 77);
            this.txtbxCuenta_Origen.Name = "txtbxCuenta_Origen";
            this.txtbxCuenta_Origen.Size = new System.Drawing.Size(213, 20);
            this.txtbxCuenta_Origen.TabIndex = 13;
            this.txtbxCuenta_Origen.TextChanged += new System.EventHandler(this.txtbxCuenta_Origen_TextChanged);
            // 
            // btnRegresar3
            // 
            this.btnRegresar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar3.ForeColor = System.Drawing.Color.Red;
            this.btnRegresar3.Location = new System.Drawing.Point(607, 374);
            this.btnRegresar3.Name = "btnRegresar3";
            this.btnRegresar3.Size = new System.Drawing.Size(85, 25);
            this.btnRegresar3.TabIndex = 18;
            this.btnRegresar3.Text = "Regresar";
            this.btnRegresar3.UseVisualStyleBackColor = true;
            this.btnRegresar3.Click += new System.EventHandler(this.btnRegresar3_Click);
            // 
            // btnRealizar_Transferencia
            // 
            this.btnRealizar_Transferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizar_Transferencia.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnRealizar_Transferencia.Location = new System.Drawing.Point(295, 302);
            this.btnRealizar_Transferencia.Name = "btnRealizar_Transferencia";
            this.btnRealizar_Transferencia.Size = new System.Drawing.Size(133, 71);
            this.btnRealizar_Transferencia.TabIndex = 19;
            this.btnRealizar_Transferencia.Text = "Realizar Transferencia";
            this.btnRealizar_Transferencia.UseVisualStyleBackColor = true;
            this.btnRealizar_Transferencia.Click += new System.EventHandler(this.btnRealizar_Transferencia_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Banco_ABC.Properties.Resources.transferencia_bancariaLogo;
            this.pictureBox1.Location = new System.Drawing.Point(553, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
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
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // Transferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(704, 411);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRealizar_Transferencia);
            this.Controls.Add(this.btnRegresar3);
            this.Controls.Add(this.txtbxCuenta_Origen);
            this.Controls.Add(this.txtbxCuenta_Destino);
            this.Controls.Add(this.txtbxNumCuenta3);
            this.Controls.Add(this.lblCantidad_Trasnferir);
            this.Controls.Add(this.lblCuenta_Destino);
            this.Controls.Add(this.lblNumCuenta3);
            this.Controls.Add(this.Texto_Consigna);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Transferencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transferencias";
            this.Load += new System.EventHandler(this.Transferencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Texto_Consigna;
        private System.Windows.Forms.Label lblNumCuenta3;
        private System.Windows.Forms.Label lblCuenta_Destino;
        private System.Windows.Forms.Label lblCantidad_Trasnferir;
        private System.Windows.Forms.TextBox txtbxNumCuenta3;
        private System.Windows.Forms.TextBox txtbxCuenta_Destino;
        private System.Windows.Forms.TextBox txtbxCuenta_Origen;
        private System.Windows.Forms.Button btnRegresar3;
        private System.Windows.Forms.Button btnRealizar_Transferencia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}
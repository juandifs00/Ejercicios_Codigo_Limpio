namespace Banco_ABC
{
    partial class Reg_C_Ahorros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reg_C_Ahorros));
            this.Saludo = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnConf_Registro = new System.Windows.Forms.Button();
            this.lblNumCuenta = new System.Windows.Forms.Label();
            this.lblNomTitular = new System.Windows.Forms.Label();
            this.lblNumDocumento = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtbxNumCuenta = new System.Windows.Forms.TextBox();
            this.txtbxNomTitular = new System.Windows.Forms.TextBox();
            this.txtbxNumDocumento = new System.Windows.Forms.TextBox();
            this.txtbxSaldo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // Saludo
            // 
            this.Saludo.AutoSize = true;
            this.Saludo.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Saludo.Location = new System.Drawing.Point(13, 13);
            this.Saludo.Name = "Saludo";
            this.Saludo.Size = new System.Drawing.Size(243, 43);
            this.Saludo.TabIndex = 0;
            this.Saludo.Text = "Hola, bienvenido";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.Red;
            this.btnRegresar.Location = new System.Drawing.Point(607, 374);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(85, 25);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnConf_Registro
            // 
            this.btnConf_Registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConf_Registro.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnConf_Registro.Location = new System.Drawing.Point(320, 334);
            this.btnConf_Registro.Name = "btnConf_Registro";
            this.btnConf_Registro.Size = new System.Drawing.Size(111, 65);
            this.btnConf_Registro.TabIndex = 3;
            this.btnConf_Registro.Text = "Confirmar Registro";
            this.btnConf_Registro.UseVisualStyleBackColor = true;
            this.btnConf_Registro.Click += new System.EventHandler(this.btnConf_Registro_Click);
            // 
            // lblNumCuenta
            // 
            this.lblNumCuenta.AutoSize = true;
            this.lblNumCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCuenta.Location = new System.Drawing.Point(18, 72);
            this.lblNumCuenta.Name = "lblNumCuenta";
            this.lblNumCuenta.Size = new System.Drawing.Size(180, 16);
            this.lblNumCuenta.TabIndex = 4;
            this.lblNumCuenta.Text = "Ingrese el número de cuenta:";
            // 
            // lblNomTitular
            // 
            this.lblNomTitular.AutoSize = true;
            this.lblNomTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomTitular.Location = new System.Drawing.Point(18, 104);
            this.lblNomTitular.Name = "lblNomTitular";
            this.lblNomTitular.Size = new System.Drawing.Size(251, 16);
            this.lblNomTitular.TabIndex = 5;
            this.lblNomTitular.Text = "Ingrese el nombre del titular de la cuenta:";
            // 
            // lblNumDocumento
            // 
            this.lblNumDocumento.AutoSize = true;
            this.lblNumDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumDocumento.Location = new System.Drawing.Point(18, 134);
            this.lblNumDocumento.Name = "lblNumDocumento";
            this.lblNumDocumento.Size = new System.Drawing.Size(210, 16);
            this.lblNumDocumento.TabIndex = 6;
            this.lblNumDocumento.Text = "Ingrese su número de documento:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(18, 165);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(149, 16);
            this.lblSaldo.TabIndex = 7;
            this.lblSaldo.Text = "Ingrese su saldo actual:";
            // 
            // txtbxNumCuenta
            // 
            this.txtbxNumCuenta.Location = new System.Drawing.Point(275, 68);
            this.txtbxNumCuenta.Name = "txtbxNumCuenta";
            this.txtbxNumCuenta.Size = new System.Drawing.Size(213, 20);
            this.txtbxNumCuenta.TabIndex = 8;
            this.txtbxNumCuenta.TextChanged += new System.EventHandler(this.txtbxNumCuenta_TextChanged);
            // 
            // txtbxNomTitular
            // 
            this.txtbxNomTitular.Location = new System.Drawing.Point(275, 103);
            this.txtbxNomTitular.Name = "txtbxNomTitular";
            this.txtbxNomTitular.Size = new System.Drawing.Size(213, 20);
            this.txtbxNomTitular.TabIndex = 9;
            this.txtbxNomTitular.TextChanged += new System.EventHandler(this.txtbxNomTitular_TextChanged);
            // 
            // txtbxNumDocumento
            // 
            this.txtbxNumDocumento.Location = new System.Drawing.Point(275, 134);
            this.txtbxNumDocumento.Name = "txtbxNumDocumento";
            this.txtbxNumDocumento.Size = new System.Drawing.Size(213, 20);
            this.txtbxNumDocumento.TabIndex = 10;
            this.txtbxNumDocumento.TextChanged += new System.EventHandler(this.txtbxNumDocumento_TextChanged);
            // 
            // txtbxSaldo
            // 
            this.txtbxSaldo.Location = new System.Drawing.Point(275, 165);
            this.txtbxSaldo.Name = "txtbxSaldo";
            this.txtbxSaldo.Size = new System.Drawing.Size(213, 20);
            this.txtbxSaldo.TabIndex = 11;
            this.txtbxSaldo.TextChanged += new System.EventHandler(this.txtbxSaldo_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Banco_ABC.Properties.Resources.BolsaDinero;
            this.pictureBox1.Location = new System.Drawing.Point(551, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
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
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // Reg_C_Ahorros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(704, 411);
            this.Controls.Add(this.txtbxSaldo);
            this.Controls.Add(this.txtbxNumDocumento);
            this.Controls.Add(this.txtbxNomTitular);
            this.Controls.Add(this.txtbxNumCuenta);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblNumDocumento);
            this.Controls.Add(this.lblNomTitular);
            this.Controls.Add(this.lblNumCuenta);
            this.Controls.Add(this.btnConf_Registro);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Saludo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Reg_C_Ahorros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Cuenta Ahorros";
            this.Load += new System.EventHandler(this.Reg_C_Ahorros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Saludo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnConf_Registro;
        private System.Windows.Forms.Label lblNumCuenta;
        private System.Windows.Forms.Label lblNomTitular;
        private System.Windows.Forms.Label lblNumDocumento;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtbxNumCuenta;
        private System.Windows.Forms.TextBox txtbxNomTitular;
        private System.Windows.Forms.TextBox txtbxNumDocumento;
        private System.Windows.Forms.TextBox txtbxSaldo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
    }
}
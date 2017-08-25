namespace HomeCinema
{
    partial class FormRegistro
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
            this.lblRegistro = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtTarjeta = new System.Windows.Forms.TextBox();
            this.btnRegistrase = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panelRegistro = new System.Windows.Forms.Panel();
            this.lblCerrarFormRegistro = new System.Windows.Forms.Label();
            this.pbRegistro = new System.Windows.Forms.PictureBox();
            this.panelRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegistro
            // 
            this.lblRegistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblRegistro.Location = new System.Drawing.Point(174, 49);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(83, 25);
            this.lblRegistro.TabIndex = 0;
            this.lblRegistro.Text = "Registro";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usuario:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "N° Tarjeta:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.Location = new System.Drawing.Point(138, 106);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(242, 33);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.Location = new System.Drawing.Point(138, 157);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(242, 33);
            this.txtUsuario.TabIndex = 6;
            // 
            // txtPass
            // 
            this.txtPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPass.Location = new System.Drawing.Point(138, 206);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(242, 33);
            this.txtPass.TabIndex = 7;
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTarjeta.Location = new System.Drawing.Point(138, 261);
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(242, 33);
            this.txtTarjeta.TabIndex = 8;
            this.txtTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTarjeta_KeyPress);
            // 
            // btnRegistrase
            // 
            this.btnRegistrase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrase.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRegistrase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrase.ForeColor = System.Drawing.Color.White;
            this.btnRegistrase.Location = new System.Drawing.Point(238, 321);
            this.btnRegistrase.Name = "btnRegistrase";
            this.btnRegistrase.Size = new System.Drawing.Size(141, 34);
            this.btnRegistrase.TabIndex = 9;
            this.btnRegistrase.Text = "Registrarse";
            this.btnRegistrase.UseVisualStyleBackColor = false;
            this.btnRegistrase.Click += new System.EventHandler(this.btnRegistrase_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(91, 321);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(141, 34);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // panelRegistro
            // 
            this.panelRegistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelRegistro.Controls.Add(this.btnCancelar);
            this.panelRegistro.Controls.Add(this.btnRegistrase);
            this.panelRegistro.Controls.Add(this.txtTarjeta);
            this.panelRegistro.Controls.Add(this.txtPass);
            this.panelRegistro.Controls.Add(this.txtUsuario);
            this.panelRegistro.Controls.Add(this.txtNombre);
            this.panelRegistro.Controls.Add(this.label5);
            this.panelRegistro.Controls.Add(this.label4);
            this.panelRegistro.Controls.Add(this.label3);
            this.panelRegistro.Controls.Add(this.label2);
            this.panelRegistro.Controls.Add(this.lblRegistro);
            this.panelRegistro.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelRegistro.Location = new System.Drawing.Point(493, 14);
            this.panelRegistro.Name = "panelRegistro";
            this.panelRegistro.Size = new System.Drawing.Size(408, 446);
            this.panelRegistro.TabIndex = 1;
            // 
            // lblCerrarFormRegistro
            // 
            this.lblCerrarFormRegistro.AutoSize = true;
            this.lblCerrarFormRegistro.BackColor = System.Drawing.Color.SteelBlue;
            this.lblCerrarFormRegistro.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrarFormRegistro.ForeColor = System.Drawing.Color.White;
            this.lblCerrarFormRegistro.Location = new System.Drawing.Point(3, 9);
            this.lblCerrarFormRegistro.Name = "lblCerrarFormRegistro";
            this.lblCerrarFormRegistro.Size = new System.Drawing.Size(51, 21);
            this.lblCerrarFormRegistro.TabIndex = 3;
            this.lblCerrarFormRegistro.Text = "Cerrar";
            this.lblCerrarFormRegistro.Click += new System.EventHandler(this.lblCerrarFormRegistro_Click);
            // 
            // pbRegistro
            // 
            this.pbRegistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbRegistro.Image = global::HomeCinema.Properties.Resources.GIf_Registro720;
            this.pbRegistro.Location = new System.Drawing.Point(7, 53);
            this.pbRegistro.Name = "pbRegistro";
            this.pbRegistro.Size = new System.Drawing.Size(480, 360);
            this.pbRegistro.TabIndex = 2;
            this.pbRegistro.TabStop = false;
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(913, 480);
            this.Controls.Add(this.lblCerrarFormRegistro);
            this.Controls.Add(this.pbRegistro);
            this.Controls.Add(this.panelRegistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegistro";
            this.panelRegistro.ResumeLayout(false);
            this.panelRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtTarjeta;
        private System.Windows.Forms.Button btnRegistrase;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panelRegistro;
        private System.Windows.Forms.PictureBox pbRegistro;
        private System.Windows.Forms.Label lblCerrarFormRegistro;

    }
}
namespace HomeCinema
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
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.lblEslogan = new System.Windows.Forms.Label();
            this.lblNombre1 = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.pbFondo = new System.Windows.Forms.PictureBox();
            this.lblCerrarForm1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre2
            // 
            this.lblNombre2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Font = new System.Drawing.Font("Segoe UI Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre2.ForeColor = System.Drawing.Color.White;
            this.lblNombre2.Location = new System.Drawing.Point(196, 99);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(241, 86);
            this.lblNombre2.TabIndex = 1;
            this.lblNombre2.Text = "Cinema";
            this.lblNombre2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEslogan
            // 
            this.lblEslogan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEslogan.AutoSize = true;
            this.lblEslogan.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEslogan.ForeColor = System.Drawing.Color.White;
            this.lblEslogan.Location = new System.Drawing.Point(63, 185);
            this.lblEslogan.Name = "lblEslogan";
            this.lblEslogan.Size = new System.Drawing.Size(332, 37);
            this.lblEslogan.TabIndex = 2;
            this.lblEslogan.Text = "El Septimo Arte en tu Home";
            this.lblEslogan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre1
            // 
            this.lblNombre1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre1.AutoSize = true;
            this.lblNombre1.Font = new System.Drawing.Font("Segoe UI Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblNombre1.Location = new System.Drawing.Point(18, 99);
            this.lblNombre1.Name = "lblNombre1";
            this.lblNombre1.Size = new System.Drawing.Size(201, 86);
            this.lblNombre1.TabIndex = 3;
            this.lblNombre1.Text = "Home";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEntrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(127, 237);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(107, 32);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistro.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.ForeColor = System.Drawing.Color.White;
            this.btnRegistro.Location = new System.Drawing.Point(240, 237);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(101, 32);
            this.btnRegistro.TabIndex = 5;
            this.btnRegistro.Text = "Registrarse";
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.button2_Click);
            // 
            // pbFondo
            // 
            this.pbFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFondo.Image = global::HomeCinema.Properties.Resources.TACOMETRO;
            this.pbFondo.Location = new System.Drawing.Point(0, 0);
            this.pbFondo.Name = "pbFondo";
            this.pbFondo.Size = new System.Drawing.Size(458, 355);
            this.pbFondo.TabIndex = 0;
            this.pbFondo.TabStop = false;
            // 
            // lblCerrarForm1
            // 
            this.lblCerrarForm1.AutoSize = true;
            this.lblCerrarForm1.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblCerrarForm1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrarForm1.ForeColor = System.Drawing.Color.White;
            this.lblCerrarForm1.Location = new System.Drawing.Point(12, 9);
            this.lblCerrarForm1.Name = "lblCerrarForm1";
            this.lblCerrarForm1.Size = new System.Drawing.Size(51, 21);
            this.lblCerrarForm1.TabIndex = 6;
            this.lblCerrarForm1.Text = "Cerrar";
            this.lblCerrarForm1.Click += new System.EventHandler(this.lblCerrarForm1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 355);
            this.Controls.Add(this.lblCerrarForm1);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblNombre1);
            this.Controls.Add(this.lblEslogan);
            this.Controls.Add(this.lblNombre2);
            this.Controls.Add(this.pbFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFondo;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.Label lblEslogan;
        private System.Windows.Forms.Label lblNombre1;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Label lblCerrarForm1;

    }
}


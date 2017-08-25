namespace HomeCinema
{
    partial class FormPelicula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPelicula));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.hcMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.gbMedia = new System.Windows.Forms.GroupBox();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPuntos = new System.Windows.Forms.Button();
            this.btnCargarMovie = new System.Windows.Forms.Button();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnVerMovie = new System.Windows.Forms.Button();
            this.btnVerTrailer = new System.Windows.Forms.Button();
            this.tbSinopsis = new System.Windows.Forms.TextBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.listBoxPeliculas = new System.Windows.Forms.ListBox();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.pbAfiche = new System.Windows.Forms.PictureBox();
            this.mnUsuario = new System.Windows.Forms.MenuStrip();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracíonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hcMediaPlayer)).BeginInit();
            this.gbMedia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAfiche)).BeginInit();
            this.mnUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.Controls.Add(this.hcMediaPlayer);
            this.flowLayoutPanel1.Controls.Add(this.gbMedia);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 47);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1016, 526);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // hcMediaPlayer
            // 
            this.hcMediaPlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hcMediaPlayer.Enabled = true;
            this.hcMediaPlayer.Location = new System.Drawing.Point(3, 3);
            this.hcMediaPlayer.Name = "hcMediaPlayer";
            this.hcMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("hcMediaPlayer.OcxState")));
            this.hcMediaPlayer.Size = new System.Drawing.Size(610, 520);
            this.hcMediaPlayer.TabIndex = 0;
            // 
            // gbMedia
            // 
            this.gbMedia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbMedia.Controls.Add(this.lblPuntos);
            this.gbMedia.Controls.Add(this.label1);
            this.gbMedia.Controls.Add(this.btnPuntos);
            this.gbMedia.Controls.Add(this.btnCargarMovie);
            this.gbMedia.Controls.Add(this.lblAnio);
            this.gbMedia.Controls.Add(this.lblNombre);
            this.gbMedia.Controls.Add(this.btnVerMovie);
            this.gbMedia.Controls.Add(this.btnVerTrailer);
            this.gbMedia.Controls.Add(this.tbSinopsis);
            this.gbMedia.Controls.Add(this.cbCategoria);
            this.gbMedia.Controls.Add(this.listBoxPeliculas);
            this.gbMedia.Controls.Add(this.tbBuscar);
            this.gbMedia.Controls.Add(this.pbAfiche);
            this.gbMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbMedia.Location = new System.Drawing.Point(619, 3);
            this.gbMedia.Name = "gbMedia";
            this.gbMedia.Size = new System.Drawing.Size(387, 519);
            this.gbMedia.TabIndex = 1;
            this.gbMedia.TabStop = false;
            // 
            // lblPuntos
            // 
            this.lblPuntos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.Location = new System.Drawing.Point(84, 323);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(0, 15);
            this.lblPuntos.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Puntos +hC:";
            // 
            // btnPuntos
            // 
            this.btnPuntos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPuntos.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPuntos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPuntos.ForeColor = System.Drawing.Color.White;
            this.btnPuntos.Location = new System.Drawing.Point(127, 319);
            this.btnPuntos.Name = "btnPuntos";
            this.btnPuntos.Size = new System.Drawing.Size(74, 23);
            this.btnPuntos.TabIndex = 11;
            this.btnPuntos.Text = "+hC";
            this.btnPuntos.UseVisualStyleBackColor = false;
            this.btnPuntos.Click += new System.EventHandler(this.btnPuntos_Click);
            // 
            // btnCargarMovie
            // 
            this.btnCargarMovie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCargarMovie.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCargarMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarMovie.ForeColor = System.Drawing.Color.White;
            this.btnCargarMovie.Location = new System.Drawing.Point(207, 319);
            this.btnCargarMovie.Name = "btnCargarMovie";
            this.btnCargarMovie.Size = new System.Drawing.Size(174, 23);
            this.btnCargarMovie.TabIndex = 10;
            this.btnCargarMovie.Text = "Cargar Pelicula";
            this.btnCargarMovie.UseVisualStyleBackColor = false;
            this.btnCargarMovie.Click += new System.EventHandler(this.btnCargarMovie_Click);
            // 
            // lblAnio
            // 
            this.lblAnio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAnio.AutoSize = true;
            this.lblAnio.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnio.Location = new System.Drawing.Point(6, 33);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(0, 15);
            this.lblAnio.TabIndex = 9;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 15);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 15);
            this.lblNombre.TabIndex = 8;
            // 
            // btnVerMovie
            // 
            this.btnVerMovie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVerMovie.BackColor = System.Drawing.Color.SteelBlue;
            this.btnVerMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerMovie.ForeColor = System.Drawing.Color.White;
            this.btnVerMovie.Location = new System.Drawing.Point(207, 484);
            this.btnVerMovie.Name = "btnVerMovie";
            this.btnVerMovie.Size = new System.Drawing.Size(95, 23);
            this.btnVerMovie.TabIndex = 7;
            this.btnVerMovie.Text = "Ver Pelicula";
            this.btnVerMovie.UseVisualStyleBackColor = false;
            this.btnVerMovie.Click += new System.EventHandler(this.btnVerMovie_Click);
            // 
            // btnVerTrailer
            // 
            this.btnVerTrailer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVerTrailer.BackColor = System.Drawing.Color.SteelBlue;
            this.btnVerTrailer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTrailer.ForeColor = System.Drawing.Color.White;
            this.btnVerTrailer.Location = new System.Drawing.Point(105, 484);
            this.btnVerTrailer.Name = "btnVerTrailer";
            this.btnVerTrailer.Size = new System.Drawing.Size(95, 23);
            this.btnVerTrailer.TabIndex = 6;
            this.btnVerTrailer.Text = "Ver Trailer";
            this.btnVerTrailer.UseVisualStyleBackColor = false;
            this.btnVerTrailer.Click += new System.EventHandler(this.btnVerTrailer_Click);
            // 
            // tbSinopsis
            // 
            this.tbSinopsis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSinopsis.Location = new System.Drawing.Point(6, 346);
            this.tbSinopsis.Multiline = true;
            this.tbSinopsis.Name = "tbSinopsis";
            this.tbSinopsis.Size = new System.Drawing.Size(375, 132);
            this.tbSinopsis.TabIndex = 5;
            // 
            // cbCategoria
            // 
            this.cbCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(207, 39);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(174, 21);
            this.cbCategoria.TabIndex = 4;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // listBoxPeliculas
            // 
            this.listBoxPeliculas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxPeliculas.FormattingEnabled = true;
            this.listBoxPeliculas.Location = new System.Drawing.Point(207, 65);
            this.listBoxPeliculas.Name = "listBoxPeliculas";
            this.listBoxPeliculas.Size = new System.Drawing.Size(174, 251);
            this.listBoxPeliculas.TabIndex = 3;
            // 
            // tbBuscar
            // 
            this.tbBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBuscar.Location = new System.Drawing.Point(207, 13);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(174, 20);
            this.tbBuscar.TabIndex = 1;
            this.tbBuscar.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged);
            // 
            // pbAfiche
            // 
            this.pbAfiche.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbAfiche.Location = new System.Drawing.Point(6, 51);
            this.pbAfiche.Name = "pbAfiche";
            this.pbAfiche.Size = new System.Drawing.Size(194, 265);
            this.pbAfiche.TabIndex = 0;
            this.pbAfiche.TabStop = false;
            // 
            // mnUsuario
            // 
            this.mnUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mnUsuario.Dock = System.Windows.Forms.DockStyle.None;
            this.mnUsuario.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnUsuario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem});
            this.mnUsuario.Location = new System.Drawing.Point(971, 1);
            this.mnUsuario.Name = "mnUsuario";
            this.mnUsuario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mnUsuario.Size = new System.Drawing.Size(68, 25);
            this.mnUsuario.TabIndex = 2;
            this.mnUsuario.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuracíonToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.usuarioToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // configuracíonToolStripMenuItem
            // 
            this.configuracíonToolStripMenuItem.Name = "configuracíonToolStripMenuItem";
            this.configuracíonToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.configuracíonToolStripMenuItem.Text = "Configuración";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // FormPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::HomeCinema.Properties.Resources.Fondo_FrmPelicula;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 580);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.mnUsuario);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPelicula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPelicula";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hcMediaPlayer)).EndInit();
            this.gbMedia.ResumeLayout(false);
            this.gbMedia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAfiche)).EndInit();
            this.mnUsuario.ResumeLayout(false);
            this.mnUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private AxWMPLib.AxWindowsMediaPlayer hcMediaPlayer;
        private System.Windows.Forms.GroupBox gbMedia;
        private System.Windows.Forms.Button btnVerMovie;
        private System.Windows.Forms.Button btnVerTrailer;
        private System.Windows.Forms.TextBox tbSinopsis;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ListBox listBoxPeliculas;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.PictureBox pbAfiche;
        private System.Windows.Forms.MenuStrip mnUsuario;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracíonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPuntos;
        private System.Windows.Forms.Button btnCargarMovie;
    }
}
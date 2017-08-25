using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Librerias para Conexíon con Servidor
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
//Liberira de intercambio;
using HomeCinema_Library;

namespace HomeCinema
{
    public partial class FormPelicula : Form
    {
        private string tempMovie = "";
        private string tempTrailer = "";
        private string tempPoster = "";
        private TcpClient myClient;
        private DataSet myDataSet;
        private Pelicula myMovie;
        private bool verifyTextBox = true;
        private static NetworkStream myNetStream;
        private static BinaryReader myBinaryReader;
        private static BinaryWriter myBinaryWriter;
        private static BinaryFormatter myFormatter = new BinaryFormatter();       
        

        public FormPelicula(TcpClient myClient, DataSet myDataSet)
        {
                InitializeComponent();
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;

                this.flowLayoutPanel1.BackColor = Color.Transparent;
                this.mnUsuario.Top = this.Top;
                this.pbAfiche.SizeMode = PictureBoxSizeMode.StretchImage;

                this.myClient = myClient;
                this.myDataSet = myDataSet;
                
                this.verifyTextBox = false;

                FormWelcome frm = new FormWelcome();
                frm.ShowDialog();

                this.cbCategoria.DataSource = this.myDataSet.Tables["tblCategorias"];
                this.cbCategoria.DisplayMember = "nombreCategoria";

                this.bindingSource.DataSource = this.myDataSet.Tables["tblPeliculas"];
                this.listBoxPeliculas.DataSource = this.bindingSource;
                this.listBoxPeliculas.DisplayMember = "nombrePelicula";
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myClient.Close();
            Form1 frmForm = new Form1();
            frmForm.Show();
            this.Close();
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            this.bindingSource.DataSource = null;
            this.listBoxPeliculas.DataSource = null;
            this.listBoxPeliculas.DisplayMember = null;

            if (verifyTextBox) return;
            DataRow[] myRows;
            myRows = myDataSet.Tables["tblPeliculas"].Select("nombrePelicula LIKE '%" + this.tbBuscar.Text + "%'");
            this.listBoxPeliculas.Items.Clear();
            if (myRows.Length > 0)
            {
                foreach (DataRow itemRow in myRows)
                {
                    this.listBoxPeliculas.Items.Add(itemRow["nombrePelicula"].ToString());
                }
            }
        }

        private void btnCargarMovie_Click(object sender, EventArgs e)
        {
            using (myClient = new TcpClient("localhost", 1111))
            using (myNetStream = /*insConnection.ConectarServer()*/this.myClient.GetStream())
            {
                DataRowView myView = (DataRowView)listBoxPeliculas.SelectedValue;
                string nameMovie = Convert.ToString(myView.Row["nombrePelicula"]); 

                myBinaryWriter = new BinaryWriter(myNetStream);
                myBinaryReader = new BinaryReader(myNetStream);

                myBinaryWriter.Write("PELICULA");
                myBinaryWriter.Write(nameMovie);
                myBinaryWriter.Flush();
                //Recibir Respuesta
                string answer = myBinaryReader.ReadString();
                if (answer.Equals("OK"))
                {
                    this.myMovie = (Pelicula)myFormatter.Deserialize(myNetStream);
                    //Cargar Datos de la Pelicula
                    this.lblNombre.Text = this.myMovie.NombrePelicula.ToString();
                    this.lblAnio.Text = this.myMovie.AnioPelicula.ToString();
                     this.tbSinopsis.Text = this.myMovie.SinopsisPelicula.ToString();
                    this.lblPuntos.Text = this.myMovie.PuntosPelicula.ToString();
                    this.tempPoster = Path.GetTempFileName();
                    File.WriteAllBytes(this.tempPoster, this.myMovie.AfichePelicula);
                    this.pbAfiche.ImageLocation = this.tempPoster;

                }
                else MessageBox.Show("No se encontró la Pelicula seleccionada.");
            }     

        }

        private void btnVerTrailer_Click(object sender, EventArgs e)
        {
            this.tempTrailer = Path.GetTempFileName();
            File.WriteAllBytes(this.tempTrailer, this.myMovie.TrailerPelicula);
            this.hcMediaPlayer.URL = tempTrailer;
        }

        private void btnVerMovie_Click(object sender, EventArgs e)
        {
            this.tempMovie = Path.GetTempFileName();
            File.WriteAllBytes(this.tempMovie, this.myMovie.PeliculaCompleta);
            this.hcMediaPlayer.URL = tempMovie;
        }

        private void btnPuntos_Click(object sender, EventArgs e)
        {
            if (this.listBoxPeliculas.SelectedItem.ToString() != null)
            {
                DataRow tempRow = ((DataRowView)this.listBoxPeliculas.SelectedItem).Row;
            }
        }
    }
}

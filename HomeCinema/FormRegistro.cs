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
    public partial class FormRegistro : Form
    {
        private TcpClient myClient;
        private static NetworkStream myNetStream;
        private static BinaryReader myBinaryReader;
        private static BinaryWriter myBinaryWriter;
        private static BinaryFormatter myFormatter = new BinaryFormatter();
        private static Usuario newUser;
        private static DataSet myDataSet;

        public FormRegistro(TcpClient myClient)
        {
            InitializeComponent();
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            this.pbRegistro.SizeMode = PictureBoxSizeMode.StretchImage;
            this.lblCerrarFormRegistro.Left = this.Left;
            this.lblCerrarFormRegistro.Top = this.Top;
            this.myClient = myClient;

        }

        private void lblCerrarFormRegistro_Click(object sender, EventArgs e)
        {
            Form1 frmForm = new Form1();
            frmForm.Show();
            this.Close();
        }

        private void btnRegistrase_Click(object sender, EventArgs e)
        {
            if (this.txtUsuario.Text.Trim() != String.Empty && this.txtNombre.Text.Trim() != String.Empty
                && this.txtPass.Text.Trim() != String.Empty && this.txtTarjeta.Text.Trim() != String.Empty)
            {
                using (myNetStream = myClient.GetStream())
                {
                    myBinaryWriter = new BinaryWriter(myNetStream);
                    myBinaryWriter.Write("REGISTRO");
                    myBinaryWriter.Write(txtUsuario.Text);
                    myBinaryWriter.Flush();

                    myBinaryReader = new BinaryReader(myNetStream);
                    String answer = myBinaryReader.ReadString();
                    if (answer.Equals("OK"))
                    {
                        myDataSet = (DataSet)myFormatter.Deserialize(myNetStream);
                        newUser = new Usuario(this.txtNombre.Text, this.txtUsuario.Text, this.txtPass.Text, Convert.ToInt64(this.txtTarjeta.Text));
                        myFormatter.Serialize(myNetStream, newUser);
                    }
                    else if (answer.Equals("Cancel"))
                    {
                        this.myClient.Close();
                        MessageBox.Show("Esté usuario ya existe, utilice otro.");
                    }
                        
                }
            }
            else
                MessageBox.Show("Todos los campos son obligatorios");

            FormPelicula frmMovie = new FormPelicula(myClient, myDataSet);
            this.Hide();
            frmMovie.Show();
        }

        private void txtTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == '\b')
            {

                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}

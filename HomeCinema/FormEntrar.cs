using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Librerias para Conexíon con Servidor0
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
//Liberira de intercambio;
using HomeCinema_Library;

namespace HomeCinema
{
    public partial class FormEntrar : Form
    {
        private TcpClient myClient;
        private static NetworkStream myNetStream;
        private static BinaryReader myBinaryReader;
        private static BinaryWriter myBinaryWriter;
        private static BinaryFormatter myFormatter = new BinaryFormatter();
        private static DataSet myDataSet;

        public FormEntrar(TcpClient myClient)
        {
            InitializeComponent();
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            this.pbEntrar.SizeMode = PictureBoxSizeMode.StretchImage;
            this.lblTitulo.Parent = this.pbEntrar;
            this.lblTitulo.BackColor = Color.Transparent;
            this.lblUsuario.Parent = this.pbEntrar;
            this.lblUsuario.BackColor = Color.Transparent;
            this.lblPass.Parent = this.pbEntrar;
            this.lblPass.BackColor = Color.Transparent;
            this.lblCerrarFormEntrar.Left = this.Left;
            this.lblCerrarFormEntrar.Top = this.Top;
            this.myClient = myClient;
        }

        private void lblCerrarFormEntrar_Click(object sender, EventArgs e)
        {
            Form1 frmForm = new Form1();
            frmForm.Show();
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (this.txtUser.Text.Trim() != string.Empty && this.txtPass.Text.Trim() != string.Empty)
            {
                using (myNetStream = myClient.GetStream()) {

                    myBinaryWriter = new BinaryWriter(myNetStream);
                    myBinaryWriter.Write("INGRESO");
                    myBinaryWriter.Write(this.txtUser.Text);
                    myBinaryWriter.Write(this.txtPass.Text);
                    myBinaryWriter.Flush();

                    myBinaryReader = new BinaryReader(myNetStream);
                    string answer = myBinaryReader.ReadString();

                    if (answer.Equals("OK"))
                    {
                        myDataSet = (DataSet)myFormatter.Deserialize(myNetStream);
                        FormPelicula frmMovie = new FormPelicula(this.myClient, myDataSet);
                        this.Hide();
                        frmMovie.Show();
                    }
                    else if (answer.Equals("Cancel"))
                    {
                        this.myClient.Close();
                        MessageBox.Show("Usuario o Contraseña incorrectos.");
                        this.txtUser.Clear();
                        this.txtPass.Clear();
                        this.myClient = new TcpClient("localhost", 1111);
                    }              
                }
            }
            else MessageBox.Show("Debe ingresar su usuario y su contraseña");   
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Librerias para Conexión con el server
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
//libreria de intercambio
using HomeCinema_Library;
//this.myClient = new TcpClient("localhost", 1111);
/*this.myClient.Connected.Equals(false)*/

namespace HomeCinema
{
    public partial class Form1 : Form
    {
 
        private TcpClient myClient;
        private NetworkStream myStream;
        
        public Form1()
        {
            InitializeComponent();
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            this.pbFondo.SizeMode = PictureBoxSizeMode.StretchImage;
            this.lblNombre2.Parent = this.pbFondo;
            this.lblNombre2.BackColor = Color.Transparent;
            this.lblNombre1.Parent = this.pbFondo;
            this.lblNombre1.BackColor = Color.Transparent;
            this.lblEslogan.Parent = this.pbFondo;
            this.lblEslogan.BackColor = Color.Transparent;
            this.lblCerrarForm1.Left = this.Left;
            this.lblCerrarForm1.Top = this.Top;
      
            try
            {
                this.myClient = new TcpClient("localhost", 1111);
                if (this.myClient.Connected.Equals(false))
                {
                    this.btnEntrar.Visible = false;
                    this.btnRegistro.Visible = false;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error:");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRegistro frmReg = new FormRegistro(this.myClient);
            this.Hide();
            frmReg.Show();
        }

        private void lblCerrarForm1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormEntrar frmEntrar = new FormEntrar(this.myClient);
            this.Hide();
            frmEntrar.Show();
        }

    }
}

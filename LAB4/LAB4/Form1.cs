using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Windows.Input;
using System.IO;
using System.Security.Cryptography;

namespace LAB4
{
    public partial class Form1 : Form
    {
        public static string GetUsuarios()
        {

            string usu = "";
            DirectoryInfo mensajes = new DirectoryInfo(@rutaa);

            foreach (var item in mensajes.GetFiles())
            {
                usu = item.Name;
            }

            return usu;
        }
        public Form1()
        {
            InitializeComponent();
        }

        string[] mensajesCarg = new string[100000];
        static string rutaa = "";
        string text = "";
        string nextChar = "";
        int pointer = 0;
        string gg = "";


        FolderBrowserDialog fbb = new FolderBrowserDialog();
        List<string> dic = new List<string>();

        private void btn_Click(object sender, EventArgs e)
        {
            if(fbb.ShowDialog() == DialogResult.OK)
            {
                rutaa = fbb.SelectedPath;
            }
            DirectoryInfo mensajes = new DirectoryInfo(@rutaa);
            int i = 0;
            foreach (var item in mensajes.GetFiles())
            {

                Mensajes.Items.Add(rutaa + "\\" + item.Name);
                mensajesCarg[i] = item.Name;
                i++;
            }
            int h = Mensajes.Items.Count;
            Mensajes.Show();
            txtDPI.Show();
            btnDPI.Show();
        }

        private void btnDPI_Click(object sender, EventArgs e)
        {
            int i = -1;

            if (i <= 653)
            {
                i++;
                try
                {

                    //Leer Archivo
                    //Recorrer Archivo
                    for (int a = 0; a < 654; a++)
                    {
                        i++;
                        foreach (string lineaActual in mensajesCarg[a].Split('\n'))
                        {

                            if (!string.IsNullOrEmpty(lineaActual))
                            {
                                //Separar

                                string[] informacion = lineaActual.Split('-');
                                var u = (informacion[1]);



                                if (informacion[1] == txtDPI.Text)
                                {

                                    MensajesDPI.Items.Add(rutaa + "\\" + mensajesCarg[a].ToString());


                                }

                            }
                        }
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error " + e);
                }

            }
            MensajesDPI.Show();
            btnSelecMensajes.Show();
            txtSelecMensaje.Show();
        }

        private void btnSelecMensajes_Click(object sender, EventArgs e)
        {
            gg = MensajesDPI.SelectedItem.ToString();
            txtSelecMensaje.Text = gg;

            btnMostMensajes.Show();
            txtMostMensajes.Show();
        }

        private void btnMostMensajes_Click(object sender, EventArgs e)
        {
            string allFileData = System.IO.File.ReadAllText(gg);
            txtMostMensajes.Text = allFileData;

            lblEncriptar.Show();
            txtClave.Show();
            btnEncriptar.Show();
        }

        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                // Export the public key.
                string publicKey = rsa.ToXmlString(false);

                // Export the private key.
                string privateKey = rsa.ToXmlString(true);

                // Read a number from user
                String Clave = txtClave.Text;
                int clave = Convert.ToInt32(Clave);

                // Encrypt the number.
                byte[] encryptedNum = rsa.Encrypt(Encoding.UTF8.GetBytes(clave.ToString()), false);
                //MessageBox.Show("Mensajes encriptados con la siguiente clave: \n" + Convert.ToBase64String(encryptedNum));
                string ClaveEncriptada = Convert.ToBase64String(encryptedNum);
                txtClaveEncriptada.Text = ClaveEncriptada;    

                txtMostMensajes.Hide();
                lblMensajeEncr.Show();
                txtClaveEncriptada.Show();
                btnDesencriptar.Show();
                lblDesencriptar.Show();
                txtClaveDesencriptada.Show();
            }
        }

        private void btnDesencriptar_Click(object sender, EventArgs e)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                // Export the public key.
                string publicKey = rsa.ToXmlString(false);

                // Export the private key.
                string privateKey = rsa.ToXmlString(true);

                // Read a number from user
                String Clave = txtClave.Text;
                int clave = Convert.ToInt32(Clave);

                // Encrypt the number.
                byte[] encryptedNum = rsa.Encrypt(Encoding.UTF8.GetBytes(clave.ToString()), false);
                //MessageBox.Show("Mensajes encriptados con la siguiente clave: \n" + Convert.ToBase64String(encryptedNum));
                string ClaveEncriptada = Convert.ToBase64String(encryptedNum);


                byte[] decryptedNum = rsa.Decrypt(encryptedNum, false);
                txtClaveDesencriptada.Text = Encoding.UTF8.GetString(decryptedNum);
                //Console.WriteLine("Decrypted Number: \n" + Encoding.UTF8.GetString(decryptedNum));
            }
            txtMostMensajes.Show();
        }
    }
}

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

namespace Lab03
{
    public partial class Form1 : Form
    {
        public static string GetUsuarios()
        {

            string usu = "";
            DirectoryInfo cartas = new DirectoryInfo(@rutaa);

            foreach (var item in cartas.GetFiles())
            {
                usu = item.Name;
            }


            return usu;
        }

        public Form1()
        {
            InitializeComponent();

        }

        string[] cartasCarg = new string[1000];
        static string rutaa = "";
        string text = "";
        string nextChar = "";
        int pointer = 0;
        string gg = "";


        FolderBrowserDialog fbb = new FolderBrowserDialog();
        List<string> dic = new List<string>();


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fbb.ShowDialog() == DialogResult.OK)
            {
                rutaa = fbb.SelectedPath;
            }
            DirectoryInfo cartas = new DirectoryInfo(@rutaa);
            int i = 0;
            foreach (var item in cartas.GetFiles())
            {

                Cartas.Items.Add(rutaa + "\\" + item.Name);
                cartasCarg[i] = item.Name;
                i++;
            }
            int h = Cartas.Items.Count;
            lblNodeCartas.Text = h.ToString();

            Cartas.Show();
            txtDPI.Show();
            button1.Show();
            NoCartas.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Cartas.Hide();

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
                        foreach (string lineaActual in cartasCarg[a].Split('\n'))
                        {

                            if (!string.IsNullOrEmpty(lineaActual))
                            {
                                //Separar

                                string[] informacion = lineaActual.Split('-');
                                var u = (informacion[1]);



                                if (informacion[1] == txtDPI.Text)
                                {

                                    NoCartas.Items.Add(rutaa + "\\" + cartasCarg[a].ToString());


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
            int h = NoCartas.Items.Count;
            lblCartasEncontradas.Text = h.ToString();

            button2.Show();
            txtMostrarCarta.Show();
            lblNodeCartas.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gg = NoCartas.SelectedItem.ToString();
            txtMostrarCarta.Text = gg;

            btnTexto.Show();
            txtMostrarTexto.Show();
        }

        private void btnTexto_Click(object sender, EventArgs e)
        {
            string allFileData = System.IO.File.ReadAllText(gg);
            txtMostrarTexto.Text = allFileData;

            btnComprimirTexto.Show();
            btnDescomprimirTexto.Show();
        }

        private void btnComprimirTexto_Click(object sender, EventArgs e)
        {
            string CompChar = "";
            int index = 0, retrn = 0;
            text = txtMostrarTexto.Text;
            txtMostrarTexto.Text = "0 " + text[0] + "\n";
            dic.Add("");
            dic.Add(text[0] + "");

            for (int indexText = 1; indexText < text.Length; indexText++)
            {

                CompChar += text[indexText];

                if (dic.IndexOf(CompChar) != -1)
                {
                    index = dic.IndexOf(CompChar);

                    retrn = 1;
                    if (indexText + 1 == text.Length)
                        txtMostrarTexto.Text += index + " null\n";

                }
                else
                {
                    if (retrn == 1)
                        txtMostrarTexto.Text += index + " " + CompChar[CompChar.Length - 1] + "\n";

                    else
                        txtMostrarTexto.Text += "0 " + CompChar + "\n";

                    dic.Add(CompChar);
                    CompChar = "";


                    retrn = 0;

                }

            }
        }

        private void btnDescomprimirTexto_Click(object sender, EventArgs e)
        {
            text = txtMostrarTexto.Text;
            string[] CompRslt = txtMostrarTexto.Text.Split();
            txtMostrarTexto.Text = "";
            int cont = 0;
            int i = 0;
            while (i < CompRslt.Length)
            {



                for (i = 0; i < text.Length; i += 2)
                {
                    if (cont < (((text.Length) / 2) + 2) - 1 && i < CompRslt.Length)
                    {
                        cont += 2;
                        if ((CompRslt[i].Length) == 0)
                        {
                            if (nextChar != "null")
                            {
                                txtMostrarTexto.Text += dic[pointer] + nextChar;
                            }
                            else
                            {
                                break;
                            }

                        }

                        if (i < (CompRslt.Length - 1) && nextChar != "null")
                        {
                            while (CompRslt[i] == "")
                            {
                                i++;
                            }
                            pointer = int.Parse(CompRslt[i]);
                            nextChar = CompRslt[i + 1];

                        }



                        if (nextChar != "null")
                            txtMostrarTexto.Text += dic[pointer] + nextChar;
                        else
                            txtMostrarTexto.Text += dic[pointer];




                        pointer = 0;
                        nextChar = "";

                    }


                }
            }


            pointer = 0;
            nextChar = "";
            dic.Clear();
        }
    }
}

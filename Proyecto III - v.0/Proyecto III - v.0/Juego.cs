using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using SbsSW.SwiPlCs;


namespace Proyecto_III___v._0
{
    public partial class Juego : Form
    {
        Thread hilo;
        string mensaje;
        int barcos;
        int jug;
        int tam;

        public Juego(int dificultad, int jugador)
        {
            InitializeComponent();
            jug = jugador;
            cargar(dificultad);

            hilo = new Thread(recivirMensaje1);
            CheckForIllegalCrossThreadCalls = false;
            hilo.Start();

        }
        //Pregunta por fue lo que se paso por el server para tomar acciones respectivas
        public void comandos()
        {
            com.Text = mensaje;
            //Si el enemigo esta listo
            if (com.Text == "listo1" && jug == 2)
            {
                listoEnemigo.Text = "Listo";
            }
            else if (com.Text == "listo2" && jug == 1)
            {
                listoEnemigo.Text = "Listo";
            }
            else if(listoTu.Text=="Listo" && listoEnemigo.Text == "Listo")
            {
                
            }
        }

        //Recive el mensaje del server
        private void recivirMensaje1()
        {
            while (true)
            {
                mensaje = Conexiones.recivirMensaje();
                comandos();
            }
        }

        //Metodo que carga las matrices con el tamano deseado.
        public void cargar(int tamano)
        {
            tam = tamano;
            barcos = tamano;
            //Dificultad Facil
            if (tamano == 5)
            {
                for (int i = 0; i < tamano; i++)

                {
                    for (int j = 0; j < tamano; j++)
                    {

                        Button a = new Button();
                        Button b = new Button();

                        a.Height = 80;
                        a.Width = 80;
                        a.Margin = new System.Windows.Forms.Padding(0);
                        a.Text = "" + i + "," + j + "";
                        a.Tag = "" + i + "," + j + "";
                        a.Name = "0";
                       

                        b.Height = 80;
                        b.Width = 80;
                        b.Margin = new System.Windows.Forms.Padding(0);
                        b.Text = "" + i + "," + j + "";
                        b.Tag = "" + i + "," + j + "";
                        b.Name = "0";
                        b.BackgroundImage = Image.FromFile(@"Agua.png");

                        if (a.Name == "0")
                            a.BackgroundImage = Image.FromFile(@"Agua.png");
                        else
                            a.BackgroundImage = Image.FromFile(@"Nada.png");

                        a.Click += (s, e) =>
                        {
                            buttonAction(a);
                        };

                       
                        tableLayoutPanel_AliadoFacil.Controls.Add(a);
                        tableLayoutPanel_EnemigoFacil.Controls.Add(b);
                    }
                }
                tableLayoutPanel_AliadoDificil.Visible = false;
                tableLayoutPanel_AliadoMedio.Visible = false;
                tableLayoutPanel_EnemigoDificil.Visible = false;
                tableLayoutPanel_EnemigoMedio.Visible = false;
            }

            //Dificultad Media
            else if (tamano == 10)
            {

                for (int i = 0; i < tamano; i++)

                {
                    for (int j = 0; j < tamano; j++)
                    {

                        Button a = new Button();
                        Button b = new Button();

                        a.Height = 80;
                        a.Width = 80;
                        a.Margin = new System.Windows.Forms.Padding(0);
                        a.Text = "" + i + "," + j + "";
                        a.Tag = "" + i + "," + j + "";
                        a.Name = "0";

                        b.Height = 80;
                        b.Width = 80;
                        b.Margin = new System.Windows.Forms.Padding(0);
                        b.Text = "" + i + "," + j + "";
                        b.Tag = "" + i + "," + j + "";
                        b.Name = "0";
                        b.BackgroundImage = Image.FromFile(@"Agua.png");

                        if (a.Name == "0")
                            a.BackgroundImage = Image.FromFile(@"Agua.png");
                        else
                            a.BackgroundImage = Image.FromFile(@"Nada.png");

                        a.Click += (s, e) =>
                        {
                            buttonAction(a);
                        };

                        tableLayoutPanel_AliadoMedio.Controls.Add(a);
                        tableLayoutPanel_EnemigoMedio.Controls.Add(b);
                    }
                }
                tableLayoutPanel_AliadoFacil.Visible = false;
                tableLayoutPanel_AliadoDificil.Visible = false;
                tableLayoutPanel_EnemigoFacil.Visible = false;
                tableLayoutPanel_EnemigoDificil.Visible = false;
            }

            //Dificultad dificil

            else 
            {

                for (int i = 0; i < tamano; i++)

                {
                    for (int j = 0; j < tamano; j++)
                    {

                        Button a = new Button();
                        Button b = new Button();

                        a.Height = 80;
                        a.Width = 80;
                        a.Margin = new System.Windows.Forms.Padding(0);
                        a.Text = "" + i + "," + j + "";
                        a.Tag = "" + i + "," + j + "";
                        a.Name = "0";

                        b.Height = 80;
                        b.Width = 80;
                        b.Margin = new System.Windows.Forms.Padding(0);
                        b.Text = "" + i + "," + j + "";
                        b.Tag = "" + i + "," + j + "";
                        b.Name = "0";
                        b.BackgroundImage = Image.FromFile(@"Agua.png");

                        if (a.Name == "0")
                            a.BackgroundImage = Image.FromFile(@"Agua.png");
                        else
                            a.BackgroundImage = Image.FromFile(@"Nada.png");

                        a.Click += (s, e) =>
                        {
                            buttonAction(a);
                        };

                        tableLayoutPanel_AliadoDificil.Controls.Add(a);
                       tableLayoutPanel_EnemigoDificil.Controls.Add(b);
                    }
                }
                tableLayoutPanel_AliadoFacil.Visible = false;
                tableLayoutPanel_AliadoMedio.Visible = false;
                tableLayoutPanel_EnemigoFacil.Visible = false;
                tableLayoutPanel_EnemigoMedio.Visible = false;
            }
        }


        //Metodo para que escojer donde colocar el barco.
        private void buttonAction(Button boton)
        {

            if (boton.Name == "0" && barcos > 0)
            {
                boton.Name = "1";
                boton.BackgroundImage = Image.FromFile(@"Nada.png");
                barcos = barcos - 1;
            }
            else if (boton.Name == "1" && barcos >= 0)
            {
                boton.Name = "0";
                boton.BackgroundImage = Image.FromFile(@"Agua.png");
                barcos = barcos + 1;
            }

            this.Refresh();

        }


        private void Juego_Load(object sender, EventArgs e)
        {
            PlEngine.PlCleanup();
            Environment.SetEnvironmentVariable("Path", @"C:\\Program Files (x86)\\swipl\\bin");
            string[] p = { "-q", "-f", @"Prolog\\matriz.pl" };
            PlEngine.Initialize(p);
        }

        //Boton de listo
        private void button_Listo(object sender, EventArgs e)
        {
            //Si ya se colocaron todos los barcos
            if (barcos == 0)
            {
                tableLayoutPanel_AliadoFacil.Enabled = false;
                tableLayoutPanel_AliadoMedio.Enabled = false;
                tableLayoutPanel_AliadoDificil.Enabled = false;
                button1.Visible = false;

                listoTu.Text = "Listo";
                if (jug == 1)
                {
                    Conexiones.enviar("listo1");
                }
                if (jug == 2)
                {
                    Conexiones.enviar("listo2");
                }
                matrizar(tam);
            }
        }



        private void tableLayoutPanel_Aliado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel_Enemigo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel_AliadoFacil_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel_AlidadoMedio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel_AliadoDificil_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listoEnemigo_Click(object sender, EventArgs e)
        {

        }


        private void matrizar(int tamano)
        {
            if (tamano == 5)
            {
                for (int i = 0; i < tamano; i++)
                {

                    for (int j = 0; j < tamano; j++)
                    {

                        Control c = tableLayoutPanel_AliadoFacil.GetControlFromPosition(i, j);
                        c.Text += "HOLA";                       
                        PlQuery.PlCall("assert(coordenada("+i+","+j+","+c.Name+"))");
                        Console.WriteLine(+i+", "+j+", "+c.Name);



                    }
                }              
            }
            else if (tamano == 10)
            {
                for (int i = 0; i < tamano; i++)

                {
                    for (int j = 0; j < tamano; j++)
                    {

                        Control c = tableLayoutPanel_AliadoMedio.GetControlFromPosition(i, j);
                        Console.WriteLine(c.Name);
                    }
                }
            }
            else if (tamano == 15)
            {
                for (int i = 0; i < tamano; i++)

                {
                    for (int j = 0; j < tamano; j++)
                    {

                        Control c = tableLayoutPanel_AliadoDificil.GetControlFromPosition(i, j);
                        Console.WriteLine(c.Name);
                    }
                }
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}

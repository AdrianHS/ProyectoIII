using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;


namespace Proyecto_III___v._0
{
    public partial class MenuPrincipal : Form
    {
        static string mensaje;
        static int jug = 0;
        Thread hilo;

        public MenuPrincipal(int jugador)
        {
            InitializeComponent();
            jug = jugador;
            label_Jugador.Text = "Jugador " + jugador;
            button_Jugar.Enabled = false;
            if (jugador == 2)
            {
                label_Dificultad.Text = "Jugador uno eligiendo dificultad";
                comboBox_Dificultad.Enabled = false;
                Conecciones.conectar("2");

                hilo = new Thread(recivirMensaje1);
                CheckForIllegalCrossThreadCalls = false;
                hilo.Start();
                Conecciones.enviar("habilitar1");
            }
            else
            {
                Conecciones.conectar("1");
                hilo = new Thread(recivirMensaje1);
                CheckForIllegalCrossThreadCalls = false;
                hilo.Start();

            }

            

        }

        private void recivirMensaje1()
        {
            while (true)
            {
                mensaje = Conecciones.recivirMensaje();
                Console.WriteLine("Uno: "+mensaje);
                comandos();
                Console.WriteLine("Dos: "+mensaje);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Environment.SetEnvironmentVariable("Path", @"C:\Program Files (x86)\swipl\bin");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Jugar
        private void button1_Click(object sender, EventArgs e)
        {
            if (jug == 1)
            {
                int dificultad;
                string dif;
                dif = comboBox_Dificultad.Text;
                if (dif == "Facil")
                    dificultad = 5;
                else if (dif == "Medio")
                    dificultad = 10;
                else
                    dificultad = 15;



                Conecciones.enviar("habilitar2");

                Conecciones.enviar(dificultad+"");

                Juego juego = new Juego(dificultad);
                juego.Show();
                hilo.Abort();
                this.Hide();
                

            }
            else
            {
                Juego juego = new Juego(Int32.Parse(prueba.Text));
                juego.Show();
                hilo.Abort();
                this.Hide();

            }



        }

        //escribe en el label
        public void comandos()
        {
            prueba.Text = mensaje;
            //Habilita el boton del jugador 1
            if (prueba.Text == "habilitar1" && jug == 1)
            {
                button_Jugar.Enabled = true;
            }
            //Habilita el boton del jugador 2
            else if (prueba.Text == "habilitar2" && jug == 2)
            {
                button_Jugar.Enabled = true;
            }


            Console.WriteLine("Entró con la variable: " + mensaje);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void prueba_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_Dificultad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

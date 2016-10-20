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

        TcpClient cliente;
        NetworkStream StreamCliente;
        static string mensaje;
        static int jug = 0;
        

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
                //enviar("Jugador 2 conectado");
                Conecciones.enviar("habilitar1");
            }
            else
            {
                Conecciones.conectar("1");

            }
            Thread hilo = new Thread(recivirMensaje1);
            //CheckForIllegalCrossThreadCalls = false;
            hilo.Start();
            

        }

        private void recivirMensaje1()
        {
            while (true)
            {
                mensaje = Conecciones.recivirMensaje();
                
                comandos();
                Console.WriteLine(mensaje);
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
                //this.Hide();

            }
            else
            {
                Juego juego = new Juego(Int32.Parse(prueba.Text));
                juego.Show();
                //this.Hide();
                /*
                button_Jugar.Enabled = false;
                label_Dificultad.Text = "En espera del jugador 1...";
                */
            }



        }

        //escribe en el label
        public void comandos()
        {
            Console.WriteLine("Entró con la variable: "+ mensaje +".");
            //Habilita el boton del jugador 1
            if (mensaje == "habilitar1" && jug == 1)
            {
                button_Jugar.Enabled = true;
            }
            //Habilita el boton del jugador 2
            if (mensaje == "habilitar2" && jug == 2)
            {
                button_Jugar.Enabled = true;
            }
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

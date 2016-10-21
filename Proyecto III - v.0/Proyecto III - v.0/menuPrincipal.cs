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
using SbsSW.SwiPlCs;

namespace Proyecto_III___v._0
{
    public partial class MenuPrincipal : Form
    {
        static string mensaje;
        static int jug = 0;
        Thread hilo;

        //Recibe al jugador y lo conecta al server sugun si numero
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
                
                hilo = new Thread(recivirMensaje1);
                CheckForIllegalCrossThreadCalls = false;
                hilo.Start();
                Conexiones.enviar("habilitar1");
            }
            else
            {
                hilo = new Thread(recivirMensaje1);
                CheckForIllegalCrossThreadCalls = false;
                hilo.Start();

            }

            

        }

        //Pregunta por fue lo que se paso por el server para tomar acciones respectivas
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

        private void Form1_Load(object sender, EventArgs e)
        {
            Environment.SetEnvironmentVariable("Path", @"C:\\Program Files (x86)\\swipl\\bin");
            string[] p = { "-q", "-f", @"Prolog\\niveles.pl"};
            PlEngine.Initialize(p);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        //consulta la dificultad en un archivo de prolog
        private int getDificultad()
        {
            PlQuery cargar = new PlQuery("cargar('niveles.pl')");
            cargar.NextSolution();
            PlQuery consulta1 = new PlQuery("dificultad(" + (comboBox_Dificultad.Text).ToLower() + ",Y)");
            string var = "";
            foreach (PlQueryVariables z in consulta1.SolutionVariables)
                var = (z["Y"].ToString());

            return Int32.Parse(var);
        }

        //Boton de jugar, consulta la dificultad y abre la otra ventana.
        private void button1_Click(object sender, EventArgs e)
        {
            if (jug == 1)
            {
                int dificultad = getDificultad();

                Conexiones.enviar("habilitar2");

                Conexiones.enviar(dificultad+"");

                Juego juego = new Juego(dificultad,jug);
                juego.Show();
                hilo.Abort();
                this.Hide();
                

            }
            else
            {
                Juego juego = new Juego(Int32.Parse(prueba.Text),jug);
                juego.Show();
                hilo.Abort();
                this.Hide();

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

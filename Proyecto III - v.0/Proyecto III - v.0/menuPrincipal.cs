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

        TcpClient Cliente;
        NetworkStream StreamCliente;
        String mensaje;
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
                conectar("2");
                //enviar("Jugador 2 conectado");
                enviar("habilitar1");
            }
            else
            {
                conectar("1");
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



                enviar("habilitar2");

                enviar(dificultad+"");


                
                


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

        //Conectar con el server
        private void conectar(string jug)
        {
            try
            {
                Cliente = new TcpClient("127.0.0.1", 5050);
                StreamCliente = Cliente.GetStream();
                byte[] data = Encoding.ASCII.GetBytes(jug);
                StreamCliente.Write(data, 0, data.Length);
                StreamCliente.Flush();
                mensaje = "Conectado con el Servidor";
                //MensajeRecivido();
                //constantemente reciviendo
                Thread hilo = new Thread(recivirMensaje);
                hilo.Start();
            }
            catch
            {
                MessageBox.Show("Error al conectar");
            }
        }


        //escribe en el label
        public void MensajeRecivido()
        {
            if (InvokeRequired)
                Invoke(new MethodInvoker(MensajeRecivido));
            else
            {
                //Pone msj de prueba
                if (mensaje != "")
                {
                    prueba.Text = mensaje;
                }
                
                //Habilita el boton del jugador 1
                if (prueba.Text == "habilitar1" && jug == 1)
                {
                    button_Jugar.Enabled = true;
                }
                //Habilita el boton del jugador 2
                if (prueba.Text == "habilitar2" && jug == 2)
                {
                    button_Jugar.Enabled = true;
                }




            }

        }
        //recive mensajes
        public void recivirMensaje()
        {
            while (true)
            {
                StreamCliente = Cliente.GetStream();
                byte[] bite = new byte[2048];
                StreamCliente.Read(bite, 0, bite.Length);
                mensaje = Encoding.ASCII.GetString(bite);
                MensajeRecivido();
            }
        }

        //envia mensajes
        public void enviar(string men)
        {
            try
            {
                StreamCliente = Cliente.GetStream();
                byte[] data = Encoding.ASCII.GetBytes(men);
                StreamCliente.Write(data, 0, data.Length);
                StreamCliente.Flush();
            }
            catch
            {
                MessageBox.Show("No se envio el mensaje");
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

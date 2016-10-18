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


namespace Proyecto_III___v._0
{
    public partial class MenuPrincipal : Form
    {
        static int jug = 0;


        public MenuPrincipal(int jugador)
        {
            InitializeComponent();
            jug = jugador;
            label_Jugador.Text = "Jugador " + jugador;
            if (jugador == 2)
            {
                label_Dificultad.Text = "Jugador uno eligiendo dificultad";
                comboBox_Dificultad.Enabled = false;
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Environment.SetEnvironmentVariable("Path", @"C:\Program Files (x86)\swipl\bin");
        }




        public static void conectar(int jugador)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint direccion = new IPEndPoint(IPAddress.Parse("192.168.0.100"), 5050);
            if (jugador == 1)
            {
                
                socket.Bind(direccion);
                socket.Listen(1);

                Socket escucha = socket.Accept();

                byte[] ByRec = new byte[2048];

                int a = escucha.Receive(ByRec, 0, ByRec.Length, 0);
                Array.Resize(ref ByRec, a);

                prueba.Text = Encoding.Default.GetString(ByRec);

                socket.Close();
            }
            else
            {

                socket.Connect(direccion);

                byte[] enviar = Encoding.Default.GetBytes("Jugador 2 conectado.");

                socket.Send(enviar, 0, enviar.Length, 0);

                socket.Close();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

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
                Juego juego = new Juego(dificultad);
                juego.Show();
                //this.Close
                conectar(jug);
                /*
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint direccion = new IPEndPoint(IPAddress.Parse("192.168.0.100"), 5050);

                socket.Connect(direccion);

                byte[] enviar = Encoding.Default.GetBytes("Jugador 2 conectado.");

                socket.Send(enviar, 0, enviar.Length, 0);

                socket.Close();*/


            }
            else
            {
                button_Jugar.Enabled = false;
                label_Dificultad.Text = "En espera del jugador 1...";
                conectar(jug);



                /*

                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint direccion = new IPEndPoint(IPAddress.Parse("192.168.0.100"), 5050);

                socket.Bind(direccion);
                socket.Listen(1);

                Socket escucha = socket.Accept();

                byte[] ByRec = new byte[2048];

                int a = escucha.Receive(ByRec, 0, ByRec.Length, 0);
                Array.Resize(ref ByRec, a);

                prueba.Text = Encoding.Default.GetString(ByRec);


                socket.Close*/
            }



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

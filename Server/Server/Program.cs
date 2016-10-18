using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Collections;


namespace Server
{
    class Program
    {
        static TcpListener servidor;
        static Hashtable cliente;

        static void Main(string[] args)
        {
            string mensajeCliente;
            try
            {
                //Conectarse
                servidor = new TcpListener(IPAddress.Parse("192.168.0.100"),5050);
                cliente = new Hashtable();

                servidor.Start();

                Console.WriteLine("Servido Conectado........");

              
                //reciviendo clientes
                while (true)
                {
                    TcpClient cliente2 = servidor.AcceptTcpClient();
                    Byte[] msjEnByte = new Byte[2];

                    NetworkStream networkCliente = cliente2.GetStream();
                    networkCliente.Read(msjEnByte, 0, msjEnByte.Length);

                    mensajeCliente = Encoding.ASCII.GetString(msjEnByte, 0, msjEnByte.Length);

                    cliente.Add(mensajeCliente, cliente2);
                    
                    //mensaje enviar a todos los clientes
                    msjTodos(mensajeCliente, mensajeCliente);


                    //ciclo infinito
                    chatear nuevo = new chatear(mensajeCliente, cliente2);



                }

            }

            catch 
            {
                Console.WriteLine("Error");
            }

            finally
            {
                servidor.Stop();
            }
        }


        public static void msjTodos(string Mensaje, string Nombre)
        {

            foreach(DictionaryEntry c in cliente)
            {
                Byte[] uno = null;
                TcpClient clienteConectado = (TcpClient) c.Value;
                NetworkStream stringg = clienteConectado.GetStream();

                uno = Encoding.ASCII.GetBytes(Nombre + " : " + Mensaje);
                Console.WriteLine(Nombre + " : " + Mensaje);

                stringg.Write(uno, 0, uno.Length);
                stringg.Flush();

            }
        }
    }

    class chatear
    {
        String nombre;
        TcpClient clienteClase;

        public chatear(String nombres, TcpClient clienteClases)
        {
            nombre = nombres;
            clienteClase = clienteClases;
            Thread hilo = new Thread(chatiando);
            hilo.Start();

        }
        public void chatiando()
        {
            String mensajeCliente;
            while (true)
            {
                //TcpClient cliente2 = clienteClase.AcceptTcpClient();

                Byte[] msjEnByte = new Byte[2];


                NetworkStream networkCliente = clienteClase.GetStream();
                networkCliente.Read(msjEnByte, 0, msjEnByte.Length);

                mensajeCliente = Encoding.ASCII.GetString(msjEnByte, 0, msjEnByte.Length);
                
                //mensaje enviar a todos los clientes
                Program.msjTodos(mensajeCliente,nombre);


                //ciclo infinito



            }
        }
    }
}

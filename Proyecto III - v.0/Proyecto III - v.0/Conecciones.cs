using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Proyecto_III___v._0
{
    class Conecciones
    {
        static TcpClient cliente;
        static NetworkStream StreamCliente;
        static string mensaje;
        //Conectar con el server

        public static void conectar(string jug)
        {
            try
            {
                cliente = new TcpClient("127.0.0.1", 5050);
                StreamCliente = cliente.GetStream();
                byte[] data = Encoding.ASCII.GetBytes(jug);
                StreamCliente.Write(data, 0, data.Length);
                StreamCliente.Flush();
                mensaje = "Conectado con el Servidor";
                //MensajeRecivido();
                //constantemente reciviendo
              
            }
            catch
            {
                Console.WriteLine("Error al conectar");
            }
        }
    


        //recive mensajes
        public static string recivirMensaje()
        {    
            StreamCliente = cliente.GetStream();
            byte[] bite = new byte[20];
            StreamCliente.Read(bite, 0, bite.Length);
            mensaje = Encoding.ASCII.GetString(bite);
            //MenuPrincipal.MensajeRecivido();
            return mensaje;
            
        }

        //envia mensajes
        public static void enviar(string men)
        {
            try
            {
                StreamCliente = cliente.GetStream();
                byte[] data = Encoding.ASCII.GetBytes(men);
                StreamCliente.Write(data, 0, data.Length);
                StreamCliente.Flush();
            }
            catch
            {
                Console.WriteLine("No se envio el mensaje");
            }
        }


    }
}

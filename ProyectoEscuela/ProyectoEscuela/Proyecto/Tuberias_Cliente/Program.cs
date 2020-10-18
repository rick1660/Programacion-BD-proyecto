using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;
using System.Threading;


namespace Tuberias_Cliente
{
    class Program
    {
        static void IniciarCliente() {
            NamedPipeClientStream Cliente = new NamedPipeClientStream("MI_SERVIDOR");
            Console.WriteLine("Cliente ha iniciado, buscando servidor ....");
            Cliente.Connect();
            Console.WriteLine("Cliente ha encontrado un Servidor, espara un mensaje ........");
            StreamReader lector = new StreamReader(Cliente);
            Console.WriteLine(lector.ReadLine());
            Console.WriteLine("Cliente ha recibido el mensaje XD....");
            Console.Read();

        }

        static void IniciarCliente1() {
            NamedPipeClientStream Cliente = new NamedPipeClientStream("MI_SERVIDO");
            Console.WriteLine("Cliente1 ha iniciado, buscando servidor ....");
            Cliente.Connect();
            Console.WriteLine("Cliente1 ha encontrado un Servidor, espara un mensaje ........");
            StreamReader lector = new StreamReader(Cliente);
            Console.WriteLine(lector.ReadLine());
            Console.WriteLine("Cliente1 ha recibido el mensaje XD....");
            Console.Read();

        }

        static void Main(string[] args)
        {
            Thread Hilo1 = new Thread(IniciarCliente);
            Thread Hilo2 = new Thread(IniciarCliente1);

            Hilo2.Start();
           Hilo1.Start();

        }
    }
}
